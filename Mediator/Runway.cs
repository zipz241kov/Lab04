namespace Mediator;

public class Runway
{
    public bool IsBusy { get; set; } = false;
    private readonly ICommandCentre _mediator;

    public Runway(ICommandCentre mediator)
    {
        _mediator = mediator;
        _mediator.SetRunway(this);
    }

    public void FreeRunway()
    {
        IsBusy = false;
        Console.WriteLine("Runway: Смуга вільна!");
    }
}
