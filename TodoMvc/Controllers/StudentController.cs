using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoMvc.DAL;

namespace TodoMvc.Controllers
{
    public class StudentController : Controller
    {
		private SchoolContext db = new SchoolContext();

        public ActionResult Index()
        {
			return View (db.Students.ToList());
        }
    }
}
