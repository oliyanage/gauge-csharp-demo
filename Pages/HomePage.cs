using GaugeDemoCsharp.Pages.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeDemoCsharp.Pages
{
    class HomePage : BaseClass
    {
        By homeLbl = By.XPath("//h1[contains(text(),'Confirmation')]");

        public void ValidateHomePage()
        {
            AreEqual("Confirmation", GetVisibleText(homeLbl), "Validate Home Lable");
        }
    }
}
