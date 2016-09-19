using BusinessServices;
using CRMCarDealer.Models;
using CRMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CRMCarDealer.Controllers
{
    public class DriveTestController:Controller
    {
        public CRMContext _context;
        public DriveTestController()
        {
            _context = new CRMContext();
        }

        public ActionResult Index()
        {
            var driveTests = _context.DriveTests.Include(d => d.Salesman).Include(d => d.Prospect).Include(d => d.TestCar).ToList();
            return View(driveTests);
        }
    }
}