using MicrosoftStore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//https://go.microsoft.com/fwlink/?LinkId=234236 上介绍了“用户控件”项模板

namespace MicrosoftStore.Views
{
    public sealed partial class FeaturedGame : UserControl
    {
        public static readonly DependencyProperty DataModelProperty = DependencyProperty.Register("FeaturedGameDataModel", typeof(FeaturedGameAppDataObject), typeof(FeaturedGame), new PropertyMetadata(null));
        public FeaturedGameAppDataObject DataModel
        {
            get { return (FeaturedGameAppDataObject)GetValue(DataModelProperty); }
            set { SetValue(DataModelProperty, value); }
        }
        public FeaturedGame()
        {
            this.InitializeComponent();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }
    }
}
