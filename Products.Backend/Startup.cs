using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Products.Backend.Startup))]
namespace Products.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
