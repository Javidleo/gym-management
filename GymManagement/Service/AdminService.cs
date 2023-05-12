using GymManagement.DataSource;
using GymManagement.Model;
using System;
using System.Linq;

namespace GymManagement.Service
{
    public class AdminService
    {
        private readonly GymContext _context;
        public AdminService()
        {
            _context = new GymContext();
        }

        public Admin GetCurrentAdmin()
        {
           return _context.Admins.FirstOrDefault(i => i.IsActive == true);
        }
        public bool AddAdmin(string name, string family, string userName,string nationalCode,
            string birthDate, string password)
        {
            bool doesExist = _context.Admins.Any(i => i.UserName == userName);
            if (doesExist)
            {
                return false;
            }

            var admin = new Admin()
            {
                Name = name,
                Family = family,
                UserName = userName,
                NationalCode = nationalCode,
                BirthDate = birthDate,
                Password = password,
                CreateDate = DateTime.Now,
            };

            _context.Admins.Add(admin);
            _context.SaveChanges();
            return true;
        }

        public bool Login(string username, string password)
        {
            var admin = _context.Admins.FirstOrDefault(i=> i.UserName == username);
            if (admin == null)
                return false;

            if (admin.Password != password)
                return false;

            return true;
        }


    }
}
