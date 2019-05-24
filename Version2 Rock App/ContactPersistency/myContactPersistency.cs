using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.AI.MachineLearning;
using Windows.Storage;

namespace Version2_Rock_App.ContactPersistency
{
    public class myContactPersistency<T> where T : class 
    {
        private const string FileName = "mydata.json";
        private CreationCollisionOption _options;
        private StorageFolder _folder;

        public myContactPersistency()
        {
            _options = CreationCollisionOption.OpenIfExists;
            _folder = ApplicationData.Current.LocalFolder;
        }

        public async Task SaveAsync(List<T> data)
        {
            var dataFile = await _folder.CreateFileAsync(FileName, _options);
            string dataJSON = JsonConvert.SerializeObject(data);
            await FileIO.WriteTextAsync(dataFile, dataJSON);
        }

        public async Task <List<T>> LoadAsync()
        {
            try
            {
                StorageFile dataFile = await _folder.GetFileAsync(FileName);
                string DataJSON = await FileIO.ReadTextAsync(dataFile);
                if (DataJSON != null)
                {
                    return JsonConvert.DeserializeObject<List<T>>(DataJSON);
                }
                else
                {
                    return new List<T>();
                }
            }
            catch (FileNotFoundException)
            {
                await SaveAsync(new List<T>());
                return new List<T>();
            }

        }
    }
}
