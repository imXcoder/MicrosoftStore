﻿#pragma checksum "D:\Microsoft\MicrosoftRepos\MicrosoftStore\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ED9B69F704E2CEB4348265ABD79E4CAED15485B6A37CA9750C5A29065ABAE2E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicrosoftStore
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_MicrosoftStore_Views_TopFreeApps_DataModel(global::MicrosoftStore.Views.TopFreeApps obj, global::MicrosoftStore.Models.TopFreeAppsDataObject value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::MicrosoftStore.Models.TopFreeAppsDataObject) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::MicrosoftStore.Models.TopFreeAppsDataObject), targetNullValue);
                }
                obj.DataModel = value;
            }
            public static void Set_MicrosoftStore_Views_FeaturedGame_DataModel(global::MicrosoftStore.Views.FeaturedGame obj, global::MicrosoftStore.Models.FeaturedGameAppDataObject value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::MicrosoftStore.Models.FeaturedGameAppDataObject) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::MicrosoftStore.Models.FeaturedGameAppDataObject), targetNullValue);
                }
                obj.DataModel = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::MicrosoftStore.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::MicrosoftStore.Views.TopFreeApps obj5;
            private global::MicrosoftStore.Views.FeaturedGame obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5DataModelDisabled = false;
            private static bool isobj6DataModelDisabled = false;

            public MainPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 57 && columnNumber == 78)
                {
                    isobj5DataModelDisabled = true;
                }
                else if (lineNumber == 60 && columnNumber == 80)
                {
                    isobj6DataModelDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // MainPage.xaml line 57
                        this.obj5 = (global::MicrosoftStore.Views.TopFreeApps)target;
                        break;
                    case 6: // MainPage.xaml line 60
                        this.obj6 = (global::MicrosoftStore.Views.FeaturedGame)target;
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

            // IMainPage_Bindings

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
                    this.dataRoot = (global::MicrosoftStore.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MicrosoftStore.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DataModel(obj.DataModel, phase);
                    }
                }
            }
            private void Update_DataModel(global::MicrosoftStore.DataModel.MicrosoftStoreDataModel obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_DataModel_TopFreeAppsData(obj.TopFreeAppsData, phase);
                        this.Update_DataModel_FeaturedGameAppData(obj.FeaturedGameAppData, phase);
                    }
                }
            }
            private void Update_DataModel_TopFreeAppsData(global::MicrosoftStore.Models.TopFreeAppsDataObject obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 57
                    if (!isobj5DataModelDisabled)
                    {
                        XamlBindingSetters.Set_MicrosoftStore_Views_TopFreeApps_DataModel(this.obj5, obj, null);
                    }
                }
            }
            private void Update_DataModel_FeaturedGameAppData(global::MicrosoftStore.Models.FeaturedGameAppDataObject obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 60
                    if (!isobj6DataModelDisabled)
                    {
                        XamlBindingSetters.Set_MicrosoftStore_Views_FeaturedGame_DataModel(this.obj6, obj, null);
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
            case 1: // MainPage.xaml line 1
                {
                    this.page = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2: // MainPage.xaml line 14
                {
                    this.MainGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 20
                {
                    this.HorizontalState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // MainPage.xaml line 32
                {
                    this.VerticalState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // MainPage.xaml line 57
                {
                    this.TopFreeApps = (global::MicrosoftStore.Views.TopFreeApps)(target);
                }
                break;
            case 6: // MainPage.xaml line 60
                {
                    this.FeaturedGame = (global::MicrosoftStore.Views.FeaturedGame)(target);
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
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

