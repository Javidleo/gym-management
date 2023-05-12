using GymManagement.Service;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class AdminForm : MaterialForm
    {
        private readonly AdminService _adminService = new AdminService();
        public AdminForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _adminService.AddAdmin(NameBox.Text, FamilyBox.Text,
                UserNameBox.Text, NationalCodeBox.Text,
                BirthDateBox.PersianDate.ToString(), PasswordBox.Text);

            if (result == true)
            {
                MessageBox.Show("با موفقیت ثبت شد.");
                this.Hide();
                Menu menu = new Menu();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("این نام کاربری قبلا استفاده شده است.");
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
