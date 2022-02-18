namespace Telefon_Tanir_Et
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MUSTERI_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUSTERI_ARIZA_OZET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUSTERININ_ULASIM_ADRESI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUSTERININ_TC_NUMARASI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 167);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MUSTERI_ID,
            this.MUSTERI_ARIZA_OZET,
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI,
            this.MUSTERININ_ULASIM_ADRESI,
            this.MUSTERININ_TC_NUMARASI});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(908, 167);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Telefonu ID";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(244, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 103);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefonu Arıza Özeti";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(717, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 26);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefonu Modeli";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(717, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 26);
            this.textBox5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşterinin Tc Kimlik Numarası";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(717, 137);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 26);
            this.textBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Müşterinin İletişim Adresi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Kayıt Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 39);
            this.button2.TabIndex = 14;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MUSTERI_ID
            // 
            this.MUSTERI_ID.DataPropertyName = "MUSTERI_ID";
            this.MUSTERI_ID.HeaderText = "MUSTERI_ID";
            this.MUSTERI_ID.Name = "MUSTERI_ID";
            this.MUSTERI_ID.ReadOnly = true;
            this.MUSTERI_ID.Visible = false;
            this.MUSTERI_ID.Width = 117;
            // 
            // MUSTERI_ARIZA_OZET
            // 
            this.MUSTERI_ARIZA_OZET.DataPropertyName = "MUSTERI_ARIZA_OZET";
            this.MUSTERI_ARIZA_OZET.HeaderText = "Arıza Nedeni";
            this.MUSTERI_ARIZA_OZET.Name = "MUSTERI_ARIZA_OZET";
            this.MUSTERI_ARIZA_OZET.ReadOnly = true;
            this.MUSTERI_ARIZA_OZET.Width = 124;
            // 
            // MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI
            // 
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI.DataPropertyName = "MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI";
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI.HeaderText = "Telefon Modeli";
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI.Name = "MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI";
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI.ReadOnly = true;
            this.MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI.Width = 126;
            // 
            // MUSTERININ_ULASIM_ADRESI
            // 
            this.MUSTERININ_ULASIM_ADRESI.DataPropertyName = "MUSTERININ_ULASIM_ADRESI";
            this.MUSTERININ_ULASIM_ADRESI.HeaderText = "İletşim Numarası";
            this.MUSTERININ_ULASIM_ADRESI.Name = "MUSTERININ_ULASIM_ADRESI";
            this.MUSTERININ_ULASIM_ADRESI.ReadOnly = true;
            this.MUSTERININ_ULASIM_ADRESI.Width = 142;
            // 
            // MUSTERININ_TC_NUMARASI
            // 
            this.MUSTERININ_TC_NUMARASI.DataPropertyName = "MUSTERININ_TC_NUMARASI";
            this.MUSTERININ_TC_NUMARASI.HeaderText = "TC Numarsı";
            this.MUSTERININ_TC_NUMARASI.Name = "MUSTERININ_TC_NUMARASI";
            this.MUSTERININ_TC_NUMARASI.ReadOnly = true;
            this.MUSTERININ_TC_NUMARASI.Width = 109;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(514, 271);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 39);
            this.button4.TabIndex = 15;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(115, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 26);
            this.textBox6.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Müşteri Tcsi";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(232, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 26);
            this.button5.TabIndex = 18;
            this.button5.Text = "ARA";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 39);
            this.button6.TabIndex = 19;
            this.button6.Text = "Tüm Kayıtları Getir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 493);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Telefon Tamircisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSTERI_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSTERI_ARIZA_OZET;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSTERININ_ULASIM_ADRESI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSTERININ_TC_NUMARASI;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

