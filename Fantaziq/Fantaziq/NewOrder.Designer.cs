namespace TravelCompany
{
    partial class NewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.insertButton = new System.Windows.Forms.Button();
            this.transportTypeLabel = new System.Windows.Forms.Label();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaShopDataSet = new TravelCompany.FantaziqDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportsLabelSub = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ordersTableAdapter = new TravelCompany.PizzaShopDataSetTableAdapters.OrdersTableAdapter();
            this.calOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pizzaShopDataSet2 = new TravelCompany.FantaziqDataSet2();
            this.pizzaShopDataSet1 = new TravelCompany.FantaziqDataSet1();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new TravelCompany.PizzaShopDataSet1TableAdapters.OrdersTableAdapter();
            this.calOrdersTableAdapter = new TravelCompany.PizzaShopDataSet2TableAdapters.CalOrdersTableAdapter();
            this.newOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.BackColor = System.Drawing.Color.Maroon;
            this.insertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertButton.FlatAppearance.BorderSize = 3;
            this.insertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.insertButton.Location = new System.Drawing.Point(590, 439);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(224, 99);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "ВКАРАЙ";
            this.insertButton.UseVisualStyleBackColor = false;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // transportTypeLabel
            // 
            this.transportTypeLabel.AutoSize = true;
            this.transportTypeLabel.BackColor = System.Drawing.Color.Maroon;
            this.transportTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportTypeLabel.ForeColor = System.Drawing.Color.SandyBrown;
            this.transportTypeLabel.Location = new System.Drawing.Point(128, 160);
            this.transportTypeLabel.Name = "transportTypeLabel";
            this.transportTypeLabel.Size = new System.Drawing.Size(224, 42);
            this.transportTypeLabel.TabIndex = 5;
            this.transportTypeLabel.Text = "ВИД ПИЦА";
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.pizzaShopDataSet;
            // 
            // pizzaShopDataSet
            // 
            this.pizzaShopDataSet.DataSetName = "PizzaShopDataSet";
            this.pizzaShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.pizzaShopDataSet;
            // 
            // transportsLabelSub
            // 
            this.transportsLabelSub.AutoSize = true;
            this.transportsLabelSub.BackColor = System.Drawing.Color.Maroon;
            this.transportsLabelSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transportsLabelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportsLabelSub.ForeColor = System.Drawing.Color.SandyBrown;
            this.transportsLabelSub.Location = new System.Drawing.Point(263, 12);
            this.transportsLabelSub.Name = "transportsLabelSub";
            this.transportsLabelSub.Size = new System.Drawing.Size(423, 55);
            this.transportsLabelSub.TabIndex = 21;
            this.transportsLabelSub.Text = "НОВА ПОРЪЧКА";
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
            this.backBtn.TabIndex = 22;
            this.backBtn.Text = "НАЗАД";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Maroon;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(92, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 160);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(595, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 42);
            this.label1.TabIndex = 25;
            this.label1.Text = "НАПИТКА";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Maroon;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.Color.SandyBrown;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(548, 246);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(305, 160);
            this.listBox2.TabIndex = 26;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // calOrdersBindingSource
            // 
            this.calOrdersBindingSource.DataMember = "CalOrders";
            this.calOrdersBindingSource.DataSource = this.pizzaShopDataSet2;
            // 
            // pizzaShopDataSet2
            // 
            this.pizzaShopDataSet2.DataSetName = "PizzaShopDataSet2";
            this.pizzaShopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pizzaShopDataSet1
            // 
            this.pizzaShopDataSet1.DataSetName = "PizzaShopDataSet1";
            this.pizzaShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.pizzaShopDataSet1;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // calOrdersTableAdapter
            // 
            this.calOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Maroon;
            this.newOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newOrderButton.FlatAppearance.BorderSize = 3;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.SandyBrown;
            this.newOrderButton.Location = new System.Drawing.Point(133, 439);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(224, 99);
            this.newOrderButton.TabIndex = 27;
            this.newOrderButton.Text = "НОВА ПОРЪЧКА";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.transportsLabelSub);
            this.Controls.Add(this.transportTypeLabel);
            this.Controls.Add(this.insertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOrder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label transportTypeLabel;
        private System.Windows.Forms.Label transportsLabelSub;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private FantaziqDataSet pizzaShopDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private PizzaShopDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private FantaziqDataSet1 pizzaShopDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private PizzaShopDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private FantaziqDataSet2 pizzaShopDataSet2;
        private System.Windows.Forms.BindingSource calOrdersBindingSource;
        private PizzaShopDataSet2TableAdapters.CalOrdersTableAdapter calOrdersTableAdapter;
        private System.Windows.Forms.Button newOrderButton;
    }
}

