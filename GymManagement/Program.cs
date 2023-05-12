using GymManagement.DataSource;
using GymManagement.Model;
using GymManagement.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GymManagement
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SeedData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        static void SeedData()
        {
            var _context = new GymContext();

            if (_context.InstallmentOptions.Any() == false)
            {
                _context.InstallmentOptions.AddRange(new List<InstallmentOption>
                {
                    new InstallmentOption
                    {
                        Price = 200000,
                        Title = "monthly",
                        Tag = OptionTag.Period
                    },
                    new InstallmentOption
                    {
                        Price = 300000,
                        Title = "twoMonth",
                        Tag = OptionTag.Period
                    },
                     new InstallmentOption
                    {
                        Price = 450000,
                        Title = "threeMonth",
                        Tag = OptionTag.Period
                    },
                      new InstallmentOption
                    {
                        Price = 800000,
                        Title = "sixMonth",
                        Tag = OptionTag.Period
                    },
                    new InstallmentOption
                    {
                        Price = 50000,
                        Title = "everyDay",
                        Tag = OptionTag.Option
                    },
                    new InstallmentOption
                    {
                        Price = 10000,
                        Title = "threeDays",
                        Tag = OptionTag.Option
                    },
                });
                _context.SaveChanges();
            }

            if (_context.Admins.Any() == false)
            {
                _context.Admins.Add(new Admin
                {
                    Name = "reza",
                    Family = "rezaie",
                    BirthDate = DateTime.Now.AddYears(-23).ToPersianDate(),
                    CreateDate = DateTime.Now,
                    IsActive = true,
                    NationalCode = "4455667788",
                    Password = "admin123",
                    UserName = "admin"
                });
                _context.SaveChanges();
            }

            if (_context.Users.Any() == false)
            {
                _context.Users.AddRange(new List<User>
                {
                    new User
                    {
                        Name = "zahra",
                        Family = "ahmadi",
                        BirthDate = DateTime.Now.AddYears(-20).ToPersianDate(),
                        CreateDate = DateTime.Now,
                        DurationStart = DateTime.Now,
                        DurationEnd = DateTime.Now.AddMonths(-1),
                        AdminId = 1,
                        PeriodOption = _context.InstallmentOptions.First(i=> i.Tag== OptionTag.Option),
                        Option = _context.InstallmentOptions.First(i=> i.Tag== OptionTag.Period)
                    },
                    new User
                    {
                        Name = "navid",
                        Family = "rezaie",
                        BirthDate = DateTime.Now.AddYears(-21).ToPersianDate(),
                        CreateDate = DateTime.Now,
                        DurationStart = DateTime.Now,
                        DurationEnd = DateTime.Now.AddMonths(1),
                        AdminId = 1,
                         PeriodOption = _context.InstallmentOptions.First(i=> i.Tag== OptionTag.Option),
                        Option = _context.InstallmentOptions.First(i=> i.Tag== OptionTag.Period),
                        NationalCode = "1234567890"
                    },
                });
                _context.SaveChanges();
            }

            
        }
    }
}
