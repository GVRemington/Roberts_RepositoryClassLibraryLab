using Roberts_RepositoryClassLibraryLab;

namespace Roberts_RepositoryWinformsIntroLab
{
    public partial class frmAddProduct : Form
    {
        private void LoadProducts()
        {
            //IProductRepository repository = new ProductRepository(_connectionString);
        }
        public frmAddProduct()
        {
            InitializeComponent();
        }

        public void btnAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product();
            {
                product.Name = txtProdName.Text;
                product.Price = decimal.Parse(txtProdPrice.Text);
                product.Stock = int.Parse(txtProdStock.Text);

            }
            //IProductRepository repository = new ProductRepository(_connectionString);


        }
    }
}
