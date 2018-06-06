using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bILesDataDataSet.As2016proc' . Możesz go przenieść lub usunąć.
            this.as2016procTableAdapter.Fill(this.bILesDataDataSet.As2016proc);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        /* private void FillCombobox()
    {
        using (InventoryEntities c = new InventoryEntities(Properties.Settings.Default.Connection))
        {
          comboBox1.DataSource    = c.Customers;
          comboBox1.ValueMember   = "id";
          comboBox1.DisplayMember = "stacja";

        }
    
    }
    */
        private void button1_Click(object sender, EventArgs e)

        {

            SqlConnection con = new SqlConnection("Server = localhost; Database = BILesData; Trusted_Connection = True; ");

            SqlCommand cmd = new SqlCommand("Select [stacja],[predkosc_wiatru] from pogoda2", con);

            DbDataReader mydatareader;

            try

            {

                con.Open();

                mydatareader = cmd.ExecuteReader();

                while (mydatareader.Read())

                {

                    this.chart1.Series["Stacja"].Points.AddXY(mydatareader.GetString(1), mydatareader.GetInt32(2));

                }

            }
              catch(Exception ex)
             {
               
                //MessageBox.show(ex.message);
            }

        }

       
       
    }
}
