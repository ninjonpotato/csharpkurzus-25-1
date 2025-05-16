namespace xhscd0_hazi;

public class UI: IUi
{
    public static int currentPosition { get; set; }
    public void ShowMessage(string msg,int top=1)
    {
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, MapRenderer.top+top); 
        currentPosition = MapRenderer.top+top;
        Console.WriteLine(msg);

    }
    public static int clearUi(int index)
    {
            Console.SetCursorPosition(0, index+1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, index+1);
        return 0;
    }
}