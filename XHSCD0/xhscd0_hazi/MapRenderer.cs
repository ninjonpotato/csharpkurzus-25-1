namespace xhscd0_hazi;

public class MapRenderer: IDrawable
{
    public static int top { get; set; }

    public void Draw(Map map)
    { 
        Console.SetCursorPosition(0, 1); 
        for (int i = 0; i < map.height; i++)
        {
            for (int j = 0; j < map.width; j++)
            {
                Console.Write(map.MapView[i, j]);
            }
            Console.WriteLine();
        }
        top = Console.GetCursorPosition().Top;
    }
    
}