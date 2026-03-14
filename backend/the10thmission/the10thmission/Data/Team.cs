using System.ComponentModel.DataAnnotations;
namespace the10thmission.Data
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        [Required]
        public string TeamName { get; set; }

        public int? CaptainID { get; set; }

        public virtual ICollection<BowlerInfo> Bowlers { get; set; } =new List<BowlerInfo>();
    }
}
