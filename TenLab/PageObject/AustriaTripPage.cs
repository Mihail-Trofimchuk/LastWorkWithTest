using OpenQA.Selenium;


namespace TenLab.PageObject
{
    public class AustriaTripPage
    {
        private IWebDriver _webDriver;

        private readonly By _reviewsOfTrip = By.XPath("/html/body/div[1]/div/div[10]/div/ul/li[3]/div/p");

        public AustriaTripPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void ReviewsOfTrip()
        {
            _webDriver.FindElement(_reviewsOfTrip).Click();

        }
    }
}
