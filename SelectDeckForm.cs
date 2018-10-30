using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NoteCardApplication
{
    public partial class SelectDeckForm : Form
    {

        private string[] directoryEntries;


        public SelectDeckForm()
        {
            InitializeComponent();
            fillCmbDecks(CardWriter.CARD_COL_FILEPATH);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frmMain = new Main();
            frmMain.ShowDialog();
            this.Close();
        }

        private void fillCmbDecks(string dirPath)
        {
            try
            {
                directoryEntries = Directory.GetFiles(dirPath);

                foreach (String deck in directoryEntries)
                {
                    string deckItem = deck.Substring(dirPath.Length + 1);
                    cmbDecks.Items.Add(deckItem);
                }
            } catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found.", "DirectoryNotFoundException",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnViewDeck_Click(object sender, EventArgs e)
        {
            string filePath = cmbDecks.GetItemText(cmbDecks.SelectedItem);


            this.Hide();

            ViewDeck vd = new ViewDeck(filePath);
            vd.ShowDialog();
            this.Close();
        }
    }
}
