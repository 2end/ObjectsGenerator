using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System.Collections.Generic;

namespace ObjectsGenerator.Generators
{
    public class HyperlinkAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly HyperlinkAttributeOptions options;

        public HyperlinkAttributeRequestGenerator(HyperlinkAttributeOptions options)
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new HyperlinkAttributeRequest
            {
                AttributeId = options.AttributeId,
                Values = GetHyperlinkValues()
            };

            return request;
        }

        private IEnumerable<HyperlinkValue> GetHyperlinkValues()
        {
            int amount = options.Multiple
                ? Faker.Random.Number(2, 5)
                : 1;

            var hyperlinkValues = new List<HyperlinkValue>(amount);
            for (int i = 0; i < amount; i++)
            {
                var hyperlinkValue = GetHyperlinkValue();
                hyperlinkValues.Add(hyperlinkValue);
            }

            return hyperlinkValues;
        }

        private HyperlinkValue GetHyperlinkValue()
        {
            var domain = Faker.Internet.DomainName();
            var protocol = Faker.Internet.Protocol();

            var displayValue = options.RequireDisplayValue ? domain : null;
            var url = $"{protocol}://{domain}";

            var hyperlinkValue = new HyperlinkValue
            {
                DisplayValue = displayValue,
                Url = url
            };

            return hyperlinkValue;
        }
    }
}
