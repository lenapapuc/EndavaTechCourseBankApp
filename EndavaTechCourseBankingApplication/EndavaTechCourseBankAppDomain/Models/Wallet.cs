using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankAppDomain.Models
{
    internal class Wallet : Common.BaseEntity

    {
        public String Name { get; set; }
        public String Currency { get; set; }
        public double Balance { get; set; }
      
        
    }
}
