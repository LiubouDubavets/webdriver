
using OpenQA.Selenium.Chrome;

namespace Core
{
    public class WebDriver
    {
        private readonly WebDriver _driver;

        private WebDriver()
        {
            _driver = new WebDriver();
        }

        public static WebDriver GetDriver()
        {
            return new WebDriver();
        }

        
        
    }
}