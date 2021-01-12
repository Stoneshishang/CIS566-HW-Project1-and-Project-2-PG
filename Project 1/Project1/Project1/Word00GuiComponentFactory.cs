using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Word00GuiComponentFactory:GuiComponentFactory
    {
        static private GuiComponentFactory instance;

        private Word00GuiComponentFactory()
        {
        }

        static public GuiComponentFactory getInstance()
        {
            if (instance == null)
            {
                instance = new Word00GuiComponentFactory();
            }

            return instance;
        }

        public override Panel createPanel()
        {
            return new Word00Panel();
        }

        public override Button createButton()
        {
            return new Word00Button();
        }

        public override TextBox createTextBox()
        {
            return new Word00TextBox();
        }
    }
}
