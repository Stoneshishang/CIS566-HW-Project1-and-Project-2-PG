using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Project2_P2
{
    class ExponentDecorator : FormatDecorator
    {
        public ExponentDecorator(string value)
        {
            this.value = value;
        }

        public override string Format()
        {
            // Find decimal position and remove it.
            int decimalIndex = value.IndexOf('.');
            if (decimalIndex > -1)
            {
                value = value.Remove(decimalIndex, 1);
            }

            if (value[0] != '0')
            {
                if (decimalIndex > 0)
                {
                    // Calculate how many places to the left the decimal must move
                    int numberOfDecimalMoves = decimalIndex - 1;

                    if (numberOfDecimalMoves >= 0)
                    {
                        // Format the string into positive exponent notation
                        value = value.Insert(1, ".");
                        return value.Insert(value.Length, "e" + numberOfDecimalMoves.ToString());
                    }
                }
            }
            else
            {
                // Calculate how many places to the right the decimal must move
                while (decimalIndex < value.Length)
                {
                    if (value[decimalIndex] != '0')
                    {
                        break;
                    }
                    else
                    {
                        decimalIndex++;
                    }
                }

                // Remove leading zeros
                value = value.Remove(0, decimalIndex);

                // Format the string into negative exponent notation
                value = value.Insert(1, ".");
                return value.Insert(value.Length, "e-" + decimalIndex.ToString());
            }

            return value;
        }
    }
}