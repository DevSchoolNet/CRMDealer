using BusinessServices;
using CRMCarDealer.Models;
using CRMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRMCarDealer.Controllers
{
    public class HomeController : Controller
    {
        //DAO Object
        CRMContext Context;

        //log4net
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

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

        //De aici incepe smekeria


        #region AddProduct
        public ActionResult AddProduct()
        {
        return View();
        }

        [HttpPost]
        public ActionResult AddProduct(AddProductModel productModel)
        {
            ProductService.AddProduct(productModel.Name, productModel.Model, productModel.EngineCapacity, productModel.Price, productModel.ChasisSeries, productModel.IsForSale);
            log.Info("AddProduct finished execution");
            return RedirectToAction("Index");
        }
        #endregion


        #region AddProspect
        public ActionResult AddProspect()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProspect(AddProspectModel prospectModel)
        {
            ProspectService.AddProspect(prospectModel.Name, prospectModel.Details, prospectModel.Email, prospectModel.Telephone);
            log.Info("AddProspect finished execution");
            return RedirectToAction("Index");
        }

        #endregion


        #region AddReminder
        public ActionResult AddReminder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddReminder(AddReminderModel reminderModel)
        {
            ReminderService.AddReminder(reminderModel.Text, reminderModel.SalesmanName, reminderModel.SalesmanSurname, reminderModel.CustomerId);
            log.Info("AddReminder finished execution");

            return RedirectToAction("Index");
        }
        #endregion

    }
}