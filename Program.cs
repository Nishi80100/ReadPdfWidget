using System;
using Spire.Pdf;
using Spire.Pdf.Widget;
using Spire.Pdf.Fields;

namespace ReadPdfWidget

{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"C:\Users\nishi\OneDrive - Huron Consulting Group\Desktop\P_Folder\Projects\EditPDF\Docs\OoPdfFormExample.pdf");
            PdfFormWidget formWidget = doc.Form as PdfFormWidget;
            for (int i = 0; i < formWidget.FieldsWidget.List.Count; i++)
            {
                PdfField field = formWidget.FieldsWidget.List[i] as PdfField;
                string fieldName = field.Name;
                Console.WriteLine(fieldName);
            }
            Console.Read();

        }
    }
}