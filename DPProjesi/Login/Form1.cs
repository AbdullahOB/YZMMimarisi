using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPProjesi.Admin;
using DPProjesi.DiyetisyenFolder;
using DPProjesi.Hasta;

namespace DPProjesi
{
    public partial class Form1 : Form
    {
        private readonly DbEntity _db;
        
        public Form1()
        {
            InitializeComponent();

            _db = new DbEntity();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
           
            var user = _db.UsersTable.FirstOrDefault(q => q.Username == usernameTxt.Text.Trim() && q.Password == passTxt.Text);
            if (user!=null) 

            {
                if (user.UserType == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    Hide();
                }
                if (user.UserType == "Diyet")
                {
                    DiyetisyenForm diyetisyen = new DiyetisyenForm();
                    diyetisyen.Show();
                    Hide();
                }
                if (user.UserType == "Hasta")
                {
                    HastaForm hasta = new HastaForm(user.Username);
                    hasta.Show();
                    Hide();
                }
            }
            else
            {
               
                MessageBox.Show("Username Or Pass Is wrong");
                
                
            }


        }
    }
}
