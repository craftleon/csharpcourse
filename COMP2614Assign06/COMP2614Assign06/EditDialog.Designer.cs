namespace COMP2614Assign06
{
    partial class EditDialog
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxComp = new System.Windows.Forms.TextBox();
            this.labelComp = new System.Windows.Forms.Label();
            this.textBoxAddr1 = new System.Windows.Forms.TextBox();
            this.labelAddr1 = new System.Windows.Forms.Label();
            this.textBoxAddr2 = new System.Windows.Forms.TextBox();
            this.labelAddr2 = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxProv = new System.Windows.Forms.TextBox();
            this.labelProv = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.labelSales = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelHold = new System.Windows.Forms.Label();
            this.checkBoxHold = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(183, 396);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(275, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(22, 24);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(77, 12);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "Client Code:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(105, 21);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(200, 21);
            this.textBoxCode.TabIndex = 3;
            // 
            // textBoxComp
            // 
            this.textBoxComp.Location = new System.Drawing.Point(105, 58);
            this.textBoxComp.Name = "textBoxComp";
            this.textBoxComp.Size = new System.Drawing.Size(200, 21);
            this.textBoxComp.TabIndex = 5;
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Location = new System.Drawing.Point(22, 61);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(83, 12);
            this.labelComp.TabIndex = 4;
            this.labelComp.Text = "Company Name:";
            // 
            // textBoxAddr1
            // 
            this.textBoxAddr1.Location = new System.Drawing.Point(105, 95);
            this.textBoxAddr1.Name = "textBoxAddr1";
            this.textBoxAddr1.Size = new System.Drawing.Size(200, 21);
            this.textBoxAddr1.TabIndex = 7;
            // 
            // labelAddr1
            // 
            this.labelAddr1.AutoSize = true;
            this.labelAddr1.Location = new System.Drawing.Point(22, 98);
            this.labelAddr1.Name = "labelAddr1";
            this.labelAddr1.Size = new System.Drawing.Size(65, 12);
            this.labelAddr1.TabIndex = 6;
            this.labelAddr1.Text = "Address 1:";
            // 
            // textBoxAddr2
            // 
            this.textBoxAddr2.Location = new System.Drawing.Point(105, 132);
            this.textBoxAddr2.Name = "textBoxAddr2";
            this.textBoxAddr2.Size = new System.Drawing.Size(200, 21);
            this.textBoxAddr2.TabIndex = 9;
            // 
            // labelAddr2
            // 
            this.labelAddr2.AutoSize = true;
            this.labelAddr2.Location = new System.Drawing.Point(22, 135);
            this.labelAddr2.Name = "labelAddr2";
            this.labelAddr2.Size = new System.Drawing.Size(65, 12);
            this.labelAddr2.TabIndex = 8;
            this.labelAddr2.Text = "Address 2:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(105, 169);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(200, 21);
            this.textBoxCity.TabIndex = 11;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(22, 172);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 12);
            this.labelCity.TabIndex = 10;
            this.labelCity.Text = "City:";
            // 
            // textBoxProv
            // 
            this.textBoxProv.Location = new System.Drawing.Point(105, 206);
            this.textBoxProv.Name = "textBoxProv";
            this.textBoxProv.Size = new System.Drawing.Size(200, 21);
            this.textBoxProv.TabIndex = 13;
            // 
            // labelProv
            // 
            this.labelProv.AutoSize = true;
            this.labelProv.Location = new System.Drawing.Point(22, 209);
            this.labelProv.Name = "labelProv";
            this.labelProv.Size = new System.Drawing.Size(59, 12);
            this.labelProv.TabIndex = 12;
            this.labelProv.Text = "Province:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(105, 243);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(200, 21);
            this.textBoxPost.TabIndex = 15;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(22, 246);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(77, 12);
            this.labelPost.TabIndex = 14;
            this.labelPost.Text = "Postal Code:";
            // 
            // textBoxSales
            // 
            this.textBoxSales.Location = new System.Drawing.Point(105, 280);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.Size = new System.Drawing.Size(200, 21);
            this.textBoxSales.TabIndex = 17;
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(22, 283);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(65, 12);
            this.labelSales.TabIndex = 16;
            this.labelSales.Text = "YTD Sales:";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(105, 317);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(200, 21);
            this.textBoxNote.TabIndex = 19;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(22, 320);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(41, 12);
            this.labelNote.TabIndex = 18;
            this.labelNote.Text = "Notes:";
            // 
            // labelHold
            // 
            this.labelHold.AutoSize = true;
            this.labelHold.Location = new System.Drawing.Point(22, 354);
            this.labelHold.Name = "labelHold";
            this.labelHold.Size = new System.Drawing.Size(77, 12);
            this.labelHold.TabIndex = 20;
            this.labelHold.Text = "Credit Hold:";
            // 
            // checkBoxHold
            // 
            this.checkBoxHold.AutoSize = true;
            this.checkBoxHold.Location = new System.Drawing.Point(105, 354);
            this.checkBoxHold.Name = "checkBoxHold";
            this.checkBoxHold.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHold.TabIndex = 21;
            this.checkBoxHold.UseVisualStyleBackColor = true;
            // 
            // EditDialog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(368, 434);
            this.Controls.Add(this.checkBoxHold);
            this.Controls.Add(this.labelHold);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxSales);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxProv);
            this.Controls.Add(this.labelProv);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxAddr2);
            this.Controls.Add(this.labelAddr2);
            this.Controls.Add(this.textBoxAddr1);
            this.Controls.Add(this.labelAddr1);
            this.Controls.Add(this.textBoxComp);
            this.Controls.Add(this.labelComp);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Record";
            this.Load += new System.EventHandler(this.EditDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxComp;
        private System.Windows.Forms.Label labelComp;
        private System.Windows.Forms.TextBox textBoxAddr1;
        private System.Windows.Forms.Label labelAddr1;
        private System.Windows.Forms.TextBox textBoxAddr2;
        private System.Windows.Forms.Label labelAddr2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxProv;
        private System.Windows.Forms.Label labelProv;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.TextBox textBoxSales;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelHold;
        private System.Windows.Forms.CheckBox checkBoxHold;
    }
}