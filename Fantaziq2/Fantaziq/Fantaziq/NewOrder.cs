using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class NewOrder : Form
    {
        //Pizza prices:
        //const double price_Kaprichoza = 2.0;
        //const double price_Peperoni = 2.2;
        //const double price_Vylcha = 2.5;
        //const double price_Karbonara = 2.1;
        ////Drink prices
        //const double price_Voda05 = 1.8;
        //const double price_Kola05 = 2.1;
        //const double price_Airqn05 = 1.5;
        //const double price_Monster = 2.5;

        public NewOrder()
        {
            InitializeComponent();
            this.ControlBox = false;    // Премахва бутоните за минимизиране, правене на цял екран и затваряне
            /*showdata();*/ // показва таблицата в интерфейса
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        private void insertButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");  // свързва се с базата данни
            con.Open(); // отваря връската между базата данни и програмата

            string rngnum = "123456789";
            int rnglen = rngnum.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string finaldigit;

            int getindex;

            for (int i = 0; i < otpdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, rnglen);
                    finaldigit = rngnum.ToCharArray()[getindex].ToString();
                }
                while (otp.IndexOf(finaldigit) != -1);
                otp += finaldigit;
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Orders(OrderID, PizzaType, Drink) VALUES (@OrderID,@PizzaType, @Drink)", con);    // от къде да черпи информация
            cmd.Parameters.AddWithValue("@OrderID", otp);
            cmd.Parameters.AddWithValue("@PizzaType", (listBox1.Text));
            cmd.Parameters.AddWithValue("@Drink", (listBox2.Text));

            cmd.ExecuteNonQuery();  // изпълнява зададеното

            con.Close();    // затваря връзката

            MessageBox.Show("Поръчката бе успешно въведена!");
        }

        //private void updateButton_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("UPDATE Orders SET PizzaType=@PizzaType WHERE OrderID=@OrderID", con);
        //    cmd.Parameters.AddWithValue("@OrderID", (listBox1.Text));
        //    cmd.Parameters.AddWithValue("@PizzaType", (listBox2.Text));
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    MessageBox.Show("Successfully updated!");

        //    //showdata();
        //}
        //public class Product
        //{
        //    public string Name { get; set; }
        //    public decimal Price { get; set; }

        //    // This returns both Name and Price, but, of course, if you want only
        //    // the name just return $"{Name}"
        //    public override string ToString()
        //    {
        //        return $"{Name} - {Price.ToString("C")}";
        //    }
        //}

        //List<Product> products = new List<Product>();
        //public Form1()
        //{
        //    InitializeComponent();
        //    AddProducts();
        //    listBox1.DataSource = ordersBindingSource1;
        //    labelTotalPrice.Text = products.Sum(x => x.Price).ToString("C");
        //}

        //public void AddProducts()
        //{
        //    products.Add(new Product { Name = "Product X", Price = 10.4m });
        //    products.Add(new Product { Name = "Product Z", Price = 1.5m });
        //    products.Add(new Product { Name = "Product K", Price = 7.32m });
        //}
        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("DELETE Orders WHERE OrderID=@OrderID", con);
        //    cmd.Parameters.AddWithValue("@OrderID", (listBox1.Text));
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    MessageBox.Show("Successfully deleted!");
        //    //showdata();
        //}

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 6)
        //    {
        //        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //        //con.Open();

        //        //SqlCommand cmd = new SqlCommand("DELETE Orders WHERE PizzaID=@PizzaID", con);
        //        //cmd.Parameters.AddWithValue("@PizzaID", pizzaIDDataGridViewTextBoxColumn);

        //        //cmd.ExecuteNonQuery();
        //        //con.Close();

        //        //MessageBox.Show("Successfully deleted!");
        //        //showdata();

        //        //-----------------------------------------------------------------------

        //        //SqlCommand cmd = new SqlCommand();

        //        //cmd.Parameters.Clear();
        //        //cmd.CommandText = "SP name";
        //        //cmd.Parameters.AddWithValue("@PizzaID", pizzaIDDataGridViewTextBoxColumn);
        //        //try
        //        //{
        //        //    con.Open();
        //        //    cmd.ExecuteReader();
        //        //}
        //        //catch (Exception ex)
        //        //{
        //        //    Console.Write(ex.InnerException);
        //        //}
        //        //finally
        //        //{
        //        //    con.Close();
        //        //}

        //        //-------------------------------------------------------------------------

        //        //int id = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        //        //SqlCommand cmd = new SqlCommand();
        //        //cmd.CommandText = "Delete FROM Orders where PizzaID='" + pizzaIDDataGridViewTextBoxColumn + "'";
        //        //cmd.Connection = con;
        //        //con.Open();
        //        //cmd.ExecuteNonQuery();
        //        //con.Close();

        //        //"@PizzaID" = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells[0].RowIndex.Value.ToString());

        //        //DialogResult result = MessageBox.Show("Сигурни ли сте?", MessageBoxButton.YesNo, MessageBox)
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            //paymentMethodBox.Items.Add(" ");
            //paymentMethodBox.Items.Add("Брой");
            //paymentMethodBox.Items.Add("Карта");

            listBox1.Items.Add("Карбонара");
            listBox1.Items.Add("Пиза пеперони");
            listBox1.Items.Add("Вълча");
            listBox1.Items.Add("Капричоза");

            listBox2.Items.Add("Вода 0.5л");
            listBox2.Items.Add("Айрян 0.5л");
            listBox2.Items.Add("Кола 0.5л");
            listBox2.Items.Add("Monster енергийна напитка");

            //EnableTextBoxesMethod();

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //EnableTextBoxes();
        }

        //private void EnableTextBoxes()
        //{
        //    Action<Control.ControlCollection> func = null;

        //    func = (controls) =>
        //    {
        //        foreach (Control control in controls)
        //        {
        //            if (control is TextBox)
        //            {
        //                (control as TextBox).Enabled = false;
        //            }
        //            else
        //            {
        //                func(control.Controls);
        //            }
        //        }
        //    };

        //    func(Controls);
        //}

        //private void searchButton_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE OrderID=@OrderID", con);  // от къде да черпи информация
        //    cmd.Parameters.AddWithValue("@OrderID", (listBox1.Text));
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    //dataGridView1.DataSource = dt;

        //    //showdata();
        //}

        //private void headerLabel_Click(object sender, EventArgs e)
        //{

        //}

        //public void showdata()
        //{
        //    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Orders", con);
        //    DataTable dt = new DataTable();
        //    adpt.Fill(dt);
        //dataGridView1.DataSource = dt;

        //DataGridViewButtonColumn deletebutton = new DataGridViewButtonColumn();

        //deletebutton.FlatStyle = FlatStyle.Popup;

        //deletebutton.HeaderText = "Delete";
        //deletebutton.Name = "Delete";
        //deletebutton.UseColumnTextForButtonValue = true;
        //deletebutton.Text = "Delete";

        //deletebutton.Width = 60;

        //if (dataGridView1.Columns.Contains(deletebutton.Name = "Delete"))
        //{

        //}
        //else
        //{
        //    dataGridView1.Columns.Add(deletebutton);
        //}
        //}

        private void backBtn_Click(object sender, EventArgs e)
        {

            this.Hide();    // скрива интерфейса

            MainInterface mainInterface = new MainInterface();  // отива на главния интерфейс

            mainInterface.ShowDialog(); // показва главния интерфейс
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void calculateButton_Click(object sender, EventArgs e)
        //{

        //    double[] itemcost = new double[8];
        //    itemcost[0] = Convert.ToDouble(peperoniQuanBox.Text) * price_Peperoni;
        //    itemcost[1] = Convert.ToDouble(karbonaraQuanBox.Text) * price_Karbonara;
        //    itemcost[2] = Convert.ToDouble(vylchaQuanBox.Text) * price_Vylcha;
        //    itemcost[3] = Convert.ToDouble(kaprichozaQuanBox.Text) * price_Kaprichoza;
        //    itemcost[4] = Convert.ToDouble(voda05QuanBox.Text) * price_Voda05;
        //    itemcost[5] = Convert.ToDouble(kola05QuanBox.Text) * price_Kola05;
        //    itemcost[6] = Convert.ToDouble(airqn05QuanBox.Text) * price_Airqn05;
        //    itemcost[7] = Convert.ToDouble(monsterQuanBox.Text) * price_Monster;

        //    double total, cost, ichange;

        //    if (paymentMethodBox.Text == "Брой")
        //    {
        //        total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7];

        //        txtTotal.Text = Convert.ToString(total);
        //        ichange = Convert.ToDouble(txtTotal.Text);
        //        cost = ichange - total;
        //        txtChange.Text = Convert.ToString(cost);

        //        txtTotal.Text = String.Format("{0:C}", cost);
        //        txtChange.Text = String.Format("{0:C}", ichange);
        //    }
        //    else
        //    {
        //        total = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7];

        //        txtTotal.Text = Convert.ToString(total);
        //        ichange = Convert.ToDouble(txtTotal.Text);
        //        cost = ichange - total;
        //        txtChange.Text = Convert.ToString(cost);

        //        txtTotal.Text = String.Format("{0:C}", cost);
        //        txtChange.Text = String.Format("{0:C}", ichange);
        //    }
        //}

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }

        //private void addToMenuButton_Click(object sender, EventArgs e)
        //{
        //    //if (string.IsNullOrEmpty(productTxtBox.Text) || string.IsNullOrEmpty(priceTxtBox.Text))
        //    //    return;
        //    //ListViewItem item = new ListViewItem(productTxtBox.Text);
        //    //item.SubItems.Add(priceTxtBox.Text);
        //    //listView1.Items.Add(item);
        //    //productTxtBox.Clear();
        //    //priceTxtBox.Clear();
        //    //productTxtBox.Focus();

        //    //string rngnum = "123456789";
        //    //int rnglen = rngnum.Length;
        //    //string otp = string.Empty;
        //    //int otpdigit = 5;
        //    //string finaldigit;

        //    //int getindex;

        //    //for (int i = 0; i < otpdigit; i++)
        //    //{
        //    //    do
        //    //    {
        //    //        getindex = new Random().Next(0, rnglen);
        //    //        finaldigit = rngnum.ToCharArray()[getindex].ToString();
        //    //    }
        //    //    while (otp.IndexOf(finaldigit) != -1);
        //    //    otp += finaldigit;
        //    //}

        //    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //    //con.Open();

        //    //SqlCommand cmd = new SqlCommand("INSERT INTO CalOrders(CalOrderID, Product, Price) VALUES (@CalOrderID,@Product, @Price)", con);
        //    //cmd.Parameters.AddWithValue("@CalOrderID", otp);
        //    //cmd.Parameters.AddWithValue("@Product", (productTxtBox.Text));
        //    //cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(priceTxtBox.Text));

        //    //cmd.ExecuteNonQuery();  // изпълнява зададеното

        //    //con.Close();    // затваря връзката

        //    //MessageBox.Show("Successfully inserted CalOrder!");
        //}

        //private void removeFromMenuButton_Click(object sender, EventArgs e)
        //{
        //    //if (listView1.Items.Count > 0)
        //    //    listView1.Items.Remove(listView1.SelectedItems[0]);
        //}

        //private void peperoniBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (peperoniBox.Checked == true)
        //    {
        //        peperoniQuanBox.Enabled = true;
        //        peperoniQuanBox.Text = "";
        //        peperoniQuanBox.Focus();
        //    }
        //    else
        //    {
        //        peperoniQuanBox.Enabled = false;
        //        peperoniQuanBox.Text = "0";
        //    }
        //}

        //private void karbonaraBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (karbonaraBox.Checked == true)
        //    {
        //        karbonaraQuanBox.Enabled = true;
        //        karbonaraQuanBox.Text = "";
        //        karbonaraQuanBox.Focus();
        //    }
        //    else
        //    {
        //        karbonaraQuanBox.Enabled = false;
        //        karbonaraQuanBox.Text = "0";
        //    }
        //}

        //private void vylchaBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (vylchaBox.Checked == true)
        //    {
        //        vylchaQuanBox.Enabled = true;
        //        vylchaQuanBox.Text = "";
        //        vylchaQuanBox.Focus();
        //    }
        //    else
        //    {
        //        vylchaQuanBox.Enabled = false;
        //        vylchaQuanBox.Text = "0";
        //    }
        //}

        //private void kaprichozaBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (kaprichozaBox.Checked == true)
        //    {
        //        kaprichozaQuanBox.Enabled = true;
        //        kaprichozaQuanBox.Text = "";
        //        kaprichozaQuanBox.Focus();
        //    }
        //    else
        //    {
        //        kaprichozaQuanBox.Enabled = false;
        //        kaprichozaQuanBox.Text = "0";
        //    }
        //}

        //private void vodaBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (vodaBox.Checked == true)
        //    {
        //        voda05QuanBox.Enabled = true;
        //        voda05QuanBox.Text = "";
        //        voda05QuanBox.Focus();
        //    }
        //    else
        //    {
        //        voda05QuanBox.Enabled = false;
        //        voda05QuanBox.Text = "0";
        //    }
        //}

        //private void airqnBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (airqnBox.Checked == true)
        //    {
        //        airqn05QuanBox.Enabled = true;
        //        airqn05QuanBox.Text = "";
        //        airqn05QuanBox.Focus();
        //    }
        //    else
        //    {
        //        airqn05QuanBox.Enabled = false;
        //        airqn05QuanBox.Text = "0";
        //    }
        //}

        //private void colaBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (colaBox.Checked == true)
        //    {
        //        kola05QuanBox.Enabled = true;
        //        kola05QuanBox.Text = "";
        //        kola05QuanBox.Focus();
        //    }
        //    else
        //    {
        //        kola05QuanBox.Enabled = false;
        //        kola05QuanBox.Text = "0";
        //    }
        //}

        //private void monsterBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (monsterBox.Checked == false)
        //    {
        //        monsterQuanBox.Enabled = false;
        //        monsterQuanBox.Text = "0";
        //    }
        //    else
        //    {
        //        monsterQuanBox.Enabled = true;
        //        monsterQuanBox.Text = "";
        //        monsterQuanBox.Focus();
        //    }
        //}

        //private void paymentMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (paymentMethodBox.Text == "Брой")
        //    {
        //        moneyGivenTxtBox.Enabled = true;
        //        moneyGivenTxtBox.Text = "";
        //        moneyGivenTxtBox.Focus();
        //    }
        //    else if (paymentMethodBox.Text == "Карта")
        //    {
        //        moneyGivenTxtBox.Enabled = true;
        //        moneyGivenTxtBox.Text = "";
        //        moneyGivenTxtBox.Focus();
        //    }
        //}

        //private void takeawayBox_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (takeawayBox.Checked == true)
        //    {
        //        imeTxtBox.Enabled = true;
        //        telNomerTxtBox.Enabled = true;
        //        adresTxtBox.Enabled = true;

        //        imeTxtBox.Text = "";
        //        telNomerTxtBox.Text = "";
        //        adresTxtBox.Text = "";

        //        imeTxtBox.Focus();
        //        telNomerTxtBox.Focus();
        //        adresTxtBox.Focus();
        //    }
        //    else
        //    {
        //        imeTxtBox.Enabled = false;
        //        telNomerTxtBox.Enabled = false;
        //        adresTxtBox.Enabled = false;
        //    }
        //}

        //private void newOrderBtn_Click(object sender, EventArgs e)
        //{
        //    RestListBoxes();
        //    //RestCheckBoxes();
        //}

        //private void RestListBoxes()
        //{
        //    Action<Control.ControlCollection> func = null;

        //    func = (controls) =>
        //    {
        //        foreach (Control control in controls)
        //            if (control is ListBox)
        //                (control as ListBox).SetSelected = "0";
        //            else
        //                func(control.Controls);
        //    };
        //    func(Controls);
        //}

        //private void RestCheckBoxes()
        //{
        //    Action<Control.ControlCollection> func = null;

        //    func = (controls) =>
        //    {
        //        foreach (Control control in controls)
        //            if (control is CheckBox)
        //                (control as CheckBox).Checked = false;
        //            else
        //                func(control.Controls);
        //    };
        //    func(Controls); ;
        //}

        //private void EnableTextBoxesMethod()
        //{
        //    Action<Control.ControlCollection> func = null;

        //    func = (controls) =>
        //    {
        //        foreach (Control control in controls)
        //            if (control is TextBox)
        //                (control as TextBox).Enabled = false;
        //            else
        //                func(control.Controls);
        //    };
        //    func(Controls);
        //}

        //private void moneyGivenTxtBox_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void transportsLabelSub_Click(object sender, EventArgs e)
        //{

        //}

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{

        //}

        //private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        //{

        //    //int pizzaID = Convert.ToInt32(dataGridView1.DataKeys[e.RowIndex].Value.ToString());

        //    //int rowIndex = dataGridView1.CurrentCell.RowIndex;
        //    //dataGridView1.Rows.RemoveAt(rowIndex);

        //    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //    //con.Open();

        //    //if (MessageBox.Show("Сигурни ли сте, че искате да изтриете тази поръчка?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    //{
        //    //    int rows = dataGridView1.RowCount;
        //    //    for (int i = rows - 1; i >= 0; i--)
        //    //    {
        //    //        if (dataGridView1.Rows[i].Selected)
        //    //        {
        //    //            db.PizzaShop.Remove(dataGridView1.Rows[i].DataBoundItem as pizzaIDDataGridViewTextBoxColumn);
        //    //            pizza
        //    //        }
        //    //    }
        //    //}

        //    //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=PizzaShop;Integrated Security=True;Pooling=False");
        //    //con.Open();

        //    //SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE OrderID = `" + pizzaIDDataGridViewTextBoxColumn+"`", con);
        //    //cmd.ExecuteNonQuery();
        //    //con.Close();

        //    //MessageBox.Show("Successfully deleted!");
        //    //showdata();
        //}
    }
}
