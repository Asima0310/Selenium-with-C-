using OpenQA.Selenium;


namespace Assignment3.Pages
{
    public class ProductPage : BaseClass
    {
        public void AddProduct1()
        {
            
            IWebElement addtoCartButton = driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));
            addtoCartButton.Click();
        }
        public void AddProduct2()
        {
            IWebElement addtoCartButton = driver.FindElement(By.Name("add-to-cart-sauce-labs-bike-light"));
            addtoCartButton.Click();
        }
    }
}