using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Merger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string pdf1 = "C:\\Users\\infoj\\Documents\\C# Projects\\Test\\JeroendeHaan_Graduation_Agreement_CMGT_2023_2024.pdf";
        private const string pdf2 = "C:\\Users\\infoj\\Documents\\C# Projects\\Test\\RAG_Assignment_23-24.pdf";

        public MainWindow()
        {
            InitializeComponent();
            MergePDFs();
        }


        private void MergePDFs()
        {
            var pdfDoc1 = PdfReader.Open(pdf1, PdfDocumentOpenMode.Import);
            var pdfDoc2 = PdfReader.Open(pdf2, PdfDocumentOpenMode.Import);
            var mergedPDF = new PdfDocument("MergedPDF.pdf");
            
            for (int i = 0; i < pdfDoc1.PageCount; i++)
            {
                mergedPDF.AddPage(pdfDoc1.Pages[i]);
            }

            for(int j = 0; j < pdfDoc2.PageCount; j++)
            {
                mergedPDF.AddPage(pdfDoc2.Pages[j]);
            }

            mergedPDF.Save("C:\\Users\\infoj\\Documents\\C# Projects\\Test\\test.pdf");

        }
    }
}