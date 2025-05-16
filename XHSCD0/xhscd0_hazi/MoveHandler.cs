namespace xhscd0_hazi;

public class MoveHandler
{
    private Option option = new Option();
    private Action action = new Action();
    public MoveHandler()
    {
        Dictionary<string, string> options = new Dictionary<string, string>();
        options.Add("w","Előre");
        options.Add("s","Hátra");
        options.Add("a","Balra");
        options.Add("d","Jobbra");
        option.setOptionList(options);
    }

    public void HandleMoves(Map map,IUi ui,Player player)
    {
        ui.ShowMessage("Merre akarsz menni?",1);
        option.ShowOptions(ui);
        string valasz = ReadInput.Read();
        int[] irany = player.mozgas(valasz);
        GameEngine.isOutOfBOunds(map,ui,player,irany);
        Entity entity =  Collision.isCollide(ui,player,map,irany);
       action.WhatActionDo(map,entity,player);


    }
}