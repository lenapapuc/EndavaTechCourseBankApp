using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankApplicationDomain.Models
{
    public class Currency : Common.BaseEntity
    {
        public String Name { get; set; }
        public String CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}
