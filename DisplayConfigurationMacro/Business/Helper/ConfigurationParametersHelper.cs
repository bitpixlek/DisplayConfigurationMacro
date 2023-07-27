using DisplayConfigurationMacro.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DisplayConfigurationMacro.Business.Helper
{
    public class ConfigurationParametersHelper
    {
        public static ConfigurationParameterModel GetConfiguration()
        {
            string jsonFile = string.Format("{0}{1}", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "/Config/ConfigurationParameters.json");
            ConfigurationParameterModel configParameter = JsonConvert.DeserializeObject<ConfigurationParameterModel>(File.ReadAllText(jsonFile));
            return configParameter;
        }
    }
}
