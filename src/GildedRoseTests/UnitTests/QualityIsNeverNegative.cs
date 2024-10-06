using Xunit;

namespace GildedRoseTests.UnitTests;

public class QualityIsNeverNegative : WhenTestingGildedRose
{
  [Fact]
  public void AnItemWithZeroQuality_ShouldStillBeZero()
  {
    // The `Quality` of an item is never negative
    var newItem = AddItem("New item", 0, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(0, newItem.Quality);
  }
}
