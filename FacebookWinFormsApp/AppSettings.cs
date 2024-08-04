using System;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        public string LastAccessToken { get; set; }
        public bool RememberUser { get; set; }

        public AppSettings()
        {
            LastAccessToken = null;
            RememberUser = false;
        }

        public void SaveToFile()
        {
            string filePath = getFilePath();

            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();
            string filePath = getFilePath();

            if (File.Exists(filePath))
            {
                using (Stream stream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AppSettings));
                    obj = xmlSerializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

        private static string getFilePath()
        {
            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;

            return Path.Combine(projectFolder, "appSettings.xml");
        }
    }
}