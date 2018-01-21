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
    public partial class Form7 : Form
    {
        string MyConnection2 = "datasource=localhost;port=3306;username=root;password=;database=e_placements";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            String em = Form2_1.SetValueForText1;
            string Query = "select cname,c_id,email_id,contact_no,pref_1,pref_2,m,duration from company natural join criteria where Email_id =" + "'" + em + "'" + ";";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;


            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();


            while (MyReader2.Read())
            {
                string s1, s2, s3, s4, s5, s6,s7,s8;
                
                
                s1 = MyReader2.GetString(0);
                s2 = MyReader2.GetString(1);
                s3 = MyReader2.GetString(2);
                s4 = MyReader2.GetString(3);
                s5 = MyReader2.GetString(4);
                s6 = MyReader2.GetString(5);
                s7 = MyReader2.GetString(6);
                s8 = MyReader2.GetString(7);


                label2.Text = s1;
                label5.Text = s2;
                label6.Text = s3;
                label7.Text = s4;
                label9.Text = s5;
                label10.Text = s6;
                label19.Text = s7;
                label20.Text = s8;
                
                Refresh();
            }


            MyConn2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String em = Form2_1.SetValueForText1;
            string Query = "(SELECT Sname, skills.pref_1,email_id ,mobile_no FROM student,criteria ,skills WHERE skills.pref_1=criteria.pref_1 and student.s_id=skills.s_id and criteria.c_id=(select DISTINCT c_id from company where email_id='"+em+ "')) UNION (SELECT Sname, skills.pref_2,email_id ,mobile_no FROM student,criteria ,skills WHERE skills.pref_2=criteria.pref_1 and student.s_id=skills.s_id and criteria.c_id=(select DISTINCT c_id from company where email_id='" + em + "')) UNION (SELECT Sname, skills.pref_1,email_id ,mobile_no FROM student,criteria ,skills WHERE skills.pref_1=criteria.pref_2 and student.s_id=skills.s_id and criteria.c_id=(select DISTINCT c_id from company where email_id='" + em + "')) UNION (SELECT Sname, skills.pref_2,email_id ,mobile_no FROM student,criteria ,skills WHERE skills.pref_2=criteria.pref_2 and student.s_id=skills.s_id and criteria.c_id=(select DISTINCT c_id from company where email_id='" + em + "'))";

            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

            //This is command class which will handle the query and connection object. 

            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

            MySqlDataReader MyReader2;


            MyConn2.Open();

            MyReader2 = MyCommand2.ExecuteReader();


           if( MyReader2.Read())

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

            if (MyReader2.Read())

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


            if (MyReader2.Read())

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
    }
}
