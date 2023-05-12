using GymManagement.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Menu : MaterialForm
    {
        public Menu()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public Menu(User user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            ShowAddDuration(user);

        }

        private void ShowAddDuration(User user)
        {
            var addUser = new AddUser_UserControll(user);
            this.MenuPanel.Controls.Clear();

            this.MenuPanel.Controls.Add(addUser);
        }

        private void UserSignUpButton_Click(object sender, EventArgs e)
        {
            var userControl = new AddUser_UserControll();
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserListButton_Click(object sender, EventArgs e)
        {
            var userControl = new UserList_UserControl();
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
        }

        private void TransactionListButton_Click(object sender, EventArgs e)
        {
            var userControl = new TransactionList_UserControl();
            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
        }

        private void DurationRenewButton_Click(object sender, EventArgs e)
        {
            var userControl = new SettingsUserControl();

            MenuPanel.Controls.Clear();
            MenuPanel.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPanel.Controls.Clear();
            Menu_UserControl userControl = new Menu_UserControl();

            MenuPanel.Controls.Add(userControl);
        }
    }
}
