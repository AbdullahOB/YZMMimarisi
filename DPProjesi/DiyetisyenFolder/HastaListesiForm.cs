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
    public partial class HastaListesiForm : Form
    {
        
        private readonly DbEntity _db;
        public HastaListesiForm()
        {
            InitializeComponent();
            _db = new DbEntity();
            
        }

        private void HastaListesiForm_Load(object sender, EventArgs e)
        {

            List<UsersTable> list = _db.UsersTable.ToList();
          
            foreach(UsersTable s in list)
            {
                if(s.UserType == "Hasta")
                {
                    ListViewItem item = new ListViewItem(s.FullName);
                    item.SubItems.Add(s.TCKN.ToString());
                    item.SubItems.Add(s.TelNo.ToString());
                    item.SubItems.Add(_db.HastaTable.FirstOrDefault(q => q.UserId == s.Id).HastalikTipi);
                    item.SubItems.Add(_db.HastaTable.FirstOrDefault(q => q.UserId == s.Id).DiyetYontemi);
                    item.SubItems.Add(_db.HastaTable.FirstOrDefault(q => q.UserId == s.Id).UserId.ToString());
                    lstHasta.Items.Add(item);
                }
            }
        }

        private void diyetYontemBtn_Click(object sender, EventArgs e)
        {
            int cur = Int32.Parse( lstHasta.SelectedItems[0].SubItems[5].Text);
            YontemDegistir yon = new YontemDegistir(cur);
            yon.Show();
            Hide();

        }

       

        private void lstHasta_MouseClick(object sender, MouseEventArgs e)
        {
            int cur = Int32.Parse(lstHasta.SelectedItems[0].SubItems[5].Text);
            selected.Text = cur.ToString();
        }
    }
}
