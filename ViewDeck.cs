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
        public ViewDeck()
        {
            InitializeComponent();
        }

        public ViewDeck(string[] deck)
        {
            InitializeComponent();

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
