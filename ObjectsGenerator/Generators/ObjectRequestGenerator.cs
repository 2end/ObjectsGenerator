using ObjectsGenerator.Contracts;
using ObjectsGenerator.Factories;
using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsGenerator.Generators
{
    public class ObjectRequestGenerator : IObjectRequestGenerator
    {
        private readonly AppSettings settings;

        public ObjectRequestGenerator(AppSettings settings)
        {
            this.settings = settings;
        }

        public IEnumerable<ObjectRequest> Generate()
        {

            var objectRequests = new List<ObjectRequest>(settings.Quantity);
            for (int i = 0; i < settings.Quantity; i++)
            {
                var objectRequest = new ObjectRequest
                {
                    ObjectTypeId = settings.ObjectTypeId,
                    ModelId = settings.ModelId
                };

                var attributeRequests = settings.Attributes
                    .Select(options => GenerateAttributeRequest(options))
                    .ToList();

                objectRequest.AttributeRequests.AddRange(attributeRequests);

                objectRequests.Add(objectRequest);

                Console.Write($"\rNumber of generated objects: {i + 1}");
            }

            Console.WriteLine();

            return objectRequests;
        }

        private AttributeRequest GenerateAttributeRequest(AttributeOptions options)
        {
            return AttributeRequestGeneratorFactory.Get(options)
                .Generate();
        }
    }
}
