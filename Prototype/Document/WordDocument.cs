namespace Prototype.Document;

// Подкласс для Word-документов
public class WordDocument : Document
{
    public WordDocument(string content) : base(content, "Word") { }

    public override Document Clone()
    {
        Console.WriteLine("Копируем *.docx");
        return new WordDocument(this.Content);
    }
}