using ObjectsGenerator.Enums;

namespace ObjectsGenerator.Models.Requests
{
    public class CurrencyAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.Currency;
        public decimal? Value { get; set; }
    }
}
