﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Book_Store.Startup))]
namespace Online_Book_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
