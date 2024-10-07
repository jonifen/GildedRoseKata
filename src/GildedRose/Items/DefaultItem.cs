namespace GildedRoseKata.Items;

public class DefaultItem : IItem
{
  private readonly Item _item;

  public DefaultItem(Item item)
  {
    _item = item;
  }

  public void Update()
  {
    if (_item.Quality > 0)
      _item.Quality -= 1;

    _item.SellIn = _item.SellIn - 1;

    if (_item.Quality > 0 && _item.SellIn < 0)
      _item.Quality = _item.Quality - 1;
  }
}
