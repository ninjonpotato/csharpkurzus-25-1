namespace xhscd0_hazi;

public interface ReadInput
{
    public static string Read()
    {
        UI.clearUi(UI.currentPosition);
        return Console.ReadLine();
    }
}