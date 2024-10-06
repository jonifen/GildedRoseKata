using Xunit;

namespace GildedRoseTests.UnitTests;

public class SulfurasNeverHasToBeSoldOrDecreaseInQuality : WhenTestingGildedRose
{
  [Fact]
  public void ShouldNeverReduceQuality_WhenItemIsSulfuras()
  {
    // __"Sulfuras"__, being a legendary item, never has to be sold or **decreases in `Quality`**
    var newItem = AddItem("Sulfuras, Hand of Ragnaros", 5, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(5, newItem.Quality);
  }

  [Fact]
  public void ShouldNeverReduceSellIn_WhenItemIsSulfuras()
  {
    // __"Sulfuras"__, being a legendary item, **never has to be sold** or decreases in `Quality`
    var newItem = AddItem("Sulfuras, Hand of Ragnaros", 5, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(5, newItem.SellIn);
  }
}
