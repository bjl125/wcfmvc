using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFMVC.ModelObject.Models
{
    [DataContract]
    [Serializable]
    public class UserModel
    {
        [DataMember]
        public int UserId { set; get; }

        [DataMember]
        public string UserName { set; get; }

        [DataMember]
        public DateTime CreateDate { set; get; }
    }
}
