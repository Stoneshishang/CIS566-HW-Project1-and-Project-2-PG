using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_P2
{
    class Yards : Length
    {
        private string value;

        public Yards(string value)
        {
            this.value = value;
        }

        public override string HandleRequest(Units unitsToConvertTo)
        {
            double numValue = 0;

            if (double.TryParse(value, out numValue))
            {
                if (unitsToConvertTo == Units.Yards)
                {
                    return (numValue * 1093.61).ToString();
                }
                else if (successor != null)
                {
                    return successor.HandleRequest(unitsToConvertTo);
                }
            }

            return value;
        }
    }
}
