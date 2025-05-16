using Newtonsoft.Json.Linq;

namespace xhscd0_hazi;

public interface IObjectFactory
{
    object CreateObjects(JObject o);
}