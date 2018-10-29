using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCardApplication
{
    class Card
    {
        private string frontText;
        private string backText;

        public Card()
        {
            frontText = "";
            backText = "";
        }

        public Card(string front, string back)
        {
            this.frontText = front;
            this.backText = back;
        }

        public void setFrontText(string text)
        {
            frontText = text;
        }

        public string getFrontText()
        {
            return frontText;
        }

        public void setBackText(string text)
        {
            backText = text;
        }

        public string getBackText()
        {
            return backText;
        }
    }
}
