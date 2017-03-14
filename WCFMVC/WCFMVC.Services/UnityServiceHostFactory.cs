using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Common;

using WCFMVC.ServiceContract;
using WCFMVC.Domain;
using WCFMVC.Services.Unity;
using WCFMVC.Utility.Loging;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace WCFMVC.Services
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            IUnityContainer container = new UnityContainer();

            IConfigurationSource configurationSource = ConfigurationSourceFactory.Create();
            LogWriterFactory logWriteFactory = new LogWriterFactory(configurationSource);
            Logger.SetLogWriter(logWriteFactory.Create());

            container.RegisterType<IEntlibLog, EntlibLog>();
            //操作类注册
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();


            //注册服务
            container.RegisterType<IUserServices, UserServices>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRoleServices, RoleServices>(new ContainerControlledLifetimeManager());

            return new UnityServiceHost(container, serviceType, baseAddresses);
        }
    }
}
