using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System;

namespace ObjectsGenerator.Generators
{
    public class DateAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly DateAttributeOptions options;

        public DateAttributeRequestGenerator(DateAttributeOptions options)
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new DateAttributeRequest
            {
                AttributeId = options.AttributeId,
                Value = GetDate()
            };

            return request;
        }

        private DateTime GetDate()
        {
            var minimumValue = options.MinimumValue.GetValueOrDefault();
            var maximumValue = options.MaximumValue.HasValue ? options.MaximumValue.Value : DateTime.MaxValue;

            var date = faker.Date.Between(minimumValue, maximumValue);
            return date;
        }
    }
}
