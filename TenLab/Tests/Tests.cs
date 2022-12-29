using NUnit.Framework;


namespace TenLab.Tests
{
    public class Tests
    {
        private readonly Steps steps = new();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
           // steps.CloseBrowser();
        }

        [Test]
        public void ReviewsOfMadeiraCheck()
        {
            steps.OpenDestinationMenu();
            steps.ChooseChine();
            steps.OpenThingsToDo();
        }


        [Test]
        public void TripsUnderOneWeekCheck()
        {
            steps.OpenTravelStyle();
            steps.ChooseTripsUnderOneWeek();
       
        }

        [Test]
        public void PageAboutCheck()
        {
            steps.OpenAboutUsMenu();
            steps.OpenAboutUsPage();
        }

        [Test]
        public void SalesTripCheck()
        {
            steps.OpenSelesPage();
            steps.OpenCertainTrip();
            steps.ViewDates();
        }

        [Test]
        public void AustriaReviewsCheck()
        {
            steps.OpenDestinationMenu();
            steps.ChooseAustria();
            steps.OpenCertainAustriaTrip();
            steps.ViewAustriaReviews();
        }

        [Test]
        public void JobOfManagerCheck()
        {
            steps.OpenDealsMenuItem();
            steps.LastTwoMinuteDeal();
            steps.SortByDeparture();
            steps.HightToLowSort();
        }

        [Test]
        public void CompareCheck()
        {
            steps.GoToFeatureTrip();
            steps.AddToCompareButton();
         
        }

        [Test]
        public void ProjectsPageCheck()
        {
            steps.InspiredMenu();
            steps.OpenTravelProject();
        }

        [Test]
        public void TripWithOptionsCheck()
        {
            steps.OpenDestinationMenu();
            steps.ChooseBrazil();
            steps.AllBrazillrips();
         
        }

        [Test]
        public void TravelCreditCheck()
        {
            steps.TravelCredit();
        }

        

    }
}
