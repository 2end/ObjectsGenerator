using ObjectsGenerator.Enums;

namespace ObjectsGenerator.Models.Requests
{
    public class NumberAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.Number;
        public decimal? Value { get; set; }
    }
}
