using System;
using Server.Models;

namespace Models
{
    public class Statistic
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ulong  Steps { get; set; }
        public ApplicationUser User { get; set; }
    }
}