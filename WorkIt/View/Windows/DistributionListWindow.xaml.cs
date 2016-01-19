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
    /// Interaction logic for DistributionListWindow.xaml
    /// </summary>
    public partial class DistributionListWindow : Window
    {

        //public List<string> dist_list;

        public DistributionListWindow()
        {
            InitializeComponent();
        }

        private void send_btn_Click(object sender, RoutedEventArgs e)
        {
            string t = title.Text;
            string d = dist_box.Text;
            if (t.Length > 0 && d.Length > 0)
            {
                MessageBox.Show("Succesfully intergrated with Vi+ \nMail has been sent to distribution list.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Title and Distribution list box can't be empty.");
            }
        }

        public void SetDistributionList(List<string> dist_list)
        {
            foreach (string s in dist_list)
            {
                ComboBoxItem b = new ComboBoxItem();
                b.Content = s;
                dist_box.Items.Add(b);
            }
        }
    }
}
