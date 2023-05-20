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

namespace StudentCRUDApplication
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        private int tempID;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = VWVITHLPUB1701\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True;");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("Select * from tbl_student",connection);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void clearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            connection.Open();
            string sqlQuery = "Insert INTO tbl_student (Name,Class,Section,Percentage,Gender) VALUES (@p1,@p2,@p3,@p4,@p5)";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@p5", comboBox1.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            display();
            MessageBox.Show("Data Inserted Successfully");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow delRow = dataGridView1.Rows[i];

                if(delRow.Selected == true)
                {
                    string sqlQuery = "DELETE FROM tbl_student Where id='" + dataGridView1.Rows[i].Cells[0].Value + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                    sqlCommand.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
            connection.Close();
            MessageBox.Show("Data Deleted Successfully");
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dataGridView1.Rows.Count > 0)
            {
                tempID = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            connection.Open();
            string sqlQuery = "UPDATE tbl_student set Name=@p1,Class=@p2,Section=@p3,Percentage=@p4,Gender=@p5 where id='"+tempID+"'";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@p3", textBox3.Text);
            cmd.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@p5", comboBox1.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.Close();
            display();
            clearFields();
            MessageBox.Show("Data Updated Successfully");
        }
    }
}
