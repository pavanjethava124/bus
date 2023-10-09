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
//using System.Text.RegularExpressions;

namespace sr
{
    public partial class book : Form
    {

        static int[] bookedseat;
        static int[] tempbookseat;
        private string gender = "";
        public book()
        {
            InitializeComponent();
            bookedseat = new int[29];
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
          //  tempbookseat[29] = 0;
            alreadybooked();

        }
        private void alreadybooked()
        {
           
            string mycon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb";
            ;
            string myquery = "select * from bus_status";
            OleDbConnection con = new OleDbConnection(mycon);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            int rows = ds.Tables[0].Rows.Count;
            int i = 0;
            while (i < rows)
            {
                String status;
                status = ds.Tables[0].Rows[i]["status"].ToString();
                if (status == "B")
                {
                    bookedseat[i] = 1;
                    if (i == 0)
                    {
                        button1.BackColor = Color.Red;
                        button1.Enabled = false;
                    }
                    if (i == 1)
                    {
                        button2.BackColor = Color.Red;
                        button2.Enabled = false;
                    }
                    if (i == 2)
                    {
                        button3.BackColor = Color.Red;
                        button3.Enabled = false;
                    }
                    if (i == 3)
                    {
                        button4.BackColor = Color.Red;
                        button4.Enabled = false;
                    }
                    if (i == 4)
                    {
                        button5.BackColor = Color.Red;
                        button5.Enabled = false;
                    }
                    if (i == 5)
                    {
                        button6.BackColor = Color.Red;
                        button6.Enabled = false;
                    }
                    if (i == 6)
                    {
                        button7.BackColor = Color.Red;
                        button7.Enabled = false;
                    }
                    if (i == 7)
                    {
                        button8.BackColor = Color.Red;
                        button8.Enabled = false;
                    }
                    if (i == 8)
                    {
                        button9.BackColor = Color.Red;
                        button9.Enabled = false;
                    }
                    if (i == 9)
                    {
                        button10.BackColor = Color.Red;
                        button10.Enabled = false;
                    }
                    if (i == 10)
                    {
                        button11.BackColor = Color.Red;
                        button11.Enabled = false;
                    }
                    if (i == 11)
                    {
                        button12.BackColor = Color.Red;
                        button12.Enabled = false;
                    }
                    if (i == 12)
                    {
                        button13.BackColor = Color.Red;
                        button13.Enabled = false;
                    }
                    if (i == 13)
                    {
                        button14.BackColor = Color.Red;
                        button14.Enabled = false;
                    }
                    if (i == 14)
                    {
                        button15.BackColor = Color.Red;
                        button15.Enabled = false;
                    }
                    if (i == 15)
                    {
                        button16.BackColor = Color.Red;
                        button16.Enabled = false;
                    }
                    if (i == 16)
                    {
                        button17.BackColor = Color.Red;
                        button17.Enabled = false;
                    }
                    if (i == 17)
                    {
                        button18.BackColor = Color.Red;
                        button18.Enabled = false;
                    }
                    if (i == 18)
                    {
                        button19.BackColor = Color.Red;
                        button19.Enabled = false;
                    }
                    if (i == 19)
                    {
                        button20.BackColor = Color.Red;
                        button20.Enabled = false;
                    }
                    if (i == 20)
                    {
                        button21.BackColor = Color.Red;
                        button21.Enabled = false;
                    }
                    if (i == 21)
                    {
                        button22.BackColor = Color.Red;
                        button22.Enabled = false;
                    }
                    if (i == 22)
                    {
                        button23.BackColor = Color.Red;
                        button23.Enabled = false;
                    }
                    if (i == 23)
                    {
                        button24.BackColor = Color.Red;
                        button24.Enabled = false;
                    }
                    if (i == 24)
                    {
                        button25.BackColor = Color.Red;
                        button25.Enabled = false;
                    }
                    if (i == 25)
                    {
                        button26.BackColor = Color.Red;
                        button26.Enabled = false;
                    }
                    if (i == 26)
                    {
                        button27.BackColor = Color.Red;
                        button27.Enabled = false;
                    }
                    if (i == 27)
                    {
                        button28.BackColor = Color.Red;
                        button28.Enabled = false;
                    }

                }
                if (status == "A")
                {
                    bookedseat[i] = 0;
                    if (i == 0)
                    {
                        button1.BackColor = Color.Gray;
                    }
                    if (i == 1)
                    {
                        button2.BackColor = Color.Gray;
                    }
                    if (i == 2)
                    {
                        button3.BackColor = Color.Gray;
                    }
                    if (i == 3)
                    {
                        button4.BackColor = Color.Gray;
                    }
                    if (i == 4)
                    {
                        button5.BackColor = Color.Gray;
                    }
                    if (i == 5)
                    {
                        button6.BackColor = Color.Gray;
                    }
                    if (i == 6)
                    {
                        button7.BackColor = Color.Gray;
                    }
                    if (i == 7)
                    {
                        button8.BackColor = Color.Gray;
                    }
                    if (i == 8)
                    {
                        button9.BackColor = Color.Gray;
                    }
                    if (i == 9)
                    {
                        button10.BackColor = Color.Gray;
                    }
                    if (i == 10)
                    {
                        button11.BackColor = Color.Gray;
                    }
                    if (i == 11)
                    {
                        button12.BackColor = Color.Gray;
                    }
                    if (i == 12)
                    {
                        button13.BackColor = Color.Gray;
                    }
                    if (i == 13)
                    {
                        button14.BackColor = Color.Gray;
                    }
                    if (i == 14)
                    {
                        button15.BackColor = Color.Gray;
                    }
                    if (i == 15)
                    {
                        button16.BackColor = Color.Gray;
                    }
                    if (i == 16)
                    {
                        button17.BackColor = Color.Gray;
                    }
                    if (i == 17)
                    {
                        button18.BackColor = Color.Gray;
                    }
                    if (i == 18)
                    {
                        button19.BackColor = Color.Gray;
                    }
                    if (i == 19)
                    {
                        button20.BackColor = Color.Gray;
                    }
                    if (i == 20)
                    {
                        button21.BackColor = Color.Gray;
                    }
                    if (i == 21)
                    {
                        button22.BackColor = Color.Gray;
                    }
                    if (i == 22)
                    {
                        button23.BackColor = Color.Gray;
                    }
                    if (i == 23)
                    {
                        button24.BackColor = Color.Gray;
                    }
                    if (i == 24)
                    {
                        button25.BackColor = Color.Gray;
                    }
                    if (i == 25)
                    {
                        button26.BackColor = Color.Gray;
                    }
                    if (i == 26)
                    {
                        button27.BackColor = Color.Gray;
                    }
                    if (i == 27)
                    {
                        button28.BackColor = Color.Gray;


                    }
                }
                i++;
            }
        }
            
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 29; i++)
            {
                if (tempbookseat[i] == 1)
                {
                    string mycon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\mydb.accdb";
                    String updatedata = "Update bus_status set status='B' where seatno=" + (i + 1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tempbookseat[0] == 0)
            {
                button1.BackColor = Color.Green;
                tempbookseat[0] = 1;

            }
            else
            {
                button1.BackColor = Color.Gray;
                tempbookseat[0] = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tempbookseat[1] == 0)
            {
                button2.BackColor = Color.Green;
                tempbookseat[1] = 1;

            }
            else
            {
                button2.BackColor = Color.Gray;
                tempbookseat[1] = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tempbookseat[2] == 0)
            {
                button3.BackColor = Color.Green;
                tempbookseat[2] = 1;

            }
            else
            {
                button3.BackColor = Color.Gray;
                tempbookseat[2] = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tempbookseat[3] == 0)
            {
                button4.BackColor = Color.Green;
                tempbookseat[3] = 1;

            }
            else
            {
                button4.BackColor = Color.Gray;
                tempbookseat[3] = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tempbookseat[4] == 0)
            {
                button5.BackColor = Color.Green;
                tempbookseat[4] = 1;

            }
            else
            {
                button5.BackColor = Color.Gray;
                tempbookseat[4] = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tempbookseat[5] == 0)
            {
                button6.BackColor = Color.Green;
                tempbookseat[5] = 1;

            }
            else
            {
                button6.BackColor = Color.Gray;
                tempbookseat[5] = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tempbookseat[6] == 0)
            {
                button7.BackColor = Color.Green;
                tempbookseat[6] = 1;

            }
            else
            {
                button7.BackColor = Color.Gray;
                tempbookseat[6] = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tempbookseat[7] == 0)
            {
                button8.BackColor = Color.Green;
                tempbookseat[7] = 1;

            }
            else
            {
                button8.BackColor = Color.Gray;
                tempbookseat[7] = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tempbookseat[8] == 0)
            {
                button9.BackColor = Color.Green;
                tempbookseat[8] = 1;

            }
            else
            {
                button9.BackColor = Color.Gray;
                tempbookseat[8] = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tempbookseat[9] == 0)
            {
                button10.BackColor = Color.Green;
                tempbookseat[9] = 1;

            }
            else
            {
                button10.BackColor = Color.Gray;
                tempbookseat[9] = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tempbookseat[10] == 0)
            {
                button11.BackColor = Color.Green;
                tempbookseat[10] = 1;

            }
            else
            {
                button11.BackColor = Color.Gray;
                tempbookseat[10] = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tempbookseat[11] == 0)
            {
                button12.BackColor = Color.Green;
                tempbookseat[11] = 1;

            }
            else
            {
                button12.BackColor = Color.Gray;
                tempbookseat[11] = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tempbookseat[12] == 0)
            {
                button13.BackColor = Color.Green;
                tempbookseat[12] = 1;

            }
            else
            {
                button13.BackColor = Color.Gray;
                tempbookseat[12] = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (tempbookseat[13] == 0)
            {
                button14.BackColor = Color.Green;
                tempbookseat[13] = 1;

            }
            else
            {
                button14.BackColor = Color.Gray;
                tempbookseat[13] = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (tempbookseat[14] == 0)
            {
                button15.BackColor = Color.Green;
                tempbookseat[14] = 1;

            }
            else
            {
                button15.BackColor = Color.Gray;
                tempbookseat[14] = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (tempbookseat[15] == 0)
            {
                button16.BackColor = Color.Green;
                tempbookseat[15] = 1;

            }
            else
            {
                button16.BackColor = Color.Gray;
                tempbookseat[15] = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tempbookseat[16] == 0)
            {
                button17.BackColor = Color.Green;
                tempbookseat[16] = 1;

            }
            else
            {
                button17.BackColor = Color.Gray;
                tempbookseat[16] = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (tempbookseat[17] == 0)
            {
                button18.BackColor = Color.Green;
                tempbookseat[17] = 1;

            }
            else
            {
                button18.BackColor = Color.Gray;
                tempbookseat[17] = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (tempbookseat[18] == 0)
            {
                button19.BackColor = Color.Green;
                tempbookseat[18] = 1;

            }
            else
            {
                button19.BackColor = Color.Gray;
                tempbookseat[18] = 0;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (tempbookseat[19] == 0)
            {
                button20.BackColor = Color.Green;
                tempbookseat[19] = 1;

            }
            else
            {
                button20.BackColor = Color.Gray;
                tempbookseat[19] = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (tempbookseat[20] == 0)
            {
                button21.BackColor = Color.Green;
                tempbookseat[20] = 1;

            }
            else
            {
                button21.BackColor = Color.Gray;
                tempbookseat[20] = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (tempbookseat[21] == 0)
            {
                button22.BackColor = Color.Green;
                tempbookseat[21] = 1;

            }
            else
            {
                button22.BackColor = Color.Gray;
                tempbookseat[21] = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (tempbookseat[22] == 0)
            {
                button23.BackColor = Color.Green;
                tempbookseat[22] = 1;

            }
            else
            {
                button23.BackColor = Color.Gray;
                tempbookseat[22] = 0;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (tempbookseat[23] == 0)
            {
                button24.BackColor = Color.Green;
                tempbookseat[23] = 1;

            }
            else
            {
                button24.BackColor = Color.Gray;
                tempbookseat[23] = 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (tempbookseat[24] == 0)
            {
                button25.BackColor = Color.Green;
                tempbookseat[24] = 1;
                
            }
            else
            {
                button25.BackColor = Color.Gray;
                tempbookseat[24] = 0;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (tempbookseat[25] == 0)
            {
                button26.BackColor = Color.Green;
                tempbookseat[25] = 1;

            }
            else
            {
                button26.BackColor = Color.Gray;
                tempbookseat[25] = 0;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (tempbookseat[26] == 0)
            {
                button27.BackColor = Color.Green;
                tempbookseat[26] = 1;

            }
            else
            {
                button27.BackColor = Color.Gray;
                tempbookseat[26] = 0;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (tempbookseat[27] == 0)
            {
                button28.BackColor = Color.Green;
                tempbookseat[27] = 1;

            }
            else
            {
                button28.BackColor = Color.Gray;
                tempbookseat[27] = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtseat_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
            this.Hide();
        }

        private void bunifuButton202_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers");
            }
          
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button29_Click(object sender, EventArgs e)
        {
            //Regex EmailExpression = new Regex(@"^([a-zA-Z0-9_\-])(a-zA-Z0-9-\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9]|[1-9][0-9]|[0-9])\.)
//{3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|[1-9][0-9]|[0-9])\])$");

  //          if (textBox2.Text.Trim() != string.Empty)
    //        {
      //          if (!EmailExpression.IsMatch(textBox2.Text.Trim()))
        //        {
          //          MessageBox.Show("E-mail id is not correxxt format");
            //        textBox2.Focus();
              //  }
 //           }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Application.StartupPath+"\\mydb.accdb");

            string res;
            if (rbtmale.Checked == true)
                res = rbtmale.Text;
            else
                res = rbtfemale.Text;
            if (txtseat.Text==""||txtbno.Text==""||txtsr.Text==""||txtdes.Text==""||txtbt.Text==""||txtarrivaltime.Text==""||txtprice.Text==""||bunifuDatePicker1.Text==""||txtnm.Text == "" || txtem.Text == "" || txtage.Text == "" || txtmob.Text=="")
            {
                MessageBox.Show("Missing information", "not insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                con.Open();
                string query = "insert into passenger(s_no,b_no, b_sr, b_des, b_ty,b_ar,b_price,b_trav,p_nm,p_em,p_ag,p_mob,p_gen)values('"+Convert.ToInt64(txtseat.Text)+ "','" + txtbno.Text + "','" + txtsr.Text + "','" + txtdes.Text + "','" + txtbt.Text + "','" + txtarrivaltime.Text + "','"+ Convert.ToInt64(txtprice.Text)+ "','" + this.bunifuDatePicker1.Text + "','" + txtnm.Text+"','"+txtem.Text+"','"+ Convert.ToInt64(txtage.Text)+"','"+Convert.ToInt64(txtmob.Text)+ "','"+res+"')";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Booking successfully...","book",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
               
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            if (txtseat.Text == "" || txtbno.Text == "" || txtsr.Text == "" || txtdes.Text == "" || txtbt.Text == "" || txtarrivaltime.Text == "" || txtprice.Text == "" || bunifuDatePicker1.Text == "" || txtnm.Text == "" || txtem.Text == "" || txtage.Text == "" || txtmob.Text == "")
            {
                MessageBox.Show("Missing information", "not insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                recipt rs = new recipt();

                if (rbtmale.Checked)
                    gender = "male";
                if (rbtfemale.Checked)
                    gender = "female";
                rs.tdate = bunifuDatePicker1.Text;
                rs.sno = txtseat.Text;
                rs.bno = txtbno.Text;
                rs.sou = txtsr.Text;
                rs.des = txtdes.Text;
                rs.bustype = txtbt.Text;
                rs.arrival = txtarrivaltime.Text;
                rs.nm = txtnm.Text;
                rs.em = txtem.Text;
                rs.ag = txtage.Text;
                rs.gen = gender;
                rs.mno = txtmob.Text;
                rs.price = txtprice.Text;
                rs.ShowDialog();

//                this.Hide();
            }
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {
           
        }

        private void book_Load(object sender, EventArgs e)
        {
           
        }
    }
}
