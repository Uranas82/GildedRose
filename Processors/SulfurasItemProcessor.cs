namespace GildedRose.Processors
{
    public class SulfurasItemProcessor : BaseItemProcessor
    {
        public override void UpdateQuality(Item item)
        {
            // “Sulfuras”, being a legendary item, never has to be sold or decreases in Quality;
        }
    }
}