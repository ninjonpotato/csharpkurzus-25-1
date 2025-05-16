namespace xhscd0_hazi;

public class Player : Entity
{
    public char def_icon = ' ';

    public void InFight()
    {
        def_icon = icon;
        icon = 'F';
    }
    public void OutFight()
    {
        if (def_icon != ' ')
        {
            icon = def_icon;
        }
    }

    public int[] mozgas(string irany)
    {

        switch (irany)
        {
            case "w":
                y--;
                return new int[2] { 0, -1 };
                break;
            case "s":
                y++;
                return new int[2] { 0, 1 };
                break;
            case "a":
                x--;
                return new int[2] { -1, 0 };
                break;
            case "d":
                x++;
                return new int[2] { 1, 0 };
                break;
            default:
                Console.WriteLine("Nincs ilyen opció");
                return new int[2] { 0, 0 };
                break;
        }
        return new int[2] { 0, 0 };
    }
}