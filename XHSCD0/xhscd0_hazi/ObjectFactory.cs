using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace xhscd0_hazi;

public class ObjectFactory : IObjectFactory
{
    private readonly string namespace_s;
    public ObjectFactory(string _namespace)
    {
        this.namespace_s = _namespace;
    }
    public object CreateObjects(JObject o)
    {
        string type = o["type"]?.ToString();
        // Console.WriteLine(json_obj);
        Type tipus = Type.GetType(namespace_s+"."+type);
        return JsonConvert.DeserializeObject(o.ToString(), tipus);
    }
}