using Newtonsoft.Json;
using xhscd0_hazi;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;

String path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
var json = IReadable.ReadFile(path); //JArray
string namespace_ = "xhscd0_hazi";
ObjectFactory objectFactory = new ObjectFactory(namespace_);
ObjectAdder objectAdder = new ObjectAdder();
Map map = new Map(15, 5, '#', '-');
objectAdder.FillMapWithObjects(map,json,objectFactory);
GameEngine gameEngine = new GameEngine(map);
gameEngine.Play();

