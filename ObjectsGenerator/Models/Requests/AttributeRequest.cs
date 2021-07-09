using ObjectsGenerator.Enums;
using System;

namespace ObjectsGenerator.Models.Requests
{
    public abstract class AttributeRequest
    {
        public Guid AttributeId { get; set; }
        public virtual AttributeCategory Category { get; }
    }
}
