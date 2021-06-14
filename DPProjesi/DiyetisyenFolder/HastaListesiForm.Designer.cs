
namespace DPProjesi.DiyetisyenFolder
{
    partial class HastaListesiForm
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
            this.diyetYontemBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.selected = new System.Windows.Forms.Label();
            this.lstHasta = new System.Windows.Forms.ListView();
            this.HastaAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TCKN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HastalikTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiyetTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // diyetYontemBtn
            // 
            this.diyetYontemBtn.Location = new System.Drawing.Point(20, 324);
            this.diyetYontemBtn.Name = "diyetYontemBtn";
            this.diyetYontemBtn.Size = new System.Drawing.Size(149, 35);
            this.diyetYontemBtn.TabIndex = 1;
            this.diyetYontemBtn.Text = "Diyet Yöntemi Ekle / Değiştir";
            this.diyetYontemBtn.UseVisualStyleBackColor = true;
            this.diyetYontemBtn.Click += new System.EventHandler(this.diyetYontemBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Export As";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // selected
            // 
            this.selected.AutoSize = true;
            this.selected.Location = new System.Drawing.Point(351, 335);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(35, 13);
            this.selected.TabIndex = 2;
            this.selected.Text = "label1";
            // 
            // lstHasta
            // 
            this.lstHasta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HastaAdi,
            this.TCKN,
            this.TelNo,
            this.HastalikTipi,
            this.DiyetTipi,
            this.UserId});
            this.lstHasta.FullRowSelect = true;
            this.lstHasta.GridLines = true;
            this.lstHasta.HideSelection = false;
            this.lstHasta.Location = new System.Drawing.Point(12, 12);
            this.lstHasta.Name = "lstHasta";
            this.lstHasta.Size = new System.Drawing.Size(719, 283);
            this.lstHasta.TabIndex = 3;
            this.lstHasta.UseCompatibleStateImageBehavior = false;
            this.lstHasta.View = System.Windows.Forms.View.Details;
            this.lstHasta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstHasta_MouseClick);
            // 
            // HastaAdi
            // 
            this.HastaAdi.Text = "Hasta Adı";
            this.HastaAdi.Width = 82;
            // 
            // TCKN
            // 
            this.TCKN.Text = "T.C Numarası";
            this.TCKN.Width = 116;
            // 
            // TelNo
            // 
            this.TelNo.Text = "Tel. Numarası";
            this.TelNo.Width = 80;
            // 
            // HastalikTipi
            // 
            this.HastalikTipi.Text = "Hastalık Tipi";
            this.HastalikTipi.Width = 82;
            // 
            // DiyetTipi
            // 
            this.DiyetTipi.Text = "Diyet Yöntemi";
            this.DiyetTipi.Width = 110;
            // 
            // UserId
            // 
            this.UserId.Text = "User Id";
            // 
            // HastaListesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.lstHasta);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diyetYontemBtn);
            this.Name = "HastaListesiForm";
            this.Text = "HastaListesiForm";
            this.Load += new System.EventHandler(this.HastaListesiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button diyetYontemBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label selected;
        private System.Windows.Forms.ListView lstHasta;
        private System.Windows.Forms.ColumnHeader UserId;
        private System.Windows.Forms.ColumnHeader HastaAdi;
        private System.Windows.Forms.ColumnHeader TCKN;
        private System.Windows.Forms.ColumnHeader TelNo;
        private System.Windows.Forms.ColumnHeader HastalikTipi;
        private System.Windows.Forms.ColumnHeader DiyetTipi;
    }
}