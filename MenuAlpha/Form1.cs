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
        int dodaj = 0; 

        //przeciąganie okna po ekranie
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

            homepage();//strona główna
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

        public void btndodaj_Click(object sender, EventArgs e)
        {
            addpage();
        }

        public void addpage()
        {
            dodaj = 1;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            textBox1.Text = null;
            textBox1.Visible = true;
            btnzapisz.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            btndodaj.Visible = false;
            button1.Visible = false;
            tytul.Text = "Dodaj robota";
            anuluj.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            textBox2.Visible = false;
            btnNM.Visible = true;
            btnNTR.Visible = true;

            tytul.Visible = true;
            tytul2.Visible = false;


            string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);

            //wypełnienie comboboxa4
            sqlconn.Open();
            string sqlquery = "select * from [dbo].[TypAll]";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            comboBox4.ValueMember = "TID";
            comboBox4.DisplayMember = "TypAll";
            comboBox4.DataSource = dt;

            //wypełnienie comboboxa5
            string sqlquery2 = "select * from [dbo].[MarkaAll]";
            SqlCommand sqlcom2 = new SqlCommand(sqlquery2, sqlconn);
            SqlDataAdapter sda2 = new SqlDataAdapter(sqlcom2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            comboBox5.ValueMember = "MID";
            comboBox5.DisplayMember = "MarkaAll";
            comboBox5.DataSource = dt2;

            sqlconn.Close();
        }

        private void btnzapisz_Click_1(object sender, EventArgs e)
        {
            switch (dodaj)
            {
                case 1:

                    if (comboBox4.SelectedValue != null && comboBox5.SelectedValue != null && !String.IsNullOrEmpty(textBox1.Text))
                    {
                        string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
                        SqlConnection sqlconn = new SqlConnection(mainconn);
                        sqlconn.Open();

                        string query = "INSERT INTO Model(model, TypID, MarkaID) VALUES('" + textBox1.Text + "', '" + comboBox4.SelectedValue.ToString() + "', '" + comboBox5.SelectedValue.ToString() + "')";
                        SqlCommand sqlcom = new SqlCommand(query, sqlconn);
                        sqlcom.ExecuteNonQuery();

                        MessageBox.Show("Zapisano");

                        string qry = "SELECT TypID, MarkaID FROM Marka WHERE TypID = '" + comboBox4.SelectedValue.ToString() + "' AND MarkaID = '" + comboBox5.SelectedValue.ToString() + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(qry, sqlconn);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 0) //sprawdzenie czy weatości się nie dublują 
                        {
                            string query2 = "INSERT INTO Marka(marka, TypID, MarkaID) VALUES('" + comboBox5.Text + "', '" + comboBox4.SelectedValue.ToString() + "', '" + comboBox5.SelectedValue.ToString() + "')";
                            SqlCommand sqlcom2 = new SqlCommand(query2, sqlconn);
                            sqlcom2.ExecuteNonQuery();
                        }

                        string qry2 = "SELECT typ FROM Typ WHERE typ = '" + comboBox4.Text + "'";
                        SqlDataAdapter sda2 = new SqlDataAdapter(qry2, sqlconn);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        if (dt2.Rows.Count == 0)
                        {
                            string query2 = "INSERT INTO Typ(typ) VALUES('" + comboBox4.Text + "')";
                            SqlCommand sqlcom2 = new SqlCommand(query2, sqlconn);
                            sqlcom2.ExecuteNonQuery();
                        }
                        sqlconn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    homepage();

                    break;
                case 2:
                    if (!String.IsNullOrEmpty(textBox2.Text))
                    {
                        string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
                        SqlConnection sqlconn = new SqlConnection(mainconn);
                        sqlconn.Open();
                       
                        string query2 = "INSERT INTO TypAll(TypAll) VALUES('" + textBox2.Text + "')";
                        SqlCommand sqlcom2 = new SqlCommand(query2, sqlconn);
                        sqlcom2.ExecuteNonQuery();
                        sqlconn.Close();


                        MessageBox.Show("Zapisano");
                    }
                    else
                    {
                        MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    addpage();

                    break;
                case 3:
                    if (!String.IsNullOrEmpty(textBox2.Text))
                    {
                        string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
                        SqlConnection sqlconn = new SqlConnection(mainconn);
                        sqlconn.Open();

                        string query2 = "INSERT INTO MarkaAll(MarkaAll) VALUES('" + textBox2.Text + "')";
                        SqlCommand sqlcom2 = new SqlCommand(query2, sqlconn);
                        sqlcom2.ExecuteNonQuery();
                        sqlconn.Close();

                        MessageBox.Show("Zapisano");
                    }
                    else
                    {
                        MessageBox.Show("Nie wprowadzono danych.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    addpage();

                    break;
            }
        }


        //private void markaBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.markaBindingSource1.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dataSet1);

        //}

     

        public void homepage()
        {
            dodaj = 0;
            //łączenie z bazą danych
            string mainconn = ConfigurationManager.ConnectionStrings["MenuAlpha.Properties.Settings.Database1ConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select * from [dbo].[Typ]";
            SqlCommand sqlcom = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //sterowanie widocznością kontrolek
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
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
            anuluj.Visible = false;
            btndodaj.Visible = true;
            button1.Visible = true;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            textBox2.Visible = false;
            btnNM.Visible = false;
            btnNTR.Visible = false;

            tytul.Visible = true;
            tytul2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Enabled == true && comboBox3.SelectedValue != null)
            {
                MessageBox.Show(String.Format("Wybrano {0} {1}", comboBox2.Text, comboBox3.Text), "Wynik", MessageBoxButtons.OK);
            }
               
        }

        //zamknięcie okna
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void anuluj_Click(object sender, EventArgs e)
        {
            homepage();
        }

        //nowy typ robota
        private void btnNTR_Click(object sender, EventArgs e)
        {
            dodaj = 2;

            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox2.Text = null;
            textBox1.Visible = false;
            btnzapisz.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            btndodaj.Visible = false;
            button1.Visible = false;
            tytul.Text = "Dodaj robota";
            anuluj.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            textBox2.Visible = true;
            btnNM.Visible = false;
            btnNTR.Visible = false;

            tytul.Visible = false;
            tytul2.Text = "Dodaj nowy typ robota";
            tytul2.Visible = true;


        }

        //nowa marka
        private void btnNM_Click(object sender, EventArgs e)
        {
            dodaj = 3;

            comboBox4.Visible = false;
            comboBox5.Visible = false;
            textBox2.Text = null;
            textBox1.Visible = false;
            btnzapisz.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            btndodaj.Visible = false;
            button1.Visible = false;
            tytul.Text = "Dodaj robota";
            anuluj.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            textBox2.Visible = true;
            btnNM.Visible = false;
            btnNTR.Visible = false;

            tytul.Visible = false;
            tytul2.Text = "Nowa marka robota";
            tytul2.Visible = true;

        }

        //przeciąganie okna po ekranie
        private void Form1_MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }
        private void drag_Click(object sender, EventArgs e)
        {

        }
    }
}
