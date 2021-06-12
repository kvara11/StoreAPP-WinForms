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
            grdProductList.Columns[0].Frozen = true;
            grdProductList.Columns[0].Visible = false;
            grdProductList.Columns[1].Frozen = true;
            grdProductList.Columns[2].Visible = false;
            grdProductList.Columns[3].Visible = false;
            grdProductList.Columns[7].Visible = false;
            grdProductList.Columns[grdProductList.Columns.Count - 1].Visible = false;

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

        private void grdProductList_MouseClick(object sender, MouseEventArgs e)
        {
            int position = grdProductList.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right && position > 0)
            {
                contexMnuProducts.Show(grdProductList,new Point(e.X,e.Y));
            }
        }

        public void RefreshData()
        {
            throw new NotImplementedException();
        }

        private void grdProductList_MouseClick(object sender, MouseEventArgs e)
        {
            int position = grdProductList.HitTest(e.X, e.Y).RowIndex;

            if (e.Button == MouseButtons.Right && position > 0)
            {
                contexMnuProducts.Show(grdProductList,new Point(e.X,e.Y));
            }
        }
    }
}
