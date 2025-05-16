using Newtonsoft.Json.Linq;

namespace xhscd0_hazi;

public class ObjectAdder: IAdder
{
    public void Add(Map map,object o)
    {

        Entity e = o as Entity;
        map.Add(e);
        if (e.x > map.width || e.y > map.height)
        {
            throw new IndexOutOfRangeException();
        }

        map.MapView[e.y, e.x] = e.icon;
    }

    public void FillMapWithObjects(Map map,JArray jsons,ObjectFactory objectFactory)
    {
        foreach (JObject item in jsons)
        {
            object o = objectFactory.CreateObjects(item);
            try
            {
                Add(map, o);
            }
            catch (IndexOutOfRangeException e)
            {
                IUi ui = new UI();
                ui.ShowMessage("A pályán kivűlre próbálsz tenni elemet!",0);


            }


        }
    }
}