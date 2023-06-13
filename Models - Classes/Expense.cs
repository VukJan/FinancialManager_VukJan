using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager_VukJan.Models___Classes
{
    public class Expense
    {              
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public DateTime DateTime { get; set; }

            public bool Needed { get; set; }    

    }
}
