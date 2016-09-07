using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FB
{
    public sealed class AppSettings
    {
        private const string k_SettingsFile = "AppSettings.xml";

        private static AppSettings s_Instance;
        private static object s_LockObj = new object();

        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = loadSettingsOrDefault();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public bool RememberMe { get; set; }

        public Point WindowLocation { get; set; }

        public int WindowHeight { get; set; }
                                      
        public string UserAccessToken { get; set; }

        private AppSettings()
        {
            RememberMe = false;
            WindowLocation = Point.Empty;
            WindowHeight = 542;
            UserAccessToken = null;
        }

        private static AppSettings loadSettingsOrDefault()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
            AppSettings appSettings;

            if (File.Exists(k_SettingsFile))
            {
                using (Stream stream = new FileStream(k_SettingsFile, FileMode.Open))
                {
                    appSettings = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SaveSettings()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));

            using (Stream stream = new FileStream(k_SettingsFile, FileMode.Create))
            {
                serializer.Serialize(stream, this);
            }
        }
    }
}
