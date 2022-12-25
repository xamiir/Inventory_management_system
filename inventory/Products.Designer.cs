namespace inventory
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.categorytxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.itemNametxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.veiwtxt = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.updatebnt = new System.Windows.Forms.Button();
            this.searchingbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(537, 105);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(270, 26);
            this.quantitytxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(126, 106);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(269, 26);
            this.itemtxt.TabIndex = 2;
            this.itemtxt.TextChanged += new System.EventHandler(this.itemtxt_TextChanged);
            // 
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(126, 180);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(269, 26);
            this.categorytxt.TabIndex = 3;
            this.categorytxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(537, 180);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(270, 26);
            this.pricetxt.TabIndex = 4;
            // 
            // itemNametxt
            // 
            this.itemNametxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNametxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemNametxt.Location = new System.Drawing.Point(12, 106);
            this.itemNametxt.Name = "itemNametxt";
            this.itemNametxt.Size = new System.Drawing.Size(104, 25);
            this.itemNametxt.TabIndex = 5;
            this.itemNametxt.Text = "itemName";
            this.itemNametxt.Click += new System.EventHandler(this.itemNametxt_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "itemCategory";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quantity.Location = new System.Drawing.Point(447, 106);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(84, 25);
            this.quantity.TabIndex = 7;
            this.quantity.Text = "quantity";
            this.quantity.Click += new System.EventHandler(this.label3_Click);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.price.Location = new System.Drawing.Point(460, 180);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(71, 25);
            this.price.TabIndex = 8;
            this.price.Text = "price";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(320, 227);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(109, 31);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "AddItem";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // veiwtxt
            // 
            this.veiwtxt.Location = new System.Drawing.Point(451, 227);
            this.veiwtxt.Name = "veiwtxt";
            this.veiwtxt.Size = new System.Drawing.Size(109, 31);
            this.veiwtxt.TabIndex = 11;
            this.veiwtxt.Text = "veiwData";
            this.veiwtxt.UseVisualStyleBackColor = true;
            this.veiwtxt.Click += new System.EventHandler(this.veiwtxt_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(5, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(823, 230);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // updatebnt
            // 
            this.updatebnt.Location = new System.Drawing.Point(589, 227);
            this.updatebnt.Name = "updatebnt";
            this.updatebnt.Size = new System.Drawing.Size(109, 31);
            this.updatebnt.TabIndex = 12;
            this.updatebnt.Text = "Update";
            this.updatebnt.UseVisualStyleBackColor = true;
            this.updatebnt.Click += new System.EventHandler(this.deletebnt_Click);
            // 
            // searchingbtn
            // 
            this.searchingbtn.Location = new System.Drawing.Point(704, 227);
            this.searchingbtn.Name = "searchingbtn";
            this.searchingbtn.Size = new System.Drawing.Size(109, 31);
            this.searchingbtn.TabIndex = 13;
            this.searchingbtn.Text = "Searching";
            this.searchingbtn.UseVisualStyleBackColor = true;
            this.searchingbtn.Click += new System.EventHandler(this.searchingbtn_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(819, 490);
            this.Controls.Add(this.searchingbtn);
            this.Controls.Add(this.updatebnt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.veiwtxt);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNametxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.categorytxt);
            this.Controls.Add(this.itemtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantitytxt);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.TextBox categorytxt;
        private System.Windows.Forms.TextBox pricetxt;
        public System.Windows.Forms.Label itemNametxt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label quantity;
        public System.Windows.Forms.Label price;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button updatebnt;
        public System.Windows.Forms.Button veiwtxt;
        private System.Windows.Forms.Button searchingbtn;
    }
}