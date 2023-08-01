using Menagerie.Classes;

Elephant elephant = new Elephant("Матильда", 15, 20);
elephant.Eating("Сено", 5);
elephant.MakeASound();
elephant.Eating("Торт", 5);
elephant.Eating("Сено", 5);
elephant.Playing();
elephant.Eating("Сено", 5);
Console.WriteLine();

Penguin penguin = new Penguin("Петя", 3, 5);
penguin.Eating("Рыба", 1);
penguin.MakeASound();
penguin.Eating("Хлеб", 1);
penguin.Eating("Рыба", 1);
penguin.Playing();
penguin.Eating("Рыба", 1);
Console.WriteLine();

Tiger tiger = new Tiger("Симба", 15, 5);
tiger.Eating("Мясо", 5);
tiger.MakeASound();
tiger.Eating("Трава", 5);
tiger.Eating("Мясо", 5);
tiger.Playing();
tiger.Eating("Мясо", 5);
Console.WriteLine();

Console.ReadLine();