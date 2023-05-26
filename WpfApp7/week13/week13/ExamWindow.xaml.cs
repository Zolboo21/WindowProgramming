using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace week13
{
    /// <summary>
    /// ExamWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExamWindow :Window
    {
        public ExamWindow()
        {
            InitializeComponent();
        }

     private void Cancel_click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Ok_click(object sender, RoutedEventArgs e) { 
        DialogResult=true;
            Close();
        }
    }
}
