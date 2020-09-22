using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;

namespace Autos.Data
{
    public class JSonHelper
    {

        public string ConvertObjectToJSon<T>(T inObj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            serializer.WriteObject(memoryStream,inObj);
            string jsonString = Encoding.UTF8.GetString(memoryStream.ToArray());
            memoryStream.Close();
            return jsonString;
        }

        public T ConvertJSonToObject<T>(string jsonString)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
            T obj = (T) serializer.ReadObject(memoryStream);
            return obj;
        }

    }
}
