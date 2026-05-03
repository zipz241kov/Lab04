namespace ChainOfResponsibility;

public class GeneralSupport : SupportHandler
{
    public override bool HandleRequest(int choice)
    {
        if (choice == 1)
        {
            Console.WriteLine("[General Support]: Перезавантажте пристрій. Допомогло? Дякуємо за звернення!");
            return true;
        }
        return base.HandleRequest(choice);
    }
}
