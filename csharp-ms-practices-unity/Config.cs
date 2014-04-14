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
        IUnityContainer Container = new UnityContainer().LoadConfiguration("someObject");
    }
}
