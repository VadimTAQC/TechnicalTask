using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTask
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement txtEmail => driver.FindElement(By.XPath("//input[@name = 'username']"));
        private IWebElement submitButton => driver.FindElement(By.XPath("(//span[@class = 'yfCvx60qsR50VNBG15jF'])[2]"));
        public void SendTextToEmail(string text) => txtEmail.SendKeys(text);
        public void ClickSubmitButton() => submitButton.Click();
        



    }
}
