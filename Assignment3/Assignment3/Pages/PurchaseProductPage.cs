using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Reflection.Emit;

namespace Assignment3.Pages
{
    public class PurchaseProductPage : BaseClass
    {
        private By shopCartbtn = By.Id("shopping_cart_container");
        private By Checkoutbtn = By.Id("checkout");
        private By Firstname = By.Id("first-name");
        private By Lastname = By.Id("last-name");
        private By Zipcode = By.Id("postal-code");
        private By ContinueBtn = By.Id("continue");
        private By Finishbtn = By.Id("finish");


        public void ClickonShopCartButton()
        {
            IWebElement shopcart = driver.FindElement(shopCartbtn);
            shopcart.Click();
        }
        public void Checkout()
        {
            Console.WriteLine("Checkout");
            IWebElement checkoutbtn = driver.FindElement(Checkoutbtn);
            checkoutbtn.Click();
        }
        public void AddDataintoFields(string username, string password, string zipCode)
        {
            IWebElement usernameField = driver.FindElement(Firstname);
            IWebElement passwordField = driver.FindElement(Lastname);
            IWebElement zipCodeField = driver.FindElement(Zipcode);

            usernameField.SendKeys(username);
            passwordField.SendKeys(password);
            zipCodeField.SendKeys(zipCode);

        }


        public void AddUsername(string username)
        {
            IWebElement usernameField = driver.FindElement(Firstname);
            usernameField.SendKeys(username);
        }
        public void AddPassword(string password)
        {
            IWebElement usernameField = driver.FindElement(Lastname);
            usernameField.SendKeys(password);
        }

        public void Continue()
        {
            Console.WriteLine("Continue");

            IWebElement continuebtn = driver.FindElement(ContinueBtn);
            continuebtn.Click();

        }
        public void Finish()
        {
            Console.WriteLine("finish");
            IWebElement finishbtn = driver.FindElement(Finishbtn);
            finishbtn.Click();
        }
        public void ContinueWithEmptyLastNamefield(string username)
        {
            IWebElement usernameField = driver.FindElement(Firstname);
            IWebElement passwordField = driver.FindElement(Lastname);


            usernameField.SendKeys(username);

            IWebElement continuebtn = driver.FindElement(ContinueBtn);
            continuebtn.Click();
        }
    }
}
