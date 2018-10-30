using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteCardApplication
{
    public partial class ViewDeck : Form
    {
        private CardReader reader;

        public ViewDeck()
        {
            InitializeComponent();
            reader = new CardReader();
            
            
        }

        public ViewDeck(string fileName)
        {
            InitializeComponent();
            reader = new CardReader();
            reader.readCollection(fileName);

            foreach (Card card in reader.getCardList())
            {
                Console.WriteLine(card.getFrontText() + " " + card.getBackText());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectDeckForm sd = new SelectDeckForm();
            sd.ShowDialog();
            this.Close();
        }
    }
}
