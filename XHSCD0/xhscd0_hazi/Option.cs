namespace xhscd0_hazi;

public class Option: IOptions
{
    public Dictionary<string,string> OptionList { get; set; }

    public int ShowOptions(IUi ui)
    {
        int index = 0;
        foreach (string key in OptionList.Keys)
        {
            ui.ShowMessage($"{key}) {OptionList[key]}",index);
            index++;
        }
        return index;
        
    }
    

    public void setOptionList(Dictionary<string, string> options)
    {
        OptionList = options;
    }   
}