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

  [Fact]
  public void AgedBrieIncreaseInQualityTheOlderItGets()
  {
    // __"Aged Brie"__ actually increases in `Quality` the older it gets
    var newItem = new Item
    {
      Name = "Aged Brie",
      Quality = 5,
      SellIn = 5
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(6, newItem.Quality);
  }

  [Fact]
  public void QualityIsNeverGreaterThan50()
  {
    // The `Quality` of an item is never more than `50`
    var newItem = new Item
    {
      Name = "Aged Brie",
      Quality = 50,
      SellIn = 5
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(50, newItem.Quality);
  }

  [Fact]
  public void SulfurasNeverHasToBeSoldOrDecreaseInQuality()
  {
    // __"Sulfuras"__, being a legendary item, never has to be sold or decreases in `Quality`
    var newItem = new Item
    {
      Name = "Sulfuras, Hand of Ragnaros",
      Quality = 5,
      SellIn = 5
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(5, newItem.Quality);
  }

  [Fact]
  public void BackstagePassesIncreaseInQualityBy2_AsSellInValueIsEqualTo10()
  {
    // __"Backstage passes"__, like aged brie, increases in `Quality` as its `SellIn` value approaches;
    // `Quality` increases by `2` when there are `10` days or less
    var newItem = new Item
    {
      Name = "Backstage passes to a TAFKAL80ETC concert",
      Quality = 5,
      SellIn = 10
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(7, newItem.Quality);
  }

  [Fact]
  public void BackstagePassesIncreaseInQualityBy3_AsSellInValueIsEqualTo5()
  {
    // __"Backstage passes"__, like aged brie, increases in `Quality` as its `SellIn` value approaches;
    // [`Quality` increases] by `3` when there are `5` days or less
    var newItem = new Item
    {
      Name = "Backstage passes to a TAFKAL80ETC concert",
      Quality = 5,
      SellIn = 5
    };
    var items = new List<Item>
    {
      newItem
    };

    var gildedRose = new GildedRose(items);

    gildedRose.UpdateQuality();

    Assert.Equal(8, newItem.Quality);
  }

  [Fact]
  public void BackstagePassesQualityDropsToZero_WhenSellInValueIsZero()
  {
    // __"Backstage passes"__, like aged brie, increases in `Quality` as its `SellIn` value approaches;
    // `Quality` drops to `0` after the concert
    var newItem = new Item
    {
      Name = "Backstage passes to a TAFKAL80ETC concert",
      Quality = 5,
      SellIn = 0
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
