namespace ObjectsGenerator.Models.Settings
{
    public class NumberAttributeOptions : AttributeOptions
    {
        public int? DecimalPlaces { get; set; }
        public decimal? MinimumValue { get; set; }
        public decimal? MaximumValue { get; set; }
    }
}
