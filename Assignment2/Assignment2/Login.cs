using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Assignment2
{
    [TestClass]
    public class Login: WebDriver

    {
      
        [TestMethod]
        public void Case1()
        {
            string usernameA = "standard_user";
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            System.Threading.Thread.Sleep(3000);
            IWebElement username = driver.FindElement(By.Id("user-name"));
            username.SendKeys(usernameA);
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");
            IWebElement btnSubmit = driver.FindElement(By.Id("login-button"));
            btnSubmit.Click();
            string message = $"Hello! Welcome to {driver.Url}. You have logged in with username \"{usernameA}\".";
            Thread.Sleep(3000);
            driver.Close();
        }

        [TestMethod]
        public void Case2()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            System.Threading.Thread.Sleep(3000);
            IWebElement username = driver.FindElement(By.Id("user-name"));
            username.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");
            IWebElement btnSubmit = driver.FindElement(By.Id("login-button"));
            btnSubmit.Click();
            Thread.Sleep(3000);
            string actualTitle = driver.Title;
            string expectedTitle = "Swag Labs";
            Assert.AreEqual(actualTitle, expectedTitle);
            driver.Close();
        }

        [TestMethod]
        public void Case3()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            System.Threading.Thread.Sleep(3000);
            IWebElement username = driver.FindElement(By.Id("user-name"));
            username.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce123");
            IWebElement btnSubmit = driver.FindElement(By.Id("login-button"));
            btnSubmit.Click();
            var errorMessage = driver.FindElement(By.ClassName("error-button"));
            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", errorMessage);
            Thread.Sleep(5000);
            driver.Close();

        }
        [TestMethod]
        public void Case4()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            System.Threading.Thread.Sleep(3000);
            IWebElement btnSubmit = driver.FindElement(By.Id("login-button"));
            btnSubmit.Click();
            var errorMessageA = driver.FindElement(By.ClassName("error-button"));
            Assert.AreEqual("Epic sadface: Username is required", errorMessageA);
            Thread.Sleep(5000);
            driver.Close();

        }

        [TestMethod]
        [Ignore] /*Point #5*/
        public void Case5()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            System.Threading.Thread.Sleep(3000);
            IWebElement username = driver.FindElement(By.Id("user-name"));
            username.SendKeys("standard_user");
            IWebElement btnSubmit = driver.FindElement(By.Id("login-button"));
            btnSubmit.Click();
            var errorMessage = driver.FindElement(By.ClassName("error-button"));
            Assert.AreEqual("Epic sadface: Password is required", errorMessage);
            Thread.Sleep(5000);
            driver.Quit();
            
        }

    }
}