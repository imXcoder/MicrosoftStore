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
        public MicrosoftStoreDataModel()
        {

        }

        /// <summary>
        /// This method is not used because it will report an error(System.IO.FileNotFoundException) when it is running
        /// </summary>
        /// <returns></returns>
        public static async Task<MicrosoftStoreDataObject> LoadDataJsonAsync()
        {
            string JsonText = await FileLoader.LoadText("DataModel/MicrosoftStoreData.json");

            MicrosoftStoreDataObject DataSource = JsonSerializer.Deserialize<MicrosoftStoreDataObject>(JsonText, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return DataSource;
        }
    }
}
