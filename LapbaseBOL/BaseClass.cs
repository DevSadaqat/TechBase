using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapbaseBOL
{
    public class BaseClass
    {
        public DateTime CreatedAt { get; set; }
        public String CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public String ModifiedBy { get; set; }
    }
}
