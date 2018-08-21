Using the package Rotativa.MVC 
https://github.com/webgio/Rotativa

(DON'T ADD THE FIRST PACKAGE in nuget search results, it didnt not working with mvc5). Please make sure you add the below package
Rotativa.MVC by Dmitry

In the controller, we can add this small ActionResult  method that takes care of the pdf part.
We can even pass the model object if we have to fill the view as second parameter to ViewAsPdf or ActionAsPdf methods of the library.

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

In the view, just link to the actionresult method like any other controller method.
@Html.ActionLink("Convert View To PDF", "ViewToPdf", "", new { target = "_blank" })
