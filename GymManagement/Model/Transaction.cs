using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagement.Model
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public int AdminId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

    }
}
