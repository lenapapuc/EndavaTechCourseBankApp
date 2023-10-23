using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankApplicationDomain.Models
{
    public class Report : Common.BaseEntity
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Transaction> TransactionList { get; set; }
        public decimal ReceivedAmount { get; set; }
        public decimal SpentAmount { get; set; }
        public decimal EndBalance { get; set; }
    }
}
