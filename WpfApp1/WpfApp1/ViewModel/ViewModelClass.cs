using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    class ViewModelClass : INotifyPropertyChanged
    {
        private int red;
        public int Red
        {
            get { return red; }
            set
            {
                red = value;
                OnPropertyChanged("Red");
                OnColorChanged();
            }
        }
        private int green;
        public int Green
        {
            get { return green; }
            set
            {
                green = value;
                OnPropertyChanged("Green");
                OnColorChanged();
            }
        }

        private int blue;
        public int Blue
        {
            get { return blue; }
            set
            {
                blue = value;
                OnPropertyChanged("Blue");
                OnColorChanged();
            }
        }




        private SolidColorBrush colorBrush;
        public SolidColorBrush ColorBrush
        {
            get { return colorBrush; }
            set
            {
                colorBrush = value;
                OnPropertyChanged("ColorBrush");
            }
        }



    private void OnColorChanged()
    {
            ColorBrush = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));

    }

        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
