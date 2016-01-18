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

namespace WorkIt.View.Windows
{
    /// <summary>
    /// Interaction logic for ParticipantsWindow.xaml
    /// </summary>
    public partial class ParticipantsWindow : Window
    {

        private string class_name;
        
        public ParticipantsWindow()
        {
            InitializeComponent();
            class_name = "";
        }

        private void show_btn_click(object sender, RoutedEventArgs e)
        {

        }



    }
}
