﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewsPortal.Startup))]
namespace NewsPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
