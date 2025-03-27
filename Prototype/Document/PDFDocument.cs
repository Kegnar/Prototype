namespace Prototype.Document;

// Подкласс для PDF-документов
public class PDFDocument : Document
{
    public PDFDocument(string content) : base(content, "PDF") { }

    public override Document Clone()
    {
        Console.WriteLine("Копируем *.pdf");
        return new PDFDocument(this.Content);
    }
}