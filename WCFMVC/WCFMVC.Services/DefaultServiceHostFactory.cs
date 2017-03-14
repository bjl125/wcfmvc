using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Activation;


namespace WCFMVC.Services
{
    public class DefaultServiceHostFactory :ServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return base.CreateServiceHost(serviceType, baseAddresses);
        }
    }
}
