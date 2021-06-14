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
    public partial class YontemDegistir : Form
    {

        private readonly DbEntity _db;
        int id;
        public YontemDegistir( int HastaId)
        {
            InitializeComponent();
            _db = new DbEntity();
            id = HastaId;

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {

             var s = _db.HastaTable.FirstOrDefault(q => q.UserId == id);
              s.DiyetYontemi = yontemCmb.Text;

            _db.Entry(s).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
            DiyetisyenForm d = new DiyetisyenForm();
            d.Show();
            Hide();

        }

        private void YontemDegistir_Load(object sender, EventArgs e)
        {
            var s = _db.HastaTable.FirstOrDefault(q => q.UserId == id);
            yontemCmb.Text = s.DiyetYontemi;
            userId.Text = id.ToString();
        }
    }
}
