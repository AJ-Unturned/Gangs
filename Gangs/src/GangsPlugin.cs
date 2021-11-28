using Gangs.src.util;
using Rocket.Core.Plugins;
using Logger = Rocket.Core.Logging.Logger;
using SDG.Unturned;
using System.Threading;


namespace Gangs
{
    public class GangsPlugin : RocketPlugin
    {
        protected override void Load()
        {
            Logger.Log($"{Name} ({Assembly.GetName().Version}) has loaded.");

            if (Level.isLoaded)
                new Modifier().EditPlugins();

            Level.onPostLevelLoaded += OnPostLevelLoaded;
        }

        protected override void Unload()
        {
            Logger.Log($"{Name} has unloaded.");
            base.Unload();
        }

        private void OnPostLevelLoaded(int x)
        {
            new Thread(new Modifier().EditPlugins).Start();
        }
    }
}
