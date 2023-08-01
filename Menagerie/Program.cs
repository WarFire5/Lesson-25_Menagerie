using Menagerie.Classes;

Elephant elephant = new Elephant("Матильда", 15, 20);
elephant.MakeASound();
elephant.Eating("Сено", 5);
elephant.Eating("Сено", 5);
elephant.Eating("Сено", 5);
elephant.Eating("Торт", 5);
elephant.Playing();
Console.WriteLine();

Penguin penguin = new Penguin("Петя", 0.9, 5);
penguin.MakeASound();
penguin.Eating("Рыба", 0.3);
penguin.Eating("Рыба", 0.3);
penguin.Eating("Хлеб", 0.3);
penguin.Playing();
Console.WriteLine();

Tiger tiger = new Tiger("Симба", 15, 5);
tiger.MakeASound();
tiger.Eating("Мясо", 5);
tiger.Eating("Трава", 5);
tiger.Playing();
Console.WriteLine();

Console.ReadLine();