using System;
using System.Collections.Generic;

namespace Domain
{
    public class Teams
    {
        public string TeamName { get; set; }
        public string LogoURL { get; set; }
        public virtual ICollection<Players> Players { get; set; }
  }
}