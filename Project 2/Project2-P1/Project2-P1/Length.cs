using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_P1
{
    abstract class Length
    {
        public enum Units { None, Kilometers, Miles, Yards, Feet };
        protected Length successor;

        public void SetSuccessor(Length successor)
        {
            this.successor = successor;
        }

        public abstract string HandleRequest(Units unitsToConvertTo);
    }
}
