
namespace DPProjesi.DiyetisyenFolder
{
    partial class YontemDegistir
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
            this.yontemCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.userId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yontemCmb
            // 
            this.yontemCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yontemCmb.FormattingEnabled = true;
            this.yontemCmb.Items.AddRange(new object[] {
            "Gluten Free",
            "Akdeniz",
            "Deniz Ürünleri",
            "Yeşillikler Dünyası"});
            this.yontemCmb.Location = new System.Drawing.Point(78, 77);
            this.yontemCmb.Name = "yontemCmb";
            this.yontemCmb.Size = new System.Drawing.Size(156, 21);
            this.yontemCmb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yontem Adı";
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(119, 121);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 23);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "Değiştir";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // userId
            // 
            this.userId.AutoSize = true;
            this.userId.Location = new System.Drawing.Point(282, 23);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(35, 13);
            this.userId.TabIndex = 3;
            this.userId.Text = "label2";
            // 
            // YontemDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 206);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yontemCmb);
            this.Name = "YontemDegistir";
            this.Text = "YontemDegistir";
            this.Load += new System.EventHandler(this.YontemDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox yontemCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label userId;
    }
}