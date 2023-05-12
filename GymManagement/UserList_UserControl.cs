using GymManagement.DataSource;
using GymManagement.Model;
using GymManagement.Tools;
using GymManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class UserList_UserControl : UserControl
    {
        GymContext _context = new GymContext();
        public UserList_UserControl()
        {
            InitializeComponent();
        }

        private string GetSearchParam()
        {
            if (NameCheck.Checked)
                return "name";

            if (NationalCodeCheck.Checked)
                return "nationalCode";

            if (BirthDateCheck.Checked)
                return "birthDate";

            if (ExpiredCheck.Checked)
                return "expired";

            return "";
        }
        private bool ParamsChecked()
        {
            if (NameCheck.Checked ||
                NationalCodeCheck.Checked ||
                BirthDateCheck.Checked ||
                ExpiredCheck.Checked)
                return true;

            return false;
        }

        private void UserGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = UserGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (status == "معتبر") return;

            UserGridView.CurrentRow.Selected = true;

            var options = ExtractInstallments(UserGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            User user = new User()
            {
                Id = int.Parse(UserGridView.Rows[e.RowIndex].Cells[0].Value.ToString()),
                Name = UserGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Family = UserGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                DurationEnd = UserGridView.Rows[e.RowIndex].Cells[3].Value.ToString().ToGregorianDate(),
                PeriodOption = options.FirstOrDefault(i => i.Tag == OptionTag.Period),
                Option = options.FirstOrDefault(i => i.Tag == OptionTag.Option),
                AdminId = _context.Admins.FirstOrDefault(i => i.IsActive == true).Id,
            };

            Menu menu = new Menu(user);

            menu.Show();
            this.Hide();
        }

        private List<InstallmentOption> ExtractInstallments(string optionsString)
        {
            var optionsArray = optionsString.Split('/');
            var option = new InstallmentOption();
            var options = _context.InstallmentOptions.ToList();
            var optionList = new List<InstallmentOption>();

            foreach (var item in optionsArray)
            {
                var title = Helper.OptionsReverseDictionary[item];
                optionList.Add(options.First(i => i.Title == title));
            }
            return optionList;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!ExpiredCheck.Checked)
            {
                if (string.IsNullOrEmpty(SearchParamBox.Text) && ParamsChecked())
                {
                    MessageBox.Show("لطفا پارامتر جستجو را وارد کنید.");
                    return;
                }
            }

            var searchParam = GetSearchParam();

            List<User> users = new List<User>();
            switch (searchParam)
            {
                case "name":
                    users = _context.Users.Include(i => i.PeriodOption).Include(i=> i.Option).Where(i => i.Name.Contains(SearchParamBox.Text)).ToList();
                    break;

                case "nationalCode":
                    users = _context.Users.Include(i => i.PeriodOption).Include(i => i.Option).Where(i => i.NationalCode == SearchParamBox.Text).ToList();
                    break;

                case "birthDate":
                    users = _context.Users.Include(i => i.PeriodOption).Include(i => i.Option).Where(i => i.BirthDate == SearchParamBox.Text).ToList();
                    break;

                case "expired":
                    users = _context.Users.Include(i => i.PeriodOption).Include(i => i.Option).Where(i => i.DurationEnd <= DateTime.Now).ToList();
                    break;

                default:
                    users = _context.Users.Include(i => i.PeriodOption).Include(i => i.Option).AsNoTracking().ToList();
                    break;
            }

            var userList = users.Select(i => new UserViewModel
            {
                Id = i.Id,
                Name = i.Name,
                Family = i.Family,
                DurationEnd = i.DurationEnd.ToPersianDate(),
                Installment = Helper.ExtractInstallment(i.PeriodOption, i.Option),
                Status = i.DurationEnd <= DateTime.Now ? "اتمام دوره" : "معتبر"
            }).ToList();


            UserGridView.DataSource = userList;

            UserGridView.Columns[0].Width = 70;
            UserGridView.Columns[1].Width = 110;
            UserGridView.Columns[2].Width = 110;
            UserGridView.Columns[3].Width = 130;
            UserGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserGridView.Columns[5].Width = 150;

            DataGridViewButtonColumn PayFee = new DataGridViewButtonColumn();
            PayFee.Name = "pay_fee";
            PayFee.Text = "pay fee";
            int columnIndex = 5;

            if (UserGridView.Columns["pay_fee"] == null)
            {
                UserGridView.Columns.Insert(columnIndex, PayFee);
            }
        }

        private void UserGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = UserGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (status == "معتبر") return;

            UserGridView.CurrentRow.Selected = true;

            var options = ExtractInstallments(UserGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            User user = new User()
            {
                Id = int.Parse(UserGridView.Rows[e.RowIndex].Cells[0].Value.ToString()),
                Name = UserGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Family = UserGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                DurationEnd = UserGridView.Rows[e.RowIndex].Cells[3].Value.ToString().ToGregorianDate(),
                PeriodOption = options.FirstOrDefault(i => i.Tag == OptionTag.Period),
                Option = options.FirstOrDefault(i => i.Tag == OptionTag.Option),
                AdminId = _context.Admins.FirstOrDefault(i => i.IsActive == true).Id,
            };

            Menu menu = new Menu(user);

            menu.Show();
            this.Hide();
        }
    }
}
