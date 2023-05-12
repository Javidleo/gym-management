using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagement.Model
{
    public class AdminActivity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public int AdminId { get; set; }

        [ForeignKey("AdminId")]
        public virtual Admin Admin { get; set; }
    }
}