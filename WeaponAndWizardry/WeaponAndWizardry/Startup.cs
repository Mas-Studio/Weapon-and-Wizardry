using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeaponAndWizardry.Startup))]
namespace WeaponAndWizardry
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
