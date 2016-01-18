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
    /// Interaction logic for MembersWindow.xaml
    /// </summary>
    public partial class MembersWindow : Window
    {
        public string[] args;
        private Dictionary<string, ICommand> m_commands;
        public MembersWindow(Dictionary<string, ICommand> commands)
        {
            InitializeComponent();
            m_commands = commands;
        }


        private void addMember_btn_click(object sender, RoutedEventArgs e)
        {
            AddMemberWindow add = new AddMemberWindow();
            add.ShowDialog();
            if (!add.cancle && add.ok)
            {
                m_commands["AddMember"].DoCommand(add.args);
            }
        }
    }
}
