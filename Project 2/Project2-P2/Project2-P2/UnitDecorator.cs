using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_P2
{
    class UnitDecorator: FormatDecorator
    {
        Length.Units unitsToConvertTo;

        public UnitDecorator(string value, Length.Units unitsToConvertTo)
        {
            this.value = value;
            this.unitsToConvertTo = unitsToConvertTo;
        }

        public override string Format()
        {
            return value + " " + unitsToConvertTo.ToString();
        }
    }
}
