using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Store.Preview.InstallControl;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.StartScreen;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MicrosoftStore.DataModel;
using System.ComponentModel;
using MicrosoftStore.Views;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace MicrosoftStore
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MicrosoftStoreDataModel DataModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.DataModel = new MicrosoftStoreDataModel();
        }
    }
}