using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using GroupAddress;
using UIEditor.Component;
using System;

namespace UIEditor
{
    public class GroupAddressStorage
    {
        /// <summary>
        /// �� Json �ļ���װ�� KNXGroupAddress
        /// </summary>
        /// <returns></returns>
        public static List<EdGroupAddress> Load()
        {
            try
            {
                string addressFile = Path.Combine(MyCache.ProjectFolder, MyConst.GroupAddressFile);

                if (File.Exists(addressFile))
                {
                    string json = File.ReadAllText(addressFile, Encoding.UTF8);
                    var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                    var groupAddressList = JsonConvert.DeserializeObject<List<KNXGroupAddress>>(json, settings);

                    return groupAddressList.Select(it => new EdGroupAddress(it)).ToList();
                }

                return new List<EdGroupAddress>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// ���� KNXGroupAddress Ϊ Json �ļ�
        /// </summary>
        /// <param name="addressTable"></param>
        public static void Save()
        {
            // ����
            List<KNXGroupAddress> data = MyCache.GroupAddressTable.Select(it => it.ToKnx()).ToList();

            //
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var jsonData = JsonConvert.SerializeObject(data, Formatting.None, settings);
            File.WriteAllText(Path.Combine(MyCache.ProjectFolder, MyConst.GroupAddressFile), jsonData, Encoding.UTF8);
        }
    }
}