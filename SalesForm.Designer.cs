
namespace Gym_Management_System_2
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label price_pe_itemLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.panel_ClientList = new System.Windows.Forms.Panel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonButton9_panel5_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6_timer_ClientList = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView2 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priceperunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton9 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplementsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDBv1DataSet = new Gym_Management_System_2.ItemsDBv1DataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.kryptonButton7 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonDataGridView3 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePeItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDBv1DataSet = new Gym_Management_System_2.SalesDBv1DataSet();
            this.kryptonButton6 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label10 = new System.Windows.Forms.Label();
            this.itemsV1TableAdapter = new Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.ItemsV1TableAdapter();
            this.tableAdapterManager = new Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.TableAdapterManager();
            this.panel5 = new System.Windows.Forms.Panel();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.price_pe_itemTextBox = new System.Windows.Forms.TextBox();
            this.salesV1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesV1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productsV1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.salesV1TableAdapter = new Gym_Management_System_2.SalesDBv1DataSetTableAdapters.SalesV1TableAdapter();
            this.tableAdapterManager1 = new Gym_Management_System_2.SalesDBv1DataSetTableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            quantityLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            price_pe_itemLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel_ClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv1DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDBv1DataSet)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesV1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesV1BindingNavigator)).BeginInit();
            this.salesV1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(192, 700);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(81, 20);
            quantityLabel.TabIndex = 55;
            quantityLabel.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(910, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(107, 20);
            label3.TabIndex = 64;
            label3.Text = "Your Order :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(315, 133);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(111, 20);
            nameLabel.TabIndex = 63;
            nameLabel.Text = "Select Item :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label8.Location = new System.Drawing.Point(56, 238);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 17);
            label8.TabIndex = 28;
            label8.Text = "Search :";
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Location = new System.Drawing.Point(80, 57);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(30, 13);
            itemLabel.TabIndex = 10;
            itemLabel.Text = "Item:";
            itemLabel.Click += new System.EventHandler(this.itemLabel_Click);
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Location = new System.Drawing.Point(80, 83);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(49, 13);
            quantityLabel1.TabIndex = 12;
            quantityLabel1.Text = "Quantity:";
            quantityLabel1.Click += new System.EventHandler(this.quantityLabel1_Click);
            // 
            // price_pe_itemLabel
            // 
            price_pe_itemLabel.AutoSize = true;
            price_pe_itemLabel.Location = new System.Drawing.Point(80, 109);
            price_pe_itemLabel.Name = "price_pe_itemLabel";
            price_pe_itemLabel.Size = new System.Drawing.Size(71, 13);
            price_pe_itemLabel.TabIndex = 14;
            price_pe_itemLabel.Text = "Price pe item:";
            price_pe_itemLabel.Click += new System.EventHandler(this.price_pe_itemLabel_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(441, 42);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 20);
            label6.TabIndex = 30;
            label6.Text = "Search Item:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(29, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 25);
            label1.TabIndex = 46;
            label1.Text = "Total :";
            // 
            // panel_ClientList
            // 
            this.panel_ClientList.BackColor = System.Drawing.Color.DarkGray;
            this.panel_ClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_ClientList.Controls.Add(this.kryptonPanel2);
            this.panel_ClientList.Controls.Add(this.panel2);
            this.panel_ClientList.Controls.Add(this.kryptonDataGridView2);
            this.panel_ClientList.Controls.Add(label3);
            this.panel_ClientList.Controls.Add(nameLabel);
            this.panel_ClientList.Controls.Add(this.kryptonButton4);
            this.panel_ClientList.Controls.Add(this.kryptonButton3);
            this.panel_ClientList.Controls.Add(this.kryptonButton9);
            this.panel_ClientList.Controls.Add(this.kryptonTextBox3);
            this.panel_ClientList.Controls.Add(quantityLabel);
            this.panel_ClientList.Controls.Add(this.kryptonDataGridView1);
            this.panel_ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClientList.Location = new System.Drawing.Point(0, 0);
            this.panel_ClientList.MaximumSize = new System.Drawing.Size(1301, 840);
            this.panel_ClientList.MinimumSize = new System.Drawing.Size(1301, 840);
            this.panel_ClientList.Name = "panel_ClientList";
            this.panel_ClientList.Size = new System.Drawing.Size(1301, 840);
            this.panel_ClientList.TabIndex = 19;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(label1);
            this.kryptonPanel2.Controls.Add(this.label5);
            this.kryptonPanel2.Location = new System.Drawing.Point(814, 645);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel2.Size = new System.Drawing.Size(303, 71);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel2.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(126, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 31);
            this.label5.TabIndex = 59;
            this.label5.Text = "0,00";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.kryptonButton9_panel5_ProductsList);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(label6);
            this.panel2.Controls.Add(this.label6_timer_ClientList);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.kryptonTextBox2);
            this.panel2.Controls.Add(this.kryptonButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 103);
            this.panel2.TabIndex = 72;
            // 
            // kryptonButton9_panel5_ProductsList
            // 
            this.kryptonButton9_panel5_ProductsList.Location = new System.Drawing.Point(768, 30);
            this.kryptonButton9_panel5_ProductsList.Name = "kryptonButton9_panel5_ProductsList";
            this.kryptonButton9_panel5_ProductsList.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_panel5_ProductsList.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_panel5_ProductsList.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_panel5_ProductsList.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_panel5_ProductsList.Size = new System.Drawing.Size(74, 45);
            this.kryptonButton9_panel5_ProductsList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_panel5_ProductsList.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.Rounding = 20;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Border.Width = 2;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_panel5_ProductsList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9_panel5_ProductsList.TabIndex = 63;
            this.kryptonButton9_panel5_ProductsList.Values.Text = "Refrech";
            this.kryptonButton9_panel5_ProductsList.Click += new System.EventHandler(this.kryptonButton9_panel5_ProductsList_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 103);
            this.panel6.TabIndex = 29;
            // 
            // label6_timer_ClientList
            // 
            this.label6_timer_ClientList.AutoSize = true;
            this.label6_timer_ClientList.BackColor = System.Drawing.Color.Transparent;
            this.label6_timer_ClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_timer_ClientList.ForeColor = System.Drawing.Color.White;
            this.label6_timer_ClientList.Location = new System.Drawing.Point(31, 31);
            this.label6_timer_ClientList.Name = "label6_timer_ClientList";
            this.label6_timer_ClientList.Size = new System.Drawing.Size(168, 44);
            this.label6_timer_ClientList.TabIndex = 18;
            this.label6_timer_ClientList.Text = "00:00:00";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(1288, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 103);
            this.panel7.TabIndex = 28;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(563, 33);
            this.kryptonTextBox2.MaximumSize = new System.Drawing.Size(189, 40);
            this.kryptonTextBox2.MinimumSize = new System.Drawing.Size(189, 40);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(189, 40);
            this.kryptonTextBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox2.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox2.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateDisabled.Border.Rounding = 20;
            this.kryptonTextBox2.TabIndex = 28;
            this.kryptonTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kryptonTextBox2_KeyDown);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1139, 30);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton1.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton1.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton1.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.Size = new System.Drawing.Size(118, 45);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 20;
            this.kryptonButton1.StateCommon.Border.Width = 2;
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 62;
            this.kryptonButton1.Values.Text = "Sales History";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonDataGridView2
            // 
            this.kryptonDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Priceperunit});
            this.kryptonDataGridView2.Location = new System.Drawing.Point(814, 187);
            this.kryptonDataGridView2.Name = "kryptonDataGridView2";
            this.kryptonDataGridView2.RowHeadersVisible = false;
            this.kryptonDataGridView2.Size = new System.Drawing.Size(303, 432);
            this.kryptonDataGridView2.StateCommon.Background.Color1 = System.Drawing.Color.Transparent;
            this.kryptonDataGridView2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView2.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView2.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView2.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Maroon;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView2.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonDataGridView2.TabIndex = 65;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Priceperunit
            // 
            this.Priceperunit.HeaderText = "Price per unit";
            this.Priceperunit.Name = "Priceperunit";
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(863, 745);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton4.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton4.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton4.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton4.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton4.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.Size = new System.Drawing.Size(75, 45);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Border.Rounding = 20;
            this.kryptonButton4.StateCommon.Border.Width = 2;
            this.kryptonButton4.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.TabIndex = 61;
            this.kryptonButton4.Values.Text = "Reset";
            this.kryptonButton4.Click += new System.EventHandler(this.kryptonButton4_Click);
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(992, 744);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton3.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton3.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton3.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton3.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.Size = new System.Drawing.Size(75, 45);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 20;
            this.kryptonButton3.StateCommon.Border.Width = 2;
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 60;
            this.kryptonButton3.Values.Text = "Print";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton9
            // 
            this.kryptonButton9.Location = new System.Drawing.Point(441, 687);
            this.kryptonButton9.Name = "kryptonButton9";
            this.kryptonButton9.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton9.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9.Size = new System.Drawing.Size(108, 45);
            this.kryptonButton9.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9.StateCommon.Border.Rounding = 20;
            this.kryptonButton9.StateCommon.Border.Width = 2;
            this.kryptonButton9.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9.TabIndex = 57;
            this.kryptonButton9.Values.Text = "Add to Bill";
            this.kryptonButton9.Click += new System.EventHandler(this.kryptonButton9_Click);
            // 
            // kryptonTextBox3
            // 
            this.kryptonTextBox3.Location = new System.Drawing.Point(279, 693);
            this.kryptonTextBox3.MaximumSize = new System.Drawing.Size(150, 40);
            this.kryptonTextBox3.MinimumSize = new System.Drawing.Size(150, 40);
            this.kryptonTextBox3.Name = "kryptonTextBox3";
            this.kryptonTextBox3.Size = new System.Drawing.Size(150, 40);
            this.kryptonTextBox3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox3.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox3.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox3.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox3.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox3.StateDisabled.Border.Rounding = 20;
            this.kryptonTextBox3.TabIndex = 56;
            this.kryptonTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kryptonTextBox3_KeyPress);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNameDataGridViewTextBoxColumn,
            this.supplementsDataGridViewCheckBoxColumn,
            this.equipmentDataGridViewCheckBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.itemsV1BindingSource;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(100, 187);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(541, 432);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(6);
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.TabIndex = 33;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplementsDataGridViewCheckBoxColumn
            // 
            this.supplementsDataGridViewCheckBoxColumn.DataPropertyName = "Supplements";
            this.supplementsDataGridViewCheckBoxColumn.HeaderText = "Supplements";
            this.supplementsDataGridViewCheckBoxColumn.Name = "supplementsDataGridViewCheckBoxColumn";
            this.supplementsDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // equipmentDataGridViewCheckBoxColumn
            // 
            this.equipmentDataGridViewCheckBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewCheckBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewCheckBoxColumn.Name = "equipmentDataGridViewCheckBoxColumn";
            this.equipmentDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsV1BindingSource
            // 
            this.itemsV1BindingSource.DataMember = "ItemsV1";
            this.itemsV1BindingSource.DataSource = this.itemsDBv1DataSet;
            // 
            // itemsDBv1DataSet
            // 
            this.itemsDBv1DataSet.DataSetName = "ItemsDBv1DataSet";
            this.itemsDBv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.kryptonButton7);
            this.panel3.Controls.Add(this.kryptonDataGridView3);
            this.panel3.Controls.Add(this.kryptonButton6);
            this.panel3.Controls.Add(label8);
            this.panel3.Controls.Add(this.kryptonTextBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(380, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 840);
            this.panel3.TabIndex = 66;
            // 
            // kryptonButton7
            // 
            this.kryptonButton7.Location = new System.Drawing.Point(402, 229);
            this.kryptonButton7.Name = "kryptonButton7";
            this.kryptonButton7.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton7.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton7.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton7.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton7.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton7.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton7.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton7.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton7.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton7.Size = new System.Drawing.Size(100, 36);
            this.kryptonButton7.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton7.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryptonButton7.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton7.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton7.StateCommon.Border.Rounding = 20;
            this.kryptonButton7.StateCommon.Border.Width = 2;
            this.kryptonButton7.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton7.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton7.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonButton7.TabIndex = 63;
            this.kryptonButton7.Values.Text = "Clear History";
            this.kryptonButton7.Click += new System.EventHandler(this.kryptonButton7_Click);
            // 
            // kryptonDataGridView3
            // 
            this.kryptonDataGridView3.AutoGenerateColumns = false;
            this.kryptonDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.pricePeItemDataGridViewTextBoxColumn});
            this.kryptonDataGridView3.DataSource = this.salesV1BindingSource;
            this.kryptonDataGridView3.Location = new System.Drawing.Point(59, 295);
            this.kryptonDataGridView3.Name = "kryptonDataGridView3";
            this.kryptonDataGridView3.ReadOnly = true;
            this.kryptonDataGridView3.Size = new System.Drawing.Size(443, 493);
            this.kryptonDataGridView3.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonDataGridView3.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView3.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView3.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView3.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView3.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView3.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.kryptonDataGridView3.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonDataGridView3.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView3.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView3.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView3.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView3.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonDataGridView3.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView3.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView3.TabIndex = 62;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pricePeItemDataGridViewTextBoxColumn
            // 
            this.pricePeItemDataGridViewTextBoxColumn.DataPropertyName = "Price pe item";
            this.pricePeItemDataGridViewTextBoxColumn.HeaderText = "Price pe item";
            this.pricePeItemDataGridViewTextBoxColumn.Name = "pricePeItemDataGridViewTextBoxColumn";
            this.pricePeItemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesV1BindingSource
            // 
            this.salesV1BindingSource.DataMember = "SalesV1";
            this.salesV1BindingSource.DataSource = this.salesDBv1DataSet;
            // 
            // salesDBv1DataSet
            // 
            this.salesDBv1DataSet.DataSetName = "SalesDBv1DataSet";
            this.salesDBv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kryptonButton6
            // 
            this.kryptonButton6.Location = new System.Drawing.Point(326, 229);
            this.kryptonButton6.Name = "kryptonButton6";
            this.kryptonButton6.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton6.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton6.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton6.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton6.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton6.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.Size = new System.Drawing.Size(70, 36);
            this.kryptonButton6.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton6.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton6.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton6.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton6.StateCommon.Border.Rounding = 20;
            this.kryptonButton6.StateCommon.Border.Width = 2;
            this.kryptonButton6.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton6.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton6.TabIndex = 61;
            this.kryptonButton6.Values.Text = "Refrech";
            this.kryptonButton6.Click += new System.EventHandler(this.kryptonButton6_Click);
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(131, 229);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(189, 35);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20;
            this.kryptonTextBox1.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox1.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateDisabled.Border.Rounding = 20;
            this.kryptonTextBox1.TabIndex = 26;
            this.kryptonTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kryptonTextBox1_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.kryptonButton2);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 195);
            this.panel4.TabIndex = 0;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(3, 5);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton2.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton2.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.Size = new System.Drawing.Size(77, 43);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 20;
            this.kryptonButton2.StateCommon.Border.Width = 2;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 62;
            this.kryptonButton2.Values.Text = "Back";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(9, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 46);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sales History";
            // 
            // itemsV1TableAdapter
            // 
            this.itemsV1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ItemsV1TableAdapter = this.itemsV1TableAdapter;
            this.tableAdapterManager.UpdateOrder = Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(itemLabel);
            this.panel5.Controls.Add(this.itemTextBox);
            this.panel5.Controls.Add(quantityLabel1);
            this.panel5.Controls.Add(this.quantityTextBox);
            this.panel5.Controls.Add(price_pe_itemLabel);
            this.panel5.Controls.Add(this.price_pe_itemTextBox);
            this.panel5.Controls.Add(this.salesV1DataGridView);
            this.panel5.Controls.Add(this.salesV1BindingNavigator);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 378);
            this.panel5.TabIndex = 66;
            // 
            // itemTextBox
            // 
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesV1BindingSource, "Item", true));
            this.itemTextBox.Location = new System.Drawing.Point(157, 54);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemTextBox.TabIndex = 11;
            this.itemTextBox.TextChanged += new System.EventHandler(this.itemTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesV1BindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(157, 80);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 13;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // price_pe_itemTextBox
            // 
            this.price_pe_itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salesV1BindingSource, "Price pe item", true));
            this.price_pe_itemTextBox.Location = new System.Drawing.Point(157, 106);
            this.price_pe_itemTextBox.Name = "price_pe_itemTextBox";
            this.price_pe_itemTextBox.Size = new System.Drawing.Size(100, 20);
            this.price_pe_itemTextBox.TabIndex = 15;
            this.price_pe_itemTextBox.TextChanged += new System.EventHandler(this.price_pe_itemTextBox_TextChanged);
            // 
            // salesV1DataGridView
            // 
            this.salesV1DataGridView.AutoGenerateColumns = false;
            this.salesV1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesV1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.salesV1DataGridView.DataSource = this.salesV1BindingSource;
            this.salesV1DataGridView.Location = new System.Drawing.Point(32, 138);
            this.salesV1DataGridView.Name = "salesV1DataGridView";
            this.salesV1DataGridView.Size = new System.Drawing.Size(300, 220);
            this.salesV1DataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price pe item";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price pe item";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // salesV1BindingNavigator
            // 
            this.salesV1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesV1BindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.salesV1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesV1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesV1BindingNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.salesV1BindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salesV1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsV1BindingNavigatorSaveItem});
            this.salesV1BindingNavigator.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.salesV1BindingNavigator.Location = new System.Drawing.Point(349, 0);
            this.salesV1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesV1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesV1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesV1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesV1BindingNavigator.Name = "salesV1BindingNavigator";
            this.salesV1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesV1BindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.salesV1BindingNavigator.Size = new System.Drawing.Size(53, 378);
            this.salesV1BindingNavigator.TabIndex = 8;
            this.salesV1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Margin = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(50, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Margin = new System.Windows.Forms.Padding(0, 20, 0, 2);
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(50, 6);
            // 
            // productsV1BindingNavigatorSaveItem
            // 
            this.productsV1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsV1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsV1BindingNavigatorSaveItem.Image")));
            this.productsV1BindingNavigatorSaveItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.productsV1BindingNavigatorSaveItem.Name = "productsV1BindingNavigatorSaveItem";
            this.productsV1BindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(5);
            this.productsV1BindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 30);
            this.productsV1BindingNavigatorSaveItem.Text = "Save Data";
            this.productsV1BindingNavigatorSaveItem.Click += new System.EventHandler(this.productsV1BindingNavigatorSaveItem_Click);
            // 
            // salesV1TableAdapter
            // 
            this.salesV1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SalesV1TableAdapter = this.salesV1TableAdapter;
            this.tableAdapterManager1.UpdateOrder = Gym_Management_System_2.SalesDBv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1301, 840);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_ClientList);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1301, 840);
            this.MinimumSize = new System.Drawing.Size(1301, 726);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel_ClientList.ResumeLayout(false);
            this.panel_ClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv1DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDBv1DataSet)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesV1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesV1BindingNavigator)).EndInit();
            this.salesV1BindingNavigator.ResumeLayout(false);
            this.salesV1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ClientList;
        private System.Windows.Forms.Label label6_timer_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private ItemsDBv1DataSet itemsDBv1DataSet;
        private System.Windows.Forms.BindingSource itemsV1BindingSource;
        private ItemsDBv1DataSetTableAdapters.ItemsV1TableAdapter itemsV1TableAdapter;
        private ItemsDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priceperunit;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingNavigator salesV1BindingNavigator;
        public System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        public System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsV1BindingNavigatorSaveItem;
        private SalesDBv1DataSet salesDBv1DataSet;
        private System.Windows.Forms.BindingSource salesV1BindingSource;
        private SalesDBv1DataSetTableAdapters.SalesV1TableAdapter salesV1TableAdapter;
        private SalesDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox price_pe_itemTextBox;
        private System.Windows.Forms.DataGridView salesV1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePeItemDataGridViewTextBoxColumn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn supplementsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn equipmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9_panel5_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton7;
    }
}