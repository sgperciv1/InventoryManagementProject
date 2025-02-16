using System.ComponentModel;
using InventoryManagementApp.Models;

namespace InventoryManagementApp
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();

            partsGridView.DataSource = Inventory.AllParts;
            productsGridView.DataSource = Inventory.Products;
        }

        private void btnAddParts_Click(object sender, EventArgs e)
        {

            focus(new AddPart());
            partsGridView.DataSource = Inventory.AllParts;
        }

        private void btnModifyParts_Click(object sender, EventArgs e)
        {
            if (!partsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to modify", "Nothing selected!");
                return;

            }

            int selectedPartId = (int)partsGridView.CurrentRow.Cells["PartID"].Value;

            focus(new ModifyPart(selectedPartId));

        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifyProducts_Click(object sender, EventArgs e)
        {




        }

        void focus(Form form)
        {

            if (Application.OpenForms[form.Name] == null)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
            else
            {
                form = Application.OpenForms[form.Name];
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Focus();
            }
        }



        private void btnPartsSearch_Click(object sender, EventArgs e)
        {
            if (txtPartsSearch.Text.Length > 0)
            {
                string searchText = txtPartsSearch.Text.ToLower().Trim().Replace("'", "''");
                if (txtPartsSearch.Text.All(char.IsDigit))
                {

                    int lookupPartID = int.Parse(searchText);
                    Part lookedUpPart = Inventory.lookupPart(lookupPartID);
                    var filterdParts = new BindingList<Part>();

                    if (lookedUpPart != null)
                    {

                        filterdParts.Add(lookedUpPart);
                        partsGridView.DataSource = filterdParts;
                        partsGridView.Refresh();
                    }
                    else
                    {

                        MessageBox.Show("Part with partID " + txtPartsSearch.Text + " not found", "Not Found!");
                    }

                }

                else
                {
                    
                    var matchingParts = Inventory.AllParts.Where(p => p.Name.ToLower().Contains(searchText));
                    List<Part> filteredList = matchingParts.ToList();
                    var filteredParts = new BindingList<Part>(filteredList);


                   if (filteredParts.Count > 0)
                    {
                        partsGridView.DataSource = filteredParts;
                        partsGridView.Refresh();

                    }


                    else
                    {

                        MessageBox.Show("Part with part name " + txtPartsSearch.Text + " not found", "Not Found!");
                    }






                }
            }
            else
            {

                partsGridView.DataSource = Inventory.AllParts;
                partsGridView.Refresh();

            }



        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            if (txtProductsSearch.Text.Length > 0)
            {
                string searchText = txtProductsSearch.Text.ToLower().Trim().Replace("'", "''");
                if (txtProductsSearch.Text.All(char.IsDigit))
                {
                    int lookupProductID = int.Parse(searchText);
                    Product lookedUpProduct = Inventory.lookupProduct(lookupProductID);
                    var filterdProduct = new BindingList<Product>();

                    if (lookedUpProduct != null)
                    {
                        filterdProduct.Add(lookedUpProduct);
                        productsGridView.DataSource = filterdProduct;
                        productsGridView.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Product with productID " + txtProductsSearch.Text + " not found", "Not Found!");
                    }

                }

                else
                {
                   
                
                    var matchingProducts = Inventory.Products.Where(p => p.Name.ToLower().Contains(searchText));
                    List<Product> filteredList = matchingProducts.ToList();
                    var filteredProducts = new BindingList<Product>(filteredList);


                    if (filteredProducts.Count > 0)
                    {
                        productsGridView.DataSource = filteredProducts;
                        productsGridView.Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Product with Product name " + txtProductsSearch.Text + " not found", "Not Found!");
                    }

                }
            }
            else
            {

                productsGridView.DataSource = Inventory.Products;
                productsGridView.Refresh();

            }


        }

        private void btnDeleteParts_Click(object sender, EventArgs e)
        {
            if (!partsGridView.CurrentRow.Selected)
            {
                MessageBox.Show("Please select a part to delete", "Nothing selected!");
                return;

            }
            int selectedPartId = (int)partsGridView.CurrentRow.Cells["PartID"].Value;

            Boolean isPartUsed = false;
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                Part lookedUpPart = Inventory.Products[i].lookupAssoicatedPart(selectedPartId);
                if (lookedUpPart != null)
                {
                    isPartUsed = true;
                    break;
                }

            }

            if (isPartUsed)
            {
                MessageBox.Show("Sorry, the selected part cannot be deleted because it's used in a product", "Part cannot be deleted!");
                return;

            }


            if (MessageBox.Show("Are you sure you want to delete the selected part?", "Confirm delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                Inventory.deletePart(Inventory.lookupPart(selectedPartId));

            }




        }

        private void partsGVDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partsGridView.ClearSelection();

        }

        private void productsGVDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            productsGridView.ClearSelection();
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {



        }
    }

}
