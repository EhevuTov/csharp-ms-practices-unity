using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace csharp_ms_practices_unity
{
    public class Config
    {
        internal static IUnityContainer container {get; private set;}
        public Config()
        {
            container = new UnityContainer().LoadConfiguration("someObject");
            var users = Config.container.Resolve<UserRegistry>();
        }

    }
}
