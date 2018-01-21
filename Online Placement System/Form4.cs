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
    public partial class Form4 : Form
    {
        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=e_placements";
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c_id = int.Parse(textBox5.Text);
            int cont = int.Parse(textBox4.Text);
            //int dur = int.Parse(comboBox5.SelectedText);


            string Query = "insert into company values(" + c_id + "," + "'" + textBox1.Text + "','" + textBox3.Text + "'," + cont + ") ; insert into clogin values('" + textBox1.Text + "','" + textBox2.Text + "'); insert into id values(" + c_id + ",'');insert into criteria values(" + c_id + ",'" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox1.Text +"',"+comboBox4.Text +"); ";

            //This is  MySqlConnection here i have created the object and pass my connection string. 

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;

            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database. 



            MyConn2.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2_1 f = new Form2_1();
            f.Show();
        }
    }
}
