using Gauge.CSharp.Lib.Attribute;
using GaugeDemoCsharp.Pages.Util;


namespace GaugeDemoCsharp.Specifications
{
    class HomeSpecs : PageFactory
    {
        [Step("Then user should navigate to home page")]
        public void ThenUserShouldNavigateToHomePage()
        {
            homePage.ValidateHomePage();
        }
    }
}
