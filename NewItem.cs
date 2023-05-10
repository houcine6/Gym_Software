using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System_2
{
    public partial class NewItemForm : Form
    {
        public NewItemForm()
        {
            InitializeComponent();
        }

        private void itemsV1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.itemsV1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemsDBv1DataSet);

        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsDBv1DataSet.ItemsV1' table. You can move, or remove it, as needed.
            this.itemsV1TableAdapter.Fill(this.itemsDBv1DataSet.ItemsV1);

            timer1.Start();
        }

        private void bindingNavigatorAddNewItem_NewProduct_Click(object sender, EventArgs e)
        {
            nameKryptonTextBox_NewProduct.Enabled = true;
            bioKryptonTextBox_NewProduct.Enabled = true;
            quantityKryptonTextBox_NewProduct.Enabled = true;
            priceKryptonTextBox_NewProduct.Enabled = true;
            supplementsCheckBox.Enabled = true;
            equipmentCheckBox.Enabled = true;
        }

        private void panel__NewProduct_Paint(object sender, PaintEventArgs e)
        {
            nameKryptonTextBox_NewProduct.MaxLength = 49;
            quantityKryptonTextBox_NewProduct.MaxLength = 49;

            dynamic d = prdouctsV2KryptonDataGridView_NewProduct.Rows.Count;
            d = d - 1;
            kryptonLabel2_ProductsList.Text = "" + d + "";
        }


        private void quantityKryptonTextBox_NewProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void priceKryptonTextBox_NewProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && !char.IsPunctuation(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3_timer_NewProduct.Text = DateTime.Now.ToString("T");
        }

        private void supplementsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (supplementsCheckBox.CheckState == CheckState.Checked)
            {
                equipmentCheckBox.Checked = false;
            }
        }

        private void equipmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (equipmentCheckBox.CheckState == CheckState.Checked)
            {
                supplementsCheckBox.Checked = false;
            }
        }

        private void prdouctsV2BindingNavigatorSaveItem_NewProduct_Click(object sender, EventArgs e)
        {
            if (nameKryptonTextBox_NewProduct.Text != "" && quantityKryptonTextBox_NewProduct.Text != "" && priceKryptonTextBox_NewProduct.Text != "")
            {
                this.Validate();
                this.itemsV1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.itemsDBv1DataSet);

                MessageBox.Show("Data saved successfully", "Saved");
            }
            else
            {
                MessageBox.Show("Important field is empty", "Error");
            }
        }

        private void kryptonButton9_panel5_ProductsList_Click(object sender, EventArgs e)
        {
            searchproductKryptonTextBox_ProductsList.Text = "";
            itemsV1BindingSource.Filter = string.Format("[Item Name] LIKE '%" + searchproductKryptonTextBox_ProductsList.Text + "%'");
        }

        private void searchproductKryptonTextBox_ProductsList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(searchproductKryptonTextBox_ProductsList.Text))
                {
                    itemsV1BindingSource.Filter = string.Format("[Item Name] LIKE '%" + searchproductKryptonTextBox_ProductsList.Text + "%'");
                }
                else
                {
                    itemsV1BindingSource.Filter = string.Empty;
                }
            }
        }

        private void bindingNavigatorDeleteItem_NewProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in prdouctsV2KryptonDataGridView_NewProduct.SelectedRows)
            {
                prdouctsV2KryptonDataGridView_NewProduct.Rows.RemoveAt(row.Index);
            }

            this.Validate();
            this.itemsV1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.itemsDBv1DataSet);

            MessageBox.Show("Data saved successfully", "Saved");
        }

        private void prdouctsV2KryptonDataGridView_NewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prdouctsV2KryptonDataGridView_NewProduct.CurrentRow.Selected = true;
        }
    }
}
