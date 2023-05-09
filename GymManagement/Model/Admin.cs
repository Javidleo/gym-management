using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace GymManagement.Model
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public string Family { get; set; }
        
        public string UserName { get; set; }
        public string Password { get; set; }
        
        public DateTime CreateDate { get; set; }

        public virtual List<User> Users { get; set; }

        public virtual List<AdminActivity> Activity { get;set; }

        public virtual List<Transaction> Transactions { get; set; }
    }
}