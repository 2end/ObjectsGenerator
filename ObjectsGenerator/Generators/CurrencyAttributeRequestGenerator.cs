using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;

namespace ObjectsGenerator.Generators
{
    public class CurrencyAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly CurrencyAttributeOptions options;

        public CurrencyAttributeRequestGenerator(CurrencyAttributeOptions options)
        {
            this.options = options;
        }
        public override AttributeRequest Generate()
        {
            var request = new CurrencyAttributeRequest
            {
                AttributeId = options.AttributeId,
                Value = GetAmount()
            };

            return request;
        }

        private decimal GetAmount()
        {
            var minimumValue = options.MinimumValue.GetValueOrDefault();
            var maximumValue = options.MaximumValue.HasValue ? options.MaximumValue.Value : decimal.MaxValue;

            var amount = faker.Random.Decimal(minimumValue, maximumValue);
            return amount;
        }
    }
}
