﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
using IOUSystems.Models;

namespace IOUSystems.Controllers
{
      
    public class AccountController : Controller
    {
        //
        // GET: /Account/Login

        public ActionResult CreateUser()
        {
            return View();
        }



    }
}
