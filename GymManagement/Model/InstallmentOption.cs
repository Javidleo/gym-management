using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GymManagement.Model
{
    public class InstallmentOption
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public OptionTag Tag { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public virtual List<User> PeriodUsers { get; set; }
        public virtual List<User> OptionUser { get; set; }

    }

    public enum OptionTag
    {
        Period = 1,
        Option = 2
    }
}