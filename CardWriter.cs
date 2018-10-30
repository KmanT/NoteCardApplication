using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoteCardApplication
{
    class CardWriter
    {
        public const string CARD_COL_FILEPATH = "C:\\Users\\Kyle\\Source\\Repos\\" +
            "NoteCardApplication\\NoteCardApplication\\CardCollections";

        private string collectionName;
        private LinkedList<Card> cardList;

        public CardWriter()
        {
            collectionName = "";
            cardList = new LinkedList<Card>();
        }

        public CardWriter(string collectionName)
        {
            this.collectionName = collectionName;
            cardList = new LinkedList<Card>();
        }

        public void addCard(Card card)
        {
            cardList.AddLast(card);
        }

        public Card readCard(int index)
        {
            return cardList.ElementAt<Card>(index);
        }

        public string createNewFileName(string fileName)
        {
            return CARD_COL_FILEPATH + "\\" + fileName + ".txt";
        }

        public void writeCard(System.IO.StreamWriter streamWriter, int index)
        {
            try
            {
                string writeLine = cardList.ElementAt<Card>(index).getFrontText();
                writeLine += "|" + cardList.ElementAt<Card>(index).getBackText();

                streamWriter.WriteLine(writeLine);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("That element in the list doesn't exist", "Index out of range " +
                    "exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("That element in the list doesn't exist", "Arguement out of range " +
                    "exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("That element in the list doesn't exist", "Null Reference " +
                    "exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void writeCollection(string fileName)
        {
            fileName = createNewFileName(fileName);
            using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    for (int i = 0; i < cardList.Count; i++)
                    {
                        writeCard(streamWriter, i);
                    }
                    streamWriter.Close();
                }
            }
        }

    }
}
