using DekContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DekContext
{
    public class DataLoadSave
    {
        public static void SaveXML(string FilePath, object Blok)
        {           
            XmlSerializer formatter = new XmlSerializer(typeof(Dek));
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                formatter.Serialize(fs, Blok);
            }
        }

        public static Dek LoadXML(string FilePath = @"DB.xml")
        {
            if (File.Exists(FilePath))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Dek));
                using (FileStream fs = new FileStream(FilePath, FileMode.OpenOrCreate))
                {                    
                    return (Dek)formatter.Deserialize(fs);
                }
            }
            else
            {
                return new Dek();
            }
        }
    }
}
