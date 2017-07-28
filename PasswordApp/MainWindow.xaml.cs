using System;
using System.Windows;
using System.Windows.Controls;
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
            user = new UserBL();
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PasswordWindow passwordWindow = new PasswordWindow();
            passwordWindow.Owner = this;
            passwordWindow.Title = "Enter password";
            passwordWindow.Show();
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
            foreach (Window window in OwnedWindows)
            {
                window.Title = "! Login changed in main window. Please wait...";
                var passWindow = window as PasswordWindow;
                passWindow.password.ClearEdit();
                PasswordTxtbx.TextChanged -= PasswordTxtbx_TextChanged;
                PasswordTxtbx.Clear();
                PasswordTxtbx.TextChanged += PasswordTxtbx_TextChanged;
                window.Title = "Enter password";
            }
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTxtbx.Text;
            user = new UserBL(login, password.Password);
            password.ClearEdit();
            PasswordTxtbx.TextChanged -= PasswordTxtbx_TextChanged;
            PasswordTxtbx.Clear();
            PasswordTxtbx.TextChanged += PasswordTxtbx_TextChanged;
            MessageBox.Show($"Password saved! User login={login}");
        }
    }
}
