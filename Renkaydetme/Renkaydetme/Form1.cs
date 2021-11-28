using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renkaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private int Renk = 0;

        private int RenkDonustur()
        {
            Renk = BackColor.ToArgb();
            MessageBox.Show(Renk.ToString());
            return Renk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(Renk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(RenkDialog.ShowDialog()==DialogResult.Cancel)
            {
                return;
            }
            BackColor = RenkDialog.Color;
            RenkDonustur();
        }
    }
}
/*
     private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Bağlantı metnini buraya yazın.!."))
            {
                //SELECT ifadesini kendinize göre özelleştirin.!.
                using (SqlCommand com = new SqlCommand("SELECT [renk] FROM [TabloAdi] WHERE [formAdi]=@formAdi", con))
                {
                    com.Parameters.AddWithValue("@formAdi", "f1");
                    con.Open();
                    object renk = com.ExecuteScalar();
                    con.Close();
                    if (renk != null)
                        BackColor = Color.FromArgb(Convert.ToInt32(renk));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = cDialog.Color;
                using (SqlConnection con = new SqlConnection("Bağlantı metnini buraya yazın.!."))
                {
                    //INSERT INTO ifadesini kendinize göre özelleştirin.!.
                    using (SqlCommand com = new SqlCommand("INSERT INTO [TabloAdi] (formAdi, renk) VALUES (@formAdi, @renk)", con))
                    {
                        com.Parameters.AddWithValue("@formAdi", "f1");
                        com.Parameters.AddWithValue("@renk", BackColor.ToArgb());
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
        }
 */
