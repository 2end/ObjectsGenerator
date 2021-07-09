using System;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Requests
{
    public class ObjectRequest
    {
        public Guid ObjectTypeId { get; set; }
        public Guid ModelId { get; set; }

        public List<AttributeRequest> AttributeRequests { get; set; } = new List<AttributeRequest>();
    }
}