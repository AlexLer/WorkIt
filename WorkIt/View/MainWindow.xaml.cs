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

        public MainWindow(IController controller)
        {
            InitializeComponent();
            m_controller = controller;
        }

        public void Start()
        {
            //Console.WriteLine(Directory.GetCurrentDirectory()); 
            this.Show();
        }

        private void memeber_btn_click(object sender, RoutedEventArgs e)
        {
            MembersWindow mw = new MembersWindow(m_commands);
            mw.ShowDialog();
        }

        private void trainer_btn_click(object sender, RoutedEventArgs e)
        {
            TrainersWindow tw = new TrainersWindow();
            tw.ShowDialog();
        }

        private void class_btn_click(object sender, RoutedEventArgs e)
        {
            ClassWindow cw = new ClassWindow(m_commands);
            cw.ShowDialog();
        }

        private void marketing_btn_click(object sender, RoutedEventArgs e)
        {
            MarketingWindow maw = new MarketingWindow();
            maw.ShowDialog();
        }

        private void program_btn_click(object sender, RoutedEventArgs e)
        {
            Training_Programs tp = new Training_Programs();
            tp.ShowDialog();
        }

        public void SetCommands(Dictionary<string, ICommand> commands)
        {
            m_commands = commands;
        }

        public void Output(string s)
        {
            MessageBox.Show(s);
        }

        public void OutputWindow(string header, string names, string IDs)
        {
            OutputWindow o = new OutputWindow();
            o.header.Content = header;
            o.Names.Text = names;
            o.IDs.Text = IDs;
            o.Show();
        }

        
    }
}
