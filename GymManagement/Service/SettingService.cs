using System.Collections.Generic;
using GymManagement.DataSource;
using GymManagement.Model;
using System.Data.Entity.Migrations;
using System.Linq;

namespace GymManagement.Service
{
    public class SettingService
    {
        private readonly GymContext _context;
        public SettingService()
        {
            _context = new GymContext();
        }

        public List<InstallmentOption> GetAll()
        {
            return _context.InstallmentOptions.ToList();
        }

        public void AddSetting(string name, double price, string description)
        {
            var option = new InstallmentOption
            {
                Description = description,
                Title = name,
                Price = price,
            };

            _context.InstallmentOptions.Add(option);
            _context.SaveChanges();
        }

        public bool UpdateSetting(string name, double price, string description)
        {
            var option = _context.InstallmentOptions.FirstOrDefault(i => i.Title == name);
            if (option == null)
            {
                return false;
            }

            option.Description = description;
            option.Title = name;
            option.Price = price;

            _context.InstallmentOptions.AddOrUpdate(option);
            _context.SaveChanges();
            return true;
        }

        public void RemoveSetting(int id)
        {
            var option = _context.InstallmentOptions.First(i => i.Id == id);
            if (option == null)
            {
                return;
            }

            _context.InstallmentOptions.Remove(option);
            _context.SaveChanges();
        }
    }
}
