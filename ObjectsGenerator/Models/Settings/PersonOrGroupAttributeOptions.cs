using System.Collections.Generic;

namespace ObjectsGenerator.Models.Settings
{
    public class PersonOrGroupAttributeOptions : AttributeOptions
    {
        public bool Multiple { get; set; }
        public IEnumerable<PersonOrGroupValueOptions> Values { get; set; }
    }
}
