using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Word10GuiComponentFactory:GuiComponentFactory
    {
        static private GuiComponentFactory instance;

        private Word10GuiComponentFactory()
        {
        }

        static public GuiComponentFactory getInstance()
        {
            if (instance == null)
            {
                instance = new Word10GuiComponentFactory();
            }

            return instance;
        }

        public override Panel createPanel()
        {
            return new Word10Panel();
        }

        public override Button createButton()
        {
            return new Word10Button();
        }

        public override TextBox createTextBox()
        {
            return new Word10TextBox();
        }
    }
}
