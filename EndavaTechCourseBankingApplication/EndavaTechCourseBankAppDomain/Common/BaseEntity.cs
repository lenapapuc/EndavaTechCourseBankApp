using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndavaTechCourseBankAppDomain.Common
{
    internal class BaseEntity
    {
        public Guid Id { get;} = Guid.NewGuid();
        public DateTime TimeStamp { get;} = DateTime.Now;
    }
}
