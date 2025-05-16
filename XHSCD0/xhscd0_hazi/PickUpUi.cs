namespace xhscd0_hazi;

public class PickUpUi: IPickUpUI
{
    public void ShowPickUp(Item item)
    {
      UI ui = new UI();
      ui.ShowMessage($"Felvetted:{item.nev}");
      if (item.dmg != 0)
      {
          if (item.dmg > 0)
          {
              ui.ShowMessage($"Nőtt a sebzésed: +{item.dmg}");
          }
          else
          {
              ui.ShowMessage($"Csökkent a sebzésed: -{item.dmg}");
          }
      }

      if (item.hp != 0)
      { 
          if (item.hp > 0)
          {
              ui.ShowMessage($"Nőtt az életed: +{item.hp}",2);
          }
          else
          {
              ui.ShowMessage($"Csökkent az életed: -{item.hp}",2);
          }
      }
    }
}