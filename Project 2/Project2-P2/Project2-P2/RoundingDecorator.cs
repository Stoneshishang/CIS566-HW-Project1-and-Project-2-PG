using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_P2
{
    class RoundingDecorator : FormatDecorator
    {  
        public RoundingDecorator(string value)
        {
            this.value = value;
        }

        public override string Format()
        {
            double numberValue = 0;
            if (double.TryParse(value, out numberValue))
            {
                numberValue = Math.Round(numberValue, 2, MidpointRounding.AwayFromZero);
                return numberValue.ToString();
            }

            return value;
        }
    }
}
