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
    public partial class DiyetisyenEkleForm : Form
    {
        private readonly DbEntity _db;
        
        public DiyetisyenEkleForm()
        {
            InitializeComponent();
           _db = new DbEntity();
      

        }

        private void ekleBtnClick(object sender, EventArgs e)
        {
            try
            {
                var user = _db.UsersTable.Create();
                user.Username = Username.Text;
                user.Password = password.Text;
                user.FullName = adSoyad.Text;
                user.TCKN = Int64.Parse(TCKN.Text);
                user.TelNo = Int64.Parse(TelNo.Text);
                user.Address = adres.Text;
                if (Erkek.Checked == true)
                    user.Gender = true;
                else
                    user.Gender = false;

                user.UserType = "Diyet";

                if (_db.UsersTable.FirstOrDefault(q => q.Username == user.Username) == null)
                {
                    _db.UsersTable.Add(user);
                    _db.SaveChanges();

                    MessageBox.Show("Kayıdınız Başarıyla Tamamlanmıştır!", "Kayıt Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Duplicated User ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen tüm alanları doldurun", "Kayıt Tamamlanmadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
