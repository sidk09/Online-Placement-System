using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Online_Placement_System
{
    public partial class Form3 : Form
    {
        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=e_placements";
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s_id = int.Parse(textBox5.Text);
            int mob = int.Parse(textBox4.Text);
            //int dur = int.Parse(comboBox5.SelectedText);


            string Query = "insert into student values("+s_id+","+"'"+textBox1.Text+"','"+ textBox3.Text + "'," + mob + ") ; insert into slogin values('"+textBox1.Text+"','"+textBox2.Text+ "'); insert into id values(" + s_id + ",'');insert into skills values(" + s_id+",'"+comboBox1.Text+"','"+comboBox2.Text+"','"+comboBox3.Text+"'); insert into s_available values("+s_id+",'"+comboBox4.Text+"','"+comboBox5.Text+"'); " ;

            //This is  MySqlConnection here i have created the object and pass my connection string. 

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;

            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database. 

            

            MyConn2.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
