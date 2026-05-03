using Strategy;

Console.WriteLine("\n--- Завдання 4: Стратегія ---");

var img1 = new LightImageNode("https://example.com/cats.png");
img1.Render();

Console.WriteLine();

var img2 = new LightImageNode("C:/images/dogs.jpg");
img2.Render();
