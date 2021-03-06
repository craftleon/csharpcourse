﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLib.Business;
using BusinessLib.Common;

namespace COMP2614Assign06
{
    public partial class EditDialog : Form
    {
        public Client Client { get; set; }

        // corresponding to new or edit actions
        public bool IsNewClient { get; set; }

        public EditDialog(List<string> provList)
        {
            InitializeComponent();
            comboBoxProv.DataSource = provList;
        }

        private void EditDialog_Load(object sender, EventArgs e)
        {
            setupDataBindings();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // try parse YTDSales with specific style before assignment
            decimal sales;
            NumberStyles style = NumberStyles.Number | NumberStyles.AllowParentheses;

            if (!string.IsNullOrWhiteSpace(textBoxSales.Text) && decimal.TryParse(textBoxSales.Text, style, null, out sales))
            {
                Client.YTDSales = sales;
            }
            else
            {
                MessageBox.Show("YTDSales has to be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client.ClientCode = maskedTextBoxCode.Text;
            Client.CompanyName = textBoxComp.Text;
            Client.Address1 = textBoxAddr1.Text;
            Client.Address2 = textBoxAddr2.Text;
            Client.City = textBoxCity.Text;
            Client.Province = comboBoxProv.Text;
            Client.PostalCode = maskedTextBoxPost.Text;
            Client.CreditHold = checkBoxHold.Checked;
            Client.Notes = textBoxNote.Text;

            int rowsaffected;
            try
            {
                if (this.IsNewClient)
                {
                    rowsaffected = ClientValidation.AddClient(Client);
                }
                else
                {
                    rowsaffected = ClientValidation.UpdateClient(Client);
                }

                if (rowsaffected > 0)
                {
                    this.DialogResult = DialogResult.OK;    // close dialog
                }
                else
                {
                    if (rowsaffected == -1)
                    {
                        errorProvider.SetError(buttonOK, ClientValidation.ErrorMessage);
                        //MessageBox.Show(ClientValidation.ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setupDataBindings()
        {
            maskedTextBoxCode.DataBindings.Add("Text", Client, "ClientCode");
            textBoxComp.DataBindings.Add("Text", Client, "CompanyName");
            textBoxAddr1.DataBindings.Add("Text", Client, "Address1");
            textBoxAddr2.DataBindings.Add("Text", Client, "Address2");
            textBoxCity.DataBindings.Add("Text", Client, "City");
            comboBoxProv.DataBindings.Add("Text", Client, "Province");
            maskedTextBoxPost.DataBindings.Add("Text", Client, "PostalCode");
            textBoxSales.DataBindings.Add("Text", Client, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxHold.DataBindings.Add("Checked", Client, "CreditHold");
            textBoxNote.DataBindings.Add("Text", Client, "Notes");
        }
    }
}
