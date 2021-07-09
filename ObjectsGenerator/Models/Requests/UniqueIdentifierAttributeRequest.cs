using ObjectsGenerator.Enums;
using System;

namespace ObjectsGenerator.Models.Requests
{
    public class UniqueIdentifierAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.UniqueIdentifier;
        public Guid? Value { get; set; }
    }
}
