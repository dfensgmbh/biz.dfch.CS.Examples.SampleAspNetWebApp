/**
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

using biz.dfch.CS.Examples.SampleAspNetWebApp.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(biz.dfch.CS.Examples.SampleAspNetWebApp.Startup))]
namespace biz.dfch.CS.Examples.SampleAspNetWebApp
{
    public partial class Startup
    {
        public const string ADMINISTRATOR_ROLE = "Administrator";
        public const string USER_ROLE = "User";

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            // DFTODO - custom code for initial role creation
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            CreateRoleIfNotExists(roleManager, ADMINISTRATOR_ROLE);
            CreateRoleIfNotExists(roleManager, USER_ROLE);
        }

        private void CreateRoleIfNotExists(RoleManager<IdentityRole> roleManager, string roleName)
        {
            roleManager.Create(new IdentityRole(roleName));
        }
    }
}
