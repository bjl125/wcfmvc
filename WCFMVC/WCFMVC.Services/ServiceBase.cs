using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Practices.Unity;
using WCFMVC.Domain;


namespace WCFMVC.Services
{
    public class ServiceBase
    {
        [Dependency]
        protected IUserRepository userRepository { set; get; }
        [Dependency]
        protected IRoleRepository roleRepository { set; get; }
    }
}
