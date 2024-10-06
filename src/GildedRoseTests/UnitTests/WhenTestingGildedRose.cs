using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests.UnitTests;

public class WhenTestingGildedRose
{
  public GildedRose GildedRose;
  private List<Item> _items;

  public WhenTestingGildedRose()
  {
    _items = new List<Item>();
  }

  public void Setup()
  {
    GildedRose = new GildedRose(_items);
  }

  public Item AddItem(string name, int quality, int sellIn)
  {
    var newItem = new Item { Name = name, Quality = quality, SellIn = sellIn };
    _items.Add(newItem);

    return newItem;
  }
}
