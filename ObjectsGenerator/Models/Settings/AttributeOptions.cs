using Newtonsoft.Json;
using ObjectsGenerator.Enums;
using ObjectsGenerator.Json;
using System;

namespace ObjectsGenerator.Models.Settings
{
    [JsonConverter(typeof(AttributeOptionsJsonConverter))]
    public class AttributeOptions
    {
        public Guid AttributeId { get; set; }
        public AttributeCategory Category { get; set; }
    }
}
