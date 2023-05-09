using GymManagement.Model;
using GymManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GymManagement
{
    public partial class Users_UserControl : UserControl
    {
        private readonly UserService _userService = new UserService();
        private readonly SettingService _settingService = new SettingService();
        private readonly AdminService _adminService = new AdminService();
        public Users_UserControl()
        {
            InitializeComponent();
        }

        private string CheckParams()
        {
            if (string.IsNullOrEmpty(NameBox.Text) ||
                string.IsNullOrEmpty(FamilyBox.Text) ||
                string.IsNullOrEmpty(NationalCodeBox.Text) ||
                string.IsNullOrEmpty(BirthDateBox.Text))
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

            if (PrivateCoutchCheck.Checked == false &&
                CardioCheck.Checked == false &&
                EveryDayCheck.Checked == false &&
                ThreeDaysCheck.Checked == false)
            {
                return "حداقل یک اپشن ثبت نام وارد کنید.";
            }

            return "";
        }

        private void UserSignUp_Click(object sender, EventArgs e)
        {
            string checkResult = CheckParams();
            if (!string.IsNullOrEmpty(checkResult))
            {
                MessageBox.Show(checkResult);
            }

            var admin = _adminService.GetCurrentAdmin();
            if (admin == null)
            {
                MessageBox.Show("ورود غیر مجاز");
            }

            var options = GetOptions();

           var result =  _userService.AddUser(NameBox.Text, FamilyBox.Text, NationalCodeBox.Text, BirthDateBox.Value.Value,
                options, admin.Id);

           if (result)
               MessageBox.Show("با موفقیت ثبت شد");

           else
               MessageBox.Show("این کد ملی قبلا استفاده شده است.");

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

            if (CardioCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "cardio"));

            if (PrivateCoutchCheck.Checked == false)
                options.Remove(options.First(i => i.Title == "privateCoutch"));

            return options;
        }
    }
}
