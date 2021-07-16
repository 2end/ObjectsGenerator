using ObjectsGenerator.Enums;
using ObjectsGenerator.Models.Requests;
using ObjectsGenerator.Models.Settings;
using System.Collections.Generic;

namespace ObjectsGenerator.Generators
{
    public class TextAttributeRequestGenerator : AttributeRequestGenerator
    {
        private readonly TextAttributeOptions options;
        private readonly IEnumerable<string> htmlTags;

        public TextAttributeRequestGenerator(TextAttributeOptions options)        
        {
            this.options = options;
            this.htmlTags = new List<string> { "p", "b", "span", "i" };
        }

        public override AttributeRequest Generate()
        {
            var plainText = GetPlainText();
            var request = new TextAttributeRequest
            {
                AttributeId = options.AttributeId,
                Value = new TextValue 
                { 
                    PlainText = plainText,
                    RichText = options.RichText ? GetRichText(plainText) : null
                }
            };

            return request;
        }

        private string GetPlainText()
        {
            var plainText = options.TextType switch
            {
                TextType.Name => Faker.Name.JobArea(),                
                _ => Faker.Lorem.Sentences()
            };

            return Faker.Random.ClampString(plainText, options.MinimumLength, options.MaximumLength);
        }

        private string GetRichText(string text)
        {
            var htmlTag = Faker.PickRandom(htmlTags);
            return $"<{htmlTag}>" + text + $"</{htmlTag}>";
        }
    }
}
