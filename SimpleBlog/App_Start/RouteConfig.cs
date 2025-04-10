﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			/*
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
			*/


			routes.MapRoute(
					"Login", 
					"login",
					new {controller = "Auth", action = "Login"}
				);

			routes.MapRoute(
					name: "Home",
					url: "",
					defaults: new {controller = "Posts", action = "Index"}
				);


        }
    }
}
