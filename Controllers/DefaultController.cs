using CrudOperationInOnePage.Context;
using CrudOperationInOnePage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudOperationInOnePage.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            using (JsonContext context = new JsonContext())
            {
                return View(context.ObjUser.ToList());        //This will get the list of all users present in db  
            }
        }

        [HttpPost]
        public JsonResult CreateUser(Users objUser)         //objUser is object which should be same as in javascript function  
        {
            try
            {
                using (JsonContext context = new JsonContext())
                {
                    context.ObjUser.Add(objUser);
                    context.SaveChanges();
                    return Json(objUser, JsonRequestBehavior.AllowGet);        //returning user to javacript  
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpGet]
        public JsonResult EditUserJ(int Id)    //For getting details of the selected User  
        {
            try
            {
                using (JsonContext context = new JsonContext())
                {
                    var User = context.ObjUser.Find(Id);
                    if (User != null)
                    {
                        return Json(User, JsonRequestBehavior.AllowGet);
                    }
                    return Json(null, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [HttpPost]
        public JsonResult EditUserJ(Users objUser)      //For Updating changes   
        {
            try
            {
                using (JsonContext context = new JsonContext())
                {
                    context.ObjUser.AddOrUpdate(objUser);
                    context.SaveChanges();
                    return Json(objUser, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}