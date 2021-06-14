
namespace DPProjesi.DiyetisyenFolder
{
    partial class DiyetisyenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiyetisyenForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hastaListBtn = new System.Windows.Forms.Button();
            this.HastaEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(387, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hastaListBtn
            // 
            this.hastaListBtn.Font = new System.Drawing.Font("Poppins", 15F);
            this.hastaListBtn.Location = new System.Drawing.Point(126, 197);
            this.hastaListBtn.Name = "hastaListBtn";
            this.hastaListBtn.Size = new System.Drawing.Size(201, 38);
            this.hastaListBtn.TabIndex = 1;
            this.hastaListBtn.Text = "Hasta Listesi Göster";
            this.hastaListBtn.UseVisualStyleBackColor = true;
            this.hastaListBtn.Click += new System.EventHandler(this.hastaListBtn_Click);
            // 
            // HastaEkleBtn
            // 
            this.HastaEkleBtn.Font = new System.Drawing.Font("Poppins", 15F);
            this.HastaEkleBtn.Location = new System.Drawing.Point(126, 119);
            this.HastaEkleBtn.Name = "HastaEkleBtn";
            this.HastaEkleBtn.Size = new System.Drawing.Size(201, 38);
            this.HastaEkleBtn.TabIndex = 1;
            this.HastaEkleBtn.Text = "Hasta Ekle";
            this.HastaEkleBtn.UseVisualStyleBackColor = true;
            this.HastaEkleBtn.Click += new System.EventHandler(this.HastaEkleBtn_Click);
            // 
            // DiyetisyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 430);
            this.Controls.Add(this.HastaEkleBtn);
            this.Controls.Add(this.hastaListBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiyetisyenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiyetisyenForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hastaListBtn;
        private System.Windows.Forms.Button HastaEkleBtn;
    }
}