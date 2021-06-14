using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPProjesi.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void exitPic_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diyetisyenEkleBtn_Click(object sender, EventArgs e)
        {
            DiyetisyenEkleForm form = new DiyetisyenEkleForm();
            form.Show();
            Hide();
        }
    }
}
