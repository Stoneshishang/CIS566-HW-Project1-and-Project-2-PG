using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Word90GuiComponentFactory: GuiComponentFactory
    {
        static private GuiComponentFactory instance;

        private Word90GuiComponentFactory()
        {
        }

        static public GuiComponentFactory getInstance()
        {
            if (instance == null)
            {
                instance = new Word90GuiComponentFactory();
            }

            return instance;
        }

        public override Panel createPanel()
        {
            return new Word90Panel();
        }

        public override Button createButton()
        {
            return new Word90Button();
        }

        public override TextBox createTextBox()
        {
            return new Word90TextBox();
        }
    }
}
