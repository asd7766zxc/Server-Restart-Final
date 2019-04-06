using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Server_Restart_Final.DataStorage
{
    public static class StorageData
    {
        public static bool NewLineOnAttributes { get; set; }
        public static void SaveData(object obj, string FilePath)
        {
            Type T = obj.GetType();
            var xs = new XmlSerializer(T);
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = NewLineOnAttributes, OmitXmlDeclaration = true };
            using (XmlWriter writer = XmlWriter.Create(FilePath, ws))
            {
                xs.Serialize(writer, obj);
            }
        }
        public static T FromXmlFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                try
                {
                    var result = FromXml<T>(sr.ReadToEnd());
                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception("There was an error attempting to read the file " + filePath + "\n\n" + e.InnerException.Message);
                }
                finally
                {
                    sr.Close();
                }
            }
            else
            {
                return IFFileNotExists<T>();
            }
        }
        public static T IFFileNotExists<T>()
        {
            SaveData(ProcessCheckStatus.data, System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            StreamReader sr = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\LocalData.xml");
            var result = FromXml<T>(sr.ReadToEnd());
            return result;

        }
        public static T FromXml<T>(string xml)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (StringReader sr = new StringReader(xml))
            {
                return (T)xs.Deserialize(sr);
            }
        }
    }
}
