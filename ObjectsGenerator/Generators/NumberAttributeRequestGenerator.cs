using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System;

namespace ObjectsGenerator.Generators
{
    public class NumberAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly NumberAttributeOptions options;

        public NumberAttributeRequestGenerator(NumberAttributeOptions options)            
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new NumberAttributeRequest
            {
                AttributeId = options.AttributeId,
                Value = GetNumber()
            };

            return request;
        }

        private decimal? GetNumber()
        {
            var minimumValue = options.MinimumValue.GetValueOrDefault();
            var maximumValue = options.MaximumValue.HasValue ? options.MaximumValue.Value : 1;

            var number = Faker.Random.Decimal(minimumValue, maximumValue);

            return options.DecimalPlaces.HasValue
                ? Math.Round(number, options.DecimalPlaces.Value)
                : number;
        }
    }
}
