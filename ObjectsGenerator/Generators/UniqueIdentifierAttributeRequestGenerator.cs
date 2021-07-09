using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System;

namespace ObjectsGenerator.Generators
{
    public class UniqueIdentifierAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly UniqueIdentifierAttributeOptions options;

        public UniqueIdentifierAttributeRequestGenerator(UniqueIdentifierAttributeOptions options)
        {
            this.options = options;
        }

        public override AttributeRequest Generate()
        {
            var request = new UniqueIdentifierAttributeRequest
            {
                AttributeId = options.AttributeId,
                Value = GetGuid()
            };

            return request;
        }

        private Guid GetGuid() => Guid.NewGuid();
    }
}
