using ChainOfResponsibility;


Console.WriteLine("--- Завдання 1: Ланцюжок відповідальностей ---");

var general = new GeneralSupport();
var billing = new BillingSupport();
var tech = new TechSupport();
var oper = new OperatorSupport();

general.SetNext(billing);
billing.SetNext(tech);
tech.SetNext(oper);

bool resolved = false;
while (!resolved)
{
    Console.WriteLine("\nГоловне меню підтримки:");
    Console.WriteLine("1 - Проблеми з інтернетом (Базова допомога)");
    Console.WriteLine("2 - Питання по оплаті");
    Console.WriteLine("3 - Складні технічні проблеми");
    Console.WriteLine("0 - З'єднання з оператором");
    Console.Write("Ваш вибір: ");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        resolved = general.HandleRequest(choice);
        if (!resolved)
        {
            Console.WriteLine("Невірний вибір або рівень не знайдено. Спробуйте ще раз.");
        }
    }
    else
    {
        Console.WriteLine("Будь ласка, введіть число.");
    }
}