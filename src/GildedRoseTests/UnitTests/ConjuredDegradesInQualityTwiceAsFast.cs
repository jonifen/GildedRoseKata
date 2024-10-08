using Xunit;

namespace GildedRoseTests.UnitTests;

public class ConjuredDegradesInQualityTwiceAsFast : WhenTestingGildedRose
{
  [Fact]
  public void ShouldIncreaseAgedBrieQuality_AsItGetsOlder()
  {
    // __"Conjured"__ items degrade in `Quality` twice as fast as normal items
    var newItem = AddItem("Conjured", 5, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(3, newItem.Quality);
  }
}
