using OpenQA.Selenium;
using System;


namespace TenLab.PageObject
{
    public class DealsPage
    {
        private IWebDriver _webDriver;

        private readonly By _sortErliestDeparture = By.XPath("/html/body/div[1]/div[2]/div[7]/div/div[2]/div/div/div[1]/div/div/div/div/div[3]/div");
        private readonly By _hightToLow = By.XPath("/html/body/div[1]/div[2]/div[7]/div/div[2]/div/div/div[1]/div/div/div/div/div[3]/div[2]/div[3]/p");
        
        public DealsPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void SortByDeparture()
        {
            _webDriver.FindElement(_sortErliestDeparture).Click();
        }

        public void HightToLowSort()
        {
            _webDriver.FindElement(_hightToLow).Click();

        }
    }
}
