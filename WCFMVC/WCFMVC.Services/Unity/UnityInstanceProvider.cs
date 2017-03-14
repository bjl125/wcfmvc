using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Microsoft.Practices.Unity;

namespace WCFMVC.Services.Unity
{
    public class UnityInstanceProvider : IInstanceProvider
    {
        private IUnityContainer container;
        private Type _serviceType;

        public UnityInstanceProvider(IUnityContainer container,Type serviceType)
        {
            this.container = container;
            _serviceType = serviceType;
        }
        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return container.Resolve(_serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            container.Teardown(instance);
        }
    }
}
