using DevExpress.Web.Mvc;
using GridViewWithDxScrollView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GridViewWithDxScrollView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult GridViewPartial() {
            var model = ModelRepository.GetData();
            return PartialView("_GridViewPartial", model);
        }
    }
}