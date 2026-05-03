namespace ChainOfResponsibility;

public class BillingSupport : SupportHandler
{
    public override bool HandleRequest(int choice)
    {
        if (choice == 2)
        {
            Console.WriteLine("[Billing Support]: Перевіряємо ваш баланс... Ваша заборгованість 0 грн.");
            return true;
        }
        return base.HandleRequest(choice);
    }
}
