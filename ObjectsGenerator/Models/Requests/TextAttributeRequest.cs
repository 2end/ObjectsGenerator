using ObjectsGenerator.Enums;

namespace ObjectsGenerator.Models.Requests
{
    public class TextAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.Text;
        public TextValue Value { get; set; }
    }
}
