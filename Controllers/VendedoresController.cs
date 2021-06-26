using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
