using Assignment3.Pages;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Test
{
    [TestClass]
    public class AddToCart : BaseClass
    {
        //Declare
        ProductPage product = new ProductPage();
        PurchaseProductPage purchase = new PurchaseProductPage();
        private UserInfo[] userInfoArray;

        public AddToCart()
        {
            string jsonFilePath = "Info.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            var dataObject = JsonConvert.DeserializeObject<JObject>(jsonData);
            userInfoArray = JsonConvert.DeserializeObject<UserInfo[]>(dataObject["userInfo"].ToString());

        }

        [TestMethod]
        public void AddToCartProducts()
        {
            product.AddProduct1();
            product.AddProduct2();
            purchase.ClickonShopCartButton();
            Thread.Sleep(3000);
            purchase.Checkout();
            driver.Close();
        }
        [TestMethod]
        public void ReadDataFromFile()
        {

            product.AddProduct1();
            product.AddProduct2();
            purchase.ClickonShopCartButton();
            purchase.Checkout();
            purchase.AddDataintoFields("Asima", "Ali", "3421");
            Thread.Sleep(3000);
            driver.Close();
        }

        [TestMethod]
        public void CompleteFlowToBuyProduct()
        {
            product.AddProduct1();
            product.AddProduct2();
            if (userInfoArray.Length > 0)
            {
                UserInfo userInfo = userInfoArray[0];
                purchase.ClickonShopCartButton();
                purchase.Checkout();
                purchase.AddDataintoFields(userInfo.username, userInfo.password, userInfo.zipCode);
            }
            else
            {
                Console.WriteLine("No user data found in the JSON file.");
            }
           
            purchase.Continue();
            purchase.Finish();
            Thread.Sleep(3000);
            driver.Close();
        }

        [TestMethod]
        public void ValidateUsername()
        {
            product.AddProduct1();
            product.AddProduct2();
            purchase.ClickonShopCartButton();
            purchase.Checkout();
            purchase.AddUsername("Asima");
            purchase.Continue();
           IWebElement errorMessageA = driver.FindElement(By.XPath("//h3//button[@class=\"error-button\"]"));
         
            Assert.IsTrue(errorMessageA.Displayed, "Error: Last Name is required"); ;
           
            Thread.Sleep(2000);
            driver.Close();
        }

        [TestMethod]
        public void ValidateLastname()
        {
            product.AddProduct1();
            product.AddProduct2();
            purchase.ClickonShopCartButton();
            purchase.Checkout();
            purchase.AddUsername("Asima");
            purchase.AddPassword("Ali");
            purchase.Continue();
            IWebElement errorMessageA = driver.FindElement(By.XPath("//div[@class ='error-message-container error']"));

            Assert.IsTrue(errorMessageA.Displayed, "Error: Postal Code is required"); ;

            Thread.Sleep(3000);
            driver.Close();
        }

    }
}
