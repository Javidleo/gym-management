using GymManagement.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class LoginForm : MaterialForm
    {
        private readonly AdminService _service = new AdminService();
        public LoginForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
                this.Hide();
                Menu menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            AdminForm addAdminForm = new AdminForm();

            this.Hide();
            addAdminForm.Closed += (s, args) => this.Close();
            addAdminForm.Show();
        }
    }
}
