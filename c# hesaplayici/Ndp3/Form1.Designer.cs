namespace Ndp3
{
    partial class Hesaplayici
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.formulBox = new System.Windows.Forms.TextBox();
            this.buttonHesapla = new System.Windows.Forms.Button();
            this.sonucBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // formulBox
            // 
            this.formulBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formulBox.Location = new System.Drawing.Point(12, 33);
            this.formulBox.Name = "formulBox";
            this.formulBox.Size = new System.Drawing.Size(229, 24);
            this.formulBox.TabIndex = 0;
            this.formulBox.TextChanged += new System.EventHandler(this.formulBox_TextChanged);
            // 
            // buttonHesapla
            // 
            this.buttonHesapla.Location = new System.Drawing.Point(12, 84);
            this.buttonHesapla.Name = "buttonHesapla";
            this.buttonHesapla.Size = new System.Drawing.Size(229, 24);
            this.buttonHesapla.TabIndex = 1;
            this.buttonHesapla.Text = "HESAPLA";
            this.buttonHesapla.UseVisualStyleBackColor = true;
            this.buttonHesapla.Click += new System.EventHandler(this.buttonHesapla_Click);
            // 
            // sonucBox
            // 
            this.sonucBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucBox.Location = new System.Drawing.Point(12, 135);
            this.sonucBox.Name = "sonucBox";
            this.sonucBox.ReadOnly = true;
            this.sonucBox.Size = new System.Drawing.Size(229, 24);
            this.sonucBox.TabIndex = 2;
            this.sonucBox.TextChanged += new System.EventHandler(this.sonucBox_TextChanged);
            // 
            // Hesaplayici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 217);
            this.Controls.Add(this.sonucBox);
            this.Controls.Add(this.buttonHesapla);
            this.Controls.Add(this.formulBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hesaplayici";
            this.Text = "HESAPLAYICI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox formulBox;
        private System.Windows.Forms.Button buttonHesapla;
        private System.Windows.Forms.TextBox sonucBox;
    }
}

