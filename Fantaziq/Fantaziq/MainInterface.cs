using System;
using System.Windows.Forms;

namespace TravelCompany
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void transportsBtnMain_Click(object sender, EventArgs e)
        {
            this.Hide();    // скрива интерфейса

            NewOrder transportsInterface = new NewOrder();  // отива на зададения интерфейс

            transportsInterface.ShowDialog();   // показва зададения интерфейс
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // спира програмата
        }

        private void tripsBtnMain_Click(object sender, EventArgs e)
        {
            this.Hide();    // скрива интерфейса

            Orders tripsInterface = new Orders(); // отива на зададения интерфейс

            tripsInterface.ShowDialog();    // показва зададения интерфейс
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
