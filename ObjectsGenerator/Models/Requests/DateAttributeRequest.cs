using ObjectsGenerator.Enums;
using System;

namespace ObjectsGenerator.Models.Requests
{
    class DateAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.Date;
        public DateTime? Value { get; set; }
    }
}
