using Xunit;

namespace GildedRoseTests.UnitTests;

public class QualityIsNeverGreaterThan50 : WhenTestingGildedRose
{
  [Fact]
  public void ShouldKeepQualityAt50_WhenQualityIsAlready50()
  {
    // The `Quality` of an item is never more than `50`
    var newItem = AddItem("Aged Brie", 50, 5);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(50, newItem.Quality);
  }
}
