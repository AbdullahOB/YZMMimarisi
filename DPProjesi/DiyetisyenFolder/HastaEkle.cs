using DPProjesi.DiyetisyenFolder.Factory;
using DPProjesi.DiyetisyenFolder.Factory.HastalikFactory;
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
    public partial class HastaEkle : Form
    {
        private readonly DbEntity _db;
        public HastaEkle()
        {
            _db = new DbEntity();
            InitializeComponent();
        }

        private void hastaEkleBtn_Click(object sender, EventArgs e)
        {
            
            var HastalikTipi = _db.HastaTable.Create();
            var Hasta = _db.UsersTable.Create();
            Hasta.FullName = HastaAd.Text;
            Hasta.Username = userTxt.Text;
            Hasta.Password = passTxt.Text;
            Hasta.TCKN =Int64.Parse( TCKNTxt.Text);
            Hasta.TelNo = Int64.Parse(TelNoTxt.Text);
            Hasta.Address = Adres.Text;
            Hasta.UserType = "Hasta";
            HastalikTipi.HastalikTipi = hastaTipiCmb.Text;
            HastalikTipi.DiyetYontemi = DiyetYontemiCmb.Text;

            if(_db.UsersTable.FirstOrDefault(q => q.Username == Hasta.Username) == null)
            {
                _db.UsersTable.Add(Hasta);
                _db.HastaTable.Add(HastalikTipi);
                _db.SaveChanges();
                MessageBox.Show("Kayıdınız Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Duplicated User ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
