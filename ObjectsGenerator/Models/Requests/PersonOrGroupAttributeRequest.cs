using ObjectsGenerator.Enums;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Requests
{
    public class PersonOrGroupAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.PersonOrGroup;
        public IEnumerable<PersonOrGroupValue> Values { get; set; }
    }
}
