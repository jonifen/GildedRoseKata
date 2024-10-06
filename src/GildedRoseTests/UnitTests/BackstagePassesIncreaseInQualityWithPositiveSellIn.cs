using Xunit;

namespace GildedRoseTests.UnitTests;

public class BackstagePassesIncreaseInQualityWithPositiveSellIn : WhenTestingGildedRose
{
  [Fact]
  public void ShouldIncreaseQualityBy1_WhenItemIsBackstagePassWithSellInGreaterThan10()
  {
    // __"Backstage passes"__, like aged brie, increases in `Quality` as its `SellIn` value approaches;
    var newItem = AddItem("Backstage passes to a TAFKAL80ETC concert", 5, 11);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(6, newItem.Quality);
  }

  [Fact]
  public void ShouldIncreaseQualityBy2_WhenItemIsBackstagePassWithSellInOf10()
  {
    // `Quality` increases by `2` when there are `10` days or less
    var newItem = AddItem("Backstage passes to a TAFKAL80ETC concert", 5, 10);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(7, newItem.Quality);
  }

  [Fact]
  public void ShouldIncreaseQualityBy3_WhenItemIsBackstagePassWithSellInOf5()
  {
    // `Quality` increases by `3` when there are `5` days or less
    var newItem = AddItem("Backstage passes to a TAFKAL80ETC concert", 5, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(8, newItem.Quality);
  }

  [Fact]
  public void ShouldSetQualityToZero_WhenItemIsBackstagePassAndSellInReachesZero()
  {
    // `Quality` drops to `0` after the concert
    var newItem = AddItem("Backstage passes to a TAFKAL80ETC concert", 10, 0);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(0, newItem.Quality);
  }
}
