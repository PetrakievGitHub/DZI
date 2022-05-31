using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fantaziq
{
    public partial class Orders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False"); // свързва се с базата данни

        int OrderID;
        public Orders()
        {
            InitializeComponent();
            this.ControlBox = false;    // Премахва бутоните за минимизиране, правене на цял екран и затваряне
            showdata();     // показва таблицата в интерфейса
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False"); // свързва се с базата данни
            con.Open();     // отваря връската между базата данни и програмата

            SqlCommand cmd = new SqlCommand("INSERT INTO Trips(OrderID, CakeType, Drink) VALUES (@OrderID,@CakeType,@Drink)", con);     // чете от полетата за писане информацията и я слага в базата данни
            cmd.Parameters.AddWithValue("@OrderID", int.Parse(orderIdTxtBox.Text));
            cmd.Parameters.AddWithValue("@CakeType", (cakeTypeTxtBox.Text));
            //cmd.Parameters.AddWithValue("@Price", int.Parse(cakePriceTxtBox.Text));
            cmd.Parameters.AddWithValue("@Drink", (drinkTypeTxtBox.Text));
            //cmd.Parameters.AddWithValue("@DrinkPrice", (drinkPriceTxtBox.Text));
            //cmd.Parameters.AddWithValue("@TotalSum", (totalPriceTxtBox.Text));

            cmd.ExecuteNonQuery();  // изпълнява зададеното

            con.Close(); // затваря връзката

            orderIdTxtBox.Text = "";
            //pizzaPriceTxtBox.Text = "";
            pizzaTypeTxtBox.Text = "";
            drinkTypeTxtBox.Text = "";
            //drinkPriceTxtBox.Text = "";
            //drinkPriceTxtBox.Text = "";
            //totalPriceTxtBox.Text = "";

            MessageBox.Show("Поръчката бе успешно въведена!");

            showdata(); // показва наново базата данни с промените
        }

        public void showdata()
        {
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Orders", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE OrderID=@OrderID", con); // откъде да черпи информация
            cmd.Parameters.AddWithValue("@OrderID", int.Parse(orderIdTxtBox.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //private void updateButton_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False");
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("UPDATE Trips SET CakeType=@PizzaType, OrderID=@OrderID, Drink=@Drink, WHERE OrderID=@OrderID", con);
        //    cmd.Parameters.AddWithValue("@OrderID", int.Parse(orderIdTxtBox.Text));
        //    cmd.Parameters.AddWithValue("@CakeType", (cakeTypeTxtBox.Text));
        //    //cmd.Parameters.AddWithValue("@Price", int.Parse(cakePriceTxtBox.Text));
        //    cmd.Parameters.AddWithValue("@Drink", (drinkTypeTxtBox.Text));
        //    //cmd.Parameters.AddWithValue("@DrinkPrice", int.Parse(drinkPriceTxtBox.Text));
        //    //cmd.Parameters.AddWithValue("@TotalSum", int.Parse(totalPriceTxtBox.Text));

        //    cmd.ExecuteNonQuery();

        //    con.Close();

        //    orderIdTxtBox.Text = "";
        //    //cakePriceTxtBox.Text = "";
        //    cakeTypeTxtBox.Text = "";
        //    drinkTypeTxtBox.Text = "";
        //    //drinkPriceTxtBox.Text = "";
        //    //totalPriceTxtBox.Text = "";

        //    MessageBox.Show("Поръчката бе успешно записана");

        //    showdata();
        //}

        public void display()
        {
            string q = "SELECT OrderID, CakeType, Drink FROM Orders";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False");
            //con.Open();
            //SqlDataAdapter sqlDa = new SqlDataAdapter("Orders", con);
            //sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlDa.SelectCommand.Parameters.AddWithValue("@CakeType", cakeTypeTxtBox.Text.Trim());
            //DataTable dtbl = new DataTable();
            //sqlDa.Fill(dtbl);
            //dataGridView1.DataSource = dtbl;
            //con.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False");
            con.Open();

            //SqlCommand cmd = new SqlCommand("DELETE Fantaziq WHERE OrderID=@OrderID", con);
            //cmd.Parameters.AddWithValue("@OrderID", int.Parse(orderIdTxtBox.Text));

            //cmd.ExecuteNonQuery();

            //foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            //{
            //    dataGridView1.Rows.RemoveAt(item.Index);
            //}

            //con.Close();

            //orderIdTxtBox.Text = "";

            string sql = "DELETE FROM Orders WHERE OrderID = " + OrderID + "";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            display();
            orderIdTxtBox.Text = "";
            //cakePriceTxtBox.Text = "";
            cakeTypeTxtBox.Text = "";
            drinkTypeTxtBox.Text = "";
            //drinkPriceTxtBox.Text = "";
            //totalPriceTxtBox.Text = "";

            MessageBox.Show("Поръчката бе успешно премахната!");

            showdata();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрива интерфейса

            MainInterface mainInterface = new MainInterface(); // отива на главния интерфейс

            mainInterface.ShowDialog(); // показва главния интерфейс
        }

        private void transportIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Trips_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FantaziqDataSet3.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter2.Fill(this.pizzaShopDataSet3.Orders);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                OrderID = Convert.ToInt32(row.Cells[0].Value);
                orderIdTxtBox.Text = row.Cells[0].Value.ToString();
                //cakePriceTxtBox.Text = row.Cells[1].Value.ToString();
                cakeTypeTxtBox.Text = row.Cells[1].Value.ToString();
                drinkTypeTxtBox.Text = row.Cells[2].Value.ToString();
                //drinkPriceTxtBox.Text = row.Cells[4].Value.ToString();
                //totalPriceTxtBox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void cakePriceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VRRV6AG\SQLEXPRESS;Initial Catalog=Fantaziq;Integrated Security=True;Pooling=False");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Orders SET PizzaType=@CakeType, OrderID=@OrderID, Drink=@Drink WHERE OrderID=@OrderID", con);
            cmd.Parameters.AddWithValue("@OrderID", int.Parse(orderIdTxtBox.Text));
            cmd.Parameters.AddWithValue("@CakeType", (cakeTypeTxtBox.Text));
            cmd.Parameters.AddWithValue("@Drink", (drinkTypeTxtBox.Text));

            cmd.ExecuteNonQuery();

            con.Close();

            orderIdTxtBox.Text = "";
            cakeTypeTxtBox.Text = "";
            drinkTypeTxtBox.Text = "";

            MessageBox.Show("Поръчката бе успешно записана");

            showdata();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            showdata();
        }
    }
}
