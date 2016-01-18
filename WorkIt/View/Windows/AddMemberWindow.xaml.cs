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
    /// Interaction logic for AddMemberWindow.xaml
    /// </summary>
    public partial class AddMemberWindow : Window
    {

        public bool ok;
        public bool cancle;
        private string name;
        private string id;
        private string age;
        private string weight;
        private string sex;
        private string address;
        private string phone_NO;
        public string[] args;

        public AddMemberWindow()
        {
            InitializeComponent();
            ok = false;
            cancle = false;
            name = "";
            id = "";
            age = "";
            weight = "";
            sex = "";
            address = "";
            phone_NO = "";
        }


        private void ok_btn_click(object sender, RoutedEventArgs e)
        {
            bool f = true;
            if ((name = name_box.Text).Length > 0)
            {
                name_box.BorderBrush = Brushes.Green;
                name_label.Content = "";
            }

            else
            {
                name_box.BorderBrush = Brushes.Red;
                name_label.Content = "Please enter a valid name";
                f = false;
            }

            if ((id = ID_box.Text).Length > 0)
            {
                ID_box.BorderBrush = Brushes.Green;
                id_label.Content = "";
            }
            else
            {
                ID_box.BorderBrush = Brushes.Red;
                id_label.Content = "Please enter a valid ID number";
                f = false;
            }

            int tmp;
            if (int.TryParse((age = Age_box.Text), out tmp) && age.Length > 0 && int.Parse(age) >= 14 && int.Parse(age) < 99)
            {
                Age_box.BorderBrush = Brushes.Green;
                age_label.Content = "";
            }
            else
            {
                Age_box.BorderBrush = Brushes.Red;
                age_label.Content = "Please Enter a valid age";
                f = false;
            }

            double tmpd;
            if (double.TryParse((weight = Weight_box.Text), out tmpd) && weight.Length > 0)
            {
                Weight_box.BorderBrush = Brushes.Green;
                weight_label.Content = "";
            }
            else
            {
                Weight_box.BorderBrush = Brushes.Red;
                weight_label.Content = "Please enter a valid weight";
                f = false;
            }

            if ((sex = gender_box.Text.ToLower()).Length > 0 && (sex == "m" || sex == "f"))
            {
                gender_box.BorderBrush = Brushes.Green;
                gender_label.Content = "";
            }
            else
            {
                gender_box.BorderBrush = Brushes.Red;
                gender_label.Content = "Gender can be m or f";
                f = false;
            }

            if ((address = Address_box.Text).Length > 0)
            {
                Address_box.BorderBrush = Brushes.Green;
                address_label.Content = "";
            }
            else
            {
                Address_box.BorderBrush = Brushes.Red;
                address_label.Content = "Please enter a valid address";
                f = false;
            }

            if ((phone_NO = PhoneNO_box.Text).Length > 0)
            {
                PhoneNO_box.BorderBrush = Brushes.Green;
                number_label.Content = "";
            }

            else
            {
                PhoneNO_box.BorderBrush = Brushes.Red;
                number_label.Content = "Please enter a valid number";
                f = false;
            }
            if (!f)
                return;
            ok = true;
            args = new string[] { name, id, age, weight, sex, address, phone_NO };
            this.Close();
        }


        private void cancle_btn_click(object sender, RoutedEventArgs e)
        {
            cancle = true;
            this.Close();
        }
    }
}
