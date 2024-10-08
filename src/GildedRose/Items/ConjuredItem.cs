using System;

namespace GildedRoseKata.Items;

public class ConjuredItem : IItem
{
  private readonly Item _item;

  public ConjuredItem(Item item)
  {
    _item = item;
  }

  public void Update()
  {
    _item.Quality -= 2;
    _item.SellIn -= 1;
  }
}
