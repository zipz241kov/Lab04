namespace Mediator;

public class Aircraft
{
    public string Name { get; }
    private readonly ICommandCentre _mediator;

    public Aircraft(string name, ICommandCentre mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void Land()
    {
        Console.WriteLine($"{Name}: Запитую дозвіл на посадку...");
        _mediator.RequestLanding(this);
    }
}
