namespace Memento;

public class DocumentMemento
{
    public string SavedContent { get; }
    public DocumentMemento(string content) { SavedContent = content; }
}
