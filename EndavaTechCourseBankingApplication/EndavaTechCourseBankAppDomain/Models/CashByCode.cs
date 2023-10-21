using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankApplicationDomain.Models
{
    public class CashByCode : Common.BaseEntity
    {
        public Wallet SourceWallet { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public decimal Commission { get; set; }
    }
}
