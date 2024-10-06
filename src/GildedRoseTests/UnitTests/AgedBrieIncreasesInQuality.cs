using Xunit;

namespace GildedRoseTests.UnitTests;

public class AgedBrieIncreasesInQuality : WhenTestingGildedRose
{
  [Fact]
  public void ShouldIncreaseAgedBrieQuality_AsItGetsOlder()
  {
    // __"Aged Brie"__ actually increases in `Quality` the older it gets
    var newItem = AddItem("Aged Brie", 5, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(6, newItem.Quality);
  }
}
