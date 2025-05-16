namespace xhscd0_hazi;

public class EntityStatUI: IEntityStatUi
{
    public void ShowEntityStatUI(Entity entity)
    {
        
        UI ui = new UI();
        ui.ShowMessage($"Név:{entity.nev}",0);
        ui.ShowMessage($"Élet:{entity.hp}",1);
        ui.ShowMessage($"Sebzés:{entity.dmg}",2);
        MapRenderer.top = Console.GetCursorPosition().Top;
    }
}