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
            this.searchingtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Deletebnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(537, 144);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(270, 26);
            this.quantitytxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
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
            this.itemtxt.Location = new System.Drawing.Point(133, 144);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(269, 26);
            this.itemtxt.TabIndex = 2;
            this.itemtxt.TextChanged += new System.EventHandler(this.itemtxt_TextChanged);
            // 
            // categorytxt
            // 
            this.categorytxt.Location = new System.Drawing.Point(133, 190);
            this.categorytxt.Name = "categorytxt";
            this.categorytxt.Size = new System.Drawing.Size(269, 26);
            this.categorytxt.TabIndex = 3;
            this.categorytxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(537, 190);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(270, 26);
            this.pricetxt.TabIndex = 4;
            this.pricetxt.TextChanged += new System.EventHandler(this.pricetxt_TextChanged);
            // 
            // itemNametxt
            // 
            this.itemNametxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNametxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemNametxt.Location = new System.Drawing.Point(12, 134);
            this.itemNametxt.Name = "itemNametxt";
            this.itemNametxt.Size = new System.Drawing.Size(104, 25);
            this.itemNametxt.TabIndex = 5;
            this.itemNametxt.Text = "itemName";
            this.itemNametxt.Click += new System.EventHandler(this.itemNametxt_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "itemCategory";
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quantity.Location = new System.Drawing.Point(447, 135);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(84, 25);
            this.quantity.TabIndex = 7;
            this.quantity.Text = "quantity";
            this.quantity.Click += new System.EventHandler(this.label3_Click);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.price.Location = new System.Drawing.Point(463, 191);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(51, 25);
            this.price.TabIndex = 8;
            this.price.Text = "price";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(351, 258);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(91, 28);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "AddItem";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // veiwtxt
            // 
            this.veiwtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.veiwtxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.veiwtxt.ForeColor = System.Drawing.Color.White;
            this.veiwtxt.Location = new System.Drawing.Point(467, 258);
            this.veiwtxt.Name = "veiwtxt";
            this.veiwtxt.Size = new System.Drawing.Size(93, 28);
            this.veiwtxt.TabIndex = 11;
            this.veiwtxt.Text = "veiwData";
            this.veiwtxt.UseVisualStyleBackColor = false;
            this.veiwtxt.Click += new System.EventHandler(this.veiwtxt_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-6, 292);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(834, 202);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // updatebnt
            // 
            this.updatebnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.updatebnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebnt.ForeColor = System.Drawing.Color.White;
            this.updatebnt.Location = new System.Drawing.Point(583, 258);
            this.updatebnt.Name = "updatebnt";
            this.updatebnt.Size = new System.Drawing.Size(109, 28);
            this.updatebnt.TabIndex = 12;
            this.updatebnt.Text = "Update";
            this.updatebnt.UseVisualStyleBackColor = false;
            this.updatebnt.Click += new System.EventHandler(this.deletebnt_Click);
            // 
            // searchingbtn
            // 
            this.searchingbtn.Location = new System.Drawing.Point(738, 98);
            this.searchingbtn.Name = "searchingbtn";
            this.searchingbtn.Size = new System.Drawing.Size(80, 28);
            this.searchingbtn.TabIndex = 13;
            this.searchingbtn.Text = "Searching";
            this.searchingbtn.UseVisualStyleBackColor = true;
            this.searchingbtn.Click += new System.EventHandler(this.searchingbtn_Click);
            // 
            // searchingtxt
            // 
            this.searchingtxt.Location = new System.Drawing.Point(537, 100);
            this.searchingtxt.Name = "searchingtxt";
            this.searchingtxt.Size = new System.Drawing.Size(191, 26);
            this.searchingtxt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(435, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "EnterItem";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(133, 101);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(269, 26);
            this.IdTxt.TabIndex = 16;
            this.IdTxt.TextChanged += new System.EventHandler(this.IdTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "EnterId:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Deletebnt
            // 
            this.Deletebnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.Deletebnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Deletebnt.ForeColor = System.Drawing.Color.White;
            this.Deletebnt.Location = new System.Drawing.Point(711, 258);
            this.Deletebnt.Name = "Deletebnt";
            this.Deletebnt.Size = new System.Drawing.Size(80, 28);
            this.Deletebnt.TabIndex = 18;
            this.Deletebnt.Text = "Delete";
            this.Deletebnt.UseVisualStyleBackColor = false;
            this.Deletebnt.Click += new System.EventHandler(this.Deletebnt_Click_1);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(819, 490);
            this.Controls.Add(this.Deletebnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchingtxt);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.TextBox categorytxt;
        public System.Windows.Forms.Label itemNametxt;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label quantity;
        public System.Windows.Forms.Label price;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button updatebnt;
        public System.Windows.Forms.Button veiwtxt;
        private System.Windows.Forms.Button searchingbtn;
        private System.Windows.Forms.TextBox searchingtxt;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdTxt;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Deletebnt;
        public System.Windows.Forms.TextBox quantitytxt;
        public System.Windows.Forms.TextBox pricetxt;
    }
}