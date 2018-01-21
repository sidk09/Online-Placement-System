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
    public partial class Form6 : Form
    {
        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=e_placements";
        public Form6()
        {
            InitializeComponent();

   

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            String em = Form2.SetValueForText1;
            string Query = "select sname,s_id,email_id,mobile_no,qualification,pref_1,pref_2,m,duration from student natural join skills natural join s_available where Email_id =" + "'" + em + "'" + ";";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;


            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();


            while (MyReader2.Read())
            {
                string s1, s2, s3, s4, s5, s6;
                string i1, i2;
                string  snamer = MyReader2.GetString(0);
                s1 = MyReader2.GetString(1);
                s2 = MyReader2.GetString(2);
                s3 = MyReader2.GetString(4);
                s4 = MyReader2.GetString(5);
                s5 = MyReader2.GetString(6);
                s6 = MyReader2.GetString(7);
                i1 = MyReader2.GetString(3);
                i2 = MyReader2.GetString(8);
                

                label2.Text = snamer;
                label5.Text = s1;
                label6.Text = s2;
                label8.Text = s3;
                label9.Text = s4;
                label10.Text = s5;
                label19.Text = s6;
                label7.Text = i1;
                label20.Text = i2;
                Refresh();
            }
            

            MyConn2.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String em = Form2.SetValueForText1;
            string Query = "(SELECT distinct Cname, skills.pref_1,email_id ,contact_no FROM company ,criteria ,skills WHERE skills.pref_1=criteria.pref_1 and company.c_id=criteria.c_id and skills.s_id=(select DISTINCT s_id from student where email_id='"+em+ "')) UNION (SELECT distinct Cname, skills.pref_2,email_id ,contact_no FROM company ,criteria ,skills WHERE skills.pref_2=criteria.pref_2 and company.c_id=criteria.c_id and skills.s_id=(select DISTINCT s_id from student where email_id='" + em + "')) UNION (SELECT distinct Cname, skills.pref_1,email_id ,contact_no FROM company ,criteria ,skills WHERE skills.pref_1=criteria.pref_2 and company.c_id=criteria.c_id and skills.s_id=(select DISTINCT s_id from student where email_id='" + em + "')) UNION (SELECT distinct Cname, skills.pref_2,email_id ,contact_no FROM company ,criteria ,skills WHERE skills.pref_2=criteria.pref_1 and company.c_id=criteria.c_id and skills.s_id=(select DISTINCT s_id from student where email_id='" + em + "'))";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;


            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();


            if(MyReader2.Read())

            {
                string s1, s2, s3, s4;
                s1 = MyReader2.GetString(0);
                s2 = MyReader2.GetString(1);
                s3 = MyReader2.GetString(2);
                s4 = MyReader2.GetString(3);



                label25.Text = s1;
                label28.Text = s2;
                label31.Text = s3;
                label34.Text = s4;
                Refresh();
            }
            else
            {
                MessageBox.Show("NO RESULT FOUND!!");
            }

            if ( MyReader2.Read())

            {
                string s1, s2, s3, s4;
                s1 = MyReader2.GetString(0);
                s2 = MyReader2.GetString(1);
                s3 = MyReader2.GetString(2);
                s4 = MyReader2.GetString(3);



                label26.Text = s1;
                label29.Text = s2;
                label32.Text = s3;
                label35.Text = s4;
                Refresh();
            }


            if(MyReader2.Read())

            {
                string s1, s2, s3, s4;
                s1 = MyReader2.GetString(0);
                s2 = MyReader2.GetString(1);
                s3 = MyReader2.GetString(2);
                s4 = MyReader2.GetString(3);



                label27.Text = s1;
                label30.Text = s2;
                label33.Text = s3;
                label36.Text = s4;
                Refresh();
            }


            MyConn2.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
