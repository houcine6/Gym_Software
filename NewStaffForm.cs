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
    public partial class NewStaffForm : Form
    {
        public NewStaffForm()
        {
            InitializeComponent();
        }

        private void NewStaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDBv1DataSet.StaffV1' table. You can move, or remove it, as needed.
            this.staffV1TableAdapter.Fill(this.staffDBv1DataSet.StaffV1);

            timer1.Start();

            kryptonDataGridView1.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
        }
        DateTime day = DateTime.Today;
        private void bindingNavigatorAddNewItem_NewStaff_Click(object sender, EventArgs e)
        {
            first_NameKryptonTextBox_NewStaff.Enabled = true;
            last_NameKryptonTextBox_NewStaff.Enabled = true;
            ageKryptonTextBox_NewStaff.Enabled = true;
            phoneKryptonTextBox_NewStaff.Enabled = true;
            positionKryptonTextBox_NewStaff.Enabled = true;
            saleryKryptonTextBox_NewStaff.Enabled = true;
            maleKryptonCheckBox_NewStaff.Enabled = true;
            femaleKryptonCheckBox_NewStaff.Enabled = true;
            kryptonTextBox1.Enabled = true;
            registration_DateDateTimePicker.Enabled = true;

            registration_DateDateTimePicker.Value = registration_DateDateTimePicker.MinDate;
            registration_DateDateTimePicker.Value = day;

        }

        private void staffV1BindingNavigatorSaveItem_NewStaff_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffV1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.staffDBv1DataSet);

            MessageBox.Show("Data saved successfully", "Saved");
        }

        private void panel_NewStaff_Paint(object sender, PaintEventArgs e)
        {
            first_NameKryptonTextBox_NewStaff.MaxLength = 49;
            last_NameKryptonTextBox_NewStaff.MaxLength = 49;
            ageKryptonTextBox_NewStaff.MaxLength = 3;
            kryptonTextBox1.MaxLength = 49;
            saleryKryptonTextBox_NewStaff.MaxLength = 10;

            dynamic x = kryptonDataGridView1.Rows.Count;
            x = x - 1;
            label3.Text = "" + x + "";
        }

        private void first_NameKryptonTextBox_NewStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!char.IsLetter(ch) && !char.IsWhiteSpace(ch)) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void last_NameKryptonTextBox_NewStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!char.IsLetter(ch) && !char.IsWhiteSpace(ch)) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ageKryptonTextBox_NewStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void phoneKryptonTextBox_NewStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void saleryKryptonTextBox_NewStaff_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3_timer_NewStaff.Text = DateTime.Now.ToString("T");
        }

        private void maleKryptonCheckBox_NewStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (maleKryptonCheckBox_NewStaff.CheckState == CheckState.Checked)
            {
                maleKryptonCheckBox_NewStaff.Text = "Male";
                femaleKryptonCheckBox_NewStaff.Checked = false;
            }
        }

        private void femaleKryptonCheckBox_NewStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleKryptonCheckBox_NewStaff.CheckState == CheckState.Checked)
            {
                femaleKryptonCheckBox_NewStaff.Text = "Female";
                maleKryptonCheckBox_NewStaff.Checked = false;
            }
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            first_NameKryptonTextBox_NewStaff.Visible = true;
            last_NameKryptonTextBox_NewStaff.Visible = true;
            ageKryptonTextBox_NewStaff.Visible = true;
            maleKryptonCheckBox_NewStaff.Visible = true;
            femaleKryptonCheckBox_NewStaff.Visible = true;
            registration_DateDateTimePicker.Visible = true;
            phoneKryptonTextBox_NewStaff.Visible = true;
            kryptonTextBox1.Visible = true;
            positionKryptonTextBox_NewStaff.Visible = true;
            saleryKryptonTextBox_NewStaff.Visible = true;
            staffV1BindingNavigator_NewStaff.Enabled = true;

            kryptonDataGridView1.Visible = false;
            kryptonButton9.Enabled = false;
            label3.Visible = false;
            label2.Visible = false;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            first_NameKryptonTextBox_NewStaff.Visible = false;
            last_NameKryptonTextBox_NewStaff.Visible = false;
            ageKryptonTextBox_NewStaff.Visible = false;
            maleKryptonCheckBox_NewStaff.Visible = false;
            femaleKryptonCheckBox_NewStaff.Visible = false;
            registration_DateDateTimePicker.Visible = false;
            phoneKryptonTextBox_NewStaff.Visible = false;
            kryptonTextBox1.Visible = false;
            positionKryptonTextBox_NewStaff.Visible = false;
            saleryKryptonTextBox_NewStaff.Visible = false;
            staffV1BindingNavigator_NewStaff.Enabled = false;

            kryptonDataGridView1.Visible = true;
            kryptonButton9.Enabled = true;
            label2.Visible = true;
            label3.Visible = true;
        }
    }
}
