using EmployeeBookXpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeBookXpert;
namespace EmployeeBookXpert.Services
{

    [RoutePrefix("api/masters")]
    public class DropdownController : ApiController
    {
        [HttpPost]
        public IHttpActionResult GetStates(string Flag)
        {
            return 
        }
    }
}
