namespace TravelCompany
{
    partial class Orders
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.orderIdTxtBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.drinkTypeTxtBox = new System.Windows.Forms.TextBox();
            this.pizzaTypeTxtBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pizzaShopDataSet = new TravelCompany.FantaziqDataSet();
            this.pizzaShopDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new TravelCompany.PizzaShopDataSetTableAdapters.OrdersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaShopDataSet3 = new TravelCompany.FantaziqDataSet3();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaShopDataSet1 = new TravelCompany.FantaziqDataSet1();
            this.transportTypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ordersTableAdapter1 = new TravelCompany.PizzaShopDataSet1TableAdapters.OrdersTableAdapter();
            this.ordersTableAdapter2 = new TravelCompany.PizzaShopDataSet3TableAdapters.OrdersTableAdapter();
            this.updateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIdTxtBox
            // 
            this.orderIdTxtBox.BackColor = System.Drawing.Color.Maroon;
            this.orderIdTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderIdTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIdTxtBox.ForeColor = System.Drawing.Color.SandyBrown;
            this.orderIdTxtBox.Location = new System.Drawing.Point(354, 110);
            this.orderIdTxtBox.Name = "orderIdTxtBox";
            this.orderIdTxtBox.Size = new System.Drawing.Size(530, 24);
            this.orderIdTxtBox.TabIndex = 13;
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Maroon;
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.FlatAppearance.BorderSize = 3;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.insertButton.Location = new System.Drawing.Point(570, 271);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(151, 106);
            this.insertButton.TabIndex = 15;
            this.insertButton.Text = "ВКАРАЙ";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Maroon;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderSize = 3;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.searchButton.Location = new System.Drawing.Point(570, 495);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 106);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "ПОТЪРСИ";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderSize = 3;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.deleteButton.Location = new System.Drawing.Point(570, 383);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(314, 106);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "ИЗТРИЙ";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // drinkTypeTxtBox
            // 
            this.drinkTypeTxtBox.BackColor = System.Drawing.Color.Maroon;
            this.drinkTypeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.drinkTypeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkTypeTxtBox.ForeColor = System.Drawing.Color.SandyBrown;
            this.drinkTypeTxtBox.Location = new System.Drawing.Point(354, 204);
            this.drinkTypeTxtBox.Name = "drinkTypeTxtBox";
            this.drinkTypeTxtBox.Size = new System.Drawing.Size(530, 24);
            this.drinkTypeTxtBox.TabIndex = 23;
            // 
            // pizzaTypeTxtBox
            // 
            this.pizzaTypeTxtBox.BackColor = System.Drawing.Color.Maroon;
            this.pizzaTypeTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzaTypeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaTypeTxtBox.ForeColor = System.Drawing.Color.SandyBrown;
            this.pizzaTypeTxtBox.Location = new System.Drawing.Point(354, 156);
            this.pizzaTypeTxtBox.Name = "pizzaTypeTxtBox";
            this.pizzaTypeTxtBox.Size = new System.Drawing.Size(530, 24);
            this.pizzaTypeTxtBox.TabIndex = 24;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Maroon;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 3;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.SandyBrown;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(113, 48);
            this.backBtn.TabIndex = 28;
            this.backBtn.Text = "НАЗАД";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(328, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 55);
            this.label2.TabIndex = 31;
            this.label2.Text = "ПОРЪЧКИ";
            // 
            // pizzaShopDataSet
            // 
            this.pizzaShopDataSet.DataSetName = "PizzaShopDataSet";
            this.pizzaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzaShopDataSetBindingSource
            // 
            this.pizzaShopDataSetBindingSource.DataSource = this.pizzaShopDataSet;
            this.pizzaShopDataSetBindingSource.Position = 0;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pizzaShopDataSetBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.pizzaTypeDataGridViewTextBoxColumn,
            this.drinkDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.ordersBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(70, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Maroon;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SandyBrown;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Maroon;
            this.dataGridView1.Size = new System.Drawing.Size(494, 330);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // pizzaTypeDataGridViewTextBoxColumn
            // 
            this.pizzaTypeDataGridViewTextBoxColumn.DataPropertyName = "PizzaType";
            this.pizzaTypeDataGridViewTextBoxColumn.HeaderText = "PizzaType";
            this.pizzaTypeDataGridViewTextBoxColumn.Name = "pizzaTypeDataGridViewTextBoxColumn";
            // 
            // drinkDataGridViewTextBoxColumn
            // 
            this.drinkDataGridViewTextBoxColumn.DataPropertyName = "Drink";
            this.drinkDataGridViewTextBoxColumn.HeaderText = "Drink";
            this.drinkDataGridViewTextBoxColumn.Name = "drinkDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.pizzaShopDataSet3;
            // 
            // pizzaShopDataSet3
            // 
            this.pizzaShopDataSet3.DataSetName = "PizzaShopDataSet3";
            this.pizzaShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.pizzaShopDataSet1;
            // 
            // pizzaShopDataSet1
            // 
            this.pizzaShopDataSet1.DataSetName = "PizzaShopDataSet1";
            this.pizzaShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportTypeLabel
            // 
            this.transportTypeLabel.AutoSize = true;
            this.transportTypeLabel.BackColor = System.Drawing.Color.Maroon;
            this.transportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportTypeLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.transportTypeLabel.Location = new System.Drawing.Point(65, 109);
            this.transportTypeLabel.Name = "transportTypeLabel";
            this.transportTypeLabel.Size = new System.Drawing.Size(229, 25);
            this.transportTypeLabel.TabIndex = 33;
            this.transportTypeLabel.Text = "ИД НА ПОРЪЧКАТА";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(163, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "ВИД ПИЦА";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(175, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "НАПИТКА";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersTableAdapter2
            // 
            this.ordersTableAdapter2.ClearBeforeFill = true;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Maroon;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatAppearance.BorderSize = 3;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.updateButton.Location = new System.Drawing.Point(733, 271);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(151, 106);
            this.updateButton.TabIndex = 37;
            this.updateButton.Text = "ПРОМЕНИ";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Maroon;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderSize = 3;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.refreshButton.Location = new System.Drawing.Point(733, 495);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(151, 106);
            this.refreshButton.TabIndex = 38;
            this.refreshButton.Text = "ОБНОВИ";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 628);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transportTypeLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pizzaTypeTxtBox);
            this.Controls.Add(this.drinkTypeTxtBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.orderIdTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Trips";
            this.Load += new System.EventHandler(this.Trips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox orderIdTxtBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox drinkTypeTxtBox;
        private System.Windows.Forms.TextBox pizzaTypeTxtBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource pizzaShopDataSetBindingSource;
        private FantaziqDataSet pizzaShopDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private PizzaShopDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label transportTypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private FantaziqDataSet1 pizzaShopDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private PizzaShopDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private FantaziqDataSet3 pizzaShopDataSet3;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private PizzaShopDataSet3TableAdapters.OrdersTableAdapter ordersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pizzaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button refreshButton;
    }
}