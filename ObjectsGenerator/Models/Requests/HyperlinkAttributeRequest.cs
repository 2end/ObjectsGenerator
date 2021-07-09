using ObjectsGenerator.Enums;
using System.Collections.Generic;

namespace ObjectsGenerator.Models.Requests
{
    public class HyperlinkAttributeRequest : AttributeRequest
    {
        public override AttributeCategory Category => AttributeCategory.Hyperlink;
        public IEnumerable<HyperlinkValue> Values { get; set; }
    }
}
