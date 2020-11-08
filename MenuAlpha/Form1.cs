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
using System.Configuration;
using System.Diagnostics.Contracts;
using MenuAlpha.DataSet1TableAdapters;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace MenuAlpha
{
    public partial class Form1 : Form
    {
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            this.MouseDown += Form1_MouseDown1;
            InitializeComponent();
            string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[Typ]";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox1.ValueMember = "TypID";
            comboBox1.DisplayMember = "Typ";
            comboBox1.DataSource = dt;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox5.Visible = false;
            comboBox4.Visible = false;
            textBox1.Visible = false;
            btnzapisz.Visible = false;
            tytul.Text = "Wybierz robota";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();

                string sqlquery = "select * from [dbo].[Marka] where TypID=@TypID";
                SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);              
                sqlcom.Parameters.AddWithValue("@TypID", comboBox1.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboBox2.ValueMember = "MarkaID";
                comboBox2.DisplayMember = "Marka";
                comboBox2.DataSource = dt;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;

            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          if (comboBox2.SelectedValue.ToString() != null)
          {

                string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();

                string sqlquery = "select * from [dbo].[Model] where MarkaID=@MarkaID AND TypID=@TypID";
                SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
                sqlcom.Parameters.AddWithValue("@MarkaID", comboBox2.SelectedValue.ToString());
                sqlcom.Parameters.AddWithValue("@TypID", comboBox1.SelectedValue.ToString());

                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboBox3.ValueMember = "ModelID";
                comboBox3.DisplayMember = "model";
                comboBox3.DataSource = dt;
                comboBox3.Enabled = true;
                
           }
        }

        private void btnzapisz_Click_1(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue != null && comboBox5.SelectedValue != null && !String.IsNullOrEmpty(textBox1.Text))
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                sqlconn.Open();

                string query = "INSERT INTO Model(model, TypID, MarkaID) VALUES('" + textBox1.Text + "', '" + comboBox4.SelectedValue.ToString() + "', '" + comboBox5.SelectedValue.ToString() + "')";
                SqlCommand sqlcom = new SqlCommand(query, sqlconn);
                sqlcom.ExecuteNonQuery();

                
                
                sqlconn.Close();
                MessageBox.Show("Zapisano");

                string qry = "SELECT TypID, MarkaID FROM Marka WHERE TypID = '" + comboBox4.SelectedValue.ToString() + "' AND MarkaID = '" + comboBox5.SelectedValue.ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, sqlconn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    sqlconn.Open();
                    string query2 = "INSERT INTO Marka(marka, TypID, MarkaID) VALUES('" + comboBox5.Text + "', '" + comboBox4.SelectedValue.ToString() + "', '" + comboBox5.SelectedValue.ToString() + "')";
                    SqlCommand sqlcom2 = new SqlCommand(query2, sqlconn);
                    sqlcom2.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("Błąd", "", MessageBoxButtons.OK);
            }

            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox1.Visible = false;
            btnzapisz.Visible = false;
            button1.Visible = true;
            btndodaj.Visible = true;
            tytul.Text = "Wybierz robota";
        }


        private void markaBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.markaBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }


        public void btndodaj_Click(object sender, EventArgs e)
        {
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            textBox1.Text= null;
            textBox1.Visible = true;
            btnzapisz.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            btndodaj.Visible = false;
            button1.Visible = false;
            tytul.Text = "Dodaj robota";

            string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            sqlconn.Open();
            string sqlquery = "select * from [dbo].[TypAll]";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox4.ValueMember = "TID";
            comboBox4.DisplayMember = "TypAll";
            comboBox4.DataSource = dt;
 
            string sqlquery2 = "select * from [dbo].[MarkaAll]";
            SqlCommand sqlcom2 = new SqlCommand(sqlquery2, sqlconn);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            comboBox5.ValueMember = "MID";
            comboBox5.DisplayMember = "MarkaAll";
            comboBox5.DataSource = dt2;
            string marka1 = comboBox5.Text;

            sqlconn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Enabled == true && comboBox3.SelectedValue != null)
            {
                MessageBox.Show(String.Format("Wybrano {0} {1}", comboBox2.Text, comboBox3.Text), "Wynik", MessageBoxButtons.OK);
            }
               
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void drag_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }


        private void Form1_MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
 
    }
}
