using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditWinAPI
{
    public class ConfigService
    {

        public static ConfigRoot GetConfig()
        {
            string config = File.ReadAllText("config.json");
            ConfigRoot configObj = JsonConvert.DeserializeObject<ConfigRoot>(config);
            return configObj;
        }
    }


    public class Settings
    {
        public string app_id { get; set; }
        public string app_secret { get; set; }
        public string refresh_token { get; set; }
    }

    public class Preferences
    {
        public List<string> subreddits { get; set; }
    }

    public class ConfigRoot
    {
        public Settings settings { get; set; }
        public Preferences preferences { get; set; }
    }

}
