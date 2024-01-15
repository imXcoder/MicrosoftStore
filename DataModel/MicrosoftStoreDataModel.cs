using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using MicrosoftStore.Helpers;
using MicrosoftStore.Models;
using Windows.ApplicationModel;
using Windows.Storage;
using Windows.Storage.Provider;
using static System.Net.WebRequestMethods;

namespace MicrosoftStore.DataModel
{
    public class MicrosoftStoreDataModel
    {
        public static MicrosoftStoreDataModel Instance { get; } = new MicrosoftStoreDataModel();
        public MicrosoftStoreDataObject DataSource { get; private set; }

        private readonly TopFreeAppsDataObject _TopFreeAppsData = TopFreeAppsDataObject.GetDataObject();

        public TopFreeAppsDataObject TopFreeAppsData { get; private set; }

        private readonly FeaturedGameAppDataObject _FeaturedGameAppData = FeaturedGameAppDataObject.GetDataObject();

        public FeaturedGameAppDataObject FeaturedGameAppData { get; private set; }

        private object _lock = new object();

        public MicrosoftStoreDataModel()
        {
            this.TopFreeAppsData = _TopFreeAppsData;
            this.FeaturedGameAppData = _FeaturedGameAppData;
        }

        /// <summary>
        /// This method is not used because it will report an error(System.IO.FileNotFoundException) when it is running
        /// </summary>
        /// <returns></returns>
        public async Task LoadJson() 
        {
            StorageFolder StorageFolder = ApplicationData.Current.LocalFolder;
            StorageFile JsonFile = await StorageFolder.GetFileAsync("DataModel/MicrosoftStoreData.json");
            string JsonText = await FileIO.ReadTextAsync(JsonFile);

            Console.WriteLine(JsonText);
        }
    }
}
