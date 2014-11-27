using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNODeal
{
    class Case 
    {
        public Case (int value, Boolean status )
        {
            Value = value;
            Status = status;
        }


        public int Value { get; set; }

        public bool Status { get; set; } 



        public override string ToString()
        {
            if (Value<1000)
            {
                return (String.Format("{0:###}", Value) + " kr "); 

            }
            else if (Value < 1000000)
            {
                return (String.Format("{0:# ###}", Value) + " kr");

            }
            else
            {
                return (String.Format("{00:# ### ###}", Value) + " kr");
            }

        }
    }
}
