using Store.App.Interfaces;
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
        public ProductListForm()
        {
            InitializeComponent();
        }

        public void Add()
        {
            MessageBox.Show("Product Add");
        }

        public void Delete()
        {
            MessageBox.Show("Deleted Add");
        }

        public void Edit()
        {
            MessageBox.Show("Edited Add");
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
