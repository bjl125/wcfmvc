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
using WCFMVC.Utility.Loging;
namespace WCFMVC.Services
{

    public class RoleServices : ServiceBase, IRoleServices
    {

        public RoleModel GetRoleInfo(int roleid)
        {
            return roleRepository.GetRoleInfo(roleid);
        }

        public int UpdateRoleName(int id, string name)
        {
            return roleRepository.UpdateRoleName(id, name);
        }

        public int SetRole()
        {
            int d = 0;
            try
            {

                var s = 9 / d;
                return 1;

            }
            catch(Exception ex)
            {
                EntlibLogFactory.Log.LogError("seterror", ex);
                
                return 0;
            }
        }
    }
}
