using System;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.ServiceModel;
using WCFMVC.Utility.Loging;

namespace WCFMVC.Utility.ErrorHandlers
{
    public class ServiceErrorHandler : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            //throw new NotImplementedException();
            EntlibLogFactory.Log.LogError("ServiceError", error);
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            //throw new NotImplementedException();

            if (error is FaultException<ServiceError>)
            {
                MessageFault msgfault = ((FaultException<ServiceError>)error).CreateMessageFault();

                fault = Message.CreateMessage(version, msgfault, ((FaultException<ServiceError>)error).Action);
            }
            else
            {
                ServiceError defaultError = new ServiceError()
                {
                    Operation = "Uncatched ServiceError",
                    ErrorMessage = error == null ? string.Empty : (error.InnerException == null ? error.Message : error.InnerException.Message)
                };
                if (error is UnauthorizedAccessException)
                {
                    defaultError.Operation = "UnauthorizedAccess Action";
                    defaultError.ErrorMessage = error == null ? string.Empty : error.Message;
                }

                FaultException<ServiceError> defaultExp = new FaultException<ServiceError>(defaultError);
                MessageFault defaultMsgFault = defaultExp.CreateMessageFault();

                fault = Message.CreateMessage(version, defaultMsgFault, defaultExp.Action);
            }
        }
    }
}
