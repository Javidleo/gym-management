using GymManagement.Service;
using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class LoginForm : Form
    {
        private readonly AdminService _service = new AdminService();
        public LoginForm()
        {
            InitializeComponent();
        }


        private bool CheckParams()
        {
            if (string.IsNullOrEmpty(UserNameBox.Text)
                || string.IsNullOrEmpty(PasswordBox.Text))
            {
                return false;
            }

            return true;
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (CheckParams() == false)
            {
                MessageBox.Show("لطفا اطلاعات را پر کنید");
            }

            var loginResult = _service.Login(UserNameBox.Text, PasswordBox.Text);

            if (loginResult == false)
            {
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است.");
            }
            else
            {
                Menu menu = new Menu();
                menu.Show();

                Close();
            }

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            AddAdmin addAdminForm = new AddAdmin();

            addAdminForm.Show();
            Close();
        }
    }
}
