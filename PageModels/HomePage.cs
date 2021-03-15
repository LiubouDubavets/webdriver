using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModels
{
    public class HomePage : AbstractPage
    {
        
        //private static IWebElement signInButton => SearchForElementXPath("//a[@ga-event-action='sign in']");
        private static IWebElement signInButton => SearchForElementXPath("/html/body/div[1]/div[1]/div[5]/ul/li[2]/a");

        public static void SignIn()
        {
            Driver.Navigate().GoToUrl(MAIL_URL);
            Thread.Sleep(5000);
            signInButton.Click();
        }
    }
}