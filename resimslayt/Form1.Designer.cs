
namespace resimslayt
{
    partial class Form1
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
            this.klasorsecbtn = new System.Windows.Forms.Button();
            this.solabtn = new System.Windows.Forms.Button();
            this.sagabtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // klasorsecbtn
            // 
            this.klasorsecbtn.Location = new System.Drawing.Point(210, 401);
            this.klasorsecbtn.Name = "klasorsecbtn";
            this.klasorsecbtn.Size = new System.Drawing.Size(88, 23);
            this.klasorsecbtn.TabIndex = 0;
            this.klasorsecbtn.Text = "Klasör Seç";
            this.klasorsecbtn.UseVisualStyleBackColor = true;
            this.klasorsecbtn.Click += new System.EventHandler(this.klasorsecbtn_Click);
            // 
            // solabtn
            // 
            this.solabtn.Location = new System.Drawing.Point(43, 401);
            this.solabtn.Name = "solabtn";
            this.solabtn.Size = new System.Drawing.Size(75, 23);
            this.solabtn.TabIndex = 1;
            this.solabtn.Text = "<<<<";
            this.solabtn.UseVisualStyleBackColor = true;
            this.solabtn.Click += new System.EventHandler(this.solabtn_Click);
            // 
            // sagabtn
            // 
            this.sagabtn.Location = new System.Drawing.Point(398, 401);
            this.sagabtn.Name = "sagabtn";
            this.sagabtn.Size = new System.Drawing.Size(75, 23);
            this.sagabtn.TabIndex = 2;
            this.sagabtn.Text = ">>>>";
            this.sagabtn.UseVisualStyleBackColor = true;
            this.sagabtn.Click += new System.EventHandler(this.sagabtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.sagabtn);
            this.Controls.Add(this.solabtn);
            this.Controls.Add(this.klasorsecbtn);
            this.Name = "Form1";
            this.Text = "Resim Galerisi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button klasorsecbtn;
        private System.Windows.Forms.Button solabtn;
        private System.Windows.Forms.Button sagabtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

