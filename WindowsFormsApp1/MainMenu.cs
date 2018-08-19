using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            lblDUserFullName.Text = Globals.userFullName;
            lblDUserCode.Text = Convert.ToString(Globals.userName);
            lblDUserRegion.Text = Convert.ToString(Globals.userRegion);
            lblDUserType.Text = Globals.userType;

            var dataGridSql = "SELECT * FROM orders ORDER BY OID DESC LIMIT 20";

            var server = "78.189.60.108";
            var database = "ef";
            var uid = "remoteuser";
            var password = "abcdefG1-1";
            string connectionString = "SERVER=" + server + "; PORT = 8001 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=none";
            var mycon = new MySqlConnection(connectionString);
            MySqlDataAdapter da = new MySqlDataAdapter(dataGridSql, mycon);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            UpdateFont();
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Consolas", 12F, GraphicsUnit.Pixel);
            }
        }
    }
}
