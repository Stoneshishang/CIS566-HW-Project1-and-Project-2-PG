using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_P1
{
    class Miles: Length
    {
        private string value;

        public Miles(string value)
        {
            this.value = value;
        }

        public override string HandleRequest(Units unitsToConvertTo)
        {
            double numValue = 0;

            if (double.TryParse(value, out numValue))
            {
                if (unitsToConvertTo == Units.Miles)
                {
                    return (numValue * 0.621371).ToString();
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
