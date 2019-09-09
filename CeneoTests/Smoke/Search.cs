﻿using CeneoFramework.Helpers;
using CeneoFramework.Pages;
using CeneoTests.Utilities;
using NUnit.Framework;

namespace CeneoTests.Smoke
{
    [TestFixture]
    public class Search : SetUpTest
    {
        [Test]
        public void User_Can_Search_A_Mug_And_Write_Price_Of_The_First_Found_Item_And_Check_If_The_Price_Is_Greater_Than_20zł()
        {
            HomePage.Search("Mug");

            Print.FirstProductInformation()
                .Name()
                .WithPrice();

            Assert.True(SearchPage.GetThePriceOfTheFirstProduct > 20);
        }
    }
}

/*
1. Go to http://www.ceneo.pl
2. Search for "Mug"
3. Write in console the name and price of the first found item
4. Check if the price is greater than 20zl
*/