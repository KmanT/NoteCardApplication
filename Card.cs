using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCardApplication
{
    class Card
    {
        private int cardID;
        private string frontText;
        private string backText;

        public Card()
        {
            cardID = 0;
            frontText = "";
            backText = "";
        }

        public Card(int cardID)
        {
            this.cardID = cardID;
            frontText = "";
            backText = "";
        }

        public int getCardID()
        {
            return cardID;
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
