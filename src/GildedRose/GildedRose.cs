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
            { "Sulfuras, Hand of Ragnaros", (item) => new SulfurasItem(item)},
            { "Conjured Mana Cake", (item) => new ConjuredItem(item)},
            { "default", (item) => new DefaultItem(item)}
        };

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                _itemsToBeUpdated
                    .First(iu => iu.Key == item.Name || iu.Key == "default")
                    .Value(item)
                    .Update();
            }
        }
    }
}
