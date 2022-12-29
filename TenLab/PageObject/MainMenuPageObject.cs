using OpenQA.Selenium;
using System.Threading;

namespace TenLab.PageObject
{
    public class MainMenuPageObject
    {

        private IWebDriver _webDriver;

        private readonly By _destinationItem = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div/div[1]/div/div[1]/div/div");
        private readonly By _chooseChine = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div[2]/div/div[2]/div/div[2]/a[2]");
        private readonly By _openThingToDo = By.XPath("/html/body/div[1]/div[2]/div[8]/div/ul/li[2]/div/p");
        private readonly By _travelStyleMenuItem = By.XPath("/html/body/div[1]/div/div[4]/div[2]/div[1]/div[1]/div/div[3]/div/div");
        private readonly By _chooseTripsUnderOneWeek = By.XPath("/html/body/div[1]/div/div[4]/div[2]/div[2]/div/div[1]/div/div/a[1]");
        private readonly By _openAboutUsmenu = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div/div[1]/div/div[4]/div/div");
        private readonly By _aboutUsItem = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div[2]/div/div[1]/div/div/a[1]");
        private readonly By _salesMenuItem = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div/div[1]/div/div[6]/div/div/a");
        private readonly By _certainItemofSalesPage = By.XPath("/html/body/div[1]/div[2]/div[8]/div/div[1]/div/div/div[1]/ul/li[1]/div/div[1]/div[2]/a");
        private readonly By _chooseAustria = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div[2]/div/div[1]/div/div[2]/a[1]");
        private readonly By _certainAustriaTrip= By.XPath("/html/body/div[1]/div[2]/div[16]/div/div[1]/div/div[1]/a/picture/img");
        private readonly By _careers = By.XPath("/html/body/div[1]/div[2]/div[18]/div[1]/div[1]/div[1]/div[2]/ul/li[3]/a");
        private readonly By _dealsMenuItem = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div/div[1]/div/div[2]/div/div");
        private readonly By _lastTwoMinutDeals = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div[2]/div/div[1]/div/div/a[2]");

        private readonly By _featureTrip = By.XPath("/html/body/div[1]/div[2]/div[6]/div/div/div[2]/div/div[1]/a/picture/img");
        private readonly By _addToCompare = By.XPath("/html/body/div[1]/div/div[6]/div[2]/div/a");

        private readonly By _getInspired = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div/div[1]/div/div[5]/div/div");
        private readonly By _travelProject = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div[2]/div/div[1]/div/div/a[2]");

        private readonly By _chooseBrazil = By.XPath("/html/body/div[1]/div[2]/div[4]/div[2]/div[2]/div/div[3]/div/div[2]/a[3]");

        private readonly By _futureTravelCredit = By.XPath("/html/body/div[1]/div[2]/div[4]/div[1]/div/div/a[2]");
        

        public MainMenuPageObject(IWebDriver webDriver) 
        {
            _webDriver = webDriver;
        }

        public BrazilTripPage ChooseBrazil()
        {
            _webDriver.FindElement(_chooseBrazil).Click();
            return new BrazilTripPage(_webDriver);
        }

        public void Future()
        {
            _webDriver.FindElement(_futureTravelCredit).Click();
        }

        public void TravelProjectItem()
        {
            _webDriver.FindElement(_travelProject).Click();
        }
        public void GetInspiredMenu()
        {
            _webDriver.FindElement(_getInspired).Click();
        }
        public void AddToCompare()
        {
            _webDriver.FindElement(_addToCompare).Click();
        }
        public void FeatureTrip()
        {
            _webDriver.FindElement(_featureTrip).Click();
        }
        public void LastTwoMinuteDeal()
        {
            _webDriver.FindElement(_lastTwoMinutDeals).Click();
        }
        public void OpenDealsMenuItem()
        {
            _webDriver.FindElement(_dealsMenuItem).Click();
        }

        public void OpenDestinationMenu()
        {
            _webDriver.FindElement(_destinationItem).Click();
        }

        public void ChooseChine()
        {
            _webDriver.FindElement(_chooseChine).Click();
        }

        public void ChooseAustria()
        {
            _webDriver.FindElement(_chooseAustria).Click();
        }

        public AustriaTripPage OpenCertainAustriaTrip()
        {
            _webDriver.FindElement(_certainAustriaTrip).Click();
            return new AustriaTripPage(_webDriver);
        }

        public void OpenThingsToDo()
        {
            _webDriver.FindElement(_openThingToDo).Click();
        }

        public void OpenTravelStyleMenuItem()
        {
            _webDriver.FindElement(_travelStyleMenuItem).Click();
        }

        public void OpenTripsUnderOneWeek()
        {
            _webDriver.FindElement(_chooseTripsUnderOneWeek).Click();
        }

        public void OpenAboutUsMenu()
        {
            _webDriver.FindElement(_openAboutUsmenu).Click();
        }

        public void OpenSelesPage()
        {
            _webDriver.FindElement(_salesMenuItem).Click();
        }

        public EuropianVistasPage OpenCertainTrip()
        {
            _webDriver.FindElement(_certainItemofSalesPage).Click();
            return new EuropianVistasPage(_webDriver);
        }
        

        public AboutPage OpenAboutUsPage()
        {
            _webDriver.FindElement(_aboutUsItem).Click();
            return new AboutPage(_webDriver);
        }

        public ContikiJobPage OpenCareersPage()
        {
            Thread.Sleep(2000);
            _webDriver.FindElement(_careers).Click();
            return new ContikiJobPage(_webDriver);
        }

    }
}
