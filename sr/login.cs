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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\mydb.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from login where uname='"+textBox1.Text+"' and pass='"+textBox2.Text+"'",con);
            OleDbDataReader dr = cmd.ExecuteReader();

            int count = 0;
            while (dr.Read())
            {
                count = count = 1;
            }
            if(count==1)
            {
                MessageBox.Show("Login successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                admin a = new admin();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username and password", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if(bunifuCheckBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Hide();
        }
    }
    }
