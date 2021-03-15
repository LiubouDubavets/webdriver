using Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageModels
{
    public abstract class AbstractPage
    {
        protected static IWebDriver Driver = new ChromeDriver();

        public const string MAIL_URL = "https://www.google.com/intl/en/gmail/about/#";

        public static IWebElement SearchForElementXPath(string xpath)
        {
            return Driver.FindElement(By.XPath(xpath));
        }
        
        public static IWebElement SearchForElementName(string name)
        {
            return Driver.FindElement(By.Name(name));
        }
        
        public static IWebElement SearchForElementID(string id)
        {
            return Driver.FindElement(By.Id(id));
        }

        protected static IWebElement SearchForElementCss(string css)
        {
            return Driver.FindElement(By.CssSelector(css));
        }

       
        
        
        

       

        

        
        
        
    }
}