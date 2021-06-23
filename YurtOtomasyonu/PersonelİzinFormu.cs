using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyonu
{
    public partial class PersonelİzinFormu : Form
    {
        public PersonelİzinFormu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonelİzinFormu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelİzinFormu f1 = new PersonelİzinFormu();
            f1.Close();
            PersonelİzinFormu f2 = new PersonelİzinFormu();
            f2.Show();
            this.Hide();
        }
    }
}
