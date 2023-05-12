using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagement.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public DateTime CreateDate { get; set; }

        public string NationalCode { get; set; }

        public string BirthDate { get; set; }


        public DateTime DurationStart { get; set; }

        public DateTime DurationEnd { get; set; }

        public int AdminId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }

        public int PeriodId { get; set; }
        public virtual InstallmentOption PeriodOption { get; set; }

        public int OptionId { get; set; }
        public virtual InstallmentOption Option { get; set; }

        public virtual List<Transaction> Transactions { get; set; }
    }
}
