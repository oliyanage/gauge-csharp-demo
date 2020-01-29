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
        By userNameTxt = By.XPath("//input[@placeholder='Username']");
        By passwordTxt = By.XPath("//input[@placeholder='Password']");
        By loginBtn = By.XPath("//button[@class='btn btn-primary btn-block']");

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterUserNamePassword(string username, string password)
        {
            SwitchToIFrame("preview");
            SendKeys(userNameTxt, (username));
            SendKeys(passwordTxt, (password));
        }
     

        public void ClickLoginButton()
        {
            Click(loginBtn);
        }

    }
}
