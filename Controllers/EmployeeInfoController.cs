using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return result;
        }
    }
}