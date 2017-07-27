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
using PA.BLL;

namespace PA.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PasswordBL password;
        public UserBL user;
        public MainWindow()
        {
            InitializeComponent();
            password = new PasswordBL();
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Show();
            passwordWindow.Owner = this;
        }

        private void PasswordTxtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            PasswordPartBL pPart = new  PasswordPartBL(PasswordTxtbx.Text);
            password.Add(pPart);
        }

        private void LoginTxtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.ClearEdit();
            PasswordTxtbx.Clear();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            
            user = new UserBL(LoginTxtbx.Text, password);
            user.SaveOrUpdate();
        }
    }
}
