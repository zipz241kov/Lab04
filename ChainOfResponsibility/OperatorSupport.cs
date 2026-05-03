namespace ChainOfResponsibility;

public class OperatorSupport : SupportHandler
{
    public override bool HandleRequest(int choice)
    {
        if (choice == 0)
        {
            Console.WriteLine("[Operator]: З'єдную з живим оператором. Очікуйте...");
            return true;
        }
        return base.HandleRequest(choice);
    }
}
