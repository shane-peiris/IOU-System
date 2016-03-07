using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IOUSystems.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            using (var db = new BBDOIOUEntities())
            {
                // Create and save a new Blog 
                //Console.Write("Enter a name for a new Blog: ");
                //var name = Console.ReadLine();

                //var blog = new  tblUserDetail{ FName = "Shane" };
                //db.tblUserDetails.Add(blog);
                //db.SaveChanges();

                // Display all Blogs from the database 
                //var query = from b in db.tblUserDetails
                            //orderby b.FName
                            //select b;

                //Console.WriteLine("All blogs in the database:");
                //foreach (var item in query)
               // {
                    //Console.WriteLine(item.Name);
                //}

                //Console.WriteLine("Press any key to exit...");
                //Console.ReadKey();
            } 


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
