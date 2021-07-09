using ObjectsGenerator.Enums;
using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsGenerator.Generators
{
    public class PersonOrGroupAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly PersonOrGroupAttributeOptions options;

        public PersonOrGroupAttributeRequestGenerator(PersonOrGroupAttributeOptions options)
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new PersonOrGroupAttributeRequest
            {
                AttributeId = options.AttributeId,
                Values = GetPersonOrGroupValues()
            };

            return request;
        }

        private IEnumerable<PersonOrGroupValue> GetPersonOrGroupValues()
        {
            var personOrGroupValues = PickPersonOrGroupValueOptions()
                .Select(ToPersonOrGroupValue)
                .ToList();

            return personOrGroupValues;
        }

        private IEnumerable<PersonOrGroupValueOptions> PickPersonOrGroupValueOptions()
        {
            var minAmountToPick = 0;
            var maxAmountToPick = options.Multiple ? options.Values.Count() : 1;
            var amountToPick = faker.Random.Number(minAmountToPick, maxAmountToPick);

            var pickedPersonOrGroupValueOptions = faker.PickRandom(options.Values, amountToPick);
            return pickedPersonOrGroupValueOptions;
        }

        private PersonOrGroupValue ToPersonOrGroupValue(PersonOrGroupValueOptions personOrGroupValueOptions)
        {
            var value = new PersonOrGroupValue
            {
                PersonId = personOrGroupValueOptions.Type == PersonOrGroupType.Person ? personOrGroupValueOptions.Id : null,
                GroupId = personOrGroupValueOptions.Type == PersonOrGroupType.Group ? personOrGroupValueOptions.Id : null
            };

            return value;
        }            
    }
}
