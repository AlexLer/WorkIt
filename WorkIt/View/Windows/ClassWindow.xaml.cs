using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorkIt.Controller.Commands;

namespace WorkIt.View.Windows
{
    /// <summary>
    /// Interaction logic for ClassWindow.xaml
    /// </summary>
    public partial class ClassWindow : Window
    {


        public string[] args;
        private Dictionary<string, ICommand> m_commands;
        public ParticipantsWindow pw;

        public ClassWindow(Dictionary<string, ICommand> commands)
        {
            InitializeComponent();
            m_commands = commands;
        }

        private void program_btn_click(object sender, RoutedEventArgs e)
        {
            pw = new ParticipantsWindow(m_commands);
            pw.ShowDialog();
        }
    }
}
