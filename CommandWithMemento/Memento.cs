public class Memento
{
    public string Content { get; private set; }

    public Memento(string content)
    {
        Content = content;
    }
}

// Originator class
public class TextService
{
    public string Content { get; set; }

    public Memento Save()
    {
        return new Memento(Content);
    }

    public void Restore(Memento memento)
    {
        Content = memento.Content;
    }
}