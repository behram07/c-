using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        new SqlConnection("Data source = ABRA; Inital Catalog = Behramerol; Integrated Security = true");

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;


        void griddoldur()
        {          
            da = new SqlDataAdapter("Select *form Behramerol", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds,"Behramerol");
            DataGridView1.DataSource = ds.Tables[Behramerol];
            con.Close;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Behramerol(ad,soyad,tc,bolum,tarih,tel) values (" + textBox1.Text + ",'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', '" + textBox5.Text + "','" + textBox6.Text + "' )";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Behramerol where ogrenci_tc=" + textBox3.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Behramerol set ad='" + textBox1.Text + "',soyad='" + textBox2.Text + "',bolum='" + textBox4.Text + "',tarih='" + textBox5.Text + "',tel='" + textBox6.Text + "' where tc=" + textBox3.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}








