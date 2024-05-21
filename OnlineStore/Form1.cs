using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectToMSSQL(string username, string password)
        {
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;User ID={username};Password={password};";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected to MSSQL");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

        private void ConnectToAccess(string username, string password)
        {
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Faim.Badgutdinov\\OneDrive\\Документы\\TestDB_be.accdb;User ID={username};Password={password};Persist Security Info=True;";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connected to MS Access");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

        private void ConnectToDatabases()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Task.Run(() => ConnectToMSSQL(username, password));
            Task.Run(() => ConnectToAccess(username, password));
        }

        private void btnConnectMSSQL_Click(object sender, EventArgs e)
        {
            ConnectToMSSQL(txtUsername.Text, txtPassword.Text);
        }

        private void btnConnectAccess_Click(object sender, EventArgs e)
        {
            ConnectToAccess(txtUsername.Text, txtPassword.Text);
        }
    }
}
