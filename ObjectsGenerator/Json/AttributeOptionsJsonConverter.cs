using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectsGenerator.Enums;
using ObjectsGenerator.Factories;
using ObjectsGenerator.Models.Settings;
using System;

namespace ObjectsGenerator.Json
{
    public class AttributeOptionsJsonConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return typeof(AttributeOptions).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            var categoryJson = jObject.Value<string>("Category");
            if (Enum.TryParse(categoryJson, true, out AttributeCategory category))
            {
                var attributeOptions = AttributeOptionsFactory.Get(category);
                serializer.Populate(jObject.CreateReader(), attributeOptions);

                return attributeOptions;
            }

            throw new ArgumentException($"Unknown category '{categoryJson}'");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
