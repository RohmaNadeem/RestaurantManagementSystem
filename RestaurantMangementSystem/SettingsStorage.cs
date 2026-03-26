using System;
using System.IO;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    public static class SettingsStorage
    {
        private static readonly string StorageFile = "settings.xml";
        private static Settings currentSettings;

        static SettingsStorage()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                if (File.Exists(StorageFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                    using (FileStream fs = new FileStream(StorageFile, FileMode.Open))
                    {
                        currentSettings = (Settings)serializer.Deserialize(fs);
                    }
                }
                else
                {
                    currentSettings = new Settings();
                    Save();
                }
            }
            catch
            {
                currentSettings = new Settings();
            }

            // Update global settings
           
        }

        public static void Save()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (FileStream fs = new FileStream(StorageFile, FileMode.Create))
                {
                    serializer.Serialize(fs, currentSettings);
                }

                // Update global settings and notify
               
            }
            catch { }
        }

        public static Settings GetSettings() => currentSettings;

        public static void UpdateSettings(Settings newSettings)
        {
            currentSettings = newSettings;
            Save();
        }
    }
}