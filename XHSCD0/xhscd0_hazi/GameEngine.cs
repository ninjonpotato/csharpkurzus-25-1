namespace xhscd0_hazi;

public class GameEngine
{
    public Map map { get; set; }
    IUi ui = new UI();
    MoveHandler moveHandler = new MoveHandler();
    private Player player = null;
    static bool gameOver = false;

    public GameEngine(Map map)
    {
        this.map = map;
        player = map.objects.FirstOrDefault(obj => obj is Player) as Player;
    }

    MapRenderer mapRenderer = new MapRenderer();

    public void Play()
    {
        if (!gameOver)
        {
            map.mapRenderer.Draw(map);
            EntityStatUI entityStatUI = new EntityStatUI();
            entityStatUI.ShowEntityStatUI(player);
            moveHandler.HandleMoves(map, ui, player);
            map.Update();
            Console.Clear();
            Play();
        }

    }

    public static void End()
    {
        IUi ui = new UI();
        Console.Clear();
        ui.ShowMessage("A játékos időnek vége");
        gameOver = true;
        Console.ReadKey();
    }

    public static void isOutOfBOunds(Map map, IUi ui, Player player,int[] irany)
    {
        if (player.x >= map.width || player.y >= map.height || player.x < 0 || player.y < 0)
        {
            ui.ShowMessage("Pálya széle."); 
            Collision.moveAway(player, irany);

        }

    }

}