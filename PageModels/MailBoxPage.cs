using OpenQA.Selenium;

namespace PageModels
{
    public class MailBoxPage : AbstractPage
    {
        private IWebElement draftsFolder => SearchForElementCss("");
        private IWebElement sendButton => SearchForElementCss("");
        private IWebElement sendFolder => SearchForElementCss("");
        private IWebElement mailSummary => SearchForElementCss("");
        private static IWebElement userButton => SearchForElementXPath("//*[@id='gb']/div[2]/div[3]/div[1]/div[2]/div/a/img");
        private static IWebElement logOutButton => SearchForElementXPath("//*[@id='gb_71']");

        public static void LogOut()
        {
            userButton.Click();
            logOutButton.Click();
        }
    }
}