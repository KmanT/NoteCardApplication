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
        public string createExistingFileName(string fileName)
        {
            return CardWriter.CARD_COL_FILEPATH + "\\" + fileName;
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

                    }
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File '" + fileName + "' does not exist.",
                    "File not found exception.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


}
