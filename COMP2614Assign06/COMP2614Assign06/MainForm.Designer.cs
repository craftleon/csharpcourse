namespace COMP2614Assign06
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEdit = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.checkBoxPrompt = new System.Windows.Forms.CheckBox();
            this.labelCountPromt = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSalesPrompt = new System.Windows.Forms.Label();
            this.labelSales = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(509, 517);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(110, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "&Edit Client";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(31, 33);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowTemplate.Height = 23;
            this.dataGridViewClients.Size = new System.Drawing.Size(720, 440);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellDoubleClick);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Location = new System.Drawing.Point(377, 517);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(110, 23);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "&New Client";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(641, 517);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "&Delete Client";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // checkBoxPrompt
            // 
            this.checkBoxPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPrompt.AutoSize = true;
            this.checkBoxPrompt.Checked = true;
            this.checkBoxPrompt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrompt.Location = new System.Drawing.Point(31, 521);
            this.checkBoxPrompt.Name = "checkBoxPrompt";
            this.checkBoxPrompt.Size = new System.Drawing.Size(138, 16);
            this.checkBoxPrompt.TabIndex = 1;
            this.checkBoxPrompt.Text = "&Ask before deletion";
            this.checkBoxPrompt.UseVisualStyleBackColor = true;
            // 
            // labelCountPromt
            // 
            this.labelCountPromt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountPromt.AutoSize = true;
            this.labelCountPromt.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCountPromt.Location = new System.Drawing.Point(404, 485);
            this.labelCountPromt.Name = "labelCountPromt";
            this.labelCountPromt.Size = new System.Drawing.Size(98, 14);
            this.labelCountPromt.TabIndex = 5;
            this.labelCountPromt.Text = "Client Count:";
            // 
            // labelCount
            // 
            this.labelCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCount.Location = new System.Drawing.Point(503, 485);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(42, 14);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "<N/A>";
            // 
            // labelSalesPrompt
            // 
            this.labelSalesPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalesPrompt.AutoSize = true;
            this.labelSalesPrompt.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSalesPrompt.Location = new System.Drawing.Point(564, 485);
            this.labelSalesPrompt.Name = "labelSalesPrompt";
            this.labelSalesPrompt.Size = new System.Drawing.Size(119, 14);
            this.labelSalesPrompt.TabIndex = 7;
            this.labelSalesPrompt.Text = "Total YTD Sales:";
            // 
            // labelSales
            // 
            this.labelSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSales.AutoSize = true;
            this.labelSales.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSales.Location = new System.Drawing.Point(689, 485);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(42, 14);
            this.labelSales.TabIndex = 8;
            this.labelSales.Text = "<N/A>";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonEdit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.labelSalesPrompt);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelCountPromt);
            this.Controls.Add(this.checkBoxPrompt);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.buttonEdit);
            this.MaximumSize = new System.Drawing.Size(1220, 640);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "MainForm";
            this.Text = "Customer Data Table";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxPrompt;
        private System.Windows.Forms.Label labelCountPromt;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelSalesPrompt;
        private System.Windows.Forms.Label labelSales;
    }
}

