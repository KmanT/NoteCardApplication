namespace NoteCardApplication
{
    partial class Main
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
            this.btnNewCards = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewCards = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCards
            // 
            this.btnNewCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCards.Location = new System.Drawing.Point(172, 64);
            this.btnNewCards.Name = "btnNewCards";
            this.btnNewCards.Size = new System.Drawing.Size(142, 23);
            this.btnNewCards.TabIndex = 0;
            this.btnNewCards.Text = "Create New Cards";
            this.btnNewCards.UseVisualStyleBackColor = true;
            this.btnNewCards.Click += new System.EventHandler(this.btnNewCards_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(17, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(438, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the Note Card Creator!";
            // 
            // btnViewCards
            // 
            this.btnViewCards.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewCards.Location = new System.Drawing.Point(172, 93);
            this.btnViewCards.Name = "btnViewCards";
            this.btnViewCards.Size = new System.Drawing.Size(142, 23);
            this.btnViewCards.TabIndex = 2;
            this.btnViewCards.Text = "View Cards";
            this.btnViewCards.UseVisualStyleBackColor = true;
            this.btnViewCards.Click += new System.EventHandler(this.btnViewCards_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(172, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnNewCards);
            this.panel1.Controls.Add(this.btnViewCards);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 184);
            this.panel1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(515, 184);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Note Card Creator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCards;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewCards;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}

