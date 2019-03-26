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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ClientViewModel clientVM;

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            clientVM = new ClientViewModel();
            setupDataGridView();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditDialog dialog = new EditDialog();
            dialog.Client = clientVM.Clients[dataGridViewClients.CurrentRow.Index];
            dialog.ShowDialog();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // update to database
        }

        // setup DataGridView
        private void setupDataGridView()
        {
            // configure for readonly
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
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
