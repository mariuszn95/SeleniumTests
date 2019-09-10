using AllegroFramework.Helpers;
using AllegroFramework.Pages;
using NUnit.Framework;
using SetUpTests.Utilities;

namespace AllegroTests.Smoke
{
    [TestFixture]
    public class Search : AllegroSetUpTest
    {
        [Test]
        public void
            User_Can_Search_A_Mug_And_Write_Price_Of_The_First_Found_Item_And_Check_If_The_Price_Is_Greater_Than_20zł()
        {
            HomePage.Search("Mug");

            Print.FirstProductInformation()
                .Name()
                .WithPrice();

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