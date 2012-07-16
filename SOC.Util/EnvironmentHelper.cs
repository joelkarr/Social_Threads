using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace SOC.Util
{
    public static class EnvironmentHelper
    {
        #region Properties

        private static DateTime? _lastUpdate;

        private static DateTime LastUpdate
        {
            get
            {
                return _lastUpdate ?? DateTime.MinValue;
            }
            set
            {
                _lastUpdate = value;
            }
        }

        private static readonly object Locker = new object();

        private static XmlDocument _settings;

        internal static XmlDocument Settings
        {
            get
            {
                if (_settings == null || DateTime.UtcNow.Subtract(LastUpdate) > TimeSpan.FromMinutes(1))
                    lock (Locker)
                        if (_settings == null || DateTime.UtcNow.Subtract(LastUpdate) > TimeSpan.FromMinutes(1))
                        {
                                _settings = LoadSettings();
                            LastUpdate = DateTime.UtcNow;
                        }
                return _settings;
            }
        }

        #endregion

        #region Functionality

        private static XmlDocument LoadSettings()
        {
            
            var data = GetData();

            // Encode the XML string in a UTF-8 byte array
            var encodedString = Encoding.UTF8.GetBytes(data);

            // Put the byte array into a stream and rewind it to the beginning
            using (var ms = new MemoryStream(encodedString))
            {
                ms.Flush();
                ms.Position = 0;

                // Build the XmlDocument from the MemorySteam of UTF-8 encoded bytes
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(ms);
                return xmlDoc;
            }
        }


        private static string GetData()
        {
            using (var file = File.OpenText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"bin\\AppSettings.config")))
            {
                return file.ReadToEnd();
            }
        }

        public static string GetEnvironmentValue(string groupName, string keyName)
        {
            try
            {
// ReSharper disable PossibleNullReferenceException
                return Settings.DocumentElement[groupName][keyName].InnerText;
// ReSharper restore PossibleNullReferenceException
            }
            catch (Exception e)
            {
                throw new NullReferenceException(String.Format("Group or Key not found: {0} {1}", groupName, keyName), e);
            }
        }

        public static Dictionary<string, string> GetEnvironmentValue(string groupName)
        {
// ReSharper disable PossibleNullReferenceException
            return Settings.DocumentElement[groupName].ChildNodes.OfType<XmlElement>().ToDictionary(
// ReSharper restore PossibleNullReferenceException
                n => n.Name, n => n.InnerText);
        }
        #endregion
  
        
        
    }
}
