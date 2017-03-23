using System;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using System.Linq;

namespace WCFMVC.Utility.ErrorHandlers
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
    public class ServiceErrorHandlerAttribute : Attribute, IServiceBehavior
    {
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            //throw new NotImplementedException();
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            //throw new NotImplementedException();
            if(serviceHostBase!=null && serviceHostBase.ChannelDispatchers.Any())
            {
                //add error handler
                foreach(ChannelDispatcher cd in serviceHostBase.ChannelDispatchers)
                {
                    cd.ErrorHandlers.Add(new ServiceErrorHandler());
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            //throw new NotImplementedException();
        }
    }
}
