using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace sr
{
    public partial class bus : Form
    {
     //    OleDbConnection con;
        //    OleDbCommand cmd;
        public bus()
        {
            InitializeComponent();
            pop();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
        private void pop()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from bus_add", con);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
            con.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtbno.Text == "" || txtsr.Text == "" || txtd.Text == "" || comboBox1.SelectedIndex == -1 || txtarrival.Text == ""||txtp.Text=="")
            {
                MessageBox.Show("Missing information", "not insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                string query = "insert into bus_add(b_no, b_sou, b_des, b_ty, b_time, b_price)values('" + txtbno.Text + "','" + txtsr.Text + "','" + txtd.Text + "','" + comboBox1.Text + "','" + txtarrival.Text +"','"+txtp.Text+"')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bus added successfully");
                con.Close();
                pop();
                reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void reset()
        {
            txtbno.Text = "";
            txtsr.Text = "";
            txtd.Text = "";
            comboBox1.Text = "";
            txtarrival.Text = "";
            txtp.Text = "";
            key = 0;
        }

        private void bus_Load(object sender, EventArgs e)
        {
        }
        int key;
        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbno.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsr.Text = bunifuDataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtd.Text = bunifuDataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = bunifuDataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtarrival.Text = bunifuDataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtp.Text = bunifuDataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            if (txtbno.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("select the bus is deleted", "bus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "Delete from bus_add where ID=" + key + "";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("bus removed successfully", "bus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    pop();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtbno.Text == "" || txtsr.Text == "" || txtd.Text == "" || comboBox1.SelectedIndex == -1 || txtarrival.Text == ""||txtp.Text=="")
            {
                MessageBox.Show("Missing information", "msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                string query = "update bus_add set b_no='" + txtbno.Text + "',b_sou='" + txtsr.Text + "',b_des='" + txtd.Text + "',b_ty='" + comboBox1.Text + "',b_time='" + txtarrival.Text + "',b_price='" + txtp.Text + "'where ID=" + key + "";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bus update successfully", "bus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                pop();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
