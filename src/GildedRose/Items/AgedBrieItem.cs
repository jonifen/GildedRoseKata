namespace GildedRoseKata.Items;

public class AgedBrieItem : IItem
{
  private readonly Item _item;

  public AgedBrieItem(Item item)
  {
    _item = item;
  }

  public void Update()
  {
    if (_item.Quality < 50)
      _item.Quality += 1;

    if (_item.Quality < 50 && _item.SellIn <= 0)
      _item.Quality += 1;

    _item.SellIn -= 1;
  }
}
