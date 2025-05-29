using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeBookXpert.Models;
using EmployeeBookXpert.Services;
namespace EmployeeBookXpert.Controllers
{
    public class EmployeeInfoController : Controller
    {
        // GET: EmployeeInfo
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public JsonResult GetStates()
        {
            JsonResult result = new JsonResult();
            var api = new ApiHelperController();
            string Qflag = "S";
            var response = api.getPostResponse("Dropdown/GetStatesServices", Qflag);
            if(response != null)
            {
                result=
            }
            return result;
        }
    }
}