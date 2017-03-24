using Server.Models;

namespace Models
{
    public class Problem
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public ApplicationUser User { get; set; }
    }
}