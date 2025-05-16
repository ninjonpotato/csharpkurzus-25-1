using System.Text;
using Newtonsoft.Json.Linq;

namespace xhscd0_hazi;

public interface IReadable
{
    static JArray ReadFile(String path)
    {
        {
            String filePath = Path.Combine(path, "Level.json");
            JArray objs = null;
            try
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open);
                string json = null;
                
                using (StreamReader olvaso = new StreamReader(fileStream, Encoding.UTF8, false, 1024, true))
                {
                    json = olvaso.ReadToEnd();
          
                }

                objs = JArray.Parse(json);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("A hozzáféréshez nincs nyogod");
            }
            catch (IOException e)
            {
                Console.WriteLine("A fájl nem található");
            }
            return objs;
        }
    }
}