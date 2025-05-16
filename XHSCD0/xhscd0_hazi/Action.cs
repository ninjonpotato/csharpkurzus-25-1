namespace xhscd0_hazi;

public class Action: IActions
{
    public void WhatActionDo(Map map,Entity entity, Player player)
    {
        map.Update();
        map.mapRenderer.Draw(map);
        if (entity is Enemy)
        {
            FightUi fightUi = new FightUi();
            player.InFight();
            map.Update();
            map.mapRenderer.Draw(map);
            fightUi.ShowFightUi(entity as Enemy,player);
            player.OutFight();
            Console.ReadKey();
         
        }

        if (entity is Item)
        {
            PickUpHandler pickUpHandler = new PickUpHandler();
            pickUpHandler.PickUp(entity as Item,player);
        }
     
        if (entity is EndGoal)
        {
            GameEngine.End();
        }
    }
}