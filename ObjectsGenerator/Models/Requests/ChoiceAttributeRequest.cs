using ObjectsGenerator.Enums;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Requests
{
    public class ChoiceAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.Choice;
        public IEnumerable<ChoiceValue> Values { get; set; }
    }
}
