namespace NoteCardApplication
{
    partial class SelectDeckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDecks = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewDeck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDecks
            // 
            this.cmbDecks.FormattingEnabled = true;
            this.cmbDecks.Location = new System.Drawing.Point(59, 54);
            this.cmbDecks.Name = "cmbDecks";
            this.cmbDecks.Size = new System.Drawing.Size(206, 24);
            this.cmbDecks.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(22, 106);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewDeck
            // 
            this.btnViewDeck.Location = new System.Drawing.Point(217, 106);
            this.btnViewDeck.Name = "btnViewDeck";
            this.btnViewDeck.Size = new System.Drawing.Size(100, 23);
            this.btnViewDeck.TabIndex = 2;
            this.btnViewDeck.Text = "View Deck";
            this.btnViewDeck.UseVisualStyleBackColor = true;
            this.btnViewDeck.Click += new System.EventHandler(this.btnViewDeck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the deck you want to view.";
            // 
            // SelectDeckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(338, 165);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewDeck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbDecks);
            this.Name = "SelectDeckForm";
            this.Text = "Select Flash Card Deck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDecks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewDeck;
        private System.Windows.Forms.Label label1;
    }
}