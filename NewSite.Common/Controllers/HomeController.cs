using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSite.Common.Controllers
{
    public sealed class HomeController : Controller
    {
        [Route("module-demo")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
