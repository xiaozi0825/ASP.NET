﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSale.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetOrderById("111");
            ViewBag.CustomerID = order.CustomerID;
            return View();
        }
    }
}