﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Word10: WordGeneration
    {
        private static WordGeneration instance;

        private Word10(string generationName, GuiComponentFactory componentFactory)
        {
            this.generationName = generationName;
            this.componentFactory = componentFactory;

            panel = componentFactory.createPanel();
            button = componentFactory.createButton();
            textBox = componentFactory.createTextBox();
        }

        public static WordGeneration getInstance(string generationName, GuiComponentFactory componentFactory)
        {
            if (instance == null)
            {
                instance = new Word10(generationName, componentFactory);
            }

            return instance;
        }
    }
}
