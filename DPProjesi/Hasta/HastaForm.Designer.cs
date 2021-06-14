
namespace DPProjesi.Hasta
{
    partial class HastaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hastalikTip = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yontem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kalanGun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // welcomeUser
            // 
            this.welcomeUser.AutoSize = true;
            this.welcomeUser.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeUser.Location = new System.Drawing.Point(229, 50);
            this.welcomeUser.Name = "welcomeUser";
            this.welcomeUser.Size = new System.Drawing.Size(69, 26);
            this.welcomeUser.TabIndex = 0;
            this.welcomeUser.Text = "{User}";
            this.welcomeUser.Click += new System.EventHandler(this.welcomeUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hastalığın Tipi :";
            // 
            // hastalikTip
            // 
            this.hastalikTip.AutoSize = true;
            this.hastalikTip.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastalikTip.Location = new System.Drawing.Point(257, 127);
            this.hastalikTip.Name = "hastalikTip";
            this.hastalikTip.Size = new System.Drawing.Size(50, 23);
            this.hastalikTip.TabIndex = 1;
            this.hastalikTip.Text = "{Tip}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yöntem :";
            // 
            // yontem
            // 
            this.yontem.AutoSize = true;
            this.yontem.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yontem.Location = new System.Drawing.Point(257, 195);
            this.yontem.Name = "yontem";
            this.yontem.Size = new System.Drawing.Size(88, 23);
            this.yontem.TabIndex = 1;
            this.yontem.Text = "{yöntem}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kalan Günler:";
            // 
            // kalanGun
            // 
            this.kalanGun.AutoSize = true;
            this.kalanGun.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalanGun.Location = new System.Drawing.Point(257, 271);
            this.kalanGun.Name = "kalanGun";
            this.kalanGun.Size = new System.Drawing.Size(73, 23);
            this.kalanGun.TabIndex = 1;
            this.kalanGun.Text = "{Kalan}";
            // 
            // HastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 398);
            this.Controls.Add(this.kalanGun);
            this.Controls.Add(this.yontem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hastalikTip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeUser);
            this.Controls.Add(this.label1);
            this.Name = "HastaForm";
            this.Text = "HastaForm";
            this.Load += new System.EventHandler(this.HastaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hastalikTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label yontem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kalanGun;
    }
}