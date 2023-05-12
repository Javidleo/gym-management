using GymManagement.DataSource;
using GymManagement.ViewModel;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class SettingsUserControl : UserControl
    {
        private readonly GymContext _context = new GymContext();
        private string _settingName;
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            var result = _context.InstallmentOptions.Select(i => new SettingViewModel
            {
                Name = i.Title,
                Price = i.Price,
            }).ToList();

            SettingGrid.DataSource = result;
            SettingGrid.Columns[0].Width = 450;
            SettingGrid.Columns[1].Width = 450;
        }

        private void SettingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameBox.Text = SettingGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            PriceBox.Text = SettingGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            _settingName = NameBox.Text;
        }

        private void UpdateSettingButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(PriceBox.Text))
            {
                MessageBox.Show("مقادیر مورد نظر را پر کنید.");
                return;
            }

            if(NameBox.Text != _settingName)
            {
                MessageBox.Show("لطفا نام تنظیمات را تغییر ندهید.");
                return;
            }

            var option = _context.InstallmentOptions.FirstOrDefault(i => i.Title == NameBox.Text);
            if(option != null)
            {
                option.Price = double.Parse(PriceBox.Text);
                _context.InstallmentOptions.AddOrUpdate(option);
                _context.SaveChanges();
                MessageBox.Show("موفق");
                return;
            }

        }
    }
}
