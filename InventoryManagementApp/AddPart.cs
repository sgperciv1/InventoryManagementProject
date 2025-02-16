using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementApp.Models;

namespace InventoryManagementApp
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();

            txtPartID.Text = Inventory.PartIdCount + "";

        }  

        private void radioButtonOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOutsourced.Checked)
            {

                labelMachinIdCompanyName.Text = "Company Name";
            }
        }

        private void radioButtonInhouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonInhouse.Checked)
            {
                labelMachinIdCompanyName.Text = "Machine ID";
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Boolean missingFields()
        {
            if (txtPartName.Text.Length == 0)
            {

                MessageBox.Show("Please enter Part Name", "Error!!");
                return true;

            }

            if (txtPartInventory.Text.Length == 0)
            {

                MessageBox.Show("Please enter Part Inventory", "Error!!");
                return true;

            }
            if (txtPartPriceCost.Text.Length == 0)
            {

                MessageBox.Show("Please enter Part Price / Cost", "Error!!");
                return true;

            }
            if (txtPartMax.Text.Length == 0)
            {

                MessageBox.Show("Please enter Part Max", "Error!!");
                return true;

            }
            if (txtPartMin.Text.Length == 0)
            {

                MessageBox.Show("Please enter Part Min", "Error!!");
                return true;

            }

            if (txtPartMachineIDCompanyName.Text.Length == 0)
            {

                MessageBox.Show("Please enter Part MachineID / CompanyName", "Error!!");
                return true;

            }

            else return false;
        }


        private void btnSaveParts_Click(object sender, EventArgs e)
        {

            if (missingFields())
            {
                return;
            }

            int partID = int.Parse(txtPartID.Text);
            string name = txtPartName.Text;
            int inStock;
            try
            {
                inStock = int.Parse(txtPartInventory.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number to Inventory", "Error!!");
                return;
            }


            decimal price;
            try
            {
                price = decimal.Parse(txtPartPriceCost.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number to Price / Cost", "Error!!");
                return;
            }


            int min;
            try
            {
                min = int.Parse(txtPartMin.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number to Min", "Error!!");
                return;
            }

            int max;
            try
            {
                max = int.Parse(txtPartMax.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number to Max", "Error!!");
                return;
            }


            if (min > max)
            {
                MessageBox.Show("Min is higher than Max", "Error!!");
                return;

            }

            if (inStock < min || inStock > max)
            {
                MessageBox.Show("Inventory is outside the Min/Max range", "Error!!");
                return;

            }


            Part newPart;
            if (radioButtonInhouse.Checked)
            {
                int machineID;
                try
                {
                    machineID = int.Parse(txtPartMachineIDCompanyName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a number to MachineID", "Error!!");
                    return;
                }




                newPart = new Inhouse
                {
                    PartID = partID,
                    Name = name,
                    InStock = inStock,
                    Price = price,
                    Min = min,
                    Max = max,
                    MachineID = machineID

                };

            }

            else
            {
                newPart = new Outsourced
                {
                    PartID = partID,
                    Name = name,
                    InStock = inStock,
                    Price = price,
                    Min = min,
                    Max = max,
                    CompanyName = txtPartMachineIDCompanyName.Text

                };

            }
            Inventory.addPart(newPart);
            this.Close();

        }
    }
}
