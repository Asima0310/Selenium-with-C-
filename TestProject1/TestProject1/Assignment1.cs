using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1
{
    [TestClass]
    public class Assignment1
    {
        private IWebDriver driver;
        [TestInitialize]
        public void TestInitialize()
        {
            string chromeDriverPath = "C:\\Users\\asima.ali\\Downloads\\chromedriver_win32 (1)\\chromedriver.exe";
            driver = new ChromeDriver(chromeDriverPath);
        }

        [TestMethod]
        public void Scenario1()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://10pearlsuniversity.org/");
            System.Threading.Thread.Sleep(3000);
            
            string actualTitle = driver.Title;
            string expectedTitle = "Home - 10PEARLS University";

             // If condition passes, print "PASS"; otherwise, print "FAIL"
             if (expectedTitle == actualTitle)
             {
                 Console.WriteLine("PASS");
             }
             else
             {
                 Console.WriteLine("FAIL");
             }
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            System.Threading.Thread.Sleep(3000);
            driver.Navigate().Back();
            string URL = driver.Url;
            Console.WriteLine(URL);
            driver.Navigate().Refresh();
            driver.Close();
        }

        [TestMethod]
        public void Scenario2()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
            System.Threading.Thread.Sleep(3000);
            IWebElement username = driver.FindElement(By.Id("username"));
            username.SendKeys("student");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Password123");
            IWebElement btnSubmit = driver.FindElement(By.Id("submit"));
            btnSubmit.Click();
            driver.Quit();
        }
    }
}

