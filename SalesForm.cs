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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDBv1DataSet.SalesV1' table. You can move, or remove it, as needed.
            this.salesV1TableAdapter.Fill(this.salesDBv1DataSet.SalesV1);
            // TODO: This line of code loads data into the 'itemsDBv1DataSet.ItemsV1' table. You can move, or remove it, as needed.
            this.itemsV1TableAdapter.Fill(this.itemsDBv1DataSet.ItemsV1);

            timer1.Start();

            panel3.SendToBack();
            panel3.Hide();
            panel5.SendToBack();
            panel5.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6_timer_ClientList.Text = DateTime.Now.ToString("T");
        }

        private void kryptonTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        Double TP = 0;
        int TI = 0;
        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            label5.Text = "0,00";
            kryptonTextBox3.Text = "";
            TP = 0;
            TI = 0;
            kryptonDataGridView2.Rows.Clear();
            printList.Clear();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            panel_ClientList.SendToBack();
            panel_ClientList.Hide();
            panel3.BringToFront();
            panel3.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            panel3.SendToBack();
            panel3.Hide();
            panel_ClientList.BringToFront();
            panel_ClientList.Show();
        }

        dynamic Q, p, n;
        String nn = "";
        int qq;
        int q2;
        dynamic q;
        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text != "")
            {
                //quantity
                q = kryptonTextBox3.Text;
                q2 = Int32.Parse(q);

                if (q2 > qq)
                {
                    MessageBox.Show("There are not enough in stock", "Error");
                }
                else
                {
                    TP = TP + (pp * q2);

                    int rest;
                    rest = qq - q2;
                    kryptonDataGridView1.CurrentRow.Cells[3].Value = rest;

                    TI = TI + q2;

                    label5.Text = "" + TP;

                    kryptonDataGridView2.Rows.Add(n, q, pp);

                    this.salesV1BindingSource.AddNew();
                    itemTextBox.Text = n;
                    quantityTextBox.Text = q;
                    price_pe_itemTextBox.Text = pp.ToString();

                    this.Validate();
                    this.salesV1BindingSource.EndEdit();
                    this.tableAdapterManager1.UpdateAll(this.salesDBv1DataSet);

                    this.Validate();
                    this.itemsV1BindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.itemsDBv1DataSet);

                    kryptonDataGridView1.CurrentRow.Selected = false;
                    kryptonTextBox3.Text = "";

                    quantity = Convert.ToString(q);
                    price = Convert.ToString(pp);

                    printList.Add(n);
                    printList.Add(quantity);
                    printList.Add(price);
                }
            }
            else
            {

            }
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void itemLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantityLabel1_Click(object sender, EventArgs e)
        {

        }

        private void price_pe_itemLabel_Click(object sender, EventArgs e)
        {

        }

        private void price_pe_itemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void productsV1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesV1BindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.salesDBv1DataSet);
        }

        private void kryptonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(kryptonTextBox1.Text))
                {
                    salesV1BindingSource.Filter = string.Format("Item LIKE '%" + kryptonTextBox1.Text + "%'");
                }
                else
                {
                    salesV1BindingSource.Filter = string.Empty;
                }
            }
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            kryptonTextBox1.Text = "";
            salesV1BindingSource.Filter = string.Format("Item LIKE '%" + kryptonTextBox1.Text + "%'");

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

            printPreviewDialog1.ShowDialog();
        }

        String today = DateTime.Now.ToString("d");
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("    ===== GYM =====", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(20, 20));
            e.Graphics.DrawString("==== Sales Summary ====", new Font("Abeezee", 15, FontStyle.Bold), Brushes.Black, new Point(2, 40));

            e.Graphics.DrawString("" + today, new Font("Abeezee", 13), Brushes.Black, new Point(2, 60));

            e.Graphics.DrawString("Item                 QTE             item Price", new Font("Abeezee", 12), Brushes.Black, new Point(2, 80));

            e.Graphics.DrawString("--------------------------------------------------", new Font("Abeezee", 12), Brushes.Black, new Point(2, 90));
            int H = 101;
            int W = 0;
            for (int i = 0; i < printList.Count; i++)
            {
                int j = i;
                e.Graphics.DrawString("" + printList[j], new Font("Abeezee", 12), Brushes.Black, new Point(W, H));
                j++;
                W = W + 120;
                e.Graphics.DrawString("" + printList[j], new Font("Abeezee", 12), Brushes.Black, new Point(W, H));
                j++;
                W = W + 100;
                e.Graphics.DrawString("" + printList[j], new Font("Abeezee", 12), Brushes.Black, new Point(W, H));
                i = i + 2;
                if (i == printList.Count - 1)
                {
                    W = 0;
                    H = H + 17;
                    e.Graphics.DrawString("--------------------------------------------------", new Font("Abeezee", 12), Brushes.Black, new Point(W, H));
                    W = 10;
                    H = H + 17;
                    e.Graphics.DrawString("Total Items : " + TI, new Font("Abeezee", 12), Brushes.Black, new Point(W, H));
                    W = 10;
                    H = H + 17;
                    e.Graphics.DrawString("Total Price : " + TP, new Font("Abeezee", 12), Brushes.Black, new Point(W, H));
                }
                H = H + 17;
                W = 0;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        Double pp;
        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kryptonDataGridView1.CurrentRow.Cells[0].Value.ToString() != "" && kryptonDataGridView1.CurrentRow.Cells[4].Value.ToString() != "" && kryptonDataGridView1.CurrentRow.Cells[3].Value.ToString() != "")
            {
                kryptonDataGridView1.CurrentRow.Selected = true;

                n = kryptonDataGridView1.CurrentRow.Cells[0].Value.ToString();

                p = kryptonDataGridView1.CurrentRow.Cells[4].Value.ToString();
                pp = Convert.ToDouble(String.Format("{0:0.00}", p));

                Q = kryptonDataGridView1.CurrentRow.Cells[3].Value.ToString();
                qq = Int32.Parse(Q);
            }
            else
            {

            }
        }

        private void kryptonButton9_panel5_ProductsList_Click(object sender, EventArgs e)
        {
            kryptonTextBox2.Text = "";
            itemsV1BindingSource.Filter = string.Format("[Item Name] LIKE '%" + kryptonTextBox2.Text + "%'");

        }

        private void kryptonTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(kryptonTextBox2.Text))
                {
                    itemsV1BindingSource.Filter = string.Format("[Item Name] LIKE '%" + kryptonTextBox2.Text + "%'");
                }
                else
                {
                    itemsV1BindingSource.Filter = string.Empty;
                }
            }
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kryptonDataGridView3.Rows.Count - 1; i++)
            {
                kryptonDataGridView3.Rows[i].Selected = true;
                foreach (DataGridViewRow row in kryptonDataGridView3.SelectedRows)
                {
                    kryptonDataGridView3.Rows.RemoveAt(row.Index);
                }
            }

            this.Validate();
            this.salesV1BindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.salesDBv1DataSet);
        }

        String quantity, price;
        List<string> printList = new List<string>();
    }
}
