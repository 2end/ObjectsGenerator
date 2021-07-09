using ObjectsGenerator.Contracts;
using ObjectsGenerator.Enums;
using ObjectsGenerator.Generators;
using ObjectsGenerator.Models.Settings;
using System;

namespace ObjectsGenerator.Factories
{
    public class AttributeRequestGeneratorFactory
    {
        public static IAttributeRequestGenerator Get(AttributeOptions options)
        {
            switch (options.Category)
            {
                case AttributeCategory.Text:
                    return new TextAttributeRequestGenerator((TextAttributeOptions)options);

                case AttributeCategory.Number:
                    return new NumberAttributeRequestGenerator((NumberAttributeOptions)options);

                case AttributeCategory.Date:
                    return new DateAttributeRequestGenerator((DateAttributeOptions)options);

                case AttributeCategory.Currency:
                    return new CurrencyAttributeRequestGenerator((CurrencyAttributeOptions)options);

                case AttributeCategory.TrueFalse:
                    return new TrueFalseAttributeRequestGenerator((TrueFalseAttributeOptions)options);

                case AttributeCategory.UniqueIdentifier:
                    return new UniqueIdentifierAttributeRequestGenerator((UniqueIdentifierAttributeOptions)options);

                case AttributeCategory.PersonOrGroup:
                    return new PersonOrGroupAttributeRequestGenerator((PersonOrGroupAttributeOptions)options);

                case AttributeCategory.Hyperlink:
                    return new HyperlinkAttributeRequestGenerator((HyperlinkAttributeOptions)options);

                case AttributeCategory.Choice:
                    return new ChoiceAttributeRequestGenerator((ChoiceAttributeOptions)options);

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
