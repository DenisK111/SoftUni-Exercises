﻿using BasicWebServer.Server.Attributes;
using BasicWebServer.Server.Controllers;
using BasicWebServer.Server.HTTP;
using DataAnnotationsExtensions;
using FootballManager.Data;
using FootballManager.Data.Models;
using FootballManager.Services;
using FootballManager.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager.Controllers
{
    public class UsersController : Controller
    {
       
        private readonly IUsersService service;

        public UsersController(Request request,IUsersService service) : base(request)
        {
       
            this.service = service;
        }

        public Response Login()
        {
            if (this.User.IsAuthenticated)
                return this.Redirect("/");

            return this.View(new {IsAuthenticated=false});
        }
        public Response Register()
        {
            if (this.User.IsAuthenticated)
                return this.Redirect("/");

            return this.View(new { IsAuthenticated = false });
        }

        [HttpPost]
        public Response Register(InputRegisterModel model)
        {
            if (this.User.IsAuthenticated)
                return this.Redirect("/");


            if (model.Username.Length<5 || model.Username.Length>20)
            {
                return this.Register();
            }

            if (model.Email.Length < 10 || model.Email.Length > 60)
            {
                return this.Register();
            }
            if (model.Password.Length < 5 || model.Password.Length > 20)
            {
                return this.Register();
            }

            // Added Email Validation
            if (!(new EmailAddressAttribute().IsValid(model.Email)))
            {
                return this.Register();
            }

            service.AddRegistration(model);

            return this.Redirect("/Users/Login");

        }

        [HttpPost]
        public Response Login(string Username,string Password)
        {

            if (this.User.IsAuthenticated)
                return this.Redirect("/");

            if (service.AuthenticateLogin(Username,Password))
            {
                this.SignIn(Username);
            }

            else
            {
                this.Login();
            }

            return this.Redirect("/");

        }

        public Response Logout()
        {
            if (!this.User.IsAuthenticated)
                return this.Redirect("/Users/Login");

            SignOut();

            return Redirect("/");
        }


      


    }
}
