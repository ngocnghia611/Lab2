using BusinessObjects.Model;
using System.Windows;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly MyStoreContext db;
        public LoginWindow()
        {
            InitializeComponent();
            db = new MyStoreContext();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Password;
            AccountMember member = db.AccountMembers.FirstOrDefault(c => c.MemberId.Equals(user) && c.MemberPassword.Equals(pass));
            if (member != null)
            {
                this.Hide();
                MainWindow main = new MainWindow();
                main.Show();
            }
            else
            {
                MessageBox.Show("Login faild");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
