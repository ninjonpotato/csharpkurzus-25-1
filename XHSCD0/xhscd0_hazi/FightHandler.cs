namespace xhscd0_hazi;

public class FightHandler: IFightHandler
{
    public int[] Fight(Entity enemy,Entity player)
    {
        int last = enemy.hp;
        enemy.setHp(player.dmg);
        return new int[]{last,enemy.hp};
    }
}