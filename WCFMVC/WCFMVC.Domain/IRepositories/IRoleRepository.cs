using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFMVC.ModelObject.Models;

namespace WCFMVC.Domain
{
    public partial interface IRoleRepository
    {
        int UpdateRoleName(int id, string name);

        RoleModel GetRoleInfo(int id);
    }
}
