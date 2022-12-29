using OpenQA.Selenium;


namespace TenLab.PageObject
{
    public class ContikiJobPage
    {
        private IWebDriver _webDriver;

        private readonly By _tripManager = By.XPath("/html/body/div[1]/div[2]/div[8]/div/div/div/div/div/div[1]/div[6]/div[1]/a");

        public ContikiJobPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void JobTripManager()
        {
            _webDriver.FindElement(_tripManager).Click();

        }
    }
}
