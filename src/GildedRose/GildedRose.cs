using System.Collections.Generic;
using GildedRoseKata.Items;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == "Aged Brie")
                {
                    var agedBrieItem = new AgedBrieItem(Items[i]);
                    agedBrieItem.Update();
                    continue;
                }

                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    var backstagePassesItem = new BackstagePassesItem(Items[i]);
                    backstagePassesItem.Update();
                    continue;
                }

                if (Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    var sulfurasItem = new SulfurasItem(Items[i]);
                    sulfurasItem.Update();
                    continue;
                }

                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" && Items[i].Name != "Sulfuras, Hand of Ragnaros" && Items[i].Quality > 0)
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert" && Items[i].Name != "Sulfuras, Hand of Ragnaros" && Items[i].Quality > 0 && Items[i].SellIn < 0)
                {
                    Items[i].Quality = Items[i].Quality - 1;
                }
            }
        }
    }
}
