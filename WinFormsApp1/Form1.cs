using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EFProductDal());
            _categoryService = new CategoryManager(new EFCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;



        private void Form1_Load_1(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
        }

        private void LoadProduct()
        {
            dataGridView1.DataSource = _productService.GetAll();

        }

        private bool _isCategoryLoaded = false;
        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
            _isCategoryLoaded = true;


            add_cb_category.DataSource = _categoryService.GetAll();
            add_cb_category.DisplayMember = "CategoryName";
            add_cb_category.ValueMember = "CategoryId";

            u_cb_category.DataSource = _categoryService.GetAll();
            u_cb_category.DisplayMember = "CategoryName";
            u_cb_category.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isCategoryLoaded && cbxCategory.SelectedValue is int categoryId)
            {
                dataGridView1.DataSource = _productService.GetProductsByCategory(categoryId);
            }
        }



        private void tbName_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetProductsByName(tbName.Text);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                CategoryId = Convert.ToInt32(add_cb_category.SelectedValue),
                ProductName = add_tb_pname.Text,
                QuantityPerUnit = add_tb_unitq.Text,
                UnitPrice = Convert.ToDecimal(add_tb_price.Text),
                UnitsInStock = Convert.ToInt16(add_tb_stockq.Text),
            });
            MessageBox.Show("Product Added");
            LoadProduct();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                ProductName = u_tb_name.Text,
                CategoryId = Convert.ToInt32(u_cb_category.SelectedValue),
                UnitsInStock = Convert.ToInt16(u_tb_stockq.Text),
                QuantityPerUnit = u_tb_unitq.Text,
                UnitPrice = Convert.ToDecimal(u_tb_price.Text)

            });
            MessageBox.Show("Product Updated");
            LoadProduct();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.CurrentRow;
            u_tb_name.Text = row.Cells[1].Value.ToString();
            u_cb_category.SelectedValue = row.Cells[2].Value;
            u_tb_price.Text = row.Cells[3].Value.ToString();
            u_tb_unitq.Text = row.Cells[4].Value.ToString();
            u_tb_stockq.Text = row.Cells[5].Value.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
                });
            }
            
            MessageBox.Show("Product Deleted");
            LoadProduct();
        }
    }
}
