namespace AllegroTests.Smoke
{
    using AllegroFramework.Helpers.Print;
    using AllegroFramework.Pages;

    using NUnit.Framework;

    using SetUpTests.Utilities;

    public class Search : AllegroSetUpTest
    {
        [Test]
        public void UserCanSearchAMugAndWritePriceOfTheFirstFoundItemAndCheckIfThePriceIsGreaterThan20Zł()
        {
            HomePage.Search("Mug");

            Print.FirstProductInformation().Name().WithPrice();

            Assert.True(SearchResultsPage.GetThePriceValueOfTheFirstProduct > 20);
        }
    }
}

/*
1. Go to https://allegro.pl/
2. Search for "Mug"
3. Write in console the name and price of the first found item
4. Check if the price is greater than 20zl
*/