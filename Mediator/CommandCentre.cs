namespace Mediator;

public class CommandCentre : ICommandCentre
{
    private Runway _runway;

    public void SetRunway(Runway runway) => _runway = runway;

    public void RequestLanding(Aircraft aircraft)
    {
        if (_runway.IsBusy)
        {
            Console.WriteLine($"Command Centre: {aircraft.Name}, посадка заборонена. Смуга зайнята.");
        }
        else
        {
            Console.WriteLine($"Command Centre: {aircraft.Name}, посадка дозволена.");
            _runway.IsBusy = true; // Займаємо смугу
        }
    }
}
