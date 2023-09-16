using Menagerie.Classes;
using System.Xml.Linq;

Console.WriteLine("Зверинец");
Console.WriteLine();

Elephant elephant = new Elephant("Матильда", 15, 20);
//bool satiety = elephant.EatingPortionOfFeed("Сено", 5);
//Console.WriteLine(satiety);
elephant.EatingPortionOfFeed("Сено", 5);
elephant.MakeASound();
elephant.EatingPortionOfFeed("Торт", 5);
elephant.EatingPortionOfFeed("Сено", 5);
elephant.Playing();
elephant.EatingPortionOfFeed("Сено", 5);
//Console.WriteLine(elephant.SatietyCheck());
Console.WriteLine();

Penguin penguin = new Penguin("Петя", 3, 5);
//bool satiety = penguin.EatingPortionOfFeed("Рыба", 1);
//Console.WriteLine(satiety);
penguin.EatingPortionOfFeed("Рыба", 1);
penguin.MakeASound();
penguin.EatingPortionOfFeed("Хлеб", 1);
penguin.EatingPortionOfFeed("Рыба", 1);
penguin.Playing();
penguin.EatingPortionOfFeed("Рыба", 1);
//Console.WriteLine(penguin.SatietyCheck());
Console.WriteLine();

Tiger tiger = new Tiger("Симба", 15, 5);
//bool satiety = tiger.EatingPortionOfFeed("Мясо", 5);
//Console.WriteLine(satiety);
tiger.EatingPortionOfFeed("Мясо", 5);
tiger.MakeASound();
tiger.EatingPortionOfFeed("Трава", 5);
tiger.EatingPortionOfFeed("Мясо", 5);
tiger.Playing();
tiger.EatingPortionOfFeed("Мясо", 5);
//Console.WriteLine(tiger.SatietyCheck());
Console.WriteLine();

Console.ReadLine();