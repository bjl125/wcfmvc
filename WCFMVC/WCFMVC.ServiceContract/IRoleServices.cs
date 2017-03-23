using System;
using System.Collections.Generic;
using System.ServiceModel;

using WCFMVC.ModelObject.Models;

namespace WCFMVC.ServiceContract
{
    [ServiceContract]
    public interface IRoleServices
    {
        [OperationContract]
        RoleModel GetRoleInfo(int roleid);

        [OperationContract]
        int UpdateRoleName(int id, string name);

        [OperationContract]
        int SetRole();

        [OperationContract]
        int GetRole();

    }
}
