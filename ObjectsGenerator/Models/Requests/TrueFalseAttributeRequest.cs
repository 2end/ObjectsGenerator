using ObjectsGenerator.Enums;

namespace ObjectsGenerator.Models.Requests
{
    public class TrueFalseAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.TrueFalse;
        public bool? Value { get; set; }
    }
}
