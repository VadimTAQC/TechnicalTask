using OpenQA.Selenium;

namespace TechnicalTask
{
    public class BasePage
    {
        protected IWebDriver driver;
        public BasePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}