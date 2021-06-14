using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPProjesi.DiyetisyenFolder
{
    public partial class DiyetisyenForm : Form
    {
        public DiyetisyenForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void hastaListBtn_Click(object sender, EventArgs e)
        {
            HastaListesiForm hastaList = new HastaListesiForm();
            hastaList.Show();
            Hide();
        }

        private void HastaEkleBtn_Click(object sender, EventArgs e)
        {
            HastaEkle hastaEkleForm = new HastaEkle();
            hastaEkleForm.Show();
            Hide();

        }
    }
}
