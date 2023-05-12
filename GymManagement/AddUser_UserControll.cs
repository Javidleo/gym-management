using GymManagement.Model;
using GymManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class AddUser_UserControll 
    {
        private User _user;
        public AddUser_UserControll()
        {
            InitializeComponent();
        }

        public AddUser_UserControll(User user)
        {
            InitializeComponent();
            _user = user;
            FillTextBoxes(_user);
            FromNowCheck.Visible = true;
            FromFinishCheck.Visible = true;
        }

        private void FillTextBoxes(User user)
        {
            this.NameBox.Text = user.Name;
            this.FamilyBox.Text = user.Family;
        }

        private readonly UserService _userService = new UserService();
        private readonly SettingService _settingService = new SettingService();
        private readonly AdminService _adminService = new AdminService();

        private string CheckParams()
        {
            if (string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(FamilyBox.Text) ||
                string.IsNullOrEmpty(NationalCodeBox.Text) ||
                string.IsNullOrEmpty(BirthDateBox.PersianDate.ToString()))
            {
                return "اطلاعات پایه را کامل کنید";
            }

            if (MonthlyCheck.Checked == false &&
                TwoMonthCheck.Checked == false &&
                ThreeDaysCheck.Checked == false &&
                SixMonthCheck.Checked == false)
            {
                return "مدت زمان پرداخت شهریه را وارد کنید.";
            }

            if (EveryDayCheck.Checked == false &&
                ThreeDaysCheck.Checked == false)
            {
                return "حداقل یک اپشن ثبت نام وارد کنید.";
            }

            return "";
        }


        private List<InstallmentOption> GetOptions()
        {
            var options = _settingService.GetAll();

            if (MonthlyCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "monthly"));

            if (TwoMonthCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "twoMonth"));

            if (ThreeMonthCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "threeMonth"));

            if (SixMonthCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "sixMonth"));

            if (EveryDayCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "everyDay"));

            if (ThreeDaysCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "threeDays"));

            return options;
        }
        private (DateTime start, DateTime end) CalculateDuration(List<InstallmentOption> options)
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMonths(1);
            var period = options.FirstOrDefault(i => i.Tag == OptionTag.Period);
            if (FromNowCheck.Checked)
            {
                start = DateTime.Now;

                end = _userService.CalculateDuration(period);
            }
            else if (FromFinishCheck.Checked)
            {
                start = _user.DurationEnd;
                end = _userService.CalculateDuration(period);
            }

            return (start, end);
        }

        private void HandleUpdate()
        {
            var admin = _adminService.GetCurrentAdmin();
            if (admin == null)
            {
                MessageBox.Show("ورود غیر مجاز");
            }
            bool result = false;

            var options = GetOptions();

            if (_user != null)
            {
                var duration = CalculateDuration(options);

                result = _userService.ChargeAccount(_user.Id, duration.start, duration.end, options, admin.Id);
                if (result == true)
                    MessageBox.Show("تمدید موفقیت امیز بود");

                else
                    MessageBox.Show("تمدید ناموفق دوباره چک کنید.");

                return;
            }
        }
        private void HandleAdd()
        {
            string checkResult = CheckParams();
            if (!string.IsNullOrEmpty(checkResult))
            {
                MessageBox.Show(checkResult);
                return;
            }

            var admin = _adminService.GetCurrentAdmin();
            if (admin == null)
            {
                MessageBox.Show("ورود غیر مجاز");
            }
            var options = GetOptions();

            var result = _userService.AddUser(NameBox.Text, FamilyBox.Text, NationalCodeBox.Text,
                BirthDateBox.PersianDate.ToString(), options, admin.Id);

            if (result)
            {
                MessageBox.Show("با موفقیت ثبت شد");
                Refresh();
            }

            else
                MessageBox.Show("این کد ملی قبلا استفاده شده است.");
        }

        private void UserSignUpButton_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                HandleAdd();
            }
            else
            {
                HandleUpdate();
            }
        }

    }
}
