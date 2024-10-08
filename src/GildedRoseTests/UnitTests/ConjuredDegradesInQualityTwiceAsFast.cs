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

  [Fact]
  public void AConjuredItemWithQualityOf1_WillReturnQualityOf0()
  {
    // __"Conjured"__ items degrade in `Quality` twice as fast as normal items
    // The `Quality` of an item is never negative
    var newItem = AddItem("Conjured", 1, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(0, newItem.Quality);
  }
}
