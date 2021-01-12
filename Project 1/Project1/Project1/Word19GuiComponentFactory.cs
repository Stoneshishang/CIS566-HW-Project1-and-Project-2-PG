using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Word19GuiComponentFactory:GuiComponentFactory
    {
        static private GuiComponentFactory instance;

        private Word19GuiComponentFactory()
        {
        }

        static public GuiComponentFactory getInstance()
        {
            if (instance == null)
            {
                instance = new Word19GuiComponentFactory();
            }

            return instance;
        }

        public override Panel createPanel()
        {
            return new Word19Panel();
        }

        public override Button createButton()
        {
            return new Word19Button();
        }

        public override TextBox createTextBox()
        {
            return new Word19TextBox();
        }
    }
}
