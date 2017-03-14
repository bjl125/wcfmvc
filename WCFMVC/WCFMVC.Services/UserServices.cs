using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Activation;
using System.ServiceModel;
using WCFMVC.ServiceContract;
using WCFMVC.ModelObject;
using WCFMVC.ModelObject.Models;

namespace WCFMVC.Services
{

    public class UserServices : ServiceBase, IUserServices
    {
        public UserModel GetUserInfo(int userid)
        {
            return userRepository.GetUserInfo(1);
        }

        public bool UpdateUserName(int userid, string usernewname)
        {
            return true;
        }

        public int ModifyUserInfo(UserModel user)
        {
            return userRepository.ModifyUserInfo(user);
        }
    }
}
