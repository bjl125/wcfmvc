using System;
using System.Collections.Generic;
using System.ServiceModel;

using WCFMVC.ModelObject.Models;

namespace WCFMVC.ServiceContract
{
    [ServiceContract]
   public interface IUserServices
    {
        [OperationContract]
        UserModel GetUserInfo(int userid);

        [OperationContract]
        bool UpdateUserName(int userid, string usernewname);

        [OperationContract]
        int ModifyUserInfo(UserModel user);
    }
}
