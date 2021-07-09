using Bogus;
using ObjectsGenerator.Contracts;
using ObjectsGenerator.Models.Requests;

namespace ObjectsGenerator.Generators
{
    public abstract class AttributeRequestGenerator : IAttributeRequestGenerator
    {
        protected static Faker Faker { get; set; } = new Faker();
        

        public abstract AttributeRequest Generate();        
    }
}
