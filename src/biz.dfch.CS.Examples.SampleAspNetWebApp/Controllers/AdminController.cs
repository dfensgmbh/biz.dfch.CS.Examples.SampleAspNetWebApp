﻿/**
 * Copyright 2018 d-fens GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Linq;
using System.Web.Mvc;
using biz.dfch.CS.Examples.SampleAspNetWebApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace biz.dfch.CS.Examples.SampleAspNetWebApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: /Admin/Index
        [Authorize(Roles = Startup.ADMINISTRATOR_ROLE)]
        public ActionResult Index()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            var model = new AdminViewModel
            {
                Roles = roleManager.Roles.ToList()
            };

            return View(model);
        }
    }
}