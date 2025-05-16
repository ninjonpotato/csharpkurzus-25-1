namespace xhscd0_hazi;

public class Collision
{

    public static void moveAway(Player player,int[] irany)
    {
        if (irany[0] != 0)
        {
            player.x += (irany[0] == -1 ? 1 : -1);
        }
        if (irany[1] != 0)
        {
            player.y += (irany[1] == -1 ? 1 : -1);
        }
    }

    public static Entity isCollide(IUi ui, Player player, Map map,int[] irany)
    {
        var Entities = map.objects.OfType<Entity>().ToList();
        Entity entity = Entities.Where(e => e.x == player.x && e.y == player.y &&e.icon != Map.tileIcon).First();
        if (entity.icon == Map.wallIcon)
        {
            ui.ShowMessage("Fal!");
            moveAway(player, irany);
        }
        else
        {
            return entity;
        }
        return null;
    }

}