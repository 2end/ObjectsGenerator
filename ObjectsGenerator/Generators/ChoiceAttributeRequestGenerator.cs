using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsGenerator.Generators
{
    public class ChoiceAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly ChoiceAttributeOptions options;

        public ChoiceAttributeRequestGenerator(ChoiceAttributeOptions options)
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new ChoiceAttributeRequest
            {
                AttributeId = options.AttributeId,
                Values = GetChoiceValues()
            };

            return request;
        }

        private IEnumerable<ChoiceValue> GetChoiceValues()
        {
            var choiceValues = PickChoiceValueOptions(options.Values)
                .Select(ToChoiceValue)
                .ToList();

            return choiceValues;
        }

        private IEnumerable<ChoiceValueOptions> PickChoiceValueOptions(IEnumerable<ChoiceValueOptions> choiceValueOptions, bool canBeEmpty = true)
        {
            var minAmountToPick = canBeEmpty ? 0 : 1;
            var maxAmountToPick = options.Multiple ? choiceValueOptions.Count() : 1;
            var amountToPick = Faker.Random.Number(minAmountToPick, maxAmountToPick);

            var pickedValueOptions = Faker.PickRandom(choiceValueOptions, amountToPick);
            return pickedValueOptions;
        }

        private ChoiceValue ToChoiceValue(ChoiceValueOptions choiceValueOptions)
        {
            var children = choiceValueOptions.Children.Any()
                ? PickChoiceValueOptions(choiceValueOptions.Children, false).Select(ToChoiceValue).ToList()
                : Enumerable.Empty<ChoiceValue>();

            var choiceValue = new ChoiceValue
            {
                AttributeConfigurationChoiceId = choiceValueOptions.AttributeConfigurationChoiceId,
                Children = children
            };

            return choiceValue;
        }        
    }
}
