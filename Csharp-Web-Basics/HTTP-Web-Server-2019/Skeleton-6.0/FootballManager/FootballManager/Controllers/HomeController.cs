﻿namespace FootballManager.Controllers
{
    using BasicWebServer.Server.Attributes;
    using BasicWebServer.Server.Controllers;
    using BasicWebServer.Server.HTTP;

    public class HomeController : Controller
    {
        public HomeController(Request request)
            : base(request)
        {
        }

        public Response Index()
        {

            if (this.User.IsAuthenticated)
            {
               return Redirect("/Players/All");
            }

            return this.View(new { IsAuthenticated = false });
        }
       
    }
}
