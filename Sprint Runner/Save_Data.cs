using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sprint_Runner
{
    public class Save_Data
    {
        public static void SaveData(object obj, string directory, string filename)
        {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(directory + filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }
    }
}