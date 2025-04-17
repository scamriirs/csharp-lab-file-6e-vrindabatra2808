using System.Data;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MI-11PRO-MAX\\SQLEXPRESS;Initial Catalog=Student_Management_System;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into sms values " + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "'", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not saved" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = MI - 11PRO - MAX\\SQLEXPRESS; Initial Catalog = Student_Management_System; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from sms where Roll_Number = " + textBox1.Text + "", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not deleted" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = MI - 11PRO - MAX\\SQLEXPRESS; Initial Catalog = Student_Management_System; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update sms set student_name='" + textBox2.Text + "', age = " + textBox3.Text + ", course ='" + textBox4.Text + "'where roll_Number = " + textBox1.Text + " ", con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not updated"+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = MI - 11PRO - MAX\\SQLEXPRESS; Initial Catalog = Student_Management_System;Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select & from sms where Roll_Number=" + textBox1.Text + "", con);
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                    textBox4.Text = dr[3].ToString();
                    MessageBox.Show("Record displayed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record doesn't exist" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
