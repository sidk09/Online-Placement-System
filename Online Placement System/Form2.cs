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
    public partial class Form2 : Form
    {
        public static string SetValueForText1 = "";

        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=e_placements";



        public Form2()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            SetValueForText1 = id;

        string pass = textBox2.Text;

            string Query = "select password from slogin where Email =" +"'"+ id +"'" + ";";

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
                         Form6 f = new Form6();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password!!");
                }
            }

            MyConn2.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
