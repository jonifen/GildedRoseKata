using System;
using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class UnitTests
{
  [Fact]
  public void OnceSellByDatePassed_QualityDegradesTwiceAsFast()
  {
    // Once the sell by date has passed, `Quality` degrades twice as fast
    var newItem = new Item
    {
      Name = "New item",
      Quality = 5,
      SellIn = 0
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(3, newItem.Quality);
  }

  [Fact]
  public void TheQualityOfAnItemIsNeverNegative()
  {
    // The `Quality` of an item is never negative
    var newItem = new Item
    {
      Name = "New item",
      Quality = 0,
      SellIn = 5
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(0, newItem.Quality);
  }
}
