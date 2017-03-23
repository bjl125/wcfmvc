using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Practices.Unity;
using WCFMVC.Domain;
using WCFMVC.Utility.Log4net;


namespace WCFMVC.Services
{
    public class ServiceBase
    {
        [Dependency]
        protected ILog4net ILog4net { set; get; }

        [Dependency]
        protected IUserRepository userRepository { set; get; }
        [Dependency]
        protected IRoleRepository roleRepository { set; get; }
    }
}
