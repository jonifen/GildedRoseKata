using System;
using System.Collections.Generic;
using System.Linq;
using GildedRoseKata.Items;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private Dictionary<string, Func<Item, IItem>> _itemsToBeUpdated = new()
        {
            { "Aged Brie", (item) => new AgedBrieItem(item)},
            { "Backstage passes to a TAFKAL80ETC concert", (item) => new BackstagePassesItem(item)},
            { "Sulfuras, Hand of Ragnaros", (item) => new SulfurasItem(item)}
        };

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var itemToBeUpdated = _itemsToBeUpdated.FirstOrDefault(iu => iu.Key == Items[i].Name);

                if (itemToBeUpdated.Value != null)
                {
                    itemToBeUpdated.Value(Items[i]).Update();
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
