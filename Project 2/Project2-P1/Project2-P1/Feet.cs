using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_P1
{
    class Feet : Length
    {
        private string value;

        public Feet(string value)
        {
            this.value = value;
        }

        public override string HandleRequest(Units unitsToConvertTo)
        {
            double numValue = 0;

            if (double.TryParse(value, out numValue))
            {
                if (unitsToConvertTo == Units.Feet)
                {
                    return (numValue * 3280.84).ToString();
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
