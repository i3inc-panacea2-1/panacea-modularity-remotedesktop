using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.RemoteDesktop
{
    public interface IRemoteDesktop : IPlugin
    {
        bool IsRunning();
        void Connect(string user, string pass, string domain, string server);
        void Disconnect();
    }
}
