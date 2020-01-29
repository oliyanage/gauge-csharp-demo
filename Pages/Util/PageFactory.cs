using Gauge.CSharp.Lib.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeDemoCsharp.Pages.Util
{
    class PageFactory : BaseClass
    {
        public static LoginPage loginPage;
        public static HomePage homePage;

        [BeforeSuite]
        public void init()
        {
            loginPage = new LoginPage();
            homePage = new HomePage();
        }
    }
}
