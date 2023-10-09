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
    public partial class cancel : Form
    {
        static int[] bookedseat;
        static int[] tempbookseat;

        public cancel()
        {
            InitializeComponent(); bookedseat = new int[29];
            tempbookseat = new int[29];
            tempbookseat[0] = 0;
            tempbookseat[1] = 0;
            tempbookseat[2] = 0;
            tempbookseat[3] = 0;
            tempbookseat[4] = 0;
            tempbookseat[5] = 0;
            tempbookseat[6] = 0;
            tempbookseat[7] = 0;
            tempbookseat[8] = 0;
            tempbookseat[9] = 0;
            tempbookseat[10] = 0;
            tempbookseat[11] = 0;
            tempbookseat[12] = 0;
            tempbookseat[13] = 0;
            tempbookseat[14] = 0;
            tempbookseat[15] = 0;
            tempbookseat[16] = 0;
            tempbookseat[17] = 0;
            tempbookseat[18] = 0;
            tempbookseat[19] = 0;
            tempbookseat[20] = 0;
            tempbookseat[21] = 0;
            tempbookseat[22] = 0;
            tempbookseat[23] = 0;
            tempbookseat[24] = 0;
            tempbookseat[25] = 0;
            tempbookseat[26] = 0;
            tempbookseat[27] = 0;
            tempbookseat[28] = 0;
            remove();
            temp();
        }
         
       
        private void remove()
        {
        }
        private void temp()
        {
            int i = 0;
            for (i = 0; i < 29; i++)
            {
                if (tempbookseat[i] == 1)
                {
                    string mycon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\mydb.accdb";
                    String updatedata = "Update bus_status set status='A' where seatno=" + (i + 1);
                    OleDbConnection con = new OleDbConnection(mycon);
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = updatedata;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
        }


private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
                con.Open();
                int studno = Convert.ToInt16(bunifuDataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                DialogResult res;
                res = MessageBox.Show("Are you sure want to delete record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand("delete from passenger where s_no=" + studno + "", con);
                    int ans = cmd.ExecuteNonQuery();
                    remove();
                    temp();
                    con.Close();
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from passenger where p_nm='"+textBox1.Text+"' and p_em='"+textBox2.Text+"' ", con);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            con.Close();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Hide();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
