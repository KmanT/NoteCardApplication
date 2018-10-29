namespace NoteCardApplication
{
    partial class NewCardForm
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
            this.txtCollectionName = new System.Windows.Forms.TextBox();
            this.lblColName = new System.Windows.Forms.Label();
            this.grpNewCard = new System.Windows.Forms.GroupBox();
            this.btnCreateCollection = new System.Windows.Forms.Button();
            this.txtFront = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtBack = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpNewCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCollectionName
            // 
            this.txtCollectionName.Location = new System.Drawing.Point(129, 12);
            this.txtCollectionName.Name = "txtCollectionName";
            this.txtCollectionName.Size = new System.Drawing.Size(163, 22);
            this.txtCollectionName.TabIndex = 0;
            // 
            // lblColName
            // 
            this.lblColName.AutoSize = true;
            this.lblColName.Location = new System.Drawing.Point(13, 17);
            this.lblColName.Name = "lblColName";
            this.lblColName.Size = new System.Drawing.Size(110, 17);
            this.lblColName.TabIndex = 1;
            this.lblColName.Text = "Collection Name";
            // 
            // grpNewCard
            // 
            this.grpNewCard.Controls.Add(this.btnClear);
            this.grpNewCard.Controls.Add(this.btnCreate);
            this.grpNewCard.Controls.Add(this.rtxtBack);
            this.grpNewCard.Controls.Add(this.label3);
            this.grpNewCard.Controls.Add(this.label2);
            this.grpNewCard.Controls.Add(this.txtFront);
            this.grpNewCard.Location = new System.Drawing.Point(16, 50);
            this.grpNewCard.Name = "grpNewCard";
            this.grpNewCard.Size = new System.Drawing.Size(440, 256);
            this.grpNewCard.TabIndex = 2;
            this.grpNewCard.TabStop = false;
            this.grpNewCard.Text = "New Card";
            // 
            // btnCreateCollection
            // 
            this.btnCreateCollection.Location = new System.Drawing.Point(12, 324);
            this.btnCreateCollection.Name = "btnCreateCollection";
            this.btnCreateCollection.Size = new System.Drawing.Size(148, 23);
            this.btnCreateCollection.TabIndex = 3;
            this.btnCreateCollection.Text = "Create Collection";
            this.btnCreateCollection.UseVisualStyleBackColor = true;
            this.btnCreateCollection.Click += new System.EventHandler(this.btnCreateCollection_Click);
            // 
            // txtFront
            // 
            this.txtFront.Location = new System.Drawing.Point(113, 47);
            this.txtFront.Name = "txtFront";
            this.txtFront.Size = new System.Drawing.Size(100, 22);
            this.txtFront.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Front Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Back Text";
            // 
            // rtxtBack
            // 
            this.rtxtBack.Location = new System.Drawing.Point(113, 89);
            this.rtxtBack.Name = "rtxtBack";
            this.rtxtBack.Size = new System.Drawing.Size(321, 115);
            this.rtxtBack.TabIndex = 3;
            this.rtxtBack.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 227);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Card";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(385, 324);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(359, 227);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // NewCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 359);
            this.Controls.Add(this.btnCreateCollection);
            this.Controls.Add(this.grpNewCard);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblColName);
            this.Controls.Add(this.txtCollectionName);
            this.Name = "NewCardForm";
            this.Text = "Create Cards";
            this.grpNewCard.ResumeLayout(false);
            this.grpNewCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCollectionName;
        private System.Windows.Forms.Label lblColName;
        private System.Windows.Forms.GroupBox grpNewCard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox rtxtBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFront;
        private System.Windows.Forms.Button btnCreateCollection;
    }
}