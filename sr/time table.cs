using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace sr
{
    public partial class time_table : Form
    {
        public time_table()
        {
            InitializeComponent();
        }
        void getdata()
        {

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from bus_add where b_no,b_sou,b_des,b_ty,b_time,b_price";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
                con.Close();
            }
        }
        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from bus_add where b_sou='" + txt1.Text + "' and b_des='" + txt2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
                MessageBox.Show(ex.Message, "access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }

        }

        private void btnswap_Click(object sender, EventArgs e)
        {
            String no1 = txt1.Text;
            string no2 = txt2.Text;

            txt1.Text = no2;
            txt2.Text = no1;

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            home h = new home();
            h.Show();
            this.Hide();
        }
    }
}
