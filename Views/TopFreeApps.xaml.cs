using MicrosoftStore.Helpers;
using MicrosoftStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//https://go.microsoft.com/fwlink/?LinkId=234236 上介绍了“用户控件”项模板

namespace MicrosoftStore.Views
{
    public sealed partial class TopFreeApps : UserControl, INotifyPropertyChanged
    {
        public static readonly DependencyProperty DataModelProperty = DependencyProperty.Register("DataModel", typeof(TopFreeAppsDataObject), typeof(TopFreeApps), new PropertyMetadata(null));
        public TopFreeAppsDataObject DataModel
        {
            get { return (TopFreeAppsDataObject)GetValue(DataModelProperty); }
            set {
                if (value != null)
                {
                    ItemsDataSource.Clear();

                    foreach (AppItemDataObject Item in value.ProductList)
                    {
                        ItemsDataSource.Add(Item);
                    }
                }

                SetValue(DataModelProperty, value); 
            }
        }

        public static readonly DependencyProperty MaximumRowsOrColumnsProperty = DependencyProperty.Register("MaximumRowsOrColumns", typeof(int), typeof(ItemsWrapGrid), new PropertyMetadata(3));

        public event PropertyChangedEventHandler PropertyChanged;

        public double TopFreeAppsItemWidth
        {
            get => _TopFreeAppsItemWidth;
            set
            {
                if (_TopFreeAppsItemWidth != value)
                {
                    _TopFreeAppsItemWidth = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TopFreeAppsItemWidth)));
                }
            }
        }
        private double _TopFreeAppsItemWidth;

        public ObservableCollection<AppItemDataObject> ItemsDataSource = new ObservableCollection<AppItemDataObject>();

        FrameworkElement lastPopUpElement = null;

        public TopFreeApps()
        {
            this.InitializeComponent();
        }

        public void ViewSizeChanged()
        {
            if (TopFreeAppsGridView != null)
            {
                ItemsWrapGrid WrapGrid = TreeHelper.FindVisualChild<ItemsWrapGrid>(TopFreeAppsGridView);
                
                int CulumnCount = WrapGrid.MaximumRowsOrColumns;
                int GridViewWidth = (int)TopFreeAppsGridView.ActualWidth;

                TopFreeAppsItemWidth = (GridViewWidth - 6 - (12 * (CulumnCount - 1)) - 6) / CulumnCount;

                UpdateGridViewItemsSource(WrapGrid);
            }
            else
            {
                TopFreeAppsItemWidth = 360;
            }
        }

        private void UpdateGridViewItemsSource(ItemsWrapGrid WrapGrid)
        {
            if (DataModel == null) 
            { 
                return; 
            }

            int ItemsCount = ItemsDataSource.Count;

            if (TopFreeAppsGridView != null && WrapGrid != null)
            {
                if (WrapGrid.MaximumRowsOrColumns == 1)
                {
                    if (ItemsCount != 3) {
                        ItemsDataSource.RemoveAt(3);
                    }
                }
                else if (WrapGrid.MaximumRowsOrColumns == 2)
                {
                    if (ItemsCount == 3)
                    {
                        ItemsDataSource.Add(DataModel.ProductList[3]);
                    }
                    else 
                    {
                        while (ItemsDataSource.Count > 4)
                        {
                            ItemsDataSource.RemoveAt(4);
                        }
                    }
                }
                else
                {
                    if (ItemsCount != 6)
                    {
                        ItemsDataSource.Add(DataModel.ProductList[4]);
                        ItemsDataSource.Add(DataModel.ProductList[5]);
                    }
                }
            }
        }

        private void GridItem_Loaded(object sender, RoutedEventArgs e)
        {
            var root = (UIElement)sender;
            InitializeAnimation(root, TreeHelper.FindVisualChild<Canvas>(root));
        }

        private void InitializeAnimation(UIElement root, UIElement shadowHost)
        {
            var rootVisual = ElementCompositionPreview.GetElementVisual(root);
            var shadowHostVisual = ElementCompositionPreview.GetElementVisual(shadowHost);
            var compositor = rootVisual.Compositor;

            // Create shadow and add it to the Visual Tree
            var shadow = compositor.CreateDropShadow();
            shadow.Color = Color.FromArgb(255, 75, 75, 80);
            var shadowVisual = compositor.CreateSpriteVisual();
            shadowVisual.Shadow = shadow;
            ElementCompositionPreview.SetElementChildVisual(shadowHost, shadowVisual);

            // Make sure the shadow resizes as its host resizes
            var bindSizeAnimation = compositor.CreateExpressionAnimation("hostVisual.Size");
            bindSizeAnimation.SetReferenceParameter("hostVisual", shadowHostVisual);
            shadowVisual.StartAnimation("Size", bindSizeAnimation);

            // Increase the blurradius as the rectangle is scaled up
            var shadowAnimation = compositor.CreateExpressionAnimation("100 * (source.Scale.X - 1)");
            shadowAnimation.SetReferenceParameter("source", rootVisual);
            shadow.StartAnimation("BlurRadius", shadowAnimation);

            // Create animation to scale up the rectangle
            var pointerEnteredAnimation = compositor.CreateVector3KeyFrameAnimation();
            pointerEnteredAnimation.InsertKeyFrame(1.0f, new Vector3(1.025f));

            // Create animation to scale the rectangle back down
            var pointerExitedAnimation = compositor.CreateVector3KeyFrameAnimation();
            pointerExitedAnimation.InsertKeyFrame(1.0f, new Vector3(1.0f));

            // Play animations on pointer enter and exit
            root.PointerEntered += (sender, args) =>
            {
                rootVisual.CenterPoint = new Vector3(rootVisual.Size / 2, 0);
                rootVisual.StartAnimation("Scale", pointerEnteredAnimation);
            };

            root.PointerExited += (sender, args) => rootVisual.StartAnimation("Scale", pointerExitedAnimation);
        }
    }
}
