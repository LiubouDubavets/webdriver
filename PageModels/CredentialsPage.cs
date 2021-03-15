using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModels
{
    public class CredentialsPage : AbstractPage
    {
        public static IWebElement loginField => SearchForElementXPath("//*[@id='identifierId']"); 
                                                                    //"#identifierId");
        public static IWebElement acceptLoginButton => SearchForElementXPath("//div[@id='identifierNext']");
        private static IWebElement passField => SearchForElementXPath("//input[@name='password']");
        private IWebElement acceptPassButton => SearchForElementXPath("//div[@id='passwordNext']");
        
        //string login, string pass
        //"nameexampletest@gmail.com", "784512875421"
        public static void OpenMailBox()
        {
            loginField.SendKeys("nameexampletest@gmail.com");
            acceptLoginButton.Click();
            Thread.Sleep(5000);
            passField.SendKeys("784512875421");
            acceptLoginButton.Click();
        }
    }
}