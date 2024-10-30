using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFMerger
{
    public class DisplayPDF : INotifyPropertyChanged
    {
        private Stream? docStream;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Stream DocumentStream
        {
            get
            {
                return docStream;
            }
            set
            {
                docStream = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DocumentStream"));
            }
        }

        public DisplayPDF()
        {
            //docStream = new FileStream("C:\\Users\\infoj\\Documents\\JeroendeHaanCV2024NL.pdf", FileMode.OpenOrCreate);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
