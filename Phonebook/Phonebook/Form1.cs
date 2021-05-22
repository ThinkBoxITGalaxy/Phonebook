using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


            if (tabControl1.SelectedIndex == 0)
            {
                label6.ForeColor = Color.LightSkyBlue;
            }
            else if (tabControl1.SelectedIndex != 0)
            {
                label6.ForeColor = Color.Black;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "#";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            textBox1.Text = temp.Substring(0, textBox1.TextLength - 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            if (textBox1.TextLength == 0)
            {
                label1.Visible = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            textBox2.Text = "First name";
            textBox2.ForeColor = Color.Gray;

            textBox3.Text = "Last name";
            textBox3.ForeColor = Color.Gray;

            textBox4.Text = "Company";
            textBox4.ForeColor = Color.Gray;

            textBox5.Text = textBox1.Text;
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text.Contains("First name"))
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text.Contains("First name"))
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox3.Text.Contains("Last name"))
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox3.Text.Contains("Last name"))
            {
                textBox3.Clear();
                textBox3.ForeColor = Color.Black;
            }
        }
        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox4.Text.Contains("Company"))
            {
                textBox4.Clear();
                textBox4.ForeColor = Color.Black;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox4.Text.Contains("Company"))
            {
                textBox4.Clear();
                textBox4.ForeColor = Color.Black;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var con = Connz.sqlConnz;
            string sql = "insert into phone_numbers(firstname,lastname,company,pnumber) values ('{0}', '{1}', '{2}','{3}')";
            string format = String.Format(sql, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            SqlCommand cmd = new SqlCommand(format, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Added");
            tabControl1.SelectedIndex = 0;
            con.Close();
            refresh();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.LightSkyBlue;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }
        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.LightSkyBlue;
        }
        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                label8.ForeColor = Color.LightSkyBlue;
            }
            else if (tabControl1.SelectedIndex != 2)
            {
                label8.ForeColor = Color.Black;
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            // TODO: This line of code loads data into the 'phonebookdbDataSet.phone_numbers' table. You can move, or remove it, as needed.
            this.phone_numbersTableAdapter.Fill(this.phonebookdbDataSet.phone_numbers);
            // TODO: This line of code loads data into the 'phonebookdbDataSet.phone_numbers' table. You can move, or remove it, as needed.
        }


        private void label5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox6.Text = row.Cells[3].Value.ToString();
                label10.Text = row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString();
                label14.Text = row.Cells[2].Value.ToString();
            }

            textBox7.Text = "First name";
            textBox8.Text = "Last name";
            textBox9.Text = "Company";
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox7.Text.Contains("First name"))
            {
                textBox7.Clear();
                textBox7.ForeColor = Color.Black;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox7.Text.Contains("First name"))
            {
                textBox7.Clear();
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox8.Text.Contains("Last name"))
            {
                textBox8.Clear();
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox8.Text.Contains("Last name"))
            {
                textBox8.Clear();
                textBox8.ForeColor = Color.Black;
            }
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox9.Text.Contains("Company"))
            {
                textBox9.Clear();
                textBox9.ForeColor = Color.Black;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox9.Text.Contains("Company"))
            {
                textBox9.Clear();
                textBox9.ForeColor = Color.Black;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            var con = Connz.sqlConnz;
            string sql = "update phone_numbers set firstname = '" + textBox7.Text + "', lastname = '" + textBox8.Text + "', company = '" + textBox9.Text + "' where pnumber = '" + textBox6.Text + "'";
            SqlCommand cmd_up = new SqlCommand(sql, con);

            con.Open();
            cmd_up.ExecuteNonQuery();
            con.Close();
            tabControl1.SelectedIndex = 2;
            refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var con = Connz.sqlConnz;
            string sql_del = "delete from phone_numbers where pnumber = '" + textBox6.Text + "'";
            SqlCommand cmd_del = new SqlCommand(sql_del, con);
            con.Open();
            cmd_del.ExecuteNonQuery();
            con.Close();
            tabControl1.SelectedIndex = 2;
            refresh();

        }
        private void refresh()
        {
            var con = Connz.sqlConnz;
            SqlCommand commando = new SqlCommand("SELECT * FROM phone_numbers", con);
            con.Open();
            SqlDataReader read = commando.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(read);
            con.Close();
            dataGridView1.DataSource = tbl;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 122 && e.KeyChar >= 97)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            var con = Connz.sqlConnz;
            SqlCommand commando = new SqlCommand("SELECT * FROM phone_numbers where firstname = '" + textBox10.Text + "'", con);
            con.Open();
            SqlDataReader read = commando.ExecuteReader();
            DataTable tbl = new DataTable();
            tbl.Load(read);
            dataGridView1.DataSource = tbl;
            con.Close();
            if (textBox10.Text.Length == 0)
            {
                refresh();
            }
        }       
    }
}

