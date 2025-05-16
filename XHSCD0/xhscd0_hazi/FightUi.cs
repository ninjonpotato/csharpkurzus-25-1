namespace xhscd0_hazi;

public class FightUi: IFightUi
{      
    FightHandler fightHandler = new FightHandler();
    Option option = new Option();

    public FightUi()
    {
        Dictionary<string, string> options = new Dictionary<string, string>();
        options.Add("-","Opciók:");
        options.Add("1","Megtámadod");
        options.Add("2","Elmenekülsz");
        option.setOptionList(options);
        MapRenderer.top = Console.GetCursorPosition().Top;
    }

    public void ShowFightUi(Enemy enemy, Player player, int top,Map map)
    {
        UI ui = new UI();
        Console.Clear();
        EntityStatUI entityStatUI = new EntityStatUI();
        player.InFight();
        map.Update();
        map.mapRenderer.Draw(map);
        entityStatUI.ShowEntityStatUI(player);
        ui.ShowMessage($"Harcba keveredtél:{enemy.nev}", 1);

     
        top = option.ShowOptions(ui);
        string valasz = ReadInput.Read();
        switch (valasz)
        {
            case "1":
                ui.ShowMessage("Megtámadtad!", 2);
                int[] hp = fightHandler.Fight(enemy, player);
                ui.ShowMessage($"Megsebezted: {hp[0]}hp --> {hp[1]}hp", top+3);
    
                if (hp[1] <= 0)
                {
                    ui.ShowMessage($"Megölted: {enemy.nev}",top+3);
                    player.OutFight();
                    map.Update();
                    map.mapRenderer.Draw(map);
                }
                else
                {
                    Random chane = new Random();
                    if (chane.Next(0, 100) <= 90)
                    {
                        ui.ShowMessage($"{enemy.nev} visszatámadott!",top+4);
                        int[] player_hp = fightHandler.Fight(player, enemy);
                        ui.ShowMessage($"Megsebzett: {player_hp[0]}hp --> {player_hp[1]}hp", top+5);
                        if (player_hp[1] <= 0)
                        {
                            ui.ShowMessage("Sajnos meghaltál :/ majd legközelebb...");
                            Console.ReadKey();
                            GameEngine.End();
                        }
                    }
                    Console.ReadKey();
                    ShowFightUi(enemy, player,0,map);
          
                }
         

                break;
            case "2":
                ui.ShowMessage("Megpróbálsz elmenekülni, ám az ellenfeled gyorsabb volt nálad és lesujtott rád.",top);
                Console.ReadKey();
                GameEngine.End();
                break;
            default:
                ui.ShowMessage("Ilyen opció nincs.",top);
                ShowFightUi(enemy, player,0,map);
                break;

        }

    }
}