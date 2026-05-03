namespace Memento;

public class TextEditor
{
    private readonly TextDocument _document;
    private readonly Stack<DocumentMemento> _history;

    public TextEditor(TextDocument doc)
    {
        _document = doc;
        _history = new Stack<DocumentMemento>();
    }

    public void Type(string text)
    {
        _document.Content += text;
    }

    public void SaveState()
    {
        _history.Push(_document.Save());
        Console.WriteLine("Стейт збережено.");
    }

    public void Undo()
    {
        if (_history.Count > 0)
        {
            var memento = _history.Pop();
            _document.Restore(memento);
            Console.WriteLine("Відкат змін виконано.");
        }
        else
        {
            Console.WriteLine("Історія порожня.");
        }
    }

    public void Print() => Console.WriteLine($"Поточний текст: \"{_document.Content}\"");
}
