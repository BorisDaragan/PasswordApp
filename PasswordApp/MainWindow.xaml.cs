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
using PA.Model;

namespace PA.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PasswordBL password;
        public UserService user;
        public MainWindow()
        {
            InitializeComponent();
            password = new PasswordBL();
            user = new UserService();
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Show();
            passwordWindow.Owner = this;
        }

        private void PasswordTxtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                password.Add(PasswordTxtbx.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message + " Password recording finished.");
            }
        }

        private void LoginTxtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            password.ClearEdit();
            PasswordTxtbx.Clear();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTxtbx.Text;
            user.SaveOrUpdate(new User(login, password.Password));
            password.ClearEdit();
            try
            {
                PasswordTxtbx.TextChanged -= PasswordTxtbx_TextChanged;
                PasswordTxtbx.Clear();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                PasswordTxtbx.TextChanged += PasswordTxtbx_TextChanged;
            }
        }
    }
}
