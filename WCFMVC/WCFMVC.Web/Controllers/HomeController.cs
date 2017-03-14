using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;

using WCFMVC.ServiceContract;
using WCFMVC.ModelObject;
using WCFMVC.ClientLogic;

namespace WCFMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GetUserInfo()
        {
            //UnityUserServices

            var u = (new BaseClientLogic()).IUserService.GetUserInfo(1);
            return Json(u, JsonRequestBehavior.AllowGet);

            //using (ChannelFactory<IUserServices> cf=new ChannelFactory<IUserServices>("IUserServices"))
            //{
            //    IUserServices user = cf.CreateChannel();


            //    return Json(user.GetUserInfo(1), JsonRequestBehavior.AllowGet);
            //}
        }


        public ActionResult GetRoleInfo()
        {
            //UnityUserServices


            var u = (new BaseClientLogic()).IRoleService.GetRoleInfo(1);//.GetUserInfo(1);
            return Json(u, JsonRequestBehavior.AllowGet);

            //using (ChannelFactory<IRoleServices> cf = new ChannelFactory<IRoleServices>("IRoleServices"))
            //{
            //    IRoleServices user = cf.CreateChannel();


            //    return Json(user.GetRoleInfo(1), JsonRequestBehavior.AllowGet);
            //}
        }


        public ActionResult SetRoleInfo()
        {
            //UnityUserServices


            var u = (new BaseClientLogic()).IRoleService.SetRole();//.GetUserInfo(1);
            return Json(u, JsonRequestBehavior.AllowGet);

            //using (ChannelFactory<IRoleServices> cf = new ChannelFactory<IRoleServices>("IRoleServices"))
            //{
            //    IRoleServices user = cf.CreateChannel();


            //    return Json(user.GetRoleInfo(1), JsonRequestBehavior.AllowGet);
            //}
        }
    }
}