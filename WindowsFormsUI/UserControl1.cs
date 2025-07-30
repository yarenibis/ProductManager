using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class UserControl1: UserControl
    {
        
        public UserControl1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductManager());
        }

        IProductService _productService;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView11.DataSource = _productService.GetAll();
        }
    }
}
