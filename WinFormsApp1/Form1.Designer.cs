namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            label_category = new Label();
            gbxName = new GroupBox();
            tbName = new TextBox();
            label_name = new Label();
            groupBox1 = new GroupBox();
            add_btn = new Button();
            add_tb_unitq = new TextBox();
            add_lbl_unitq = new Label();
            add_tb_stockq = new TextBox();
            add_lbl_stockq = new Label();
            add_cb_category = new ComboBox();
            add_tb_price = new TextBox();
            add_lbl_price = new Label();
            add_lbl_category = new Label();
            add_tb_pname = new TextBox();
            add_lbl_pname = new Label();
            groupBox2 = new GroupBox();
            update_btn = new Button();
            u_tb_unitq = new TextBox();
            label1 = new Label();
            u_tb_stockq = new TextBox();
            label2 = new Label();
            u_cb_category = new ComboBox();
            u_tb_price = new TextBox();
            label3 = new Label();
            u_lbl_category = new Label();
            u_tb_name = new TextBox();
            update_label_name = new Label();
            delete_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbxCategory.SuspendLayout();
            gbxName.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(739, 151);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(label_category);
            gbxCategory.Location = new Point(30, 24);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(739, 71);
            gbxCategory.TabIndex = 1;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Search by Category";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(152, 29);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(151, 28);
            cbxCategory.TabIndex = 2;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // label_category
            // 
            label_category.AutoSize = true;
            label_category.Location = new Point(33, 29);
            label_category.Name = "label_category";
            label_category.Size = new Size(69, 20);
            label_category.TabIndex = 0;
            label_category.Text = "Category";
            // 
            // gbxName
            // 
            gbxName.Controls.Add(tbName);
            gbxName.Controls.Add(label_name);
            gbxName.Location = new Point(30, 101);
            gbxName.Name = "gbxName";
            gbxName.Size = new Size(739, 77);
            gbxName.TabIndex = 3;
            gbxName.TabStop = false;
            gbxName.Text = "Search by Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(152, 29);
            tbName.Name = "tbName";
            tbName.Size = new Size(151, 27);
            tbName.TabIndex = 1;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(33, 29);
            label_name.Name = "label_name";
            label_name.Size = new Size(49, 20);
            label_name.TabIndex = 0;
            label_name.Text = "Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(add_btn);
            groupBox1.Controls.Add(add_tb_unitq);
            groupBox1.Controls.Add(add_lbl_unitq);
            groupBox1.Controls.Add(add_tb_stockq);
            groupBox1.Controls.Add(add_lbl_stockq);
            groupBox1.Controls.Add(add_cb_category);
            groupBox1.Controls.Add(add_tb_price);
            groupBox1.Controls.Add(add_lbl_price);
            groupBox1.Controls.Add(add_lbl_category);
            groupBox1.Controls.Add(add_tb_pname);
            groupBox1.Controls.Add(add_lbl_pname);
            groupBox1.Location = new Point(30, 341);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 146);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(405, 106);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(151, 29);
            add_btn.TabIndex = 11;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // add_tb_unitq
            // 
            add_tb_unitq.Location = new Point(405, 76);
            add_tb_unitq.Name = "add_tb_unitq";
            add_tb_unitq.Size = new Size(151, 27);
            add_tb_unitq.TabIndex = 10;
            // 
            // add_lbl_unitq
            // 
            add_lbl_unitq.AutoSize = true;
            add_lbl_unitq.Location = new Point(296, 79);
            add_lbl_unitq.Name = "add_lbl_unitq";
            add_lbl_unitq.Size = new Size(94, 20);
            add_lbl_unitq.TabIndex = 9;
            add_lbl_unitq.Text = "Unit quantity";
            // 
            // add_tb_stockq
            // 
            add_tb_stockq.Location = new Point(405, 40);
            add_tb_stockq.Name = "add_tb_stockq";
            add_tb_stockq.Size = new Size(151, 27);
            add_tb_stockq.TabIndex = 8;
            // 
            // add_lbl_stockq
            // 
            add_lbl_stockq.AutoSize = true;
            add_lbl_stockq.Location = new Point(296, 43);
            add_lbl_stockq.Name = "add_lbl_stockq";
            add_lbl_stockq.Size = new Size(103, 20);
            add_lbl_stockq.TabIndex = 7;
            add_lbl_stockq.Text = "Stock quantity";
            // 
            // add_cb_category
            // 
            add_cb_category.FormattingEnabled = true;
            add_cb_category.Location = new Point(116, 69);
            add_cb_category.Name = "add_cb_category";
            add_cb_category.Size = new Size(151, 28);
            add_cb_category.TabIndex = 3;
            // 
            // add_tb_price
            // 
            add_tb_price.Location = new Point(116, 103);
            add_tb_price.Name = "add_tb_price";
            add_tb_price.Size = new Size(151, 27);
            add_tb_price.TabIndex = 6;
            // 
            // add_lbl_price
            // 
            add_lbl_price.AutoSize = true;
            add_lbl_price.Location = new Point(6, 106);
            add_lbl_price.Name = "add_lbl_price";
            add_lbl_price.Size = new Size(41, 20);
            add_lbl_price.TabIndex = 5;
            add_lbl_price.Text = "Price";
            // 
            // add_lbl_category
            // 
            add_lbl_category.AutoSize = true;
            add_lbl_category.Location = new Point(6, 69);
            add_lbl_category.Name = "add_lbl_category";
            add_lbl_category.Size = new Size(69, 20);
            add_lbl_category.TabIndex = 4;
            add_lbl_category.Text = "Category";
            // 
            // add_tb_pname
            // 
            add_tb_pname.Location = new Point(116, 36);
            add_tb_pname.Name = "add_tb_pname";
            add_tb_pname.Size = new Size(151, 27);
            add_tb_pname.TabIndex = 3;
            // 
            // add_lbl_pname
            // 
            add_lbl_pname.AutoSize = true;
            add_lbl_pname.Location = new Point(6, 36);
            add_lbl_pname.Name = "add_lbl_pname";
            add_lbl_pname.Size = new Size(104, 20);
            add_lbl_pname.TabIndex = 2;
            add_lbl_pname.Text = "Product Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(update_btn);
            groupBox2.Controls.Add(u_tb_unitq);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(u_tb_stockq);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(u_cb_category);
            groupBox2.Controls.Add(u_tb_price);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(u_lbl_category);
            groupBox2.Controls.Add(u_tb_name);
            groupBox2.Controls.Add(update_label_name);
            groupBox2.Location = new Point(30, 493);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(618, 146);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Product";
            // 
            // update_btn
            // 
            update_btn.Location = new Point(405, 106);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(151, 29);
            update_btn.TabIndex = 11;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // u_tb_unitq
            // 
            u_tb_unitq.Location = new Point(405, 76);
            u_tb_unitq.Name = "u_tb_unitq";
            u_tb_unitq.Size = new Size(151, 27);
            u_tb_unitq.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 79);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 9;
            label1.Text = "Unit quantity";
            // 
            // u_tb_stockq
            // 
            u_tb_stockq.Location = new Point(405, 40);
            u_tb_stockq.Name = "u_tb_stockq";
            u_tb_stockq.Size = new Size(151, 27);
            u_tb_stockq.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 43);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 7;
            label2.Text = "Stock quantity";
            // 
            // u_cb_category
            // 
            u_cb_category.FormattingEnabled = true;
            u_cb_category.Location = new Point(116, 69);
            u_cb_category.Name = "u_cb_category";
            u_cb_category.Size = new Size(151, 28);
            u_cb_category.TabIndex = 3;
            // 
            // u_tb_price
            // 
            u_tb_price.Location = new Point(116, 103);
            u_tb_price.Name = "u_tb_price";
            u_tb_price.Size = new Size(151, 27);
            u_tb_price.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // u_lbl_category
            // 
            u_lbl_category.AutoSize = true;
            u_lbl_category.Location = new Point(6, 69);
            u_lbl_category.Name = "u_lbl_category";
            u_lbl_category.Size = new Size(69, 20);
            u_lbl_category.TabIndex = 4;
            u_lbl_category.Text = "Category";
            // 
            // u_tb_name
            // 
            u_tb_name.Location = new Point(116, 36);
            u_tb_name.Name = "u_tb_name";
            u_tb_name.Size = new Size(151, 27);
            u_tb_name.TabIndex = 3;
            // 
            // update_label_name
            // 
            update_label_name.AutoSize = true;
            update_label_name.Location = new Point(6, 36);
            update_label_name.Name = "update_label_name";
            update_label_name.Size = new Size(104, 20);
            update_label_name.TabIndex = 2;
            update_label_name.Text = "Product Name";
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(654, 353);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(115, 29);
            delete_btn.TabIndex = 12;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 661);
            Controls.Add(delete_btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gbxName);
            Controls.Add(gbxCategory);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Products";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxName.ResumeLayout(false);
            gbxName.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label label_category;
        private GroupBox gbxName;
        private Label label_name;
        private TextBox tbName;
        private GroupBox groupBox1;
        private TextBox add_tb_pname;
        private Label add_lbl_pname;
        private TextBox add_tb_stockq;
        private Label add_lbl_stockq;
        private ComboBox add_cb_category;
        private TextBox add_tb_price;
        private Label add_lbl_price;
        private Label add_lbl_category;
        private Button add_btn;
        private TextBox add_tb_unitq;
        private Label add_lbl_unitq;
        private GroupBox groupBox2;
        private Button update_btn;
        private TextBox u_tb_unitq;
        private Label label1;
        private TextBox u_tb_stockq;
        private Label label2;
        private ComboBox u_cb_category;
        private TextBox u_tb_price;
        private Label label3;
        private Label u_lbl_category;
        private TextBox u_tb_name;
        private Label update_label_name;
        private Button delete_btn;
    }
}
