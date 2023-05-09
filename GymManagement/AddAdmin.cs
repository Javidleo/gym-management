using GymManagement.Service;
using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class AddAdmin : Form
    {
        private readonly AdminService _service = new AdminService();
        public AddAdmin()
        {
            InitializeComponent();
        }

        private bool CheckParams()
        {
            if (string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(FamilyBox.Text) ||
                string.IsNullOrEmpty(UserNameBox.Text) ||
                string.IsNullOrEmpty(PasswordBox.Text))
            {
                return false;
            }

            return true;
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (CheckParams() == false)
            {
                MessageBox.Show("اطلاعات وارد شده صحیح نیست");
                return;
            }
            var result = _service.AddAdmin(NameBox.Text, FamilyBox.Text, UserNameBox.Text, PasswordBox.Text);

            if (result == "با موفقیت ثبت شد.")
            {
                MessageBox.Show(result);

                Menu menu = new Menu();
                menu.Show();
                Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
