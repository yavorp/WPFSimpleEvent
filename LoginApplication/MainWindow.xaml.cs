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
using Week10a;

namespace LoginApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblUsername.Content = LoginUserControl.Username;
            lblPassword.Content = LoginUserControl.Password;
        }

        private void OnLogin(object sender,  EventArgs e)
        {  // callback for handling the LoginOK event
            LoginEventAgrs args = (LoginEventAgrs) e;
            lblUsername.Content = args.Username;
            lblPassword.Content = args.Password;

        }
    }
}
