using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTask
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement _createAccount => driver.FindElement(By.XPath("(//span[@class = 'yfCvx60qsR50VNBG15jF'])[2]"));
        public string CreateAccountMessage() => _createAccount.Text;
    }
}
