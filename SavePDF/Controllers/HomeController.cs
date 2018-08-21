using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa.MVC;

namespace SavePDF.Controllers
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

        public ActionResult ViewToPdf()
        {
            // This will directly download the view as pdf file
            //return new ActionAsPdf( "Index")
            //                        { FileName = "ViewAsPdf.pdf" };

            // This will open the view as pdf file and user can then print or save
            var pdfResult = new ViewAsPdf("Index")
            { FileName = "ViewAsPdf.pdf" };

            var binary = pdfResult.BuildPdf(this.ControllerContext);
            return File(binary, "application/pdf");
        }
    }
}