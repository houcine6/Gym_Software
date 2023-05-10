
namespace Gym_Management_System_2
{
    partial class NewItemForm
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
            System.Windows.Forms.Label clothingLabel_NewProduct;
            System.Windows.Forms.Label nameLabel_NewProduct;
            System.Windows.Forms.Label bioLabel_NewProduct;
            System.Windows.Forms.Label quantityLabel_NewProduct;
            System.Windows.Forms.Label priceLabel_NewProduct;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItemForm));
            this.panel__NewProduct = new System.Windows.Forms.Panel();
            this.kryptonLabel2_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.prdouctsV2BindingNavigator_NewProduct = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.itemsV1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsDBv1DataSet = new Gym_Management_System_2.ItemsDBv1DataSet();
            this.bindingNavigatorCountItem_NewProduct = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator_NewProduct = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem_NewProduct = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1_NewProduct = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2_NewProduct = new System.Windows.Forms.ToolStripSeparator();
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct = new System.Windows.Forms.ToolStripButton();
            this.prdouctsV2KryptonDataGridView_NewProduct = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplementsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.equipmentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4_fel_NewProduct = new System.Windows.Forms.Panel();
            this.equipmentCheckBox = new System.Windows.Forms.CheckBox();
            this.supplementsCheckBox = new System.Windows.Forms.CheckBox();
            this.bioKryptonTextBox_NewProduct = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nameKryptonTextBox_NewProduct = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.quantityKryptonTextBox_NewProduct = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.priceKryptonTextBox_NewProduct = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel3_fel_NewProduct = new System.Windows.Forms.Panel();
            this.kryptonButton9_panel5_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchproductKryptonTextBox_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3_ProductsList = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3_timer_NewProduct = new System.Windows.Forms.Label();
            this.itemsV1TableAdapter = new Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.ItemsV1TableAdapter();
            this.tableAdapterManager = new Gym_Management_System_2.ItemsDBv1DataSetTableAdapters.TableAdapterManager();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            clothingLabel_NewProduct = new System.Windows.Forms.Label();
            nameLabel_NewProduct = new System.Windows.Forms.Label();
            bioLabel_NewProduct = new System.Windows.Forms.Label();
            quantityLabel_NewProduct = new System.Windows.Forms.Label();
            priceLabel_NewProduct = new System.Windows.Forms.Label();
            this.panel__NewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdouctsV2BindingNavigator_NewProduct)).BeginInit();
            this.prdouctsV2BindingNavigator_NewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdouctsV2KryptonDataGridView_NewProduct)).BeginInit();
            this.panel4_fel_NewProduct.SuspendLayout();
            this.panel3_fel_NewProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // clothingLabel_NewProduct
            // 
            clothingLabel_NewProduct.AutoSize = true;
            clothingLabel_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            clothingLabel_NewProduct.Location = new System.Drawing.Point(95, 469);
            clothingLabel_NewProduct.Name = "clothingLabel_NewProduct";
            clothingLabel_NewProduct.Size = new System.Drawing.Size(80, 16);
            clothingLabel_NewProduct.TabIndex = 9;
            clothingLabel_NewProduct.Text = "Categorie:";
            // 
            // nameLabel_NewProduct
            // 
            nameLabel_NewProduct.AutoSize = true;
            nameLabel_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            nameLabel_NewProduct.Location = new System.Drawing.Point(94, 232);
            nameLabel_NewProduct.Name = "nameLabel_NewProduct";
            nameLabel_NewProduct.Size = new System.Drawing.Size(86, 16);
            nameLabel_NewProduct.TabIndex = 3;
            nameLabel_NewProduct.Text = "Item Name:";
            // 
            // bioLabel_NewProduct
            // 
            bioLabel_NewProduct.AutoSize = true;
            bioLabel_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            bioLabel_NewProduct.Location = new System.Drawing.Point(95, 349);
            bioLabel_NewProduct.Name = "bioLabel_NewProduct";
            bioLabel_NewProduct.Size = new System.Drawing.Size(85, 16);
            bioLabel_NewProduct.TabIndex = 5;
            bioLabel_NewProduct.Text = "About Item:";
            // 
            // quantityLabel_NewProduct
            // 
            quantityLabel_NewProduct.AutoSize = true;
            quantityLabel_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            quantityLabel_NewProduct.Location = new System.Drawing.Point(94, 599);
            quantityLabel_NewProduct.Name = "quantityLabel_NewProduct";
            quantityLabel_NewProduct.Size = new System.Drawing.Size(68, 16);
            quantityLabel_NewProduct.TabIndex = 7;
            quantityLabel_NewProduct.Text = "Quantity:";
            // 
            // priceLabel_NewProduct
            // 
            priceLabel_NewProduct.AutoSize = true;
            priceLabel_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            priceLabel_NewProduct.Location = new System.Drawing.Point(95, 719);
            priceLabel_NewProduct.Name = "priceLabel_NewProduct";
            priceLabel_NewProduct.Size = new System.Drawing.Size(48, 16);
            priceLabel_NewProduct.TabIndex = 13;
            priceLabel_NewProduct.Text = "Price:";
            // 
            // panel__NewProduct
            // 
            this.panel__NewProduct.BackColor = System.Drawing.Color.DarkGray;
            this.panel__NewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel__NewProduct.Controls.Add(this.kryptonLabel2_ProductsList);
            this.panel__NewProduct.Controls.Add(this.kryptonLabel1_ProductsList);
            this.panel__NewProduct.Controls.Add(this.prdouctsV2BindingNavigator_NewProduct);
            this.panel__NewProduct.Controls.Add(clothingLabel_NewProduct);
            this.panel__NewProduct.Controls.Add(this.prdouctsV2KryptonDataGridView_NewProduct);
            this.panel__NewProduct.Controls.Add(this.panel4_fel_NewProduct);
            this.panel__NewProduct.Controls.Add(this.bioKryptonTextBox_NewProduct);
            this.panel__NewProduct.Controls.Add(nameLabel_NewProduct);
            this.panel__NewProduct.Controls.Add(this.nameKryptonTextBox_NewProduct);
            this.panel__NewProduct.Controls.Add(bioLabel_NewProduct);
            this.panel__NewProduct.Controls.Add(quantityLabel_NewProduct);
            this.panel__NewProduct.Controls.Add(this.quantityKryptonTextBox_NewProduct);
            this.panel__NewProduct.Controls.Add(priceLabel_NewProduct);
            this.panel__NewProduct.Controls.Add(this.priceKryptonTextBox_NewProduct);
            this.panel__NewProduct.Controls.Add(this.panel3_fel_NewProduct);
            this.panel__NewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel__NewProduct.Location = new System.Drawing.Point(0, 0);
            this.panel__NewProduct.Name = "panel__NewProduct";
            this.panel__NewProduct.Size = new System.Drawing.Size(1301, 840);
            this.panel__NewProduct.TabIndex = 8;
            this.panel__NewProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panel__NewProduct_Paint);
            // 
            // kryptonLabel2_ProductsList
            // 
            this.kryptonLabel2_ProductsList.Location = new System.Drawing.Point(881, 204);
            this.kryptonLabel2_ProductsList.Name = "kryptonLabel2_ProductsList";
            this.kryptonLabel2_ProductsList.Size = new System.Drawing.Size(21, 23);
            this.kryptonLabel2_ProductsList.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonLabel2_ProductsList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2_ProductsList.TabIndex = 20;
            this.kryptonLabel2_ProductsList.Values.Text = "0";
            // 
            // kryptonLabel1_ProductsList
            // 
            this.kryptonLabel1_ProductsList.Location = new System.Drawing.Point(734, 204);
            this.kryptonLabel1_ProductsList.Name = "kryptonLabel1_ProductsList";
            this.kryptonLabel1_ProductsList.Size = new System.Drawing.Size(132, 23);
            this.kryptonLabel1_ProductsList.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1_ProductsList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1_ProductsList.TabIndex = 19;
            this.kryptonLabel1_ProductsList.Values.Text = "Total Products :";
            // 
            // prdouctsV2BindingNavigator_NewProduct
            // 
            this.prdouctsV2BindingNavigator_NewProduct.AddNewItem = this.bindingNavigatorAddNewItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.BackColor = System.Drawing.Color.White;
            this.prdouctsV2BindingNavigator_NewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prdouctsV2BindingNavigator_NewProduct.BackgroundImage")));
            this.prdouctsV2BindingNavigator_NewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prdouctsV2BindingNavigator_NewProduct.BindingSource = this.itemsV1BindingSource;
            this.prdouctsV2BindingNavigator_NewProduct.CountItem = this.bindingNavigatorCountItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.DeleteItem = this.bindingNavigatorDeleteItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.prdouctsV2BindingNavigator_NewProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prdouctsV2BindingNavigator_NewProduct.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.prdouctsV2BindingNavigator_NewProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem_NewProduct,
            this.bindingNavigatorMovePreviousItem_NewProduct,
            this.bindingNavigatorSeparator_NewProduct,
            this.bindingNavigatorPositionItem_NewProduct,
            this.bindingNavigatorCountItem_NewProduct,
            this.bindingNavigatorSeparator1_NewProduct,
            this.bindingNavigatorMoveNextItem_NewProduct,
            this.bindingNavigatorMoveLastItem_NewProduct,
            this.bindingNavigatorSeparator2_NewProduct,
            this.bindingNavigatorAddNewItem_NewProduct,
            this.bindingNavigatorDeleteItem_NewProduct,
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct});
            this.prdouctsV2BindingNavigator_NewProduct.Location = new System.Drawing.Point(1248, 0);
            this.prdouctsV2BindingNavigator_NewProduct.MoveFirstItem = this.bindingNavigatorMoveFirstItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.MoveLastItem = this.bindingNavigatorMoveLastItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.MoveNextItem = this.bindingNavigatorMoveNextItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.MovePreviousItem = this.bindingNavigatorMovePreviousItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.Name = "prdouctsV2BindingNavigator_NewProduct";
            this.prdouctsV2BindingNavigator_NewProduct.PositionItem = this.bindingNavigatorPositionItem_NewProduct;
            this.prdouctsV2BindingNavigator_NewProduct.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.prdouctsV2BindingNavigator_NewProduct.Size = new System.Drawing.Size(53, 840);
            this.prdouctsV2BindingNavigator_NewProduct.Stretch = true;
            this.prdouctsV2BindingNavigator_NewProduct.TabIndex = 18;
            this.prdouctsV2BindingNavigator_NewProduct.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem_NewProduct
            // 
            this.bindingNavigatorAddNewItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem_NewProduct.Image")));
            this.bindingNavigatorAddNewItem_NewProduct.Margin = new System.Windows.Forms.Padding(0, 50, 0, 2);
            this.bindingNavigatorAddNewItem_NewProduct.Name = "bindingNavigatorAddNewItem_NewProduct";
            this.bindingNavigatorAddNewItem_NewProduct.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorAddNewItem_NewProduct.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem_NewProduct.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorAddNewItem_NewProduct.Text = "Add new";
            this.bindingNavigatorAddNewItem_NewProduct.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_NewProduct_Click);
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
            // bindingNavigatorCountItem_NewProduct
            // 
            this.bindingNavigatorCountItem_NewProduct.Name = "bindingNavigatorCountItem_NewProduct";
            this.bindingNavigatorCountItem_NewProduct.Size = new System.Drawing.Size(50, 15);
            this.bindingNavigatorCountItem_NewProduct.Text = "of {0}";
            this.bindingNavigatorCountItem_NewProduct.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem_NewProduct
            // 
            this.bindingNavigatorDeleteItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem_NewProduct.Image")));
            this.bindingNavigatorDeleteItem_NewProduct.Margin = new System.Windows.Forms.Padding(0, 15, 0, 2);
            this.bindingNavigatorDeleteItem_NewProduct.Name = "bindingNavigatorDeleteItem_NewProduct";
            this.bindingNavigatorDeleteItem_NewProduct.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorDeleteItem_NewProduct.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem_NewProduct.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorDeleteItem_NewProduct.Text = "Delete";
            this.bindingNavigatorDeleteItem_NewProduct.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_NewProduct_Click);
            // 
            // bindingNavigatorMoveFirstItem_NewProduct
            // 
            this.bindingNavigatorMoveFirstItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem_NewProduct.Image")));
            this.bindingNavigatorMoveFirstItem_NewProduct.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.bindingNavigatorMoveFirstItem_NewProduct.Name = "bindingNavigatorMoveFirstItem_NewProduct";
            this.bindingNavigatorMoveFirstItem_NewProduct.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem_NewProduct.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveFirstItem_NewProduct.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem_NewProduct
            // 
            this.bindingNavigatorMovePreviousItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem_NewProduct.Image")));
            this.bindingNavigatorMovePreviousItem_NewProduct.Name = "bindingNavigatorMovePreviousItem_NewProduct";
            this.bindingNavigatorMovePreviousItem_NewProduct.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorMovePreviousItem_NewProduct.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem_NewProduct.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorMovePreviousItem_NewProduct.Text = "Move previous";
            // 
            // bindingNavigatorSeparator_NewProduct
            // 
            this.bindingNavigatorSeparator_NewProduct.Name = "bindingNavigatorSeparator_NewProduct";
            this.bindingNavigatorSeparator_NewProduct.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorPositionItem_NewProduct
            // 
            this.bindingNavigatorPositionItem_NewProduct.AccessibleName = "Position";
            this.bindingNavigatorPositionItem_NewProduct.AutoSize = false;
            this.bindingNavigatorPositionItem_NewProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem_NewProduct.Name = "bindingNavigatorPositionItem_NewProduct";
            this.bindingNavigatorPositionItem_NewProduct.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem_NewProduct.Text = "0";
            this.bindingNavigatorPositionItem_NewProduct.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1_NewProduct
            // 
            this.bindingNavigatorSeparator1_NewProduct.Name = "bindingNavigatorSeparator1_NewProduct";
            this.bindingNavigatorSeparator1_NewProduct.Size = new System.Drawing.Size(50, 6);
            // 
            // bindingNavigatorMoveNextItem_NewProduct
            // 
            this.bindingNavigatorMoveNextItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem_NewProduct.Image")));
            this.bindingNavigatorMoveNextItem_NewProduct.Name = "bindingNavigatorMoveNextItem_NewProduct";
            this.bindingNavigatorMoveNextItem_NewProduct.Padding = new System.Windows.Forms.Padding(5);
            this.bindingNavigatorMoveNextItem_NewProduct.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem_NewProduct.Size = new System.Drawing.Size(50, 30);
            this.bindingNavigatorMoveNextItem_NewProduct.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem_NewProduct
            // 
            this.bindingNavigatorMoveLastItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem_NewProduct.Image")));
            this.bindingNavigatorMoveLastItem_NewProduct.Name = "bindingNavigatorMoveLastItem_NewProduct";
            this.bindingNavigatorMoveLastItem_NewProduct.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem_NewProduct.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorMoveLastItem_NewProduct.Text = "Move last";
            // 
            // bindingNavigatorSeparator2_NewProduct
            // 
            this.bindingNavigatorSeparator2_NewProduct.Name = "bindingNavigatorSeparator2_NewProduct";
            this.bindingNavigatorSeparator2_NewProduct.Size = new System.Drawing.Size(50, 6);
            // 
            // prdouctsV2BindingNavigatorSaveItem_NewProduct
            // 
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Image = ((System.Drawing.Image)(resources.GetObject("prdouctsV2BindingNavigatorSaveItem_NewProduct.Image")));
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Margin = new System.Windows.Forms.Padding(0, 15, 0, 2);
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Name = "prdouctsV2BindingNavigatorSaveItem_NewProduct";
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Padding = new System.Windows.Forms.Padding(5);
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Size = new System.Drawing.Size(50, 30);
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Text = "Save Data";
            this.prdouctsV2BindingNavigatorSaveItem_NewProduct.Click += new System.EventHandler(this.prdouctsV2BindingNavigatorSaveItem_NewProduct_Click);
            // 
            // prdouctsV2KryptonDataGridView_NewProduct
            // 
            this.prdouctsV2KryptonDataGridView_NewProduct.AutoGenerateColumns = false;
            this.prdouctsV2KryptonDataGridView_NewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prdouctsV2KryptonDataGridView_NewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.aboutItemDataGridViewTextBoxColumn,
            this.supplementsDataGridViewCheckBoxColumn,
            this.equipmentDataGridViewCheckBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.prdouctsV2KryptonDataGridView_NewProduct.DataSource = this.itemsV1BindingSource;
            this.prdouctsV2KryptonDataGridView_NewProduct.Location = new System.Drawing.Point(428, 249);
            this.prdouctsV2KryptonDataGridView_NewProduct.Name = "prdouctsV2KryptonDataGridView_NewProduct";
            this.prdouctsV2KryptonDataGridView_NewProduct.Size = new System.Drawing.Size(742, 548);
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Brown;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Silver;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.Gray;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.Gray;
            this.prdouctsV2KryptonDataGridView_NewProduct.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.prdouctsV2KryptonDataGridView_NewProduct.TabIndex = 17;
            this.prdouctsV2KryptonDataGridView_NewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prdouctsV2KryptonDataGridView_NewProduct_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // aboutItemDataGridViewTextBoxColumn
            // 
            this.aboutItemDataGridViewTextBoxColumn.DataPropertyName = "About Item";
            this.aboutItemDataGridViewTextBoxColumn.HeaderText = "About Item";
            this.aboutItemDataGridViewTextBoxColumn.Name = "aboutItemDataGridViewTextBoxColumn";
            // 
            // supplementsDataGridViewCheckBoxColumn
            // 
            this.supplementsDataGridViewCheckBoxColumn.DataPropertyName = "Supplements";
            this.supplementsDataGridViewCheckBoxColumn.HeaderText = "Supplements";
            this.supplementsDataGridViewCheckBoxColumn.Name = "supplementsDataGridViewCheckBoxColumn";
            // 
            // equipmentDataGridViewCheckBoxColumn
            // 
            this.equipmentDataGridViewCheckBoxColumn.DataPropertyName = "Equipment";
            this.equipmentDataGridViewCheckBoxColumn.HeaderText = "Equipment";
            this.equipmentDataGridViewCheckBoxColumn.Name = "equipmentDataGridViewCheckBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // panel4_fel_NewProduct
            // 
            this.panel4_fel_NewProduct.BackColor = System.Drawing.Color.White;
            this.panel4_fel_NewProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4_fel_NewProduct.Controls.Add(this.equipmentCheckBox);
            this.panel4_fel_NewProduct.Controls.Add(this.supplementsCheckBox);
            this.panel4_fel_NewProduct.Location = new System.Drawing.Point(98, 495);
            this.panel4_fel_NewProduct.Name = "panel4_fel_NewProduct";
            this.panel4_fel_NewProduct.Size = new System.Drawing.Size(201, 40);
            this.panel4_fel_NewProduct.TabIndex = 16;
            // 
            // equipmentCheckBox
            // 
            this.equipmentCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.itemsV1BindingSource, "Equipment", true));
            this.equipmentCheckBox.Enabled = false;
            this.equipmentCheckBox.Location = new System.Drawing.Point(114, 7);
            this.equipmentCheckBox.Name = "equipmentCheckBox";
            this.equipmentCheckBox.Size = new System.Drawing.Size(80, 24);
            this.equipmentCheckBox.TabIndex = 20;
            this.equipmentCheckBox.Text = "Equipment";
            this.equipmentCheckBox.UseVisualStyleBackColor = true;
            this.equipmentCheckBox.CheckedChanged += new System.EventHandler(this.equipmentCheckBox_CheckedChanged);
            // 
            // supplementsCheckBox
            // 
            this.supplementsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.itemsV1BindingSource, "Supplements", true));
            this.supplementsCheckBox.Enabled = false;
            this.supplementsCheckBox.Location = new System.Drawing.Point(10, 7);
            this.supplementsCheckBox.Name = "supplementsCheckBox";
            this.supplementsCheckBox.Size = new System.Drawing.Size(88, 24);
            this.supplementsCheckBox.TabIndex = 19;
            this.supplementsCheckBox.Text = "Supplements";
            this.supplementsCheckBox.UseVisualStyleBackColor = true;
            this.supplementsCheckBox.CheckedChanged += new System.EventHandler(this.supplementsCheckBox_CheckedChanged);
            // 
            // bioKryptonTextBox_NewProduct
            // 
            this.bioKryptonTextBox_NewProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsV1BindingSource, "About Item", true));
            this.bioKryptonTextBox_NewProduct.Enabled = false;
            this.bioKryptonTextBox_NewProduct.Location = new System.Drawing.Point(98, 372);
            this.bioKryptonTextBox_NewProduct.MaximumSize = new System.Drawing.Size(200, 40);
            this.bioKryptonTextBox_NewProduct.MinimumSize = new System.Drawing.Size(200, 40);
            this.bioKryptonTextBox_NewProduct.Name = "bioKryptonTextBox_NewProduct";
            this.bioKryptonTextBox_NewProduct.Size = new System.Drawing.Size(200, 40);
            this.bioKryptonTextBox_NewProduct.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.bioKryptonTextBox_NewProduct.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.bioKryptonTextBox_NewProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bioKryptonTextBox_NewProduct.StateCommon.Border.Rounding = 20;
            this.bioKryptonTextBox_NewProduct.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.bioKryptonTextBox_NewProduct.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioKryptonTextBox_NewProduct.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.bioKryptonTextBox_NewProduct.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.bioKryptonTextBox_NewProduct.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bioKryptonTextBox_NewProduct.StateDisabled.Border.Rounding = 20;
            this.bioKryptonTextBox_NewProduct.TabIndex = 6;
            // 
            // nameKryptonTextBox_NewProduct
            // 
            this.nameKryptonTextBox_NewProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsV1BindingSource, "Item Name", true));
            this.nameKryptonTextBox_NewProduct.Enabled = false;
            this.nameKryptonTextBox_NewProduct.Location = new System.Drawing.Point(97, 255);
            this.nameKryptonTextBox_NewProduct.MaximumSize = new System.Drawing.Size(200, 40);
            this.nameKryptonTextBox_NewProduct.MinimumSize = new System.Drawing.Size(200, 40);
            this.nameKryptonTextBox_NewProduct.Name = "nameKryptonTextBox_NewProduct";
            this.nameKryptonTextBox_NewProduct.Size = new System.Drawing.Size(200, 40);
            this.nameKryptonTextBox_NewProduct.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.nameKryptonTextBox_NewProduct.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.nameKryptonTextBox_NewProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameKryptonTextBox_NewProduct.StateCommon.Border.Rounding = 20;
            this.nameKryptonTextBox_NewProduct.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameKryptonTextBox_NewProduct.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.nameKryptonTextBox_NewProduct.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.nameKryptonTextBox_NewProduct.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameKryptonTextBox_NewProduct.StateDisabled.Border.Rounding = 20;
            this.nameKryptonTextBox_NewProduct.TabIndex = 4;
            // 
            // quantityKryptonTextBox_NewProduct
            // 
            this.quantityKryptonTextBox_NewProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsV1BindingSource, "Quantity", true));
            this.quantityKryptonTextBox_NewProduct.Enabled = false;
            this.quantityKryptonTextBox_NewProduct.Location = new System.Drawing.Point(97, 622);
            this.quantityKryptonTextBox_NewProduct.MaximumSize = new System.Drawing.Size(200, 40);
            this.quantityKryptonTextBox_NewProduct.MinimumSize = new System.Drawing.Size(200, 40);
            this.quantityKryptonTextBox_NewProduct.Name = "quantityKryptonTextBox_NewProduct";
            this.quantityKryptonTextBox_NewProduct.Size = new System.Drawing.Size(200, 40);
            this.quantityKryptonTextBox_NewProduct.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.quantityKryptonTextBox_NewProduct.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.quantityKryptonTextBox_NewProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.quantityKryptonTextBox_NewProduct.StateCommon.Border.Rounding = 20;
            this.quantityKryptonTextBox_NewProduct.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.quantityKryptonTextBox_NewProduct.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityKryptonTextBox_NewProduct.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.quantityKryptonTextBox_NewProduct.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.quantityKryptonTextBox_NewProduct.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.quantityKryptonTextBox_NewProduct.StateDisabled.Border.Rounding = 20;
            this.quantityKryptonTextBox_NewProduct.TabIndex = 8;
            this.quantityKryptonTextBox_NewProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityKryptonTextBox_NewProduct_KeyPress);
            // 
            // priceKryptonTextBox_NewProduct
            // 
            this.priceKryptonTextBox_NewProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemsV1BindingSource, "Price", true));
            this.priceKryptonTextBox_NewProduct.Enabled = false;
            this.priceKryptonTextBox_NewProduct.Location = new System.Drawing.Point(97, 738);
            this.priceKryptonTextBox_NewProduct.MaximumSize = new System.Drawing.Size(200, 40);
            this.priceKryptonTextBox_NewProduct.MinimumSize = new System.Drawing.Size(200, 40);
            this.priceKryptonTextBox_NewProduct.Name = "priceKryptonTextBox_NewProduct";
            this.priceKryptonTextBox_NewProduct.Size = new System.Drawing.Size(200, 40);
            this.priceKryptonTextBox_NewProduct.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.priceKryptonTextBox_NewProduct.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.priceKryptonTextBox_NewProduct.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.priceKryptonTextBox_NewProduct.StateCommon.Border.Rounding = 20;
            this.priceKryptonTextBox_NewProduct.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.priceKryptonTextBox_NewProduct.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceKryptonTextBox_NewProduct.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.priceKryptonTextBox_NewProduct.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.priceKryptonTextBox_NewProduct.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.priceKryptonTextBox_NewProduct.TabIndex = 14;
            this.priceKryptonTextBox_NewProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceKryptonTextBox_NewProduct_KeyPress);
            // 
            // panel3_fel_NewProduct
            // 
            this.panel3_fel_NewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3_fel_NewProduct.BackgroundImage")));
            this.panel3_fel_NewProduct.Controls.Add(this.kryptonButton9_panel5_ProductsList);
            this.panel3_fel_NewProduct.Controls.Add(this.searchproductKryptonTextBox_ProductsList);
            this.panel3_fel_NewProduct.Controls.Add(this.kryptonLabel3_ProductsList);
            this.panel3_fel_NewProduct.Controls.Add(this.label1);
            this.panel3_fel_NewProduct.Controls.Add(this.label3_timer_NewProduct);
            this.panel3_fel_NewProduct.Location = new System.Drawing.Point(0, 0);
            this.panel3_fel_NewProduct.Margin = new System.Windows.Forms.Padding(0);
            this.panel3_fel_NewProduct.Name = "panel3_fel_NewProduct";
            this.panel3_fel_NewProduct.Size = new System.Drawing.Size(1248, 174);
            this.panel3_fel_NewProduct.TabIndex = 0;
            // 
            // kryptonButton9_panel5_ProductsList
            // 
            this.kryptonButton9_panel5_ProductsList.Location = new System.Drawing.Point(1146, 118);
            this.kryptonButton9_panel5_ProductsList.Name = "kryptonButton9_panel5_ProductsList";
            this.kryptonButton9_panel5_ProductsList.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_panel5_ProductsList.OverrideDefault.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_panel5_ProductsList.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kryptonButton9_panel5_ProductsList.OverrideFocus.Back.Color2 = System.Drawing.Color.Maroon;
            this.kryptonButton9_panel5_ProductsList.Size = new System.Drawing.Size(71, 40);
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
            this.kryptonButton9_panel5_ProductsList.TabIndex = 23;
            this.kryptonButton9_panel5_ProductsList.Values.Text = "Refrech";
            this.kryptonButton9_panel5_ProductsList.Click += new System.EventHandler(this.kryptonButton9_panel5_ProductsList_Click);
            // 
            // searchproductKryptonTextBox_ProductsList
            // 
            this.searchproductKryptonTextBox_ProductsList.Location = new System.Drawing.Point(910, 118);
            this.searchproductKryptonTextBox_ProductsList.MaximumSize = new System.Drawing.Size(223, 40);
            this.searchproductKryptonTextBox_ProductsList.MinimumSize = new System.Drawing.Size(223, 40);
            this.searchproductKryptonTextBox_ProductsList.Name = "searchproductKryptonTextBox_ProductsList";
            this.searchproductKryptonTextBox_ProductsList.Size = new System.Drawing.Size(223, 40);
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Border.Rounding = 20;
            this.searchproductKryptonTextBox_ProductsList.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Back.Color1 = System.Drawing.Color.Silver;
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Border.Color1 = System.Drawing.Color.Silver;
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchproductKryptonTextBox_ProductsList.StateDisabled.Border.Rounding = 20;
            this.searchproductKryptonTextBox_ProductsList.TabIndex = 22;
            this.searchproductKryptonTextBox_ProductsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchproductKryptonTextBox_ProductsList_KeyDown);
            // 
            // kryptonLabel3_ProductsList
            // 
            this.kryptonLabel3_ProductsList.Location = new System.Drawing.Point(767, 126);
            this.kryptonLabel3_ProductsList.Name = "kryptonLabel3_ProductsList";
            this.kryptonLabel3_ProductsList.Size = new System.Drawing.Size(137, 23);
            this.kryptonLabel3_ProductsList.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel3_ProductsList.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel3_ProductsList.TabIndex = 21;
            this.kryptonLabel3_ProductsList.Values.Text = "Search product :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(1042, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 47);
            this.label1.TabIndex = 20;
            this.label1.Text = "New Item";
            // 
            // label3_timer_NewProduct
            // 
            this.label3_timer_NewProduct.AutoSize = true;
            this.label3_timer_NewProduct.BackColor = System.Drawing.Color.Transparent;
            this.label3_timer_NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_timer_NewProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3_timer_NewProduct.Location = new System.Drawing.Point(5, 7);
            this.label3_timer_NewProduct.Name = "label3_timer_NewProduct";
            this.label3_timer_NewProduct.Size = new System.Drawing.Size(168, 44);
            this.label3_timer_NewProduct.TabIndex = 17;
            this.label3_timer_NewProduct.Text = "00:00:00";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 840);
            this.Controls.Add(this.panel__NewProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1301, 840);
            this.MinimumSize = new System.Drawing.Size(1301, 726);
            this.Name = "NewItemForm";
            this.Text = "NewItem";
            this.Load += new System.EventHandler(this.NewItemForm_Load);
            this.panel__NewProduct.ResumeLayout(false);
            this.panel__NewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdouctsV2BindingNavigator_NewProduct)).EndInit();
            this.prdouctsV2BindingNavigator_NewProduct.ResumeLayout(false);
            this.prdouctsV2BindingNavigator_NewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsV1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDBv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdouctsV2KryptonDataGridView_NewProduct)).EndInit();
            this.panel4_fel_NewProduct.ResumeLayout(false);
            this.panel3_fel_NewProduct.ResumeLayout(false);
            this.panel3_fel_NewProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel__NewProduct;
        private System.Windows.Forms.Panel panel4_fel_NewProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox bioKryptonTextBox_NewProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameKryptonTextBox_NewProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox quantityKryptonTextBox_NewProduct;
        private System.Windows.Forms.Panel panel3_fel_NewProduct;
        private System.Windows.Forms.Label label3_timer_NewProduct;
        private ItemsDBv1DataSet itemsDBv1DataSet;
        private System.Windows.Forms.BindingSource itemsV1BindingSource;
        private ItemsDBv1DataSetTableAdapters.ItemsV1TableAdapter itemsV1TableAdapter;
        private ItemsDBv1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator prdouctsV2BindingNavigator_NewProduct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem_NewProduct;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem_NewProduct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem_NewProduct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem_NewProduct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem_NewProduct;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator_NewProduct;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem_NewProduct;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1_NewProduct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem_NewProduct;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem_NewProduct;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2_NewProduct;
        private System.Windows.Forms.ToolStripButton prdouctsV2BindingNavigatorSaveItem_NewProduct;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView prdouctsV2KryptonDataGridView_NewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn supplementsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn equipmentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox priceKryptonTextBox_NewProduct;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox equipmentCheckBox;
        private System.Windows.Forms.CheckBox supplementsCheckBox;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox searchproductKryptonTextBox_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3_ProductsList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton9_panel5_ProductsList;
    }
}