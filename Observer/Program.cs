using Observer;

Console.WriteLine("\n--- Завдання 3: Спостерігач ---");
var button = new LightElementNodeWithEvents("button");

button.AddEventListener("click", () => Console.WriteLine("Обробник 1"));
button.AddEventListener("click", () => Console.WriteLine("Обробник 2"));
button.AddEventListener("mouseover", () => Console.WriteLine("Обробник: Курсор наведено на кнопку."));

button.DispatchEvent("click");
button.DispatchEvent("mouseover");
