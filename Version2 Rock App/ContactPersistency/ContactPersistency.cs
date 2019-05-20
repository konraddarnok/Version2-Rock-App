using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version2_Rock_App.ContactPersistency
{
    public class ContactPersistency<> where : class 
    {
        private const string
        private CreationCollisionOption _options;
        private StorageFolder _folder;

        public ContactPersistency()
        {
            _options = CreationCollisionOption.OpenIfExists;
            _folder = ApplicationData.Current.LocalFolder;
        }

        public async Task SaveAsync(List<> data)
        {
            var dataFile = await _folder.CreateFileAsync(FileName, _options);
            string dataJSON = JsonConvert.SerializeObject(data);
            await FileIO.WriteTextAsync(dataFile, dataJSON);
        }

        public async Task <List<>> LoadAsync()
        {
            try
            {
                StorageFile dataFile = await _folder.GetFileAsync(FileName);
                string DataJSON = await FileIO.ReadTextAsync(dataFile);
                if(DataJSON != null)
                {
                    return JsonConvert.DeserializeObject<List<>>(dataJSON);
                }
                else
                {
                    return new List<>();
                }
                catch (FileNotFoundException)
            {
                await SaveAsync(new List<>());
                return new List<>();
            }
            }
        }
    }
}
