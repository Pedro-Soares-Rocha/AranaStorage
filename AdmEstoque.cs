using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AranaStorage
{
    public partial class AdmEstoque : Form
    {
        public AdmEstoque()
        {
            InitializeComponent();
        }

        private void btnFoto_Produto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagensPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            { 
                MessageBox.Show("Erro ao carregar o arquivo de imagem",
                    "AranaTech", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._arana_stockDataSet);

        }

        private void AdmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_arana_stockDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this._arana_stockDataSet.Estoque);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this._arana_stockDataSet.Estoque);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this._arana_stockDataSet.Categorias);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this._arana_stockDataSet.Categorias);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this._arana_stockDataSet.Produtos);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Estoque' table. You can move, or remove it, as needed.
            this.estoqueTableAdapter.Fill(this._arana_stockDataSet.Estoque);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this._arana_stockDataSet.Produtos);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this._arana_stockDataSet.Produtos);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this._arana_stockDataSet.Produtos);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this._arana_stockDataSet.Categorias);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this._arana_stockDataSet.Categorias);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Componentes_PC' table. You can move, or remove it, as needed.
            //this.componentes_PCTableAdapter.Fill(this._arana_stockDataSet.Componentes_PC);
            // TODO: This line of code loads data into the '_arana_stockDataSet.Produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this._arana_stockDataSet.Produtos);

        }

        private void categoriasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._arana_stockDataSet);

        }

        private void produtosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._arana_stockDataSet);

        }
    }
}
