namespace Petrol_ve_Marketcilik_Otomasyonu
{
    partial class MarketForm
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
            this.dataGridUrunler = new System.Windows.Forms.DataGridView();
            this.UrunIdTxt = new System.Windows.Forms.TextBox();
            this.UrunAdTxt = new System.Windows.Forms.TextBox();
            this.UrunAdetTxt = new System.Windows.Forms.TextBox();
            this.UrunFiyatTxt = new System.Windows.Forms.TextBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.ListelemeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUrunler
            // 
            this.dataGridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUrunler.Location = new System.Drawing.Point(28, 40);
            this.dataGridUrunler.Name = "dataGridUrunler";
            this.dataGridUrunler.RowHeadersWidth = 51;
            this.dataGridUrunler.RowTemplate.Height = 24;
            this.dataGridUrunler.Size = new System.Drawing.Size(549, 379);
            this.dataGridUrunler.TabIndex = 0;
            // 
            // UrunIdTxt
            // 
            this.UrunIdTxt.Location = new System.Drawing.Point(632, 115);
            this.UrunIdTxt.Name = "UrunIdTxt";
            this.UrunIdTxt.Size = new System.Drawing.Size(100, 22);
            this.UrunIdTxt.TabIndex = 1;
            // 
            // UrunAdTxt
            // 
            this.UrunAdTxt.Location = new System.Drawing.Point(632, 143);
            this.UrunAdTxt.Name = "UrunAdTxt";
            this.UrunAdTxt.Size = new System.Drawing.Size(100, 22);
            this.UrunAdTxt.TabIndex = 1;
            // 
            // UrunAdetTxt
            // 
            this.UrunAdetTxt.Location = new System.Drawing.Point(632, 171);
            this.UrunAdetTxt.Name = "UrunAdetTxt";
            this.UrunAdetTxt.Size = new System.Drawing.Size(100, 22);
            this.UrunAdetTxt.TabIndex = 1;
            // 
            // UrunFiyatTxt
            // 
            this.UrunFiyatTxt.Location = new System.Drawing.Point(632, 199);
            this.UrunFiyatTxt.Name = "UrunFiyatTxt";
            this.UrunFiyatTxt.Size = new System.Drawing.Size(100, 22);
            this.UrunFiyatTxt.TabIndex = 1;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(632, 227);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(100, 23);
            this.EkleBtn.TabIndex = 2;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            // 
            // SilBtn
            // 
            this.SilBtn.Location = new System.Drawing.Point(632, 256);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(100, 23);
            this.SilBtn.TabIndex = 2;
            this.SilBtn.Text = "Sİl";
            this.SilBtn.UseVisualStyleBackColor = true;
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.Location = new System.Drawing.Point(632, 285);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(100, 23);
            this.GuncelleBtn.TabIndex = 2;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = true;
            // 
            // ListelemeBtn
            // 
            this.ListelemeBtn.Location = new System.Drawing.Point(632, 314);
            this.ListelemeBtn.Name = "ListelemeBtn";
            this.ListelemeBtn.Size = new System.Drawing.Size(100, 23);
            this.ListelemeBtn.TabIndex = 2;
            this.ListelemeBtn.Text = "Listele";
            this.ListelemeBtn.UseVisualStyleBackColor = true;
            this.ListelemeBtn.Click += new System.EventHandler(this.ListelemeBtn_Click);
            // 
            // MarketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListelemeBtn);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.UrunFiyatTxt);
            this.Controls.Add(this.UrunAdetTxt);
            this.Controls.Add(this.UrunAdTxt);
            this.Controls.Add(this.UrunIdTxt);
            this.Controls.Add(this.dataGridUrunler);
            this.Name = "MarketForm";
            this.Text = "MarketForm";
            this.Load += new System.EventHandler(this.MarketForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUrunler;
        private System.Windows.Forms.TextBox UrunIdTxt;
        private System.Windows.Forms.TextBox UrunAdTxt;
        private System.Windows.Forms.TextBox UrunAdetTxt;
        private System.Windows.Forms.TextBox UrunFiyatTxt;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Button ListelemeBtn;
    }
}