using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ErpKadr
{
    public class FileHelper<T> where T : new() 
    {
        private string filePath;

        public FileHelper(string _filePath)
        {
            filePath = _filePath;
        }

        public void SerializeToFile(T employees)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var stremWriter = new StreamWriter(filePath))
            {
                serializer.Serialize(stremWriter, employees);
                stremWriter.Close();
            }
        }

        public T DeserializeFromFile() 
        {
            if (!File.Exists(filePath))
                return new T();
            var serializer = new XmlSerializer(typeof(T));
            using (var stremWriter = new StreamReader(filePath)) 
            {
                var employees = (T)serializer.Deserialize(stremWriter);
                stremWriter.Close();
                return employees;
            }

        }
    }
}
