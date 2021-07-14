using ObjectsGenerator.Contracts;
using ObjectsGenerator.Factories;
using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var objectRequests = new ConcurrentStack<ObjectRequest>();
            Parallel.For(0, settings.Quantity, i =>
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

                objectRequests.Push(objectRequest);
            });

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
