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
        CRMContext Context;

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
            return RedirectToAction("Index");
        }

        #endregion



    }
}