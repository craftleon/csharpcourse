using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06
{
    public partial class EditDialog : Form
    {
        public Client Client { get; set; }

        public EditDialog()
        {
            InitializeComponent();
        }

        private void EditDialog_Load(object sender, EventArgs e)
        {
            setupDataBindings();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            decimal sales;
            if (textBoxCode.Text == "" || textBoxComp.Text == "" || textBoxAddr1.Text == "" || textBoxProv.Text == "" ||
                textBoxSales.Text == "" || !decimal.TryParse(textBoxSales.Text, out sales) )
            {
                return;
            }

            Client.ClientCode = textBoxCode.Text;
            Client.CompanyName = textBoxComp.Text;
            Client.Address1 = textBoxAddr1.Text;
            Client.Address2 = textBoxAddr2.Text;
            Client.City = textBoxCity.Text;
            Client.Province = textBoxProv.Text;
            Client.PostalCode = textBoxPost.Text;
            Client.YTDSales = decimal.Parse(textBoxSales.Text);
            Client.CreditHold = checkBoxHold.Checked;
            Client.Notes = textBoxNote.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void setupDataBindings()
        {
            textBoxCode.DataBindings.Add("Text", Client, "ClientCode", false, DataSourceUpdateMode.Never);
            textBoxComp.DataBindings.Add("Text", Client, "CompanyName", false, DataSourceUpdateMode.Never);
            textBoxAddr1.DataBindings.Add("Text", Client, "Address1", false, DataSourceUpdateMode.Never);
            textBoxAddr2.DataBindings.Add("Text", Client, "Address2", false, DataSourceUpdateMode.Never);
            textBoxCity.DataBindings.Add("Text", Client, "City", false, DataSourceUpdateMode.Never);
            textBoxProv.DataBindings.Add("Text", Client, "Province", false, DataSourceUpdateMode.Never);
            textBoxPost.DataBindings.Add("Text", Client, "PostalCode", false, DataSourceUpdateMode.Never);
            textBoxSales.DataBindings.Add("Text", Client, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxHold.DataBindings.Add("Checked", Client, "CreditHold", false, DataSourceUpdateMode.Never);
            textBoxNote.DataBindings.Add("Text", Client, "Notes", false, DataSourceUpdateMode.Never);
        }
    }
}
