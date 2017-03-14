using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFMVC.ModelObject.Models;

namespace WCFMVC.Domain
{
    public partial class RoleRepository : IRoleRepository
    {
        public RoleModel GetRoleInfo(int id)
        {
            return new RoleModel() { RoleId = 1, RoleName = "Admin" };
        }

        public int UpdateRoleName(int id, string name)
        {
            return 2;
        }
    }
}
