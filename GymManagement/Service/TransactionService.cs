using GymManagement.DataSource;
using GymManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.Service
{
    public class TransactionService
    {
        private readonly GymContext _context;
        public TransactionService()
        {
            _context = new GymContext();
        }

        public void AddTransaction(string description, int userId, int adminid, double price)
        {
            var transaction = new Transaction
            {
                Description = description,
                UserId = userId,
                AdminId = adminid,
                Price = price,
                Time = DateTime.Now,
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
    }
}
