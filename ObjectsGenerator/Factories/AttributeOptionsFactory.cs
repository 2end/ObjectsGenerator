using ObjectsGenerator.Enums;
using ObjectsGenerator.Models.Settings;
using System;

namespace ObjectsGenerator.Factories
{
    public class AttributeOptionsFactory
    {
        public static AttributeOptions Get(AttributeCategory category)
        {
            switch (category)
            {
                case AttributeCategory.Text:
                    return new TextAttributeOptions();

                case AttributeCategory.Number:
                    return new NumberAttributeOptions();

                case AttributeCategory.Date:
                    return new DateAttributeOptions();

                case AttributeCategory.Currency:
                    return new CurrencyAttributeOptions();

                case AttributeCategory.TrueFalse:
                    return new TrueFalseAttributeOptions();

                case AttributeCategory.UniqueIdentifier:
                    return new UniqueIdentifierAttributeOptions();

                case AttributeCategory.PersonOrGroup:
                    return new PersonOrGroupAttributeOptions();

                case AttributeCategory.Hyperlink:
                    return new HyperlinkAttributeOptions();

                case AttributeCategory.Choice:
                    return new ChoiceAttributeOptions();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
