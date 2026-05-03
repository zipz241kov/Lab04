using Mediator;

Console.WriteLine("\n--- Завдання 2: Посередник ---");
var centre = new CommandCentre();
var runway = new Runway(centre);

var boeing = new Aircraft("Boeing 747", centre);
var f16 = new Aircraft("F-16", centre);

boeing.Land();
f16.Land();

runway.FreeRunway();
f16.Land();
