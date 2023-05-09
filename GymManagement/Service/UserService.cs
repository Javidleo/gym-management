using GymManagement.DataSource;
using GymManagement.Model;
using System;
using System.Collections.Generic;
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
        public bool AddUser(string name, string family, string nationalCode, DateTime birthDate,
            List<InstallmentOption> options, int adminId)
        {
            if (_context.Users.Any(i => i.NationalCode == nationalCode))
                return false;

            double price = options.Sum(option => option.Price);

            var user = new User
            {
                Name = name,
                Family = family,
                Installments = options,
                CreateDate = DateTime.Now,
                NationalCode = nationalCode,
                BirthDate = birthDate,
                DurationStart = DateTime.Now,
                DurationEnd = CalculateDuration(options),
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

        private DateTime CalculateDuration(List<InstallmentOption> options)
        {
            var periodOptions = options.FirstOrDefault(i => i.Tag == OptionTag.Period);
            switch (periodOptions.Title)
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

        public void UpdateUser(int id, string name, string family, List<InstallmentOption> options, int adminId)
        {
            var user = _context.Users.Find(id);

            if (user == null) return;

            user.Name = name;
            user.Family = family;
            user.Installments = options;
            user.CreateDate = DateTime.Now;
            user.AdminId = adminId;

            _context.Users.AddOrUpdate(user);
            _context.SaveChanges();
        }

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

        public void ChargeAccount(int id, DateTime start, DateTime end)
        {
            var user = _context.Users.Find(id);
            if (user == null) return;

            user.DurationStart = start;
            user.DurationEnd = end;

            _context.Users.AddOrUpdate(user);
            _context.SaveChanges();
        }


    }
}
