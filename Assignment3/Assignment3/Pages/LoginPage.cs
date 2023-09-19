using OpenQA.Selenium;

namespace Assignment3
{
    public class LoginPage : BaseClass
    {
        private By usernamefield = By.Name("user-name");
        private By passwordfield = By.Name("password");
        private By Loginbtn = By.Name("login-button");


        public void Enterusername(string username)
        {
            driver.FindElement(usernamefield).SendKeys(username);
        }
        public void Enterpassword(string password)
        {
            driver.FindElement(passwordfield).SendKeys(password);
        }
        public void ClickLoginButton()
        {
            driver.FindElement(Loginbtn).Click();
        }

        public void Login(string username, string password)
        {
            Enterusername(username);
            Enterpassword(password);
            ClickLoginButton();
        }

        internal void Enterusername()
        {
            throw new NotImplementedException();
        }
    }
}
