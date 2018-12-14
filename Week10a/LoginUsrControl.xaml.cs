using System;
using System.Windows.Controls;

namespace Week10a
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {  // Even source
        public event EventHandler LoginOK;
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Password; }
            set { txtPassword.Password = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            LoginOK?.Invoke(this, new LoginEventAgrs(txtPassword.Password, txtUsername.Text));
        }

        private void BtnCancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Password = "";
        }
    }
}
