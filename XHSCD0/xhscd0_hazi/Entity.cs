using System.Reflection;
using Newtonsoft.Json;

namespace xhscd0_hazi;

public class Entity
{
    public int x { get; set; }
    public int y { get; set; }

    public char icon { get; set; }
    public int hp { get; set; }
    public int dmg{ get; set; }
    public string nev{ get; set; }
    public void setHp(int dmg)
    {
        if (dmg < 0) dmg = 0;
        hp -= dmg;
        if (hp <= 0) icon = Map.tileIcon;
    }
    
    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
    
}