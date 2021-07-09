using ObjectsGenerator.Enums;

namespace ObjectsGenerator.Models.Settings
{
    public class TextAttributeOptions : AttributeOptions
    {
        public int? MinimumLength { get; set; }
        public int? MaximumLength { get; set; }
        public bool RichText { get; set; }
        public TextType? TextType { get; set; }
    }
}
