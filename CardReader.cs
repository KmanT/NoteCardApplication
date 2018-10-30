using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace NoteCardApplication
{
    class CardReader
    {
        private string collectionName;
        private LinkedList<Card> cardList;

        public CardReader()
        {
            collectionName = "";
            cardList = new LinkedList<Card>();
        }


        public string createExistingFileName(string fileName)
        {
            return CardWriter.CARD_COL_FILEPATH + "\\" + fileName;
        }

        public LinkedList<Card> getCardList()
        {
            return cardList;
        }

        public void readCollection(string fileName)
        {
            fileName = createExistingFileName(fileName);
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string fileLine;
                        while ((fileLine = streamReader.ReadLine()) != null)
                        {
                            fileLine = streamReader.ReadLine();
                            
                            string[] args = fileLine.Split('|');

                            cardList.AddLast(new Card(args[0], args[1]));
                        }

                        streamReader.Close();
                    }
                }

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory for '" + fileName + "' was not found.",
                    "Directory not found exception.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File '" + fileName + "' does not exist.",
                    "File not found exception.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}