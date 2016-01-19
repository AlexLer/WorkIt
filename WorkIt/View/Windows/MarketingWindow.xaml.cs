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
    /// Interaction logic for MarketingWindow.xaml
    /// </summary>
    public partial class MarketingWindow : Window
    {
        public DistributionListWindow dlw;
        private Dictionary<string, ICommand> m_commands;

        public MarketingWindow(Dictionary<string, ICommand> commands)
        {
            InitializeComponent();
            m_commands = commands;
        }

        private void Send_btn_Click(object sender, RoutedEventArgs e)
        {
            dlw = new DistributionListWindow();
            m_commands["GetDistributonList"].DoCommand(new string[] {});
            dlw.ShowDialog();
        }
    }
}
