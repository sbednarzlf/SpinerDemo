// Kontroler Obslugujacy Opis LifeSpinner'a
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lfspinnerBeta.Controllers
{
    //[RequireHttps]
    public class MeetController : Controller
    {
        //
        // GET: /Meet/

        public ActionResult Index()
        {
            return View();
        }

    }
}
