using DocumentFormat.OpenXml.Drawing.Charts;
using GymManagement.DataSource;
using GymManagement.Model;
using GymManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace GymManagement.Service
{
    public class UserService
    {
        private readonly GymContext _context;
        public UserService()
        {
            _context = new GymContext();
        }
        public bool AddUser(string name, string family, string nationalCode, string birthDate,
            List<InstallmentOption> options, int adminId)
        {
            if (_context.Users.Any(i => i.NationalCode == nationalCode))
                return false;

            var periodOption = options.FirstOrDefault(i => i.Tag == OptionTag.Period);

            var option = options.FirstOrDefault(i => i.Tag == OptionTag.Option);

            double price = periodOption.Price + option.Price;

            var user = new User
            {
                AdminId = adminId,
                Name = name,
                Family = family,
                PeriodId = periodOption.Id,
                OptionId = option.Id,
                CreateDate = DateTime.Now,
                NationalCode = nationalCode,
                BirthDate = birthDate,
                DurationStart = DateTime.Now,
                DurationEnd = CalculateDuration(periodOption),
                Transactions = new List<Transaction>
                {
                    new Transaction
                    {
                        AdminId = adminId,
                        Price = price,
                        Description = "پرداخت شهریه",
                        Time = DateTime.Now,
                    }
                }
            };
            _context.Users.Add(user);

            _context.SaveChanges();

            return true;
        }

        public DateTime CalculateDuration(InstallmentOption option)
        {
            switch (option.Title)
            {
                case "monthly":
                    return DateTime.Now.AddMonths(1);

                case "twoMonth":
                    return DateTime.Now.AddMonths(2);

                case "threeMonth":
                    return DateTime.Now.AddMonths(3);

                case "sixMonth":
                    return DateTime.Now.AddMonths(6);

                default:
                    return DateTime.Now.AddMonths(1);
            }
        }

        public void RemoveUser(int Id)
        {
            var user = _context.Users.Find(Id);
            if (user == null)
                return;

            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        //public void UpdateUser(int id, string name, string family, List<InstallmentOption> options, int adminId)
        //{
        //    var user = _context.Users.Find(id);

        //    if (user == null) return;

        //    user.Name = name;
        //    user.Family = family;
        //    user.Installments = options;
        //    user.CreateDate = DateTime.Now;
        //    user.AdminId = adminId;

        //    _context.Users.AddOrUpdate(user);
        //    _context.SaveChanges();
        //}

        public User FindUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return null;

            return user;
        }

        public List<User> GetUserList()
        {
            return _context.Users.ToList();
        }

        public bool ChargeAccount(int id, DateTime start, DateTime end, List<InstallmentOption> options, int adminId)
        {
            var user = _context.Users.FirstOrDefault(i => i.Id == id);
            if (user == null) return false;

            var period = options.FirstOrDefault(i => i.Tag == OptionTag.Period);
            var option = options.FirstOrDefault(i => i.Tag == OptionTag.Option);

            user.DurationStart = start;
            user.DurationEnd = end;
            user.AdminId = adminId;
            user.PeriodId = period.Id;
            user.OptionId = option.Id;

            _context.Users.AddOrUpdate(user);

            var transaction = new Transaction
            {
                AdminId = adminId,
                UserId = id,
                Price = options.Sum(i => i.Price),
                Description = "باز تمدید شهریه",
                Time = DateTime.Now,
            };

            _context.Transactions.Add(transaction);

            _context.SaveChanges();

            return true;
        }


    }
}
