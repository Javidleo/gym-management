using GymManagement.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GymManagement.Tools
{
    public static class DateConverter
    {
        public static string ToPersianDate(this DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();

            return string.Format("{0}/{1}/{2}", calendar.GetYear(date),
                calendar.GetMonth(date), calendar.GetDayOfMonth(date));
        }

        public static DateTime ToGregorianDate(this string persianDate)
        {
            var data = persianDate.Split('/');
            int year = int.Parse(data[0]);
            int month = int.Parse(data[1]);
            int day = int.Parse(data[2]);
            var persianCalender = new PersianCalendar();


            var date = new DateTime(year, month, day, persianCalender);
            return date;
        }

    }

    public static class Helper
    {

        public static Dictionary<string, string> OptionsDictionary = new Dictionary<string, string>()
        {
            {"monthly" ,"ماهانه"},
            {"twoMonth" ,"دوماهه"},
            {"threeMonth" ,"سه ماهه"},
            {"sixMonth" ,"شش ماهه"},
            {"everyDay" ,"هر روز"},
            {"threeDays" ,"سه روز در هفته"},
            {"cardio" ,"هوازی"},
            {"privateCoutch" ,"مربی شخصی"}
        };

        public static Dictionary<string, string> OptionsReverseDictionary = new Dictionary<string, string>()
        {
            {"ماهانه","monthly" },
            {"دوماهه","twoMonth" },
            {"سه ماهه","threeMonth"},
            {"شش ماهه","sixMonth" },
            {"هر روز","everyDay"},
            {"سه روز در هفته","threeDays"},
            {"هوازی","cardio"},
            {"مربی شخصی","privateCoutch"}
        };


        public static string ExtractInstallment(InstallmentOption period, InstallmentOption option)
        {
            StringBuilder stringBuilder = new StringBuilder();

            OptionsDictionary.TryGetValue(period.Title, out var periodTitle);
            stringBuilder.Append(periodTitle);

            OptionsDictionary.TryGetValue(option.Title, out var optionTitle);

            stringBuilder.Append("/").Append(optionTitle);

            return stringBuilder.ToString();
        }
    }
}
