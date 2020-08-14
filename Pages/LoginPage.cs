using GaugeDemoCsharp.Pages.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeDemoCsharp.Pages
{
    class LoginPage : BaseClass
    {
       

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

       

    }
}
