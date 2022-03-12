namespace L1_i.nechaev
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iVT_2022DataSet = new L1_i.nechaev.IVT_2022DataSet();
            this.nechaev_t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.i_nechaev_t1TableAdapter = new L1_i.nechaev.IVT_2022DataSetTableAdapters.i_nechaev_t1TableAdapter();
            this.tableAdapterManager = new L1_i.nechaev.IVT_2022DataSetTableAdapters.TableAdapterManager();
            this.nechaev_t1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.nechaev_t1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.i_nechaev_t1DataGridView = new System.Windows.Forms.DataGridView();
            this.inechaevt1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVT2022DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nechaev_t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nechaev_t1BindingNavigator)).BeginInit();
            this.nechaev_t1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_nechaev_t1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inechaevt1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT2022DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iVT_2022DataSet
            // 
            this.iVT_2022DataSet.DataSetName = "IVT_2022DataSet";
            this.iVT_2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nechaev_t1BindingSource
            // 
            this.nechaev_t1BindingSource.DataSource = this.iVT_2022DataSet;
            this.nechaev_t1BindingSource.Position = 0;
            // 
            // i_nechaev_t1TableAdapter
            // 
            this.i_nechaev_t1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.i_nechaev_t1TableAdapter = this.i_nechaev_t1TableAdapter;
            this.tableAdapterManager.UpdateOrder = L1_i.nechaev.IVT_2022DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nechaev_t1BindingNavigator
            // 
            this.nechaev_t1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nechaev_t1BindingNavigator.BindingSource = this.nechaev_t1BindingSource;
            this.nechaev_t1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nechaev_t1BindingNavigator.DeleteItem = null;
            this.nechaev_t1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton2,
            this.bindingNavigatorAddNewItem,
            this.nechaev_t1BindingNavigatorSaveItem});
            this.nechaev_t1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nechaev_t1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nechaev_t1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nechaev_t1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nechaev_t1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nechaev_t1BindingNavigator.Name = "nechaev_t1BindingNavigator";
            this.nechaev_t1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nechaev_t1BindingNavigator.Size = new System.Drawing.Size(387, 25);
            this.nechaev_t1BindingNavigator.TabIndex = 0;
            this.nechaev_t1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "1";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // nechaev_t1BindingNavigatorSaveItem
            // 
            this.nechaev_t1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nechaev_t1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nechaev_t1BindingNavigatorSaveItem.Image")));
            this.nechaev_t1BindingNavigatorSaveItem.Name = "nechaev_t1BindingNavigatorSaveItem";
            this.nechaev_t1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nechaev_t1BindingNavigatorSaveItem.Text = "Save Data";
            this.nechaev_t1BindingNavigatorSaveItem.Click += new System.EventHandler(this.nechaev_t1BindingNavigatorSaveItem_Click);
            // 
            // i_nechaev_t1DataGridView
            // 
            this.i_nechaev_t1DataGridView.AutoGenerateColumns = false;
            this.i_nechaev_t1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.i_nechaev_t1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.i_nechaev_t1DataGridView.DataSource = this.inechaevt1BindingSource;
            this.i_nechaev_t1DataGridView.Location = new System.Drawing.Point(64, 47);
            this.i_nechaev_t1DataGridView.Name = "i_nechaev_t1DataGridView";
            this.i_nechaev_t1DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.i_nechaev_t1DataGridView.Size = new System.Drawing.Size(242, 220);
            this.i_nechaev_t1DataGridView.TabIndex = 1;
            this.i_nechaev_t1DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.i_nechaev_t1DataGridView_CellContentClick);
            this.i_nechaev_t1DataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.i_nechaev_t1DataGridView_DataError);
            // 
            // inechaevt1BindingSource
            // 
            this.inechaevt1BindingSource.DataMember = "i.nechaev_t1";
            this.inechaevt1BindingSource.DataSource = this.iVT_2022DataSet;
            // 
            // iVT2022DataSetBindingSource
            // 
            this.iVT2022DataSetBindingSource.DataSource = this.iVT_2022DataSet;
            this.iVT2022DataSetBindingSource.Position = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MaxInputLength = 11;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 319);
            this.Controls.Add(this.i_nechaev_t1DataGridView);
            this.Controls.Add(this.nechaev_t1BindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iVT_2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nechaev_t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nechaev_t1BindingNavigator)).EndInit();
            this.nechaev_t1BindingNavigator.ResumeLayout(false);
            this.nechaev_t1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_nechaev_t1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inechaevt1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT2022DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IVT_2022DataSet iVT_2022DataSet;
        private System.Windows.Forms.BindingSource nechaev_t1BindingSource;
        private IVT_2022DataSetTableAdapters.i_nechaev_t1TableAdapter i_nechaev_t1TableAdapter;
        private IVT_2022DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nechaev_t1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nechaev_t1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView i_nechaev_t1DataGridView;
        private System.Windows.Forms.BindingSource inechaevt1BindingSource;
        private System.Windows.Forms.BindingSource iVT2022DataSetBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

