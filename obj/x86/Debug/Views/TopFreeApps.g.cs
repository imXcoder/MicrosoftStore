﻿#pragma checksum "D:\Microsoft\Interview\MicrosoftStore\Views\TopFreeApps.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0537C841A6FDFB1B20550843991BDE579E18A5D9E4A72E458420ADB3F443A2F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicrosoftStore.Views
{
    partial class TopFreeApps : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Border_Background(global::Windows.UI.Xaml.Controls.Border obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TopFreeApps_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITopFreeApps_Bindings
        {
            private global::MicrosoftStore.Models.AppItemDataObject dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;
            private global::Windows.UI.Xaml.Controls.Border obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.Image obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Controls.Image obj12;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5BackgroundDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10SourceDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj12SourceDisabled = false;

            public TopFreeApps_obj3_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 31 && columnNumber == 21)
                {
                    isobj5BackgroundDisabled = true;
                }
                else if (lineNumber == 71 && columnNumber == 25)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 43 && columnNumber == 25)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 50 && columnNumber == 29)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 54 && columnNumber == 29)
                {
                    isobj10SourceDisabled = true;
                }
                else if (lineNumber == 60 && columnNumber == 29)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 34 && columnNumber == 25)
                {
                    isobj12SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\TopFreeApps.xaml line 20
                        this.obj3 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.RelativePanel)target);
                        break;
                    case 5: // Views\TopFreeApps.xaml line 28
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 7: // Views\TopFreeApps.xaml line 70
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // Views\TopFreeApps.xaml line 42
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // Views\TopFreeApps.xaml line 49
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10: // Views\TopFreeApps.xaml line 53
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 11: // Views\TopFreeApps.xaml line 59
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 12: // Views\TopFreeApps.xaml line 33
                        this.obj12 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj3.Target as global::Windows.UI.Xaml.Controls.RelativePanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::MicrosoftStore.Models.AppItemDataObject) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ITopFreeApps_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MicrosoftStore.Models.AppItemDataObject)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MicrosoftStore.Models.AppItemDataObject obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ImageBackground(obj.ImageBackground, phase);
                        this.Update_DisplayPrice(obj.DisplayPrice, phase);
                        this.Update_Title(obj.Title, phase);
                        this.Update_AverageRating(obj.AverageRating, phase);
                        this.Update_AverageRatingImageLocation(obj.AverageRatingImageLocation, phase);
                        this.Update_Category(obj.Category, phase);
                        this.Update_ImageLocation(obj.ImageLocation, phase);
                    }
                }
            }
            private void Update_ImageBackground(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 28
                    if (!isobj5BackgroundDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Border_Background(this.obj5, (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), obj), null);
                    }
                }
            }
            private void Update_DisplayPrice(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 70
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 42
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_AverageRating(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 49
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_AverageRatingImageLocation(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 53
                    if (!isobj10SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj10, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_Category(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 59
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                    }
                }
            }
            private void Update_ImageLocation(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 33
                    if (!isobj12SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj12, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TopFreeApps_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITopFreeApps_Bindings
        {
            private global::MicrosoftStore.Views.TopFreeApps dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::System.WeakReference obj1;
            private global::Windows.UI.Xaml.Controls.GridView obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;
            private global::Windows.UI.Xaml.Controls.Image obj18;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.SizeChangedEventHandler obj1SizeChanged;
            private global::Windows.UI.Xaml.Controls.ItemClickEventHandler obj16ItemClick;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj16ItemsSourceDisabled = false;
            private static bool isobj17TextDisabled = false;
            private static bool isobj18SourceDisabled = false;

            private TopFreeApps_obj1_BindingsTracking bindingsTracking;

            public TopFreeApps_obj1_Bindings()
            {
                this.bindingsTracking = new TopFreeApps_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 13 && columnNumber == 5)
                {
                    if (this.obj1.IsAlive)
                    {
                        ((global::Windows.UI.Xaml.Controls.UserControl)this.obj1.Target).SizeChanged -= obj1SizeChanged;
                    }
                }
                else if (lineNumber == 138 && columnNumber == 13)
                {
                    isobj16ItemsSourceDisabled = true;
                }
                else if (lineNumber == 137 && columnNumber == 13)
                {
                    this.obj16.ItemClick -= obj16ItemClick;
                }
                else if (lineNumber == 127 && columnNumber == 17)
                {
                    isobj17TextDisabled = true;
                }
                else if (lineNumber == 131 && columnNumber == 17)
                {
                    isobj18SourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 1: // Views\TopFreeApps.xaml line 1
                        this.obj1 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.UserControl)target);
                        this.obj1SizeChanged = (global::System.Object p0, global::Windows.UI.Xaml.SizeChangedEventArgs p1) =>
                        {
                            this.dataRoot.ViewSizeChanged();
                        };
                        ((global::Windows.UI.Xaml.Controls.UserControl)target).SizeChanged += obj1SizeChanged;
                        break;
                    case 16: // Views\TopFreeApps.xaml line 135
                        this.obj16 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        this.obj16ItemClick = (global::System.Object p0, global::Windows.UI.Xaml.Controls.ItemClickEventArgs p1) =>
                        {
                            this.dataRoot.GridItem_Click(p0, p1);
                        };
                        ((global::Windows.UI.Xaml.Controls.GridView)target).ItemClick += obj16ItemClick;
                        break;
                    case 17: // Views\TopFreeApps.xaml line 126
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 18: // Views\TopFreeApps.xaml line 130
                        this.obj18 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ITopFreeApps_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::MicrosoftStore.Views.TopFreeApps)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MicrosoftStore.Views.TopFreeApps obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ItemsDataSource(obj.ItemsDataSource, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DataModel(obj.DataModel, phase);
                    }
                }
            }
            private void Update_ItemsDataSource(global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ItemsDataSource(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TopFreeApps.xaml line 135
                    if (!isobj16ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj16, obj, null);
                    }
                }
            }
            private void Update_DataModel(global::MicrosoftStore.Models.TopFreeAppsDataObject obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DataModel_Title(obj.Title, phase);
                        this.Update_DataModel_ImageLocation(obj.ImageLocation, phase);
                    }
                }
            }
            private void Update_DataModel_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 126
                    if (!isobj17TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, obj, null);
                    }
                }
            }
            private void Update_DataModel_ImageLocation(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\TopFreeApps.xaml line 130
                    if (!isobj18SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj18, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TopFreeApps_obj1_BindingsTracking
            {
                private global::System.WeakReference<TopFreeApps_obj1_Bindings> weakRefToBindingObj; 

                public TopFreeApps_obj1_BindingsTracking(TopFreeApps_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TopFreeApps_obj1_Bindings>(obj);
                }

                public TopFreeApps_obj1_Bindings TryGetBindingObject()
                {
                    TopFreeApps_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_ItemsDataSource(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TopFreeApps_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::MicrosoftStore.Views.TopFreeApps obj = sender as global::MicrosoftStore.Views.TopFreeApps;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ItemsDataSource(obj.ItemsDataSource, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "ItemsDataSource":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ItemsDataSource(obj.ItemsDataSource, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::MicrosoftStore.Views.TopFreeApps obj)
                {
                    TopFreeApps_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void PropertyChanged_ItemsDataSource(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TopFreeApps_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ItemsDataSource(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    TopFreeApps_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject> cache_ItemsDataSource = null;
                public void UpdateChildListeners_ItemsDataSource(global::System.Collections.ObjectModel.ObservableCollection<global::MicrosoftStore.Models.AppItemDataObject> obj)
                {
                    if (obj != cache_ItemsDataSource)
                    {
                        if (cache_ItemsDataSource != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ItemsDataSource).PropertyChanged -= PropertyChanged_ItemsDataSource;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ItemsDataSource).CollectionChanged -= CollectionChanged_ItemsDataSource;
                            cache_ItemsDataSource = null;
                        }
                        if (obj != null)
                        {
                            cache_ItemsDataSource = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ItemsDataSource;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ItemsDataSource;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\TopFreeApps.xaml line 1
                {
                    this.TopFreeAppsView = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2: // Views\TopFreeApps.xaml line 16
                {
                    this.TopFreeAppItemTemplate = (global::Windows.UI.Xaml.DataTemplate)(target);
                }
                break;
            case 3: // Views\TopFreeApps.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.RelativePanel element3 = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                    ((global::Windows.UI.Xaml.Controls.RelativePanel)element3).Loaded += this.GridItem_Loaded;
                }
                break;
            case 13: // Views\TopFreeApps.xaml line 93
                {
                    this.MinRowsOrColumnsState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 14: // Views\TopFreeApps.xaml line 102
                {
                    this.MidRowsOrColumnsState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 15: // Views\TopFreeApps.xaml line 111
                {
                    this.MaxRowsOrColumnsState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 16: // Views\TopFreeApps.xaml line 135
                {
                    this.TopFreeAppsGridView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\TopFreeApps.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    TopFreeApps_obj1_Bindings bindings = new TopFreeApps_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 3: // Views\TopFreeApps.xaml line 20
                {                    
                    global::Windows.UI.Xaml.Controls.RelativePanel element3 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                    TopFreeApps_obj3_Bindings bindings = new TopFreeApps_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
