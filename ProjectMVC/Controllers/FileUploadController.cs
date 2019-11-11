using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMVC.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        // GET: FileUpload/Details/5
        public ActionResult Upload()

        {
            var name = Request.Form["Name"]; //Atrapar Datos

            for (int i = 0; i < Request.Files.Count; i++)  //Atrapar archivos
            {
                HttpPostedFileBase file = Request.Files[i]; //Reconociendo los archivos 
                //int fileSize = file.ContentLength;
                //string fileName = file.FileName;
                string mimeType = file.ContentType;
                //System.IO.Stream fileContent = file.InputStream;

                var guid = Guid.NewGuid();
                var ext = mimeType.Split('/').LastOrDefault();

                ViewBag.Guid = string.Format("{0}.{1}", guid, ext);  //Para enviar del controlador a la vista

                file.SaveAs(Server.MapPath("~/Images/Products/") +
                    string.Format("{0}.{1}", guid, ext));

            }

            return View("Show");
        }
    }
}
