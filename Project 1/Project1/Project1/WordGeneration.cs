using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class WordGeneration
    {
        protected string generationName;
        protected GuiComponentFactory componentFactory;
        protected byte numberOfRuns = 0;
        protected const byte MaxRunsAllowed = 2;

        protected Panel panel;
        protected Button button;
        protected TextBox textBox;

        public void testGui()
        {
            // Tests only allowed to run a fixed number of times!
            if (numberOfRuns == MaxRunsAllowed)
            {
                Console.Write("*** Warning: " + generationName + " tests have run twice already! ***");
                return;
            }

            panel.draw();
            Console.Write(", ");
            button.draw();
            Console.Write(", ");
            textBox.draw();

            numberOfRuns++;
        }
    }
}
