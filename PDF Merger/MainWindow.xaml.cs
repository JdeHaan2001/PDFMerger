using Microsoft.Win32;
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
using System;

namespace PDFMerger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fileDialogue = new OpenFileDialog();

            fileDialogue.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fileDialogue.Filter = "Pdf files|*.pdf";
            fileDialogue.RestoreDirectory = true;

            if (fileDialogue.ShowDialog() == true)
            {
                string filePath = fileDialogue.FileName;
                MessageBox.Show(filePath);
            }
        }
    }
}