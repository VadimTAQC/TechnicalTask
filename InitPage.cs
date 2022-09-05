using OpenQA.Selenium;

namespace TechnicalTask
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base(driver)
        {

        }
        private IWebElement _languageBtn => driver.FindElement(By.XPath("(//div[@class = 'bui-group__item'])[2]"));
        private IWebElement _selectEnglishBtn => driver.FindElement(By.XPath("(//div[@class = 'bui-inline-container__main'])[3]"));
        private IWebElement _txtCountry => driver.FindElement(By.XPath("//input[@class = 'c-autocomplete__input sb-searchbox__input sb-destination__input']"));
        private IWebElement _calendarBtn => driver.FindElement(By.XPath("(//span[@class = 'sb-date-field__icon sb-date-field__icon-btn bk-svg-wrapper calendar-restructure-sb'])[1]"));
        private IWebElement _selectMonthBtn => driver.FindElement(By.XPath("//div[@class = 'bui-calendar__control bui-calendar__control--next']"));
        private IWebElement _selectFirstDateBtn => driver.FindElement(By.XPath("//span[@aria-label = '1 December 2022']"));
        private IWebElement _selectLastDateBtn => driver.FindElement(By.XPath("//span[@aria-label = '31 December 2022']"));
        private IWebElement _searchBtn => driver.FindElement(By.XPath("//div[@class = 'sb-searchbox-submit-col -submit-button ']"));
        
        private readonly By _nameTab = By.XPath("//span[@data-testid='address']");

        private readonly By _dateTab = By.XPath("//div[@data-testid = 'price-for-x-nights']");
        public void ClickLanguageBtn() => _languageBtn.Click();
        public void ChoseEnglishBtn() => _selectEnglishBtn.Click();
        public void SendTextToCountryField(string text) => _txtCountry.SendKeys(text);
        public void ClickDateBtn() => _calendarBtn.Click();
        public void ClickMonthBtn() => _selectMonthBtn.Click();
        public void ClickFirstDateBtn() => _selectFirstDateBtn.Click();
        public void ClickLastDateBtn() => _selectLastDateBtn.Click();
        public void ClickSearchBtn() => _searchBtn.Click();
        
        public bool CheckCountryList()
        {
            try
            {
                driver.FindElements(_nameTab);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool CheckDateList()
        {
            try
            {
                driver.FindElements(_dateTab);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        private IWebElement _buttonSignIn => driver.FindElement(By.XPath("(//span[@class = 'bui-button__text'])[5]"));
        public void ClickSignInBtn() => _buttonSignIn.Click();
    }
}