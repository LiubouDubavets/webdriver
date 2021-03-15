using System.IO;
using Core;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Tests
{ 
    public class Hooks
    {
        private IWebDriver Driver; 
        
        [SetUp]
        public void StartExecuting()
        {
           // Driver = new ChromeDriver();
           // Driver.Navigate().GoToUrl("https://gmail.com/");
        }

        [TearDown]
        public void QuitBrowser()
        {
            Driver.Quit();
        }

    }
}