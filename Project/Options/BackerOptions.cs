using System;
using System.Collections.Generic;
using System.Text;

namespace Crowfund.Options
{
   public class BackerOptions
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public decimal Wallet { get; set; }
        public string Email { get; set; }
        public Boolean IsActive { get; set; }
        public string Tag { get; set; }
    }
}
