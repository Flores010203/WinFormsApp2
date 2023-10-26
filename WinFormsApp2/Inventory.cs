using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp2
{
    public partial class Inventory : Form
    {
        private int _Quantity;

        public double _SellPrice { get; private set; }
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;

        private BindingSource showProductList = new BindingSource();
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);
                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate,
                _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (NumberFormatException ex)
            {
                MessageBox.Show($"Number Format input in quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (StringFormatException ex)
            {
                MessageBox.Show($"String Format input in product name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CurrencyFormatException ex)
            {
                MessageBox.Show($"Currency Format in price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = new string[]
            {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other",
            };
            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                throw new StringFormatException("Invalid product name format");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9]"))
                throw new NumberFormatException("Invalid quantity format");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Invalid selling price format");
            return Convert.ToDouble(price);
        }

        public class NumberFormatException : Exception
        {
            public NumberFormatException(string message) : base(message) { }
        }

        public class StringFormatException : Exception
        {
            public StringFormatException(string message) : base(message) { }
        }

        public class CurrencyFormatException : Exception
        {
            public CurrencyFormatException(string message) : base(message) { }
        }
    }
}