using Newtonsoft.Json.Linq;

namespace xhscd0_hazi;

public interface IAdder
{
    public void Add(Map map,object o);
    public void FillMapWithObjects(Map map, JArray jsons, ObjectFactory objectFactory);
}