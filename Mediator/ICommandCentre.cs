namespace Mediator;

public interface ICommandCentre
{
    void RequestLanding(Aircraft aircraft);
    void SetRunway(Runway runway);
}
