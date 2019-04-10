using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLib.Business;
using BusinessLib.Common;

namespace COMP2614Assign06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public ClientViewModel ClientVM { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelCount.Text = "";
            labelSales.Text = "";
            ClientVM = new ClientViewModel();
            ClientVM.PropertyChanged += ClientVM_PropertyChanged;   // handle ClientCollection change
            setupDataGridView();
            updateLabels();
        }

        private void ClientVM_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            updateLabels();
        }

        private void updateLabels()
        {
            labelCount.Text = string.Format("{0}", ClientVM.ClientCount);
            labelSales.Text = string.Format("{0:N2}", ClientVM.TotalYTDSales);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            EditDialog dialog = new EditDialog(ClientVM.ProvinceList);
            dialog.IsNewClient = true;
            dialog.Client = new Client();   // create new empty Client instance
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                // add the new instance into ClientCollection list
                ClientVM.AddClient(dialog.Client);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditDialog dialog = new EditDialog(ClientVM.ProvinceList);
            dialog.IsNewClient = false;
            int index = dataGridViewClients.CurrentRow.Index;
            dialog.Client = new Client(ClientVM.GetClientByIndex(index));    // create new Client with properties copied
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                // reflect changes to ClientCollection list
                ClientVM.SetClientByIndex(index, dialog.Client);
            }
        }

        private void dataGridViewClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // ignore column header double clicks 
            if (e.RowIndex < 0)
            {
                return;
            }

            buttonEdit_Click(sender, e);
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Client client = ClientVM.GetClientByIndex(dataGridViewClients.CurrentRow.Index);
            bool allowDelete = false;

            if (checkBoxPrompt.Checked)
            {
                // show a messagebox to confirm deletion.
                if (DialogResult.Yes == MessageBox.Show($@"Are you sure to delete client entry ""{client.ClientCode}"" from database?", "Deleting entry", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    allowDelete = true;
                }
            }
            else
            {
                allowDelete = true;
            }

            // delete the client
            if (allowDelete)
            {
                try
                {
                    int rowsaffected = ClientValidation.DeleteClient(client);
                    if (rowsaffected > 0)
                    {
                        ClientVM.RemoveClient(client);
                    }
                    else if (rowsaffected == 0)
                    {
                        MessageBox.Show("No DB changes were made", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        // setup DataGridView
        private void setupDataGridView()
        {
            // configure for readonly
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = ClientVM.Clients;
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // add columns
            DataGridViewTextBoxColumn codeCol = new DataGridViewTextBoxColumn();
            codeCol.Name = "code";
            codeCol.DataPropertyName = "ClientCode";
            codeCol.HeaderText = "Client Code";
            codeCol.Width = 60;
            //codeCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //codeCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            codeCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(codeCol);

            DataGridViewTextBoxColumn compCol = new DataGridViewTextBoxColumn();
            compCol.Name = "comp";
            compCol.DataPropertyName = "CompanyName";
            compCol.HeaderText = "Company Name";
            compCol.Width = 200;
            //compCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //compCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            compCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(compCol);

            DataGridViewTextBoxColumn addr1Col = new DataGridViewTextBoxColumn();
            addr1Col.Name = "addr1";
            addr1Col.DataPropertyName = "Address1";
            addr1Col.HeaderText = "Address 1";
            addr1Col.Width = 200;
            //addr1Col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //addr1Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            addr1Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(addr1Col);

            DataGridViewTextBoxColumn addr2Col = new DataGridViewTextBoxColumn();
            addr2Col.Name = "addr2";
            addr2Col.DataPropertyName = "Address2";
            addr2Col.HeaderText = "Address 2";
            addr2Col.Width = 160;
            //addr2Col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //addr2Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            addr2Col.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(addr2Col);

            DataGridViewTextBoxColumn cityCol = new DataGridViewTextBoxColumn();
            cityCol.Name = "city";
            cityCol.DataPropertyName = "City";
            cityCol.HeaderText = "City";
            cityCol.Width = 80;
            //cityCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //cityCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cityCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(cityCol);

            DataGridViewTextBoxColumn provCol = new DataGridViewTextBoxColumn();
            provCol.Name = "prov";
            provCol.DataPropertyName = "Province";
            provCol.HeaderText = "Prov- ince";
            provCol.Width = 40;
            //provCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //provCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            provCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(provCol);

            DataGridViewTextBoxColumn postCol = new DataGridViewTextBoxColumn();
            postCol.Name = "post";
            postCol.DataPropertyName = "PostalCode";
            postCol.HeaderText = "Postal Code";
            postCol.Width = 60;
            //postCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //postCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            postCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postCol);

            DataGridViewTextBoxColumn salesCol = new DataGridViewTextBoxColumn();
            salesCol.Name = "sales";
            salesCol.DataPropertyName = "YTDSales";
            salesCol.HeaderText = "YTD Sales";
            salesCol.Width = 70;
            salesCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            salesCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            salesCol.DefaultCellStyle.Format = "N2";
            salesCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(salesCol);

            DataGridViewCheckBoxColumn holdCol = new DataGridViewCheckBoxColumn();
            holdCol.Name = "hold";
            holdCol.DataPropertyName = "CreditHold";
            holdCol.HeaderText = "Credit Hold";
            holdCol.Width = 50;
            //holdCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //holdCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            holdCol.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(holdCol);

            DataGridViewTextBoxColumn note = new DataGridViewTextBoxColumn();
            note.Name = "note";
            note.DataPropertyName = "Notes";
            note.HeaderText = "Notes";
            note.Width = 220;
            //note.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            //note.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            note.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(note);
        }
    }
}
