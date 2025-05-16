namespace xhscd0_hazi;

public class PickUpHandler : IPickUp
{
    public void PickUp(Item item, Player player)
    {
        IPickUpUI pickUpUi = new PickUpUi();
        pickUpUi.ShowPickUp(item);
        player.hp += item.hp;
        player.dmg += item.dmg;
        item.setHp(Int32.MaxValue);
        Console.ReadKey();
    }
}