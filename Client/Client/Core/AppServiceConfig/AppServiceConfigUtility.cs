using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Client.Model;
using Client.Utility;

namespace Client
{
    public class AppServiceConfigUtility
    {
        private const string AppServiceConfigFileName = "ClientNetConfig.xml";

        public static AppServiceConfig Load()
        {
            string filePath = Path.Combine(Application.StartupPath, AppServiceConfigFileName);
            var a = XmlUtil.Deserialize(typeof(AppServiceConfig), FileUtility.ReadFile(filePath)) as AppServiceConfig;
            return XmlUtil.Deserialize(typeof(AppServiceConfig), FileUtility.ReadFile(filePath)) as AppServiceConfig;
        }
    }
}
