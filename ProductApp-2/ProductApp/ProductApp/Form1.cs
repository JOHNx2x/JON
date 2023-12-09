using System;
using System.Windows.Forms;

namespace ProductApp
{
    public partial class frmMainWindow : Form
    {
        ProductManager productlist = new ProductManager();
        public frmMainWindow()
        {
            InitializeComponent();

        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            // Display any existing products in the DataGridView

            productlist.DisplayProducts(ProductGrid);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string name = tbProdName.Text;
            string idText = tbProdID.Text;
            string priceText = tbProdPrice.Text;

            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(idText) || string.IsNullOrWhiteSpace(priceText))
            {
                MessageBox.Show("Invalid input. Please enter product name, ID, and price.");
                return;
            }

            // Convert input to appropriate data types
            if (!int.TryParse(idText, out int numId) || !double.TryParse(priceText, out double numPrice))
            {
                MessageBox.Show("Invalid input. Please enter valid ID and price.");
                return;
            }

            // Add the product and display the updated list
            productlist.AddProduct(numId, name, numPrice);
            productlist.DisplayProducts(ProductGrid);

            // Clear the input fields
            tbProdID.Text = "";
            tbProdName.Text = "";
            tbProdPrice.Text = "";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }


        private void tbnfindIDproduct_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(tbFindProduct.Text, out id))
            {
                Product foundProduct = productlist.FindProductById(id);
                if (foundProduct != null)
                {
                    // Display the found product in a message box or any other way you prefer
                    MessageBox.Show($"ID: {foundProduct.ProductId}, Name: {foundProduct.ProductName}, Price: {foundProduct.ProductPrice}");
                }
                else
                {
                    MessageBox.Show("Product not found");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID");
            }

        }

        private void lbl_display_Click(object sender, EventArgs e)
        {

        }

        private void tbFindProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProdPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
