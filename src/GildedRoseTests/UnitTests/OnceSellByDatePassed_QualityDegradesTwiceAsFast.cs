using Xunit;

namespace GildedRoseTests.UnitTests;

public class OnceSellByDatePassed_QualityDegradesTwiceAsFast : WhenTestingGildedRose
{
  [Fact]
  public void Should_ReduceQualityBy2_When_SellInIsLessThanOrEqualToZero()
  {
    // Once the sell by date has passed, `Quality` degrades twice as fast
    var newItem = AddItem("New Item", 5, 0);
    Setup();

    GildedRose.UpdateQuality();

    Assert.Equal(3, newItem.Quality);
  }
}
