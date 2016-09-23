using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRMCarDealer.CustomFilter;

namespace CRMCarDealer.Controllers
{
    [AuthLog(Roles = "salesman")]
    public class SalesmanController : Controller
    {
        // GET: Salesman
        public ActionResult Index()
        {
            return View();
        }
    }
}