// Вариант 2: Реализуйте класс Document с методом clone(), который будет использовать паттерн
// Prototype для создания копий документов с различными форматами (например, PDF, Word).

using Prototype.Document;

// Создаем оригинальные документы
var pdfDoc = new PDFDocument("PDF-ка");
var wordDoc = new WordDocument("Вордовский документ");

// Клонируем документы
var clonedPdf = pdfDoc.Clone();
var clonedWord = wordDoc.Clone();

// Выводим информацию о документах
Console.WriteLine("\nОригиналы:");

Console.WriteLine(pdfDoc); //тут неявно вызывается переопределенный в классе Document метод ToString()
Console.WriteLine(wordDoc);

Console.WriteLine("\nКопии:");
Console.WriteLine(clonedPdf);
Console.WriteLine(clonedWord);