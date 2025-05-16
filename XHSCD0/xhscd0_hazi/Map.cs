namespace xhscd0_hazi;

public class Map
{ 
    public int width { get; set; }
    public int height { get; set; }
    public static char wallIcon { get; set; }
    public static char tileIcon { get; set; }
    public IEntityTarolo<Entity> objects = new EntityTarolo<Entity>();
    public char[,] MapView = null;
    public MapRenderer mapRenderer = new MapRenderer();

    public Map(int width, int height, char _wallIcon,char _tileIcon)
    {
        this.width = width;
        this.height = height;
        wallIcon = _wallIcon;
        tileIcon = _tileIcon;
        MapView = new char[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {

                if (i == 0 || j == width - 1 || i == height - 1 || j == 0)
                {
                    objects.Add(new Entity(){x=j,y=i, icon=wallIcon});
                }
                else
                {
                    objects.Add(new Entity(){x=j,y=i, icon=tileIcon});
                }

            }
        }
        Update();
        
    }
    public void Add(Entity o)
    {
        objects.Add(o);
    }

    public char getTile(int x, int y)
    {
        return MapView[y, x];
    }
    public void setTile(Entity e)
    {
        try
        {
            MapView[e.y, e.x] = e.icon;
        }
        catch (IndexOutOfRangeException error)
        {
            Console.WriteLine($"Az alábbi enitáts: ${e} helyzete túlmutat a pályán");
        }
    }

    public override string ToString()
    {
        return $"Map:{width}x{height} wall:{wallIcon}";   
    }
    
    public void Update()
    {
        foreach (Entity e in objects)
        {
            setTile(e);
        }
        
    }

}