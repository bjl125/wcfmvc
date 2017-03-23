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
using WCFMVC.Utility.ErrorHandlers;
using WCFMVC.Utility.Log4net;
namespace WCFMVC.Services
{
    [ServiceErrorHandler]
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

        public int GetRole()
        {
            try
            {
            int[] s = { 1, 2 };

            int s2 = s[3];

            }
            catch(Exception ex)
            {

                ILog4net.Debug("GetRole", "Role", ex.Message, ex);
                EntlibLogFactory.Log.LogError("seterror", ex);
            }
            return 1;
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
                ILog4net.Debug("SetRole", "Role", ex.Message, ex);

                EntlibLogFactory.Log.LogError("seterror", ex);
                throw ex;
                //return 0;
            }
        }
    }
}
