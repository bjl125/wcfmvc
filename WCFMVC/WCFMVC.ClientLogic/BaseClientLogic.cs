using System;
using Microsoft.Practices.Unity;
using WCFMVC.WebUnity;
using WCFMVC.ServiceContract;

namespace WCFMVC.ClientLogic
{
    public class BaseClientLogic
    {
        public IRoleServices IRoleService
        {
            get
            {
                return UnityConfig.GetConfiguredContainer().Resolve<IRoleServices>();
            }
        }

        //[Dependency]
        //public IUserServices IUserService { set; get; }

        public IUserServices IUserService
        {
            get
            {

                return UnityConfig.GetConfiguredContainer().Resolve<IUserServices>();
            }
        }
    }
}
