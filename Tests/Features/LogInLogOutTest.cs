using System.Threading;
using NUnit.Framework;
using PageModels;

namespace Tests.Features
{
    public class LogInLogOutTest
    {
        [Test]
        public void Test1()
        {
            HomePage.SignIn();
            Thread.Sleep(5000);
            CredentialsPage.OpenMailBox();
            Thread.Sleep(5000);
            MailBoxPage.LogOut();
            Thread.Sleep(5000);
            Assert.Equals(AbstractPage.SearchForElementXPath(""),HomePage.SearchForElementXPath(""));
        }
    }
}