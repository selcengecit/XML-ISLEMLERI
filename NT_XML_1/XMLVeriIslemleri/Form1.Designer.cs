namespace XMLVeriIslemleri
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXMLVeriOku = new System.Windows.Forms.Button();
            this.btnXMLVeriBul = new System.Windows.Forms.Button();
            this.btnXpathVerileriCek = new System.Windows.Forms.Button();
            this.btnXpathVeriCek = new System.Windows.Forms.Button();
            this.btnXMLVeriSİl = new System.Windows.Forms.Button();
            this.btnXMLVeriDegistir = new System.Windows.Forms.Button();
            this.btnVTXMLOku = new System.Windows.Forms.Button();
            this.btnXMLVeriEkle = new System.Windows.Forms.Button();
            this.btnXMLSchema = new System.Windows.Forms.Button();
            this.btnVTXMLYaz = new System.Windows.Forms.Button();
            this.btnSchemaDogrula = new System.Windows.Forms.Button();
            this.btnSQLSchemaXML = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnXMLVeriOku
            // 
            this.btnXMLVeriOku.Location = new System.Drawing.Point(40, 279);
            this.btnXMLVeriOku.Name = "btnXMLVeriOku";
            this.btnXMLVeriOku.Size = new System.Drawing.Size(126, 40);
            this.btnXMLVeriOku.TabIndex = 1;
            this.btnXMLVeriOku.Text = "XML dosyalarından veri oku ";
            this.btnXMLVeriOku.UseVisualStyleBackColor = true;
            this.btnXMLVeriOku.Click += new System.EventHandler(this.btnXMLVeriOku_Click);
            // 
            // btnXMLVeriBul
            // 
            this.btnXMLVeriBul.Location = new System.Drawing.Point(40, 325);
            this.btnXMLVeriBul.Name = "btnXMLVeriBul";
            this.btnXMLVeriBul.Size = new System.Drawing.Size(126, 39);
            this.btnXMLVeriBul.TabIndex = 2;
            this.btnXMLVeriBul.Text = "XML içindeki veriyi bul ";
            this.btnXMLVeriBul.UseVisualStyleBackColor = true;
            this.btnXMLVeriBul.Click += new System.EventHandler(this.btnXMLVeriBul_Click);
            // 
            // btnXpathVerileriCek
            // 
            this.btnXpathVerileriCek.Location = new System.Drawing.Point(40, 416);
            this.btnXpathVerileriCek.Name = "btnXpathVerileriCek";
            this.btnXpathVerileriCek.Size = new System.Drawing.Size(126, 39);
            this.btnXpathVerileriCek.TabIndex = 4;
            this.btnXpathVerileriCek.Text = "XML ile verileri XPath ile çek";
            this.btnXpathVerileriCek.UseVisualStyleBackColor = true;
            // 
            // btnXpathVeriCek
            // 
            this.btnXpathVeriCek.Location = new System.Drawing.Point(40, 370);
            this.btnXpathVeriCek.Name = "btnXpathVeriCek";
            this.btnXpathVeriCek.Size = new System.Drawing.Size(126, 40);
            this.btnXpathVeriCek.TabIndex = 3;
            this.btnXpathVeriCek.Text = "XML ile veriyi XPath ile çek";
            this.btnXpathVeriCek.UseVisualStyleBackColor = true;
            // 
            // btnXMLVeriSİl
            // 
            this.btnXMLVeriSİl.Location = new System.Drawing.Point(40, 507);
            this.btnXMLVeriSİl.Name = "btnXMLVeriSİl";
            this.btnXMLVeriSİl.Size = new System.Drawing.Size(126, 39);
            this.btnXMLVeriSİl.TabIndex = 6;
            this.btnXMLVeriSİl.Text = "XML\'den veri sil";
            this.btnXMLVeriSİl.UseVisualStyleBackColor = true;
            // 
            // btnXMLVeriDegistir
            // 
            this.btnXMLVeriDegistir.Location = new System.Drawing.Point(40, 461);
            this.btnXMLVeriDegistir.Name = "btnXMLVeriDegistir";
            this.btnXMLVeriDegistir.Size = new System.Drawing.Size(126, 40);
            this.btnXMLVeriDegistir.TabIndex = 5;
            this.btnXMLVeriDegistir.Text = "XML içindeki veriyi değiştir";
            this.btnXMLVeriDegistir.UseVisualStyleBackColor = true;
            // 
            // btnVTXMLOku
            // 
            this.btnVTXMLOku.Location = new System.Drawing.Point(246, 325);
            this.btnVTXMLOku.Name = "btnVTXMLOku";
            this.btnVTXMLOku.Size = new System.Drawing.Size(126, 39);
            this.btnVTXMLOku.TabIndex = 8;
            this.btnVTXMLOku.Text = "Veritabanından XML\'e oku";
            this.btnVTXMLOku.UseVisualStyleBackColor = true;
            // 
            // btnXMLVeriEkle
            // 
            this.btnXMLVeriEkle.Location = new System.Drawing.Point(246, 279);
            this.btnXMLVeriEkle.Name = "btnXMLVeriEkle";
            this.btnXMLVeriEkle.Size = new System.Drawing.Size(126, 40);
            this.btnXMLVeriEkle.TabIndex = 7;
            this.btnXMLVeriEkle.Text = "XML\'e veri ekle";
            this.btnXMLVeriEkle.UseVisualStyleBackColor = true;
            // 
            // btnXMLSchema
            // 
            this.btnXMLSchema.Location = new System.Drawing.Point(246, 416);
            this.btnXMLSchema.Name = "btnXMLSchema";
            this.btnXMLSchema.Size = new System.Drawing.Size(126, 39);
            this.btnXMLSchema.TabIndex = 10;
            this.btnXMLSchema.Text = "XML Schema terimi oluştur";
            this.btnXMLSchema.UseVisualStyleBackColor = true;
            // 
            // btnVTXMLYaz
            // 
            this.btnVTXMLYaz.Location = new System.Drawing.Point(246, 370);
            this.btnVTXMLYaz.Name = "btnVTXMLYaz";
            this.btnVTXMLYaz.Size = new System.Drawing.Size(126, 40);
            this.btnVTXMLYaz.TabIndex = 9;
            this.btnVTXMLYaz.Text = "XML\'den veritabanına yaz";
            this.btnVTXMLYaz.UseVisualStyleBackColor = true;
            // 
            // btnSchemaDogrula
            // 
            this.btnSchemaDogrula.Location = new System.Drawing.Point(246, 507);
            this.btnSchemaDogrula.Name = "btnSchemaDogrula";
            this.btnSchemaDogrula.Size = new System.Drawing.Size(126, 39);
            this.btnSchemaDogrula.TabIndex = 12;
            this.btnSchemaDogrula.Text = "XML Schema doğrulama";
            this.btnSchemaDogrula.UseVisualStyleBackColor = true;
            // 
            // btnSQLSchemaXML
            // 
            this.btnSQLSchemaXML.Location = new System.Drawing.Point(246, 461);
            this.btnSQLSchemaXML.Name = "btnSQLSchemaXML";
            this.btnSQLSchemaXML.Size = new System.Drawing.Size(126, 40);
            this.btnSQLSchemaXML.TabIndex = 11;
            this.btnSQLSchemaXML.Text = "SQL den istenen şemaya uygun XML oluştur";
            this.btnSQLSchemaXML.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(466, 15);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(322, 510);
            this.webBrowser1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnSchemaDogrula);
            this.Controls.Add(this.btnSQLSchemaXML);
            this.Controls.Add(this.btnXMLSchema);
            this.Controls.Add(this.btnVTXMLYaz);
            this.Controls.Add(this.btnVTXMLOku);
            this.Controls.Add(this.btnXMLVeriEkle);
            this.Controls.Add(this.btnXMLVeriSİl);
            this.Controls.Add(this.btnXMLVeriDegistir);
            this.Controls.Add(this.btnXpathVerileriCek);
            this.Controls.Add(this.btnXpathVeriCek);
            this.Controls.Add(this.btnXMLVeriBul);
            this.Controls.Add(this.btnXMLVeriOku);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXMLVeriOku;
        private System.Windows.Forms.Button btnXMLVeriBul;
        private System.Windows.Forms.Button btnXpathVerileriCek;
        private System.Windows.Forms.Button btnXpathVeriCek;
        private System.Windows.Forms.Button btnXMLVeriSİl;
        private System.Windows.Forms.Button btnXMLVeriDegistir;
        private System.Windows.Forms.Button btnVTXMLOku;
        private System.Windows.Forms.Button btnXMLVeriEkle;
        private System.Windows.Forms.Button btnXMLSchema;
        private System.Windows.Forms.Button btnVTXMLYaz;
        private System.Windows.Forms.Button btnSchemaDogrula;
        private System.Windows.Forms.Button btnSQLSchemaXML;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

