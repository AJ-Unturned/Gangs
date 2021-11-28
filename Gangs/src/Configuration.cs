using Rocket.API;
using System.Collections.Generic;

namespace Gangs.src
{
    public class Configuration : IRocketPluginConfiguration
    {
        public List<string> Plugins;
        public static Configuration config;

        public void LoadDefaults()
        {
            Plugins = new List<string>()
            {
                "Completely custom",
                "plugins made",
                "by @AceLikesGhosts"
            };

        }
    }
}
