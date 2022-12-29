using OpenQA.Selenium;



namespace TenLab.PageObject
{
    public class EuropianVistasPage
    {

        private IWebDriver _webDriver;

        private readonly By _viewDatesButton = By.XPath("/html/body/div[1]/div/section/section/section/div/button[1]");

        public EuropianVistasPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void ViewDates()
        {

            _webDriver.FindElement(_viewDatesButton).Click();       

        }
    }
}
