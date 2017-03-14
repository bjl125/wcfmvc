using System;
using System.ServiceModel;
using Microsoft.Practices.Unity;


namespace WCFMVC.Services.Unity
{
    public class UnityServiceHost:ServiceHost
    {
        private IUnityContainer unityContainer;

        public UnityServiceHost(IUnityContainer unityContainer,Type serviceType,params Uri[] baseAddresses) : base(serviceType, baseAddresses)
        {
            this.unityContainer = unityContainer;
        }

        protected override void OnOpening()
        {
            base.OnOpening();

            if (this.Description.Behaviors.Find<UnityServiceBehavior>() == null)
            {
                this.Description.Behaviors.Add(new UnityServiceBehavior(this.unityContainer));
            }

        }
    }
}
