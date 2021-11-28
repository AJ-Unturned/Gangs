using System.Threading;
using Steamworks;
using Logger = Rocket.Core.Logging.Logger;

namespace Gangs.src.util
{
    class Modifier
    {
        public void EditPlugins(string[] plugins, int bots)
        {
            // Waits a second, due to some weird shit w/ Rocket.
            Thread.Sleep(1000);

            SteamGameServer.SetKeyValue("rocketplugins", string.Join(",", plugins));
            SteamGameServer.SetBotPlayerCount(bots);
        }
    }
}
