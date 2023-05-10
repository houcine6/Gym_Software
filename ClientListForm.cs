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
    public partial class ClientListForm : Form
    {
        dynamic c;
        public ClientListForm()
        {
            InitializeComponent();
        }

        private void clientsV2KryptonDataGridView_NewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ClientListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientsDBv1DataSet.ClientsV1' table. You can move, or remove it, as needed.
            this.clientsV1TableAdapter.Fill(this.clientsDBv1DataSet.ClientsV1);

            timer1.Start();
            panel1.SendToBack();
            panel1.Hide();
        }
        
        private void panel_ClientList_Paint(object sender, PaintEventArgs e)
        {
            c = clientsV2KryptonDataGridView_NewClient.Rows.Count;
            c = c - 1;
            kryptonLabel2__ClientList.Text = "" + c + "";
        }

        private void searchKryptonTextBox__ClientList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(searchKryptonTextBox__ClientList.Text))
                {
                    clientsV1BindingSource.Filter = string.Format("[First Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%' OR [Last Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%'");
                }
                else
                {
                    clientsV1BindingSource.Filter = string.Empty;
                }
            }
        }

        private void kryptonButton9_ClientList_Click(object sender, EventArgs e)
        {
            searchKryptonTextBox__ClientList.Text = "";
            clientsV1BindingSource.Filter = string.Format("[First Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%' OR [Last Name] LIKE '%" + searchKryptonTextBox__ClientList.Text + "%'");

        }

        private void kryptonButton8__ClientList_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6_timer_ClientList.Text = DateTime.Now.ToString("T");
        }

        DateTime today = DateTime.Today;
         
        int i = 0;
        String d,dd;
        String Fname;
        String Lname;
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            for(i=0; i < clientsV2KryptonDataGridView_NewClient.Rows.Count -1 ; i++)
            {
                d = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[9].Value.ToString();
                d = Convert.ToDateTime(d).ToString("dd/MM/yyyy");
                dd = d;
                DateTime Exdate = Convert.ToDateTime(d);

                int daysDiff = ((TimeSpan)(Exdate - today)).Days;

                if (daysDiff <= 0)
                {
                    Fname = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[1].Value.ToString();
                    Lname = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[2].Value.ToString();
                    d = clientsV2KryptonDataGridView_NewClient.Rows[i].Cells[9].Value.ToString();
                    d = Convert.ToDateTime(d).ToString("dd/MM/yyyy");
                    dd = d;
                    Console.WriteLine("fn :" + Fname);
                    Console.WriteLine("ln : " + Lname);

                    kryptonDataGridView1.Rows.Add(Fname, Lname, dd);
                }
            }

            panel_ClientList.SendToBack();
            panel_ClientList.Hide();
            panel1.BringToFront();
            panel1.Show();

            //clientsV1BindingSource.Filter = string.Format("[Expiration Date] LIKE '%"+  +" ");

        }

        dynamic E;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            E = kryptonDataGridView1.Rows.Count;
            E = E - 1;
            kryptonLabel1.Text = "" + E + "";
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel1.Hide();
            panel_ClientList.BringToFront();
            panel_ClientList.Show();
            kryptonDataGridView1.Rows.Clear();
        }
    }
}
