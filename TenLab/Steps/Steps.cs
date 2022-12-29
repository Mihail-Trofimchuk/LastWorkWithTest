using NUnit.Framework;
using OpenQA.Selenium;
using TenLab.Driver;
using TenLab.PageObject;

namespace TenLab
{
    public class Steps
    {
        IWebDriver _webDriver;
        public void InitBrowser()
        {
            _webDriver = DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            DriverInstance.TearDown();
        }

        // 1st test case

        public void OpenDestinationMenu()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenDestinationMenu();
        }


        public void ChooseChine()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.ChooseChine();
        }

        public void OpenThingsToDo()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenThingsToDo();
        }

        // 2st test case

        public void OpenTravelStyle()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenTravelStyleMenuItem();
        }

        public void ChooseTripsUnderOneWeek()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenTripsUnderOneWeek();
        }

        // 3st test case

        public void OpenAboutUsMenu()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenAboutUsMenu();
        }

        public void OpenAboutUsPage()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenAboutUsPage();
        }


        // 4st test case

        public void OpenSelesPage()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenSelesPage();
        }

        public void OpenCertainTrip()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenCertainTrip();
        }

        public void ViewDates()
        {
            EuropianVistasPage europianVistasPage = new EuropianVistasPage(_webDriver);
            europianVistasPage.ViewDates();
        }

        // 5st test case

        public void ChooseAustria()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.ChooseAustria();
        }

        public void OpenCertainAustriaTrip()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenCertainAustriaTrip();
        }

        public void ViewAustriaReviews()
        {
            AustriaTripPage austriaTripPage = new AustriaTripPage(_webDriver);
            austriaTripPage.ReviewsOfTrip();
            Assert.AreEqual("https://www.contiki.com/en-us/tours/austria-ski-1-week?tab=reviews", _webDriver.Url);
        }

        // 6st test case

        public void OpenDealsMenuItem()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.OpenDealsMenuItem();
        }

        public void LastTwoMinuteDeal()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.LastTwoMinuteDeal();
        }

        public void SortByDeparture()
        {
            DealsPage dealsPagePage = new DealsPage(_webDriver);
            dealsPagePage.SortByDeparture();
        }

        public void HightToLowSort()
        {
            DealsPage dealsPagePage = new DealsPage(_webDriver);
            dealsPagePage.HightToLowSort();
        }

        // 7st test case

        public void GoToFeatureTrip()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.FeatureTrip();
        }

        public void AddToCompareButton()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.AddToCompare();
            Assert.AreEqual("https://www.contiki.com/en-us/tours/berlin-for-new-year", _webDriver.Url);
        }

        // 8st test case

        public void InspiredMenu()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.GetInspiredMenu();
        }

        public void OpenTravelProject()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.TravelProjectItem();
           
        }

        // 9st test case



        public void ChooseBrazil()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.ChooseBrazil();
          
        }

        public void AllBrazillrips()
        {
            BrazilTripPage brazilTripPage = new BrazilTripPage(_webDriver);
            brazilTripPage.AllBrazilTrips();
        }

    

        public void ViewTrip()
        {
            BrazilTripPage brazilTripPage = new BrazilTripPage(_webDriver);
            brazilTripPage.ViewTrip();
        }


        // 10st test case

        public void TravelCredit()
        {
            MainMenuPageObject mainPage = new MainMenuPageObject(_webDriver);
            mainPage.Future();
            //Assert.AreEqual("https://www.contiki.com/six-two/thetravelproject/", _webDriver.Url);
        }

        //Assert.AreEqual("https://www.contiki.com/en-us/tours/austria-ski-1-week?tab=reviews", _webDriver.Url);

        // 8th test case
        //public void OpenDiscountPage()
        //{
        //    Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
        //    mainPage.GoToDiscountPage();
        //}

        //public void OpenAsiaDiscount()
        //{
        //    Pages.DiscountPageObject discountPage = new Pages.DiscountPageObject(_driver);
        //    discountPage.OpenDiscountAboutAsia();
        //}

        //// 9th test case
        //public void OpenVacanciesPage()
        //{
        //    Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
        //    mainPage.GoToVacanciesPage();
        //}

        //public void SearchForVacancy()
        //{
        //    Pages.VacanciesPageObject vacanciesPage = new Pages.VacanciesPageObject(_driver);
        //    vacanciesPage.SearchForVacancies();
        //}

        //// 10th test case
        //public void OpenRentalCarPage()
        //{
        //    Pages.MainPageObject mainPage = new Pages.MainPageObject(_driver);
        //    mainPage.GoToRentalCarPage();
        //}

        //public void ShowInfoAboutHowToChooseCar()
        //{
        //    Pages.RentalCarPageObject rentalCarPage = new Pages.RentalCarPageObject(_driver);
        //    rentalCarPage.ShowInfoAboutChoosingAuto();
        //}
    }
}
