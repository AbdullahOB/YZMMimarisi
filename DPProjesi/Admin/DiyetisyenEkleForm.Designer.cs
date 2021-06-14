
namespace DPProjesi.Admin
{
    partial class DiyetisyenEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCKN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alan = new System.Windows.Forms.ComboBox();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cinsiyet = new System.Windows.Forms.GroupBox();
            this.Kadin = new System.Windows.Forms.RadioButton();
            this.Erkek = new System.Windows.Forms.RadioButton();
            this.Cinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // adSoyad
            // 
            this.adSoyad.Location = new System.Drawing.Point(49, 61);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(176, 20);
            this.adSoyad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diyetisyen Adı";
            // 
            // TCKN
            // 
            this.TCKN.Location = new System.Drawing.Point(49, 118);
            this.TCKN.Name = "TCKN";
            this.TCKN.Size = new System.Drawing.Size(176, 20);
            this.TCKN.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TCKN";
            // 
            // TelNo
            // 
            this.TelNo.Location = new System.Drawing.Point(49, 186);
            this.TelNo.Name = "TelNo";
            this.TelNo.Size = new System.Drawing.Size(176, 20);
            this.TelNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "TelNo";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(49, 251);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(176, 20);
            this.Username.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(273, 61);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(176, 20);
            this.password.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Diyetisyen Alanı";
            // 
            // alan
            // 
            this.alan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alan.FormattingEnabled = true;
            this.alan.Items.AddRange(new object[] {
            "obez",
            "çölyak",
            "şeker"});
            this.alan.Location = new System.Drawing.Point(273, 118);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(176, 21);
            this.alan.TabIndex = 2;
            // 
            // ekleBtn
            // 
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekleBtn.Location = new System.Drawing.Point(195, 339);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(156, 46);
            this.ekleBtn.TabIndex = 3;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtnClick);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(273, 176);
            this.adres.MinimumSize = new System.Drawing.Size(200, 70);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(249, 70);
            this.adres.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adres";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.Controls.Add(this.Erkek);
            this.Cinsiyet.Controls.Add(this.Kadin);
            this.Cinsiyet.Location = new System.Drawing.Point(273, 252);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(249, 56);
            this.Cinsiyet.TabIndex = 4;
            this.Cinsiyet.TabStop = false;
            this.Cinsiyet.Text = "Cinsyet";
            // 
            // Kadin
            // 
            this.Kadin.AutoSize = true;
            this.Kadin.Location = new System.Drawing.Point(146, 24);
            this.Kadin.Name = "Kadin";
            this.Kadin.Size = new System.Drawing.Size(52, 17);
            this.Kadin.TabIndex = 0;
            this.Kadin.TabStop = true;
            this.Kadin.Text = "Kadın";
            this.Kadin.UseVisualStyleBackColor = true;
            // 
            // Erkek
            // 
            this.Erkek.AutoSize = true;
            this.Erkek.Location = new System.Drawing.Point(42, 24);
            this.Erkek.Name = "Erkek";
            this.Erkek.Size = new System.Drawing.Size(53, 17);
            this.Erkek.TabIndex = 0;
            this.Erkek.TabStop = true;
            this.Erkek.Text = "Erkek";
            this.Erkek.UseVisualStyleBackColor = true;
            // 
            // DiyetisyenEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 441);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.alan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.TelNo);
            this.Controls.Add(this.TCKN);
            this.Controls.Add(this.adSoyad);
            this.Name = "DiyetisyenEkleForm";
            this.Text = "DiyetisyenEkleForm";
            this.Cinsiyet.ResumeLayout(false);
            this.Cinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCKN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TelNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox alan;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Cinsiyet;
        private System.Windows.Forms.RadioButton Erkek;
        private System.Windows.Forms.RadioButton Kadin;
    }
}