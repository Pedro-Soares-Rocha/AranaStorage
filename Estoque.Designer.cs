namespace AranaStorage
{
    partial class Estoque
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label especLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this._arana_stockDataSet = new AranaStorage._arana_stockDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new AranaStorage._arana_stockDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new AranaStorage._arana_stockDataSetTableAdapters.TableAdapterManager();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.especTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.produtosDataGridView = new System.Windows.Forms.DataGridView();
            this.produtosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            especLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._arana_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).BeginInit();
            this.produtosBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(554, 153);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 20);
            label1.TabIndex = 129;
            label1.Text = "R$";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.BackColor = System.Drawing.Color.Transparent;
            nomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            nomeLabel1.ForeColor = System.Drawing.Color.White;
            nomeLabel1.Location = new System.Drawing.Point(406, 57);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(97, 22);
            nomeLabel1.TabIndex = 121;
            nomeLabel1.Text = "Categoria";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(77, 57);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(61, 22);
            nomeLabel.TabIndex = 117;
            nomeLabel.Text = "Nome";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.BackColor = System.Drawing.Color.Transparent;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            marcaLabel.ForeColor = System.Drawing.Color.White;
            marcaLabel.Location = new System.Drawing.Point(554, 57);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(64, 22);
            marcaLabel.TabIndex = 118;
            marcaLabel.Text = "Marca";
            // 
            // especLabel
            // 
            especLabel.AutoSize = true;
            especLabel.BackColor = System.Drawing.Color.Transparent;
            especLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            especLabel.ForeColor = System.Drawing.Color.White;
            especLabel.Location = new System.Drawing.Point(77, 105);
            especLabel.Name = "especLabel";
            especLabel.Size = new System.Drawing.Size(144, 22);
            especLabel.TabIndex = 119;
            especLabel.Text = "Especificações";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.BackColor = System.Drawing.Color.Transparent;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.ForeColor = System.Drawing.Color.White;
            precoLabel.Location = new System.Drawing.Point(554, 130);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(58, 20);
            precoLabel.TabIndex = 120;
            precoLabel.Text = "Preço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(554, 225);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 20);
            label6.TabIndex = 116;
            label6.Text = "Quantidade";
            // 
            // _arana_stockDataSet
            // 
            this._arana_stockDataSet.DataSetName = "_arana_stockDataSet";
            this._arana_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this._arana_stockDataSet;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = null;
            this.tableAdapterManager.Componentes_PCTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = null;
            this.tableAdapterManager.Montagem_PCTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = AranaStorage._arana_stockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(81, 82);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(323, 20);
            this.nomeTextBox.TabIndex = 133;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(558, 82);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.ReadOnly = true;
            this.marcaTextBox.Size = new System.Drawing.Size(119, 20);
            this.marcaTextBox.TabIndex = 135;
            // 
            // especTextBox
            // 
            this.especTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Espec", true));
            this.especTextBox.Location = new System.Drawing.Point(81, 132);
            this.especTextBox.Multiline = true;
            this.especTextBox.Name = "especTextBox";
            this.especTextBox.ReadOnly = true;
            this.especTextBox.Size = new System.Drawing.Size(466, 136);
            this.especTextBox.TabIndex = 137;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(592, 153);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.ReadOnly = true;
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 139;
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Categoria", true));
            this.categoriaTextBox.Location = new System.Drawing.Point(410, 82);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.ReadOnly = true;
            this.categoriaTextBox.Size = new System.Drawing.Size(137, 20);
            this.categoriaTextBox.TabIndex = 145;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(558, 248);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.ReadOnly = true;
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 147;
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AllowUserToAddRows = false;
            this.produtosDataGridView.AllowUserToDeleteRows = false;
            this.produtosDataGridView.AllowUserToResizeColumns = false;
            this.produtosDataGridView.AllowUserToResizeRows = false;
            this.produtosDataGridView.AutoGenerateColumns = false;
            this.produtosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.produtosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produtosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9});
            this.produtosDataGridView.DataSource = this.produtosBindingSource;
            this.produtosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produtosDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.produtosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.ReadOnly = true;
            this.produtosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.produtosDataGridView.Size = new System.Drawing.Size(799, 274);
            this.produtosDataGridView.TabIndex = 147;
            // 
            // produtosBindingNavigator
            // 
            this.produtosBindingNavigator.AddNewItem = null;
            this.produtosBindingNavigator.BindingSource = this.produtosBindingSource;
            this.produtosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtosBindingNavigator.DeleteItem = null;
            this.produtosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.produtosBindingNavigator.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.produtosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.produtosBindingNavigator.Location = new System.Drawing.Point(330, 9);
            this.produtosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtosBindingNavigator.Name = "produtosBindingNavigator";
            this.produtosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtosBindingNavigator.Size = new System.Drawing.Size(213, 26);
            this.produtosBindingNavigator.TabIndex = 148;
            this.produtosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(39, 23);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 23);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Preco";
            this.dataGridViewTextBoxColumn5.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.produtosDataGridView);
            this.panel1.Location = new System.Drawing.Point(1, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 274);
            this.panel1.TabIndex = 149;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::AranaStorage.Properties.Resources.AranaPc11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.produtosBindingNavigator);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.especTextBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.categoriaTextBox);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(especLabel);
            this.Controls.Add(precoLabel);
            this.Controls.Add(label6);
            this.DoubleBuffered = true;
            this.Name = "Estoque";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this._arana_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).EndInit();
            this.produtosBindingNavigator.ResumeLayout(false);
            this.produtosBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _arana_stockDataSet _arana_stockDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private _arana_stockDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private _arana_stockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox especTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.DataGridView produtosDataGridView;
        private System.Windows.Forms.BindingNavigator produtosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Panel panel1;
    }
}