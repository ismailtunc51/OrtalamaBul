using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaBul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            double sonuc = (Convert.ToDouble(txtone.Text) + Convert.ToDouble(textwo.Text)) / 2;

            texthree.Text=sonuc.ToString();

           DialogResult tercih = MessageBox.Show("yeni bir işlem yapmak ister misiniz?","bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tercih==DialogResult.Yes)
            {
                txtone.Text = string.Empty;
                textwo.Text = string.Empty;
                texthree.Text = string.Empty;           
            }
            else
            {
                MessageBox.Show("çıkış yapıldı");                
            }
        }      
    }
}
