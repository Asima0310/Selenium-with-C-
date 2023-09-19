using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Assignment3
{

    public class BaseClass
    {
        public static IWebDriver driver;

        [TestInitialize]
        public void DriverInitialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            LoginPage loginPage = new LoginPage();
            loginPage.Login("standard_user", "secret_sauce");
        }
        public class UserInfo
        {
            public string username { get; set; }
            public string password { get; set; }
            public string zipCode { get; set; }
        }
    }
}