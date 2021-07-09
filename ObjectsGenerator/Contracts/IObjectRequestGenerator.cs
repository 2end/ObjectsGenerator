using ObjectsGenerator.Models.Requests;
using System.Collections.Generic;

namespace ObjectsGenerator.Contracts
{
    public interface IObjectRequestGenerator
    {
        IEnumerable<ObjectRequest> Generate();
    }
}