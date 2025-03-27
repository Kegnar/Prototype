namespace Prototype.Document;

public abstract class Document
{
    public string Content { get; }
    public string FormatType { get; }

    protected Document(string content, string formatType)
    {
        Content = content;
        FormatType = formatType;
    }

    // Метод клонирования с конкретным возвращаемым типом
    public abstract Document Clone();
    
    public override string ToString()
    {
        return $"Документ {FormatType}: {Content}";
    }
}