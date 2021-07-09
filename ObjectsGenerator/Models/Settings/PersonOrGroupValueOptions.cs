using ObjectsGenerator.Enums;
using System;

namespace ObjectsGenerator.Models.Settings
{
    public class PersonOrGroupValueOptions
    {
        public Guid Id { get; set; }
        public PersonOrGroupType Type { get; set; }
    }
}
