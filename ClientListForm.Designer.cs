
namespace Gym_Management_System_2
{
    partial class ClientListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientListForm));
            this.panel_ClientList = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.clientsV2KryptonDataGridView_NewClient = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.femaleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDBv1DataSet = new Gym_Management_System_2.ClientsDBv1DataSet();
            this.searchKryptonTextBox__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButton9_ClientList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1__ClientList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel4_fel_ClientList = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6_timer_ClientList = new System.Windows.Forms.Label();
            this.clientsV1TableAdapter = new Gym_Management_System_2.ClientsDBv1DataSetTableAdapters.ClientsV1TableAdapter();
            this.tableAdapterManager = new Gym_Management_System_2.ClientsDBv1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_ClientList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV2KryptonDataGridView_NewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv1DataSet)).BeginInit();
            this.panel4_fel_ClientList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ClientList
            // 
            this.panel_ClientList.BackColor = System.Drawing.Color.DarkGray;
            this.panel_ClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_ClientList.Controls.Add(this.kryptonButton1);
            this.panel_ClientList.Controls.Add(this.clientsV2KryptonDataGridView_NewClient);
            this.panel_ClientList.Controls.Add(this.searchKryptonTextBox__ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonButton9_ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonLabel3__ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonLabel2__ClientList);
            this.panel_ClientList.Controls.Add(this.kryptonLabel1__ClientList);
            this.panel_ClientList.Controls.Add(this.panel4_fel_ClientList);
            this.panel_ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ClientList.Location = new System.Drawing.Point(0, 0);
            this.panel_ClientList.Name = "panel_ClientList";
            this.panel_ClientList.Size = new System.Drawing.Size(1301, 840);
            this.panel_ClientList.TabIndex = 18;
            this.panel_ClientList.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ClientList_Paint);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(1077, 245);
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
            this.kryptonButton1.Size = new System.Drawing.Size(106, 41);
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
            this.kryptonButton1.TabIndex = 33;
            this.kryptonButton1.Values.Text = "Expired clients";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // clientsV2KryptonDataGridView_NewClient
            // 
            this.clientsV2KryptonDataGridView_NewClient.AutoGenerateColumns = false;
            this.clientsV2KryptonDataGridView_NewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsV2KryptonDataGridView_NewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.maleDataGridViewCheckBoxColumn,
            this.femaleDataGridViewCheckBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.registrationDateDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.clientsV2KryptonDataGridView_NewClient.DataSource = this.clientsV1BindingSource;
            this.clientsV2KryptonDataGridView_NewClient.Location = new System.Drawing.Point(80, 317);
            this.clientsV2KryptonDataGridView_NewClient.Name = "clientsV2KryptonDataGridView_NewClient";
            this.clientsV2KryptonDataGridView_NewClient.Size = new System.Drawing.Size(1142, 481);
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.clientsV2KryptonDataGridView_NewClient.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.clientsV2KryptonDataGridView_NewClient.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.clientsV2KryptonDataGridView_NewClient.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.clientsV2KryptonDataGridView_NewClient.TabIndex = 32;
            this.clientsV2KryptonDataGridView_NewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsV2KryptonDataGridView_NewClient_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // maleDataGridViewCheckBoxColumn
            // 
            this.maleDataGridViewCheckBoxColumn.DataPropertyName = "Male";
            this.maleDataGridViewCheckBoxColumn.HeaderText = "Male";
            this.maleDataGridViewCheckBoxColumn.Name = "maleDataGridViewCheckBoxColumn";
            // 
            // femaleDataGridViewCheckBoxColumn
            // 
            this.femaleDataGridViewCheckBoxColumn.DataPropertyName = "Female";
            this.femaleDataGridViewCheckBoxColumn.HeaderText = "Female";
            this.femaleDataGridViewCheckBoxColumn.Name = "femaleDataGridViewCheckBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E-mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // registrationDateDataGridViewTextBoxColumn
            // 
            this.registrationDateDataGridViewTextBoxColumn.DataPropertyName = "Registration Date";
            this.registrationDateDataGridViewTextBoxColumn.HeaderText = "Registration Date";
            this.registrationDateDataGridViewTextBoxColumn.Name = "registrationDateDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "Expiration Date";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Expiration Date";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "Amount Paid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "Amount Paid";
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            // 
            // clientsV1BindingSource
            // 
            this.clientsV1BindingSource.DataMember = "ClientsV1";
            this.clientsV1BindingSource.DataSource = this.clientsDBv1DataSet;
            // 
            // clientsDBv1DataSet
            // 
            this.clientsDBv1DataSet.DataSetName = "ClientsDBv1DataSet";
            this.clientsDBv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchKryptonTextBox__ClientList
            // 
            this.searchKryptonTextBox__ClientList.Location = new System.Drawing.Point(554, 246);
            this.searchKryptonTextBox__ClientList.MaximumSize = new System.Drawing.Size(254, 40);
            this.searchKryptonTextBox__ClientList.MinimumSize = new System.Drawing.Size(254, 40);
            this.searchKryptonTextBox__ClientList.Name = "searchKryptonTextBox__ClientList";
            this.searchKryptonTextBox__ClientList.Size = new System.Drawing.Size(254, 40);
            this.searchKryptonTextBox__ClientList.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.searchKryptonTextBox__ClientList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.searchKryptonTextBox__ClientList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchKryptonTextBox__ClientList.StateCommon.Border.Rounding = 20;
            this.searchKryptonTextBox__ClientList.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchKryptonTextBox__ClientList.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.searchKryptonTextBox__ClientList.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.searchKryptonTextBox__ClientList.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchKryptonTextBox__ClientList.StateDisabled.Border.Rounding = 20;
            this.searchKryptonTextBox__ClientList.TabIndex = 9;
            this.searchKryptonTextBox__ClientList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchKryptonTextBox__ClientList_KeyDown);
            // 
            // kryptonButton9_ClientList
            // 
            this.kryptonButton9_ClientList.Location = new System.Drawing.Point(814, 245);
            this.kryptonButton9_ClientList.Name = "kryptonButton9_ClientList";
            this.kryptonButton9_ClientList.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_ClientList.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_ClientList.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_ClientList.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_ClientList.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_ClientList.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_ClientList.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_ClientList.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_ClientList.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_ClientList.OverrideFocus.Border.Rounding = 20;
            this.kryptonButton9_ClientList.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_ClientList.Size = new System.Drawing.Size(72, 41);
            this.kryptonButton9_ClientList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_ClientList.StateCommon.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_ClientList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9_ClientList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton9_ClientList.StateCommon.Border.Rounding = 20;
            this.kryptonButton9_ClientList.StateCommon.Border.Width = 2;
            this.kryptonButton9_ClientList.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton9_ClientList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton9_ClientList.TabIndex = 7;
            this.kryptonButton9_ClientList.Values.Text = "Refrech";
            this.kryptonButton9_ClientList.Click += new System.EventHandler(this.kryptonButton9_ClientList_Click);
            // 
            // kryptonLabel3__ClientList
            // 
            this.kryptonLabel3__ClientList.Location = new System.Drawing.Point(403, 254);
            this.kryptonLabel3__ClientList.Name = "kryptonLabel3__ClientList";
            this.kryptonLabel3__ClientList.Size = new System.Drawing.Size(145, 23);
            this.kryptonLabel3__ClientList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3__ClientList.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3__ClientList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3__ClientList.TabIndex = 8;
            this.kryptonLabel3__ClientList.Values.Text = "Search by name :";
            // 
            // kryptonLabel2__ClientList
            // 
            this.kryptonLabel2__ClientList.Location = new System.Drawing.Point(239, 256);
            this.kryptonLabel2__ClientList.Name = "kryptonLabel2__ClientList";
            this.kryptonLabel2__ClientList.Size = new System.Drawing.Size(21, 23);
            this.kryptonLabel2__ClientList.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel2__ClientList.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2__ClientList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2__ClientList.TabIndex = 4;
            this.kryptonLabel2__ClientList.Values.Text = "0";
            // 
            // kryptonLabel1__ClientList
            // 
            this.kryptonLabel1__ClientList.Location = new System.Drawing.Point(103, 256);
            this.kryptonLabel1__ClientList.Name = "kryptonLabel1__ClientList";
            this.kryptonLabel1__ClientList.Size = new System.Drawing.Size(117, 23);
            this.kryptonLabel1__ClientList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1__ClientList.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1__ClientList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1__ClientList.TabIndex = 3;
            this.kryptonLabel1__ClientList.Values.Text = "Total Clients :";
            // 
            // panel4_fel_ClientList
            // 
            this.panel4_fel_ClientList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4_fel_ClientList.BackgroundImage")));
            this.panel4_fel_ClientList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4_fel_ClientList.Controls.Add(this.label2);
            this.panel4_fel_ClientList.Controls.Add(this.label6_timer_ClientList);
            this.panel4_fel_ClientList.Location = new System.Drawing.Point(0, 0);
            this.panel4_fel_ClientList.Margin = new System.Windows.Forms.Padding(0);
            this.panel4_fel_ClientList.Name = "panel4_fel_ClientList";
            this.panel4_fel_ClientList.Size = new System.Drawing.Size(1301, 212);
            this.panel4_fel_ClientList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(1087, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 47);
            this.label2.TabIndex = 19;
            this.label2.Text = "Client List";
            // 
            // label6_timer_ClientList
            // 
            this.label6_timer_ClientList.AutoSize = true;
            this.label6_timer_ClientList.BackColor = System.Drawing.Color.Transparent;
            this.label6_timer_ClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_timer_ClientList.ForeColor = System.Drawing.Color.White;
            this.label6_timer_ClientList.Location = new System.Drawing.Point(12, 157);
            this.label6_timer_ClientList.Name = "label6_timer_ClientList";
            this.label6_timer_ClientList.Size = new System.Drawing.Size(174, 46);
            this.label6_timer_ClientList.TabIndex = 18;
            this.label6_timer_ClientList.Text = "00:00:00";
            // 
            // clientsV1TableAdapter
            // 
            this.clientsV1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsV1TableAdapter = this.clientsV1TableAdapter;
            this.tableAdapterManager.UpdateOrder = Gym_Management_System_2.ClientsDBv1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.kryptonLabel2);
            this.panel1.Controls.Add(this.kryptonDataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(380, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 840);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(300, 230);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(21, 23);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Red;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 35;
            this.kryptonLabel1.Values.Text = "0";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(165, 230);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(117, 23);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 34;
            this.kryptonLabel2.Values.Text = "Total Clients :";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.expirationdate});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(76, 278);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(342, 523);
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
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.TabIndex = 33;
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First name";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            // 
            // expirationdate
            // 
            this.expirationdate.HeaderText = "Expiration Date";
            this.expirationdate.Name = "expirationdate";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.kryptonButton2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 203);
            this.panel2.TabIndex = 3;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(6, 7);
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
            this.kryptonButton2.Size = new System.Drawing.Size(79, 45);
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
            this.kryptonButton2.TabIndex = 63;
            this.kryptonButton2.Values.Text = "Back";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(99, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "Expired Clients";
            // 
            // ClientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1301, 840);
            this.Controls.Add(this.panel_ClientList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1301, 840);
            this.MinimumSize = new System.Drawing.Size(1301, 726);
            this.Name = "ClientListForm";
            this.Text = "ClientListForm";
            this.Load += new System.EventHandler(this.ClientListForm_Load);
            this.panel_ClientList.ResumeLayout(false);
            this.panel_ClientList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV2KryptonDataGridView_NewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDBv1DataSet)).EndInit();
            this.panel4_fel_ClientList.ResumeLayout(false);
            this.panel4_fel_ClientList.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchKryptonTextBox__ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3__ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2__ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1__ClientList;
        private System.Windows.Forms.Panel panel4_fel_ClientList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6_timer_ClientList;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView clientsV2KryptonDataGridView_NewClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn maleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn femaleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsV1BindingSource;
        private ClientsDBv1DataSet clientsDBv1DataSet;
        private ClientsDBv1DataSetTableAdapters.ClientsV1TableAdapter clientsV1TableAdapter;
        private ClientsDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationdate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}