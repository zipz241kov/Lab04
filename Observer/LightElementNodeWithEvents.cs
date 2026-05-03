namespace Observer;

public class LightElementNodeWithEvents
{
    public string TagName { get; }

    
    private Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();

    public LightElementNodeWithEvents(string tagName)
    {
        TagName = tagName;
    }

    
    public void AddEventListener(string eventType, Action listener)
    {
        if (!_eventListeners.ContainsKey(eventType))
        {
            _eventListeners[eventType] = new List<Action>();
        }
        _eventListeners[eventType].Add(listener);
    }

    
    public void DispatchEvent(string eventType)
    {
        if (_eventListeners.ContainsKey(eventType))
        {
            Console.WriteLine($"\n--- Triggering event: {eventType} on <{TagName}> ---");
            foreach (var listener in _eventListeners[eventType])
            {
                listener.Invoke();
            }
        }
    }
}
