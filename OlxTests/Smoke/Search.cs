namespace OlxTests.Smoke
{
    using NUnit.Framework;

    using OlxFramework.Helpers.Print;
    using OlxFramework.Pages;

    using SetUpTests.Utilities;

    public class Search : OlxSetUpTest
    {
        [Test]
        public void UserCanSearchAMugAndWritePriceOfTheFirstFoundItemAndCheckIfThePriceIsGreaterThan20Zł()
        {
            HomePage.Search("Mug");

            Print.FirstProductInformation().Name().WithPrice();

            Assert.True(SearchResultsPage.GetThePriceOfTheFirstProduct > 20);
        }
    }
}

/*
1. Go to https://www.olx.pl/
2. Search for "Mug"
3. Write in console the name and price of the first found item
4. Check if the price is greater than 20zl
*/