namespace ChainOfResponsibility;

public class TechSupport : SupportHandler
{
    public override bool HandleRequest(int choice)
    {
        if (choice == 3)
        {
            Console.WriteLine("[Tech Support]: Підключаємо технічного спеціаліста для перевірки лінії...");
            return true;
        }
        return base.HandleRequest(choice);
    }
}
