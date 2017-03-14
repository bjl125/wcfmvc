using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFMVC.ModelObject.Models
{
    [DataContract]
    [Serializable]
    public class RoleModel
    {
        [DataMember]
        public int RoleId { set; get; }

        [DataMember]
        public string RoleName { set; get; }
        
    }
}
