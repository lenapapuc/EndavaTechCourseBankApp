using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankApplicationDomain.Models
{
    public class Transaction : Common.BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public decimal Commission { get; set; }
        public Wallet SourceWallet { get; set; }
        public Wallet DestinationWallet { get; set; }
        public string TransactionStatus { get; set; }

    }
}
