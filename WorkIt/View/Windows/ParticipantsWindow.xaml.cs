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
    /// Interaction logic for ParticipantsWindow.xaml
    /// </summary>
    public partial class ParticipantsWindow : Window
    {

        private string class_name;

        public string[] args;
        private Dictionary<string, ICommand> m_commands;
        bool s;

        public ParticipantsWindow(Dictionary<string, ICommand> commands)
        {
            InitializeComponent();
            class_name = "";
            m_commands = commands;
            for (int i = 0 ; i < 30; i ++){
                ComboBoxItem b = new ComboBoxItem();
                b.Content = i + 1;
                date.Items.Add(b);
            }

            for (int i = 14; i < 23; i++)
            {
                ComboBoxItem b = new ComboBoxItem();
                b.Content = i + ":00:00";
                time.Items.Add(b);
            }

            s = false;
        }

        private void show_btn_click(object sender, RoutedEventArgs e)
        {
            string t = time.Text;
            string d = date.Text;
            class_name = class_block.Text;
            if (class_name.Length > 0 && t.Length > 0 && d.Length > 0)
            {
                s = true;
                args = new string[] { t, d };
                m_commands["ClassList"].DoCommand(new string[] { class_name });
            }
        }

        private void send_btn_click(object sender, RoutedEventArgs e)
        {
            if (s)
                this.Close();
        }



    }
}
