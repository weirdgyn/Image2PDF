// See https://aka.ms/new-console-template for more information
using iTextSharp.text.pdf;

internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("Usage: recover <doc.pdf> <front.pdf> <back.pdf>");
            return;
        }

        var doc = args[0];
        var front = args[1];
        var back = args[2];
        var guid = $@"{Guid.NewGuid()}.pdf";

        using (var rDoc = new PdfReader(doc))
        using (var rFront = new PdfReader(front))
        using (var rBack = new PdfReader(back))
        {
            using PdfStamper stamper = new(rDoc, new FileStream(guid, FileMode.Append));

            stamper.ReplacePage(rFront, 1, 1);
            stamper.ReplacePage(rBack, 1, rDoc.NumberOfPages);
            stamper.Close();
        }

        File.Delete(doc);

        File.Move(guid, doc);
    }
}