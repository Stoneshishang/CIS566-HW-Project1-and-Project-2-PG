using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class GuiComponentFactory
    {
        public abstract Panel createPanel();
        public abstract Button createButton();
        public abstract TextBox createTextBox();
    }
}
