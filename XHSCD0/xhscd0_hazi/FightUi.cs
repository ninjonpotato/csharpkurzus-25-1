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

    public void ShowFightUi(Enemy enemy, Player player, int top = 0)
    {
        UI ui = new UI();
        EntityStatUI entityStatUI = new EntityStatUI();
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
                }
                else
                {
                    ShowFightUi(enemy, player);
                }

                break;
            case "2":
                ui.ShowMessage("Megpróbálsz elmenekülni, ám az ellenfeled gyorsabb volt nálad és lesujtott rád.",top);
                Console.ReadKey();
                GameEngine.End();
                break;
            default:
                ui.ShowMessage("Ilyen opció nincs.",top);
                ShowFightUi(enemy, player);
                break;

        }

    }
}