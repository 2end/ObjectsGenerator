using System;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Settings
{
    public class AppSettings
    {
        public int Quantity { get; set; }
        public Guid ObjectTypeId { get; set; }
        public Guid ModelId { get; set; }

        public IEnumerable<AttributeOptions> Attributes { get; set; }
    }
}
