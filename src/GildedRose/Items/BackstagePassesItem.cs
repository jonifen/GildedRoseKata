namespace GildedRoseKata.Items;

public class BackstagePassesItem : IItem
{
  private readonly Item _item;

  public BackstagePassesItem(Item item)
  {
    _item = item;
  }

  public void Update()
  {
    if (_item.Quality < 50)
      _item.Quality += 1;

    if (_item.Quality < 50 && _item.SellIn < 11)
      _item.Quality += 1;

    if (_item.Quality < 50 && _item.SellIn < 6)
      _item.Quality += 1;

    if (_item.SellIn <= 0)
      _item.Quality -= _item.Quality;

    _item.SellIn -= 1;
  }
}
