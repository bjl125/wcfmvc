using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFMVC.ModelObject.Models;

namespace WCFMVC.Domain
{
    public partial class UserRepository : IUserRepository
    {
        public UserModel GetUserInfo(int userid)
        {
            return new UserModel() { UserId = 2, UserName = "Tom", CreateDate = DateTime.Now };
        }

        public int ModifyUserInfo(UserModel user)
        {
            return 3;
        }
    }
}
