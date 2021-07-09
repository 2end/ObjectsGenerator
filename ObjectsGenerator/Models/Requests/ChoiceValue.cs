using System;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Requests
{
    public class ChoiceValue
    {
        public Guid AttributeConfigurationChoiceId { get; set; }
        public IEnumerable<ChoiceValue> Children { get; set; }
    }
}
