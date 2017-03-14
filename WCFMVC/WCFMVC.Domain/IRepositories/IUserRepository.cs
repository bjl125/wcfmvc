using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFMVC.ModelObject.Models;

namespace WCFMVC.Domain
{
    public partial interface IUserRepository
    {
        int ModifyUserInfo(UserModel user);

        UserModel GetUserInfo(int userid);
    }
}
