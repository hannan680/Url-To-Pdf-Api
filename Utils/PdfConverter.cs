using System;
using SelectPdf;


namespace MyChromeExtensionBackend.Converters;

class PdfConverter
{
  
   public  static void UrlToPdf(string url)
    {
        Uri uri = new Uri(url);
        string domain = uri.Host;
        string outputPath = $"./pdf/{domain}.pdf";

        // Instantiate an HtmlToPdf converter object
        HtmlToPdf converter = new HtmlToPdf();

        // Create a new PDF document converting HTML content
        // PdfDocument doc = converter.ConvertHtmlString(htmlContent);
        PdfDocument doc = converter.ConvertUrl(url);
         doc.Save(outputPath);
          

            // Close the PDF document
            doc.Close();

          
        
    }
}
