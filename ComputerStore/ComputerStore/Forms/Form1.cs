using System.Data;
using System.Data.SqlClient;

namespace ComputerStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadcategories();
        }
        string connectionString = @"Data Source=LAPTOP-J4KLRFPG\ANHVIET;Initial Catalog=ComputerStoreDB;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable DataTable;
        void loadcategories()
        {
            connection = new SqlConnection(connectionString);
            string sql = "select * from LoaiHang";
            adapter = new SqlDataAdapter(sql,connection);
            DataTable = new DataTable();
            adapter.Fill(DataTable);
            dtvgCategories.DataSource = DataTable;
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
