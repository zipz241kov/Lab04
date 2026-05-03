namespace ChainOfResponsibility;

public abstract class SupportHandler
{
    protected SupportHandler _nextHandler;

    public void SetNext(SupportHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual bool HandleRequest(int choice)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.HandleRequest(choice);
        }
        return false;
    }
}
