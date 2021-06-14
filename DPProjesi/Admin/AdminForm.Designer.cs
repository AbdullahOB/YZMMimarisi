
namespace DPProjesi.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.exitPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diyetisyenEkleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).BeginInit();
            this.SuspendLayout();
            // 
            // exitPic
            // 
            this.exitPic.Image = ((System.Drawing.Image)(resources.GetObject("exitPic.Image")));
            this.exitPic.Location = new System.Drawing.Point(315, 10);
            this.exitPic.Name = "exitPic";
            this.exitPic.Size = new System.Drawing.Size(27, 29);
            this.exitPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPic.TabIndex = 0;
            this.exitPic.TabStop = false;
            this.exitPic.Click += new System.EventHandler(this.exitPic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 15F);
            this.label1.Location = new System.Drawing.Point(100, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Admin";
            // 
            // diyetisyenEkleBtn
            // 
            this.diyetisyenEkleBtn.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.diyetisyenEkleBtn.Location = new System.Drawing.Point(100, 99);
            this.diyetisyenEkleBtn.Name = "diyetisyenEkleBtn";
            this.diyetisyenEkleBtn.Size = new System.Drawing.Size(155, 37);
            this.diyetisyenEkleBtn.TabIndex = 2;
            this.diyetisyenEkleBtn.Text = "Diyetseyen Ekle";
            this.diyetisyenEkleBtn.UseVisualStyleBackColor = true;
            this.diyetisyenEkleBtn.Click += new System.EventHandler(this.diyetisyenEkleBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 399);
            this.Controls.Add(this.diyetisyenEkleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.exitPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button diyetisyenEkleBtn;
    }
}