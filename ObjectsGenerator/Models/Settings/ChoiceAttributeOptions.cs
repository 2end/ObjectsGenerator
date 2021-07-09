using System.Collections.Generic;

namespace ObjectsGenerator.Models.Settings
{
    public class ChoiceAttributeOptions : AttributeOptions
    {
        public bool Multiple { get; set; }
        public IEnumerable<ChoiceValueOptions> Values { get; set; }
    }
}
