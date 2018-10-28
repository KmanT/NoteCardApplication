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
            this.SuspendLayout();
            // 
            // btnNewCards
            // 
            this.btnNewCards.Location = new System.Drawing.Point(211, 43);
            this.btnNewCards.Name = "btnNewCards";
            this.btnNewCards.Size = new System.Drawing.Size(142, 23);
            this.btnNewCards.TabIndex = 0;
            this.btnNewCards.Text = "Create New Cards";
            this.btnNewCards.UseVisualStyleBackColor = true;
            this.btnNewCards.Click += new System.EventHandler(this.btnNewCards_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(58, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(438, 31);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the Note Card Creator!";
            // 
            // btnViewCards
            // 
            this.btnViewCards.Location = new System.Drawing.Point(211, 72);
            this.btnViewCards.Name = "btnViewCards";
            this.btnViewCards.Size = new System.Drawing.Size(142, 23);
            this.btnViewCards.TabIndex = 2;
            this.btnViewCards.Text = "View Cards";
            this.btnViewCards.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(211, 101);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 177);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewCards);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnNewCards);
            this.Name = "Main";
            this.Text = "Note Card Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCards;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewCards;
        private System.Windows.Forms.Button btnExit;
    }
}

