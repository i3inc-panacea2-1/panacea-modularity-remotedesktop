using Panacea.Core;
using System.Linq;

namespace Panacea.Modularity.RemoteDesktop
{
    public static class PanaceaServicesExtensions
    {
        public static IRemoteDesktop GetImprivata(this PanaceaServices core)
        {
            return core.PluginLoader.GetPlugin<IRemoteDesktop>();
        }

        public static bool TryGetCitrix(this PanaceaServices core, out IRemoteDesktop plugin)
        {
            plugin = null;
            var rdc = core.PluginLoader.GetPlugins<IRemoteDesktop>().FirstOrDefault();
            if (rdc == null)
            {
                return false;
            }
            plugin = rdc;
            return true;
        }
    }
}
