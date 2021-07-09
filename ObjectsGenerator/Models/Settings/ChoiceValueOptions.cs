using System;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Settings
{
    public class ChoiceValueOptions
    {
        public Guid AttributeConfigurationChoiceId { get; set; }
        public IEnumerable<ChoiceValueOptions> Children { get; set; }
    }
}
