using System;
using System.Runtime.Serialization;

namespace WCFMVC.Utility.ErrorHandlers
{
    [DataContract(Name ="ServiceError")]
    public class ServiceError
    {
        [DataMember]
        public string Operation { set; get; }
        [DataMember]
        public string ErrorMessage { set; get; }
    }
}
