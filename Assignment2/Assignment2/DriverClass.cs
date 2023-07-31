using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class WebDriver
    {
        protected IWebDriver driver;
        public WebDriver()
        {
            string chromeDriverPath = "C:\\Users\\asima.ali\\Downloads\\chromedriver_win32 (1)\\chromedriver.exe";
            driver = new ChromeDriver(chromeDriverPath);
        }

    }
}
