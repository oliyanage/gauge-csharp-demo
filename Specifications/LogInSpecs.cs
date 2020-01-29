using Gauge.CSharp.Lib.Attribute;
using Gauge.CSharp.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaugeDemoCsharp.Pages.Util;
using OpenQA.Selenium;

namespace GaugeDemoCsharp.Specifications
{
    class LogInSpecs : PageFactory
    {
        
       

        [Step("Given user navigate to <url>")]
        public void GivenUserNavigateToUrl(string url)
        {
            loginPage.NavigateToUrl(url);
        }

        [Step("And enter usernane and password <table>")]
        public void AndEnterUsernaneAndPasswordTable(Table table)
        {
            foreach (var row in table.GetTableRows())
            {
                loginPage.EnterUserNamePassword(row.GetCell("username"), row.GetCell("password"));
            }

        }

        [Step("When user click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            loginPage.ClickLoginButton();
        }

    
    }
}
