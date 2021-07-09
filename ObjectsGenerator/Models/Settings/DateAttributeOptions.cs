using System;

namespace ObjectsGenerator.Models.Settings
{
    public class DateAttributeOptions : AttributeOptions
    {
        public DateTime? MinimumValue { get; set; }
        public DateTime? MaximumValue { get; set; }
    }
}
