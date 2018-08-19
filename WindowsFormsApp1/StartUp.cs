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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var dbConnectionStatus = false;
            var server = "78.189.60.108";
            var database = "ef";
            var uid = "remoteuser";
            var password = "abcdefG1-1";
            string connectionString = "SERVER=" + server + "; PORT = 8001 ;" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";SslMode=none";
            var mycon = new MySqlConnection(connectionString);

           // "SERVER=78.189.60.108; PORT = 8001 ;DATABASE=ef; UID=remoteuser; PASSWORD=abcdefG1-1;SslMode=none";

            try
            {
                mycon.Open();
                dbConnectionStatus = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Database Connection Failed!");
                mycon.Close();

            }

            if (dbConnectionStatus)
            {

                // lblUserName.Text = "Connected" + mycon.Database;

                var UserNameInput = txtbUserName.Text;
                var UserPasswordInput = txtbPassword.Text;
                MySqlCommand cmd = mycon.CreateCommand();
                cmd.CommandText = "SELECT * from users WHERE UCODE ='" + UserNameInput + "' AND UPASS='" + UserPasswordInput + "'";
                MessageBox.Show(cmd.CommandText);

                MySqlDataReader reader = cmd.ExecuteReader();
                // reader.Read();

                if (reader.Read())
                {
                    //   MessageBox.Show(reader.GetString(0) + reader.GetString(1) + reader.GetString(2) + reader.GetString(3) + reader.GetString(4) + reader.GetString(5));
                    Globals.userFullName = reader["UNAME"].ToString();
                    Globals.userName = reader["UCODE"].ToString();
                    Globals.userPass = reader["UPASS"].ToString();
                    Globals.userType = reader["TYPE"].ToString();
                    Globals.userRegion = Convert.ToInt32(reader["UREGION"]);
                    Globals.userId = Convert.ToInt32(reader["UID"]);

                    MainMenu frm2 = new MainMenu();
                    this.Hide();           //Hide the main form before showing the secondary
                    frm2.ShowDialog();     //Show secondary form, code execution stop until frm2 is closed
                    this.Show();
                }
                else
                {
                    MessageBox.Show("USERNAME or PASSWORD is invalid!");
                    mycon.Close();
                }
            }


        }
    }
    public static class Globals
    {
        public static string userFullName = "";
        public static string userName = "";
        public static string userPass = "";
        public static string userType = "";
        public static int userId = 0;
        public static int userRegion = 0;
    }
}


