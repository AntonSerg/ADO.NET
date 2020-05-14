using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Windows.Forms;
using AutoLotConnectedLayer;
using System.Threading;

namespace AutoLotGui
{
    public partial class Form1 : Form
    {
        InventoryDAL inventoryDAL;
        public Form1()
        {
            InitializeComponent();
            inventoryDAL = new InventoryDAL();
            new Thread(() => initControls(false)).Start();
        }
        public void initControls(bool state)
        {
            this.BeginInvoke(new Action(() =>
            {
                btnOpenCon.Enabled = !state;
                btnCloseCon.Enabled = state;
                btnGetTable.Enabled = state;
                btnInsertAuto.Enabled = !string.IsNullOrWhiteSpace(txtInsertMake.Text) && !string.IsNullOrWhiteSpace(txtInsertColor.Text) && !string.IsNullOrWhiteSpace(txtInsertPetName.Text) && state;
                btnUpdPet.Enabled = string.IsNullOrWhiteSpace(txtUpdPetId.Text) && state;
                cbTables.Items.Clear();
                cbTables.Enabled = state;
            }));
            
            if(inventoryDAL.conState == ConnectionState.Open)
            {
                DataTable tablesName = inventoryDAL.GetTablesName();
                foreach (DataRow item in tablesName.Rows)
                {
                    string tableName = (string)item[2];
                    this.BeginInvoke(new Action(() => cbTables.Items.Add(tableName)));

                }
                this.BeginInvoke(new Action(() => cbTables.SelectedIndex = 0));
            }
        }
        public void InvalidateListView(DataTable dataTable)
        {
            lvMain.Clear();
            foreach (DataColumn column in dataTable.Columns)
            {
                lvMain.Columns.Add(column.ColumnName);
            }
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem lvItem = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    lvItem.SubItems.Add(row[i].ToString());
                }
                lvMain.Items.Add(lvItem);
            }
        }
        private void btnGetInventory_Click(object sender, EventArgs e)
        {
            string tableName = (string)cbTables.SelectedItem;
            if(tableName == null)
            {
                MessageBox.Show("Wrong table name!", "Error");
                return;
            }
            DataTable dataTable = inventoryDAL.GetAllFromTableAsDataTable(tableName);
            dataTable.AcceptChanges();
            InvalidateListView(dataTable);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            new Thread(
                () => {
                    inventoryDAL.OpenConnection(@"Data Source=DESKTOP-NOV64VM\SQLEXPRESS;Initial Catalog=AutoLot;Integrated Security=True;Pooling=False");
                    if (inventoryDAL.conState == ConnectionState.Open)
                    {
                        initControls(true);
                    }
                }).Start();
        }

        private void btnCloseCon_Click(object sender, EventArgs e)
        {
            new Thread(
                () => {
                    inventoryDAL.CloseConnection();
                    if (inventoryDAL.conState == ConnectionState.Closed)
                    {
                        this.BeginInvoke(new Action(() => initControls(false)));
                    }
                }).Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (inventoryDAL.conState == ConnectionState.Open)
                inventoryDAL.CloseConnection();
        }

        private void btnConState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(inventoryDAL.conState.ToString(), "Connection status");
        }

        private void txtInsert_TextChanged(object sender, EventArgs e)
        {
            btnInsertAuto.Enabled = !string.IsNullOrWhiteSpace(txtInsertMake.Text) && !string.IsNullOrWhiteSpace(txtInsertColor.Text) && !string.IsNullOrWhiteSpace(txtInsertPetName.Text) && inventoryDAL.conState != ConnectionState.Closed;
        }

        private void btnInsertAuto_Click(object sender, EventArgs e)
        {
            string make = txtInsertMake.Text.Trim();
            string color = txtInsertColor.Text.Trim();
            string petName = txtInsertPetName.Text.Trim();
            inventoryDAL.InsertAuto(make, color, petName);
        }

        private void txtInsert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRemoveAuto_Click(object sender, EventArgs e)
        {
            inventoryDAL.DeleteCar((int)numRemoveId.Value);
        }

        private void txtUpdPetId_TextChanged(object sender, EventArgs e)
        {
            btnUpdPet.Enabled = !string.IsNullOrWhiteSpace(txtUpdPetId.Text) && inventoryDAL.conState != ConnectionState.Closed;
        }

        private void btnUpdPet_Click(object sender, EventArgs e)
        {
            int id = (int)numUpdPetId.Value;
            string newPetName = txtUpdPetId.Text.Trim();
            new Thread(() => inventoryDAL.UpdateCarPetName(id, newPetName)).Start();
        }

        private void btnShowPetName_Click(object sender, EventArgs e)
        {
            int id = (int)numShowPetId.Value;
            string petName = string.Empty;
            new Thread(() =>
            {
                petName = inventoryDAL.LookUpPetName(id);
                this.BeginInvoke(new Action(() => txtShowPetPName.Text = petName));
            }).Start();
        }
    }
}
