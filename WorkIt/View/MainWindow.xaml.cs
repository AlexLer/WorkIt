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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkIt.Controller;
using WorkIt.Controller.Commands;
using WorkIt.View.Windows;

namespace WorkIt.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        string[] args;
        private Dictionary<string, ICommand> m_commands;
        private IController m_controller;

        public MembersWindow wMembers;
        public TrainersWindow wTrainers;
        public ClassWindow wClasses;
        public MarketingWindow wMarketing;
        public Training_Programs wPrograms;

        public MainWindow(IController controller)
        {
            InitializeComponent();
            m_controller = controller;
        }

        public void Start()
        {
            this.Show();
        }

        private void memeber_btn_click(object sender, RoutedEventArgs e)
        {
            wMembers = new MembersWindow(m_commands);
            wMembers.ShowDialog();
        }

        private void trainer_btn_click(object sender, RoutedEventArgs e)
        {
            wTrainers = new TrainersWindow();
            wTrainers.ShowDialog();
        }

        private void class_btn_click(object sender, RoutedEventArgs e)
        {
            wClasses = new ClassWindow(m_commands);
            wClasses.ShowDialog();
        }

        private void marketing_btn_click(object sender, RoutedEventArgs e)
        {
            wMarketing = new MarketingWindow(m_commands);
            wMarketing.ShowDialog();
        }

        private void program_btn_click(object sender, RoutedEventArgs e)
        {
            wPrograms = new Training_Programs();
            wPrograms.ShowDialog();
        }

        public void SetCommands(Dictionary<string, ICommand> commands)
        {
            m_commands = commands;
        }

        public string[] getArgs()
        {
            return wClasses.pw.args;
        }

        public void Output(string s)
        {
            MessageBox.Show(s);
        }

        public void OutputWindow(string header, string names, string IDs)
        {
            OutputWindow o = new OutputWindow();
            o.header.Text = header;
            o.Names.Text = names;
            o.IDs.Text = IDs;
            o.Show();
        }

        public void SetDistributionList(List<string> list)
        {
            wMarketing.dlw.SetDistributionList(list);
        }
        
    }
}
