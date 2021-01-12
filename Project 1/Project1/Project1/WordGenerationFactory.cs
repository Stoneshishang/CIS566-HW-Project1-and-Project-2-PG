using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    static class WordGenerationFactory
    {
        public static WordGeneration GetGui(string generationName)
        {
            WordGeneration app = null;
            switch (generationName.ToLower())
            {
                case "word90":
                    app = Word90.getInstance(generationName, Word90GuiComponentFactory.getInstance());
                    break;

                case "word00":
                    app = Word00.getInstance(generationName, Word00GuiComponentFactory.getInstance());
                    break;

                case "word10":
                    app = Word10.getInstance(generationName, Word10GuiComponentFactory.getInstance());
                    break;

                case "word19":
                    app = Word19.getInstance(generationName, Word19GuiComponentFactory.getInstance());
                    break;
            }

            return app;
        }
    }
}
