namespace AranaStorage
{
    partial class AdmEstoque
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
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label especLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label imagensLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label label6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmEstoque));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFoto_Produto = new System.Windows.Forms.Button();
            this._arana_stockDataSet = new AranaStorage._arana_stockDataSet();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new AranaStorage._arana_stockDataSetTableAdapters.ProdutosTableAdapter();
            this.tableAdapterManager = new AranaStorage._arana_stockDataSetTableAdapters.TableAdapterManager();
            this.categoriasTableAdapter = new AranaStorage._arana_stockDataSetTableAdapters.CategoriasTableAdapter();
            this.estoqueTableAdapter = new AranaStorage._arana_stockDataSetTableAdapters.EstoqueTableAdapter();
            this.produtosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.especTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.imagensPictureBox = new System.Windows.Forms.PictureBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeListBox = new System.Windows.Forms.ListBox();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            marcaLabel = new System.Windows.Forms.Label();
            especLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            imagensLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._arana_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).BeginInit();
            this.produtosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagensPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.BackColor = System.Drawing.Color.Transparent;
            marcaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            marcaLabel.ForeColor = System.Drawing.Color.White;
            marcaLabel.Location = new System.Drawing.Point(522, 45);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(64, 22);
            marcaLabel.TabIndex = 72;
            marcaLabel.Text = "Marca";
            // 
            // especLabel
            // 
            especLabel.AutoSize = true;
            especLabel.BackColor = System.Drawing.Color.Transparent;
            especLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            especLabel.ForeColor = System.Drawing.Color.White;
            especLabel.Location = new System.Drawing.Point(50, 93);
            especLabel.Name = "especLabel";
            especLabel.Size = new System.Drawing.Size(144, 22);
            especLabel.TabIndex = 74;
            especLabel.Text = "Especificações";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.BackColor = System.Drawing.Color.Transparent;
            precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precoLabel.ForeColor = System.Drawing.Color.White;
            precoLabel.Location = new System.Drawing.Point(679, 93);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(64, 20);
            precoLabel.TabIndex = 76;
            precoLabel.Text = "Preco:";
            // 
            // imagensLabel
            // 
            imagensLabel.AutoSize = true;
            imagensLabel.BackColor = System.Drawing.Color.Transparent;
            imagensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            imagensLabel.ForeColor = System.Drawing.Color.White;
            imagensLabel.Location = new System.Drawing.Point(522, 93);
            imagensLabel.Name = "imagensLabel";
            imagensLabel.Size = new System.Drawing.Size(78, 22);
            imagensLabel.TabIndex = 80;
            imagensLabel.Text = "Imagem";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.BackColor = System.Drawing.Color.Transparent;
            nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            nomeLabel.ForeColor = System.Drawing.Color.White;
            nomeLabel.Location = new System.Drawing.Point(50, 45);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(61, 22);
            nomeLabel.TabIndex = 70;
            nomeLabel.Text = "Nome";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.BackColor = System.Drawing.Color.Transparent;
            nomeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            nomeLabel1.ForeColor = System.Drawing.Color.White;
            nomeLabel1.Location = new System.Drawing.Point(379, 45);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(97, 22);
            nomeLabel1.TabIndex = 83;
            nomeLabel1.Text = "Categoria";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(679, 45);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(104, 20);
            label6.TabIndex = 30;
            label6.Text = "Quantidade";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Escolha a foto do produto";
            // 
            // btnFoto_Produto
            // 
            this.btnFoto_Produto.BackColor = System.Drawing.Color.White;
            this.btnFoto_Produto.BackgroundImage = global::AranaStorage.Properties.Resources.free_folder_icon_1449_thumb;
            this.btnFoto_Produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoto_Produto.Font = new System.Drawing.Font("Corbel", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto_Produto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFoto_Produto.Location = new System.Drawing.Point(683, 209);
            this.btnFoto_Produto.Name = "btnFoto_Produto";
            this.btnFoto_Produto.Size = new System.Drawing.Size(35, 35);
            this.btnFoto_Produto.TabIndex = 35;
            this.btnFoto_Produto.UseVisualStyleBackColor = false;
            this.btnFoto_Produto.Click += new System.EventHandler(this.btnFoto_Produto_Click);
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
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.Componentes_PCTableAdapter = null;
            this.tableAdapterManager.EstoqueTableAdapter = this.estoqueTableAdapter;
            this.tableAdapterManager.Montagem_PCTableAdapter = null;
            this.tableAdapterManager.ProdutosTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = AranaStorage._arana_stockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingNavigator
            // 
            this.produtosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtosBindingNavigator.BindingSource = this.produtosBindingSource;
            this.produtosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtosBindingNavigatorSaveItem});
            this.produtosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtosBindingNavigator.Name = "produtosBindingNavigator";
            this.produtosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtosBindingNavigator.Size = new System.Drawing.Size(803, 25);
            this.produtosBindingNavigator.TabIndex = 84;
            this.produtosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Text = "0";
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
            // produtosBindingNavigatorSaveItem
            // 
            this.produtosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosBindingNavigatorSaveItem.Image")));
            this.produtosBindingNavigatorSaveItem.Name = "produtosBindingNavigatorSaveItem";
            this.produtosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtosBindingNavigatorSaveItem.Text = "Save Data";
            this.produtosBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtosBindingNavigatorSaveItem_Click_1);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(54, 70);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(319, 20);
            this.nomeTextBox.TabIndex = 87;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(526, 70);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 89;
            // 
            // especTextBox
            // 
            this.especTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Espec", true));
            this.especTextBox.Location = new System.Drawing.Point(54, 118);
            this.especTextBox.Multiline = true;
            this.especTextBox.Name = "especTextBox";
            this.especTextBox.Size = new System.Drawing.Size(445, 126);
            this.especTextBox.TabIndex = 91;
            // 
            // precoTextBox
            // 
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtosBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(683, 116);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 93;
            // 
            // imagensPictureBox
            // 
            this.imagensPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.imagensPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.produtosBindingSource, "imagens", true));
            this.imagensPictureBox.Location = new System.Drawing.Point(526, 118);
            this.imagensPictureBox.Name = "imagensPictureBox";
            this.imagensPictureBox.Size = new System.Drawing.Size(151, 126);
            this.imagensPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagensPictureBox.TabIndex = 97;
            this.imagensPictureBox.TabStop = false;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this._arana_stockDataSet;
            // 
            // nomeListBox
            // 
            this.nomeListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriasBindingSource, "Nome", true));
            this.nomeListBox.FormattingEnabled = true;
            this.nomeListBox.Location = new System.Drawing.Point(383, 70);
            this.nomeListBox.Name = "nomeListBox";
            this.nomeListBox.Size = new System.Drawing.Size(116, 17);
            this.nomeListBox.TabIndex = 100;
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "fk_Estoque_Produtos";
            this.estoqueBindingSource.DataSource = this.produtosBindingSource;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(683, 67);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantidadeTextBox.TabIndex = 103;
            // 
            // AdmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::AranaStorage.Properties.Resources.AranaPc11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 486);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.nomeListBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(this.especTextBox);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.imagensPictureBox);
            this.Controls.Add(this.produtosBindingNavigator);
            this.Controls.Add(nomeLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(especLabel);
            this.Controls.Add(precoLabel);
            this.Controls.Add(imagensLabel);
            this.Controls.Add(this.btnFoto_Produto);
            this.Controls.Add(label6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdmEstoque";
            this.Text = "Adminstrador de Estoque";
            this.Load += new System.EventHandler(this.AdmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this._arana_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingNavigator)).EndInit();
            this.produtosBindingNavigator.ResumeLayout(false);
            this.produtosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagensPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFoto_Produto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private _arana_stockDataSet _arana_stockDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private _arana_stockDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private _arana_stockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produtosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox especTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.PictureBox imagensPictureBox;
        private _arana_stockDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.ListBox nomeListBox;
        private _arana_stockDataSetTableAdapters.EstoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private System.Windows.Forms.TextBox quantidadeTextBox;
    }
}