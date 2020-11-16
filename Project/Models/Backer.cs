using System;
using System.Collections.Generic;
using System.Text;

namespace Crowfund.Models
{
    public class Backer
    { 
        public int Id { get; set; }
        public string Username { get; set; }
        public decimal Wallet { get; set; }
        public string Email { get; set; }
        public Boolean IsActive { get; set; }
        public List<SuppProjects> Project { get; set; }
        public string Tag { get; set; }
        public string Cart { get set; }
    }
}
