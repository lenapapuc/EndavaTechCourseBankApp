using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankApplicationDomain.Models
{
    public class Wallet : Common.BaseEntity

    {
        public String Type { get; set; }
        public Currency Currency { get; set; }
        public decimal Amount { get; set; }
        
    }
}
