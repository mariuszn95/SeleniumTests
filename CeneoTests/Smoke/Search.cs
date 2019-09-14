namespace CeneoTests.Smoke
{
    using CeneoFramework.Helpers.Print;
    using CeneoFramework.Pages;

    using NUnit.Framework;

    using SetUpTests.Utilities;
    
    public class Search : CeneoSetUpTest
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
1. Go to http://www.ceneo.pl
2. Search for "Mug"
3. Write in console the name and price of the first found item
4. Check if the price is greater than 20zl
*/