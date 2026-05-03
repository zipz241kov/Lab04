namespace Strategy;

public class LightImageNode
{
    public string Href { get; }
    private IImageLoadStrategy _loadStrategy;

    public LightImageNode(string href)
    {
        Href = href;

        if (href.StartsWith("http://") || href.StartsWith("https://"))
        {
            _loadStrategy = new NetworkLoadStrategy();
        }
        else
        {
            _loadStrategy = new FileSystemLoadStrategy();
        }
    }

    public void Render()
    {
        _loadStrategy.Load(Href);
        Console.WriteLine($"<img src=\"{Href}\" />");
    }
}
