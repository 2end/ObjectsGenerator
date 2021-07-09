using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;

namespace ObjectsGenerator.Generators
{
    public class TrueFalseAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly TrueFalseAttributeOptions options;

        public TrueFalseAttributeRequestGenerator(TrueFalseAttributeOptions options)
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new TrueFalseAttributeRequest
            {
                AttributeId = options.AttributeId,
                Value = GetBool()
            };

            return request;
        }

        private bool GetBool() => Faker.Random.Bool();
    }
}
