using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenLab.PageObject
{
    public class BrazilTripPage
    {
        private IWebDriver _webDriver;

        private readonly By _allBrazilTripsButton = By.XPath("/html/body/div[1]/div[2]/div[6]/div/div/ul/li/div/div/div/div/a");
        private readonly By _viewTrip = By.XPath("/html/body/div[1]/div/div[8]/div/div[3]/div/p[2]");
      
   

        public BrazilTripPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public void AllBrazilTrips()
        {
            _webDriver.FindElement(_allBrazilTripsButton).Click();
        }

        public void ViewTrip()
        {
            _webDriver.FindElement(_viewTrip).Click();
        }


    }
}
