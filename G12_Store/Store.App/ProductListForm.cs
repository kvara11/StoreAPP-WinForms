using Store.App.Interfaces;
using Store.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.App
{
    public partial class ProductListForm : Form, IListForm
    {
        private readonly ProductRepository _productRepository;
        public ProductListForm()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            grdProductList.DataSource = _productRepository.Select().ToList();
        }   

        public void Add()
        {
            MessageBox.Show("Product Add");
        }

        public void Delete()
        {
            MessageBox.Show("Product Deleted");
        }

        public void Edit()
        {
            MessageBox.Show("Product Edited ");
        }
    }
}
