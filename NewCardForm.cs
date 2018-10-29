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
    public partial class NewCardForm : Form
    {
        private CardWriter cardWriter;

        public NewCardForm()
        {
            InitializeComponent();
            cardWriter = new CardWriter();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main frmMain = new Main();
            frmMain.ShowDialog();
            this.Close();
        }

        private void btnCreateCollection_Click(object sender, EventArgs e)
        {
            if (Validator.isEmpty(txtCollectionName.Name, txtCollectionName.Text) == false)
            {
                cardWriter.writeCollection(txtCollectionName.Text);
            }            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            cardWriter.addCard(new Card(txtFront.Text, rtxtBack.Text));
            txtFront.Clear();
            rtxtBack.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFront.Clear();
            rtxtBack.Clear();
        }
    }
}
