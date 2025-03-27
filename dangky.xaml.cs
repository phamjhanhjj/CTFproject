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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CTFproject
{
    /// <summary>
    /// Interaction logic for dangky.xaml
    /// </summary>
    public partial class dangky : Page
    {
        public dangky()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void register_bt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void login_bt_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                var loginWindow = new dangnhap
                {
                    Title = "Login"
                };
                loginWindow.Show();
                Window.GetWindow(this)?.Close();
            }));
        }


    }
}
