using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPProjesi.Hasta
{
    public partial class HastaForm : Form
    {
        private readonly DbEntity _db;
        string username;
        public HastaForm(string user)
        {
            InitializeComponent();
            _db = new DbEntity();
            username = user;
        }
       


        private void HastaForm_Load(object sender, EventArgs e)
        {
            var user = _db.UsersTable.FirstOrDefault(q => q.Username==username);
            var hastalik = _db.HastaTable.FirstOrDefault(t => t.UserId == user.Id);
            welcomeUser.Text = user.FullName;
            yontem.Text = hastalik.DiyetYontemi;
            hastalikTip.Text = hastalik.HastalikTipi;
            if (hastalik.HastalikTipi == "Obez")
                kalanGun.Text = 14.ToString();
            else if (hastalik.HastalikTipi == "Colyak")
                kalanGun.Text = 8.ToString();
            else if (hastalik.HastalikTipi == "Seker")
                kalanGun.Text = 18.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeUser_Click(object sender, EventArgs e)
        {

        }
    }
}
