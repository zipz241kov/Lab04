namespace Memento;

public class TextDocument
{
    public string Content { get; set; } = "";

    public DocumentMemento Save()
    {
        return new DocumentMemento(Content);
    }

    public void Restore(DocumentMemento memento)
    {
        if (memento != null)
        {
            Content = memento.SavedContent;
        }
    }
}
