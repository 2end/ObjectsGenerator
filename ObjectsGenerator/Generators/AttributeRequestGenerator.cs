using Bogus;
using ObjectsGenerator.Contracts;
using ObjectsGenerator.Models.Requests;

namespace ObjectsGenerator.Generators
{
    public abstract class AttributeRequestGenerator : IAttributeRequestGenerator
    {
        protected readonly Faker faker;

        public AttributeRequestGenerator()
        {
            this.faker = new Faker();
        }
        

        public abstract AttributeRequest Generate();        
    }
}
