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

namespace CTFproject
{
    /// <summary>
    /// Interaction logic for dangnhap.xaml
    /// </summary>
    public partial class dangnhap : Window
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void login_bt_Click(object sender, RoutedEventArgs e)
        {
            var homeWindow = new home
            {
                Title = "Home"
            };
            homeWindow.Show();
            this.Hide();
        }


        //private void register_bt_Click(object sender, RoutedEventArgs e)
        //{
        //    dangky registrationWindow = new dangky();
        //    Window window = new Window
        //    {
        //        Content = registrationWindow,
        //        Title = "Registration"
        //    };
        //    window.Show();
        //    this.Hide();
        //}

        private void register_bt_Click(object sender, RoutedEventArgs e)
        {
            var registrationWindow = new Window
            {
                Content = new dangky(),
                Title = "Registration"
            };
            registrationWindow.Show();
            this.Hide();
        }


        private void forgot_bt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
