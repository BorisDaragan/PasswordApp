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
using PA.BLL;

namespace PA.UI
{
    /// <summary>
    /// Interaction logic for PasswordWindow.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        private PasswordBL password;


        public PasswordWindow()
        {
            InitializeComponent();
            password = new PasswordBL();
        }

        private void PasswordTxtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (this.Title == "! Login changed in main window. Please wait...")
            {
                MessageBox.Show("! Login changed in main window. Please wait...");
            }
            else
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
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            UserBL user = new UserBL();
            var mainWindow = this.Owner as MainWindow;
            if (mainWindow != null)
            {
               user =  mainWindow.user;
            }
            if (user.CheckPassword(password.Password))
            {
                MessageBox.Show("Passwords match");
            }
            else
            {
                MessageBox.Show("Password does not match, please try again");
            }
            password.ClearEdit();
            PasswordTxtbx.TextChanged -= PasswordTxtbx_TextChanged;
            PasswordTxtbx.Clear();
            PasswordTxtbx.TextChanged += PasswordTxtbx_TextChanged;
        }

    }
}
