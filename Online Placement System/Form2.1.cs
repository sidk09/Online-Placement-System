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

namespace Online_Placement_System
{
    public partial class Form2_1 : Form
    {
        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=e_placements";
        public static string SetValueForText1 = "";
        public Form2_1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string pass = textBox2.Text;
            SetValueForText1 = id;

            string Query = "select password from clogin where Email =" + "'" + id + "'" + ";";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;


            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();


            while (MyReader2.Read())
            {
                if (MyReader2.GetString(0).Equals(pass))
                {
                    Form7 f = new Form7();
                    f.Show();
             
                }
                else
                {
                    MessageBox.Show("Wrong Password!!");
                }
            }
            MyConn2.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void Form2_1_Load(object sender, EventArgs e)
        {

        }
    }
}
