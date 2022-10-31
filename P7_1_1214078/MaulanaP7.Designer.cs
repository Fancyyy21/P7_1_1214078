namespace P7_1_1214078
{
    partial class MaulanaP7
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaulanaP7));
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Kurikulum = new System.Windows.Forms.GroupBox();
            this.Kurikulum2014 = new System.Windows.Forms.RadioButton();
            this.Kurikulum2010 = new System.Windows.Forms.RadioButton();
            this.Kurikulum2006 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.ProgramStudi = new System.Windows.Forms.Label();
            this.TahunAkademik = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.Label();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.NIM = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.MataKuliah = new System.Windows.Forms.GroupBox();
            this.ManajemenRantaiPasok = new System.Windows.Forms.CheckBox();
            this.JaringanKomputer = new System.Windows.Forms.CheckBox();
            this.SistemOperasi = new System.Windows.Forms.CheckBox();
            this.PengantarLogistik = new System.Windows.Forms.CheckBox();
            this.Pemrograman7 = new System.Windows.Forms.CheckBox();
            this.Pemrograman5 = new System.Windows.Forms.CheckBox();
            this.Pemrograman6 = new System.Windows.Forms.CheckBox();
            this.Pemrograman4 = new System.Windows.Forms.CheckBox();
            this.Pemrograman3 = new System.Windows.Forms.CheckBox();
            this.Pemrograman1 = new System.Windows.Forms.CheckBox();
            this.Pemrograman2 = new System.Windows.Forms.CheckBox();
            this.Matematika = new System.Windows.Forms.CheckBox();
            this.PilihMataKuliah = new System.Windows.Forms.Button();
            this.Simpan = new System.Windows.Forms.Button();
            this.Batal = new System.Windows.Forms.Button();
            this.Laki = new System.Windows.Forms.RadioButton();
            this.Perempuan = new System.Windows.Forms.RadioButton();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.Kurikulum.SuspendLayout();
            this.MataKuliah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(319, 105);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(100, 22);
            this.txtNIM.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Teknik Informatika"});
            this.comboBox1.Location = new System.Drawing.Point(887, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // Kurikulum
            // 
            this.Kurikulum.Controls.Add(this.Kurikulum2014);
            this.Kurikulum.Controls.Add(this.Kurikulum2010);
            this.Kurikulum.Controls.Add(this.Kurikulum2006);
            this.Kurikulum.Location = new System.Drawing.Point(85, 420);
            this.Kurikulum.Name = "Kurikulum";
            this.Kurikulum.Size = new System.Drawing.Size(375, 241);
            this.Kurikulum.TabIndex = 4;
            this.Kurikulum.TabStop = false;
            this.Kurikulum.Text = "Kurikulum Pilihan";
            // 
            // Kurikulum2014
            // 
            this.Kurikulum2014.AutoSize = true;
            this.Kurikulum2014.Location = new System.Drawing.Point(18, 121);
            this.Kurikulum2014.Name = "Kurikulum2014";
            this.Kurikulum2014.Size = new System.Drawing.Size(113, 20);
            this.Kurikulum2014.TabIndex = 7;
            this.Kurikulum2014.TabStop = true;
            this.Kurikulum2014.Text = "Kurikulum2014";
            this.Kurikulum2014.UseVisualStyleBackColor = true;
            this.Kurikulum2014.CheckedChanged += new System.EventHandler(this.Kurikulum2014_CheckedChanged);
            // 
            // Kurikulum2010
            // 
            this.Kurikulum2010.AutoSize = true;
            this.Kurikulum2010.Location = new System.Drawing.Point(18, 76);
            this.Kurikulum2010.Name = "Kurikulum2010";
            this.Kurikulum2010.Size = new System.Drawing.Size(116, 20);
            this.Kurikulum2010.TabIndex = 6;
            this.Kurikulum2010.TabStop = true;
            this.Kurikulum2010.Text = "Kurikulum 2010";
            this.Kurikulum2010.UseVisualStyleBackColor = true;
            this.Kurikulum2010.CheckedChanged += new System.EventHandler(this.Kurikulum2010_CheckedChanged);
            // 
            // Kurikulum2006
            // 
            this.Kurikulum2006.AutoSize = true;
            this.Kurikulum2006.Location = new System.Drawing.Point(18, 30);
            this.Kurikulum2006.Name = "Kurikulum2006";
            this.Kurikulum2006.Size = new System.Drawing.Size(116, 20);
            this.Kurikulum2006.TabIndex = 5;
            this.Kurikulum2006.TabStop = true;
            this.Kurikulum2006.Text = "Kurikulum 2006";
            this.Kurikulum2006.UseVisualStyleBackColor = true;
            this.Kurikulum2006.CheckedChanged += new System.EventHandler(this.Kurikulum2006_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "PILIHAN MATA KULIAH MAHASISWA";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(319, 144);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(100, 22);
            this.txtNama.TabIndex = 6;
            // 
            // ProgramStudi
            // 
            this.ProgramStudi.AutoSize = true;
            this.ProgramStudi.Location = new System.Drawing.Point(751, 100);
            this.ProgramStudi.Name = "ProgramStudi";
            this.ProgramStudi.Size = new System.Drawing.Size(92, 16);
            this.ProgramStudi.TabIndex = 7;
            this.ProgramStudi.Text = "Program Studi";
            // 
            // TahunAkademik
            // 
            this.TahunAkademik.AutoSize = true;
            this.TahunAkademik.Location = new System.Drawing.Point(751, 150);
            this.TahunAkademik.Name = "TahunAkademik";
            this.TahunAkademik.Size = new System.Drawing.Size(109, 16);
            this.TahunAkademik.TabIndex = 8;
            this.TahunAkademik.Text = "Tahun Akademik";
            // 
            // Semester
            // 
            this.Semester.AutoSize = true;
            this.Semester.Location = new System.Drawing.Point(751, 198);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(65, 16);
            this.Semester.TabIndex = 9;
            this.Semester.Text = "Semester";
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(887, 147);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(100, 22);
            this.txtTA.TabIndex = 10;
            this.txtTA.TextChanged += new System.EventHandler(this.txtTA_TextChanged);
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(887, 195);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(100, 22);
            this.txtSemester.TabIndex = 11;
            this.txtSemester.TextChanged += new System.EventHandler(this.txtSemester_TextChanged);
            // 
            // NIM
            // 
            this.NIM.AutoSize = true;
            this.NIM.Location = new System.Drawing.Point(205, 105);
            this.NIM.Name = "NIM";
            this.NIM.Size = new System.Drawing.Size(31, 16);
            this.NIM.TabIndex = 12;
            this.NIM.Text = "NIM";
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Location = new System.Drawing.Point(205, 153);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(44, 16);
            this.Nama.TabIndex = 13;
            this.Nama.Text = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(204, 201);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(90, 16);
            this.JenisKelamin.TabIndex = 14;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Alamat";
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(318, 244);
            this.Alamat.Multiline = true;
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(233, 64);
            this.Alamat.TabIndex = 17;
            // 
            // MataKuliah
            // 
            this.MataKuliah.Controls.Add(this.ManajemenRantaiPasok);
            this.MataKuliah.Controls.Add(this.JaringanKomputer);
            this.MataKuliah.Controls.Add(this.SistemOperasi);
            this.MataKuliah.Controls.Add(this.PengantarLogistik);
            this.MataKuliah.Controls.Add(this.Pemrograman7);
            this.MataKuliah.Controls.Add(this.Pemrograman5);
            this.MataKuliah.Controls.Add(this.Pemrograman6);
            this.MataKuliah.Controls.Add(this.Pemrograman4);
            this.MataKuliah.Controls.Add(this.Pemrograman3);
            this.MataKuliah.Controls.Add(this.Pemrograman1);
            this.MataKuliah.Controls.Add(this.Pemrograman2);
            this.MataKuliah.Controls.Add(this.Matematika);
            this.MataKuliah.Location = new System.Drawing.Point(557, 415);
            this.MataKuliah.Name = "MataKuliah";
            this.MataKuliah.Size = new System.Drawing.Size(681, 246);
            this.MataKuliah.TabIndex = 6;
            this.MataKuliah.TabStop = false;
            this.MataKuliah.Text = "MataKuliah Pilihan";
            this.MataKuliah.Enter += new System.EventHandler(this.MataKuliah_Enter);
            // 
            // ManajemenRantaiPasok
            // 
            this.ManajemenRantaiPasok.AutoSize = true;
            this.ManajemenRantaiPasok.Enabled = false;
            this.ManajemenRantaiPasok.Location = new System.Drawing.Point(454, 162);
            this.ManajemenRantaiPasok.Name = "ManajemenRantaiPasok";
            this.ManajemenRantaiPasok.Size = new System.Drawing.Size(184, 20);
            this.ManajemenRantaiPasok.TabIndex = 16;
            this.ManajemenRantaiPasok.Text = "Manajemen Rantai Pasok";
            this.ManajemenRantaiPasok.UseVisualStyleBackColor = true;
            // 
            // JaringanKomputer
            // 
            this.JaringanKomputer.AutoSize = true;
            this.JaringanKomputer.Enabled = false;
            this.JaringanKomputer.Location = new System.Drawing.Point(454, 82);
            this.JaringanKomputer.Name = "JaringanKomputer";
            this.JaringanKomputer.Size = new System.Drawing.Size(141, 20);
            this.JaringanKomputer.TabIndex = 15;
            this.JaringanKomputer.Text = "Jaringan Komputer";
            this.JaringanKomputer.UseVisualStyleBackColor = true;
            // 
            // SistemOperasi
            // 
            this.SistemOperasi.AutoSize = true;
            this.SistemOperasi.Enabled = false;
            this.SistemOperasi.Location = new System.Drawing.Point(454, 121);
            this.SistemOperasi.Name = "SistemOperasi";
            this.SistemOperasi.Size = new System.Drawing.Size(121, 20);
            this.SistemOperasi.TabIndex = 14;
            this.SistemOperasi.Text = "Sistem Operasi";
            this.SistemOperasi.UseVisualStyleBackColor = true;
            // 
            // PengantarLogistik
            // 
            this.PengantarLogistik.AutoSize = true;
            this.PengantarLogistik.Enabled = false;
            this.PengantarLogistik.Location = new System.Drawing.Point(454, 44);
            this.PengantarLogistik.Name = "PengantarLogistik";
            this.PengantarLogistik.Size = new System.Drawing.Size(140, 20);
            this.PengantarLogistik.TabIndex = 13;
            this.PengantarLogistik.Text = "Pengantar Logistik";
            this.PengantarLogistik.UseVisualStyleBackColor = true;
            // 
            // Pemrograman7
            // 
            this.Pemrograman7.AutoSize = true;
            this.Pemrograman7.Enabled = false;
            this.Pemrograman7.Location = new System.Drawing.Point(227, 162);
            this.Pemrograman7.Name = "Pemrograman7";
            this.Pemrograman7.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman7.TabIndex = 12;
            this.Pemrograman7.Text = "Pemrograman7";
            this.Pemrograman7.UseVisualStyleBackColor = true;
            // 
            // Pemrograman5
            // 
            this.Pemrograman5.AutoSize = true;
            this.Pemrograman5.Enabled = false;
            this.Pemrograman5.Location = new System.Drawing.Point(227, 82);
            this.Pemrograman5.Name = "Pemrograman5";
            this.Pemrograman5.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman5.TabIndex = 11;
            this.Pemrograman5.Text = "Pemrograman5";
            this.Pemrograman5.UseVisualStyleBackColor = true;
            // 
            // Pemrograman6
            // 
            this.Pemrograman6.AutoSize = true;
            this.Pemrograman6.Enabled = false;
            this.Pemrograman6.Location = new System.Drawing.Point(227, 121);
            this.Pemrograman6.Name = "Pemrograman6";
            this.Pemrograman6.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman6.TabIndex = 10;
            this.Pemrograman6.Text = "Pemrograman6";
            this.Pemrograman6.UseVisualStyleBackColor = true;
            // 
            // Pemrograman4
            // 
            this.Pemrograman4.AutoSize = true;
            this.Pemrograman4.Enabled = false;
            this.Pemrograman4.Location = new System.Drawing.Point(227, 44);
            this.Pemrograman4.Name = "Pemrograman4";
            this.Pemrograman4.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman4.TabIndex = 9;
            this.Pemrograman4.Text = "Pemrograman4";
            this.Pemrograman4.UseVisualStyleBackColor = true;
            // 
            // Pemrograman3
            // 
            this.Pemrograman3.AutoSize = true;
            this.Pemrograman3.Enabled = false;
            this.Pemrograman3.Location = new System.Drawing.Point(16, 162);
            this.Pemrograman3.Name = "Pemrograman3";
            this.Pemrograman3.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman3.TabIndex = 8;
            this.Pemrograman3.Text = "Pemrograman3";
            this.Pemrograman3.UseVisualStyleBackColor = true;
            // 
            // Pemrograman1
            // 
            this.Pemrograman1.AutoSize = true;
            this.Pemrograman1.Enabled = false;
            this.Pemrograman1.Location = new System.Drawing.Point(16, 82);
            this.Pemrograman1.Name = "Pemrograman1";
            this.Pemrograman1.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman1.TabIndex = 7;
            this.Pemrograman1.Text = "Pemrograman1";
            this.Pemrograman1.UseVisualStyleBackColor = true;
            // 
            // Pemrograman2
            // 
            this.Pemrograman2.AutoSize = true;
            this.Pemrograman2.Enabled = false;
            this.Pemrograman2.Location = new System.Drawing.Point(16, 121);
            this.Pemrograman2.Name = "Pemrograman2";
            this.Pemrograman2.Size = new System.Drawing.Size(122, 20);
            this.Pemrograman2.TabIndex = 6;
            this.Pemrograman2.Text = "Pemrograman2";
            this.Pemrograman2.UseVisualStyleBackColor = true;
            // 
            // Matematika
            // 
            this.Matematika.AutoSize = true;
            this.Matematika.Enabled = false;
            this.Matematika.Location = new System.Drawing.Point(16, 44);
            this.Matematika.Name = "Matematika";
            this.Matematika.Size = new System.Drawing.Size(99, 20);
            this.Matematika.TabIndex = 5;
            this.Matematika.Text = "Matematika";
            this.Matematika.UseVisualStyleBackColor = true;
            // 
            // PilihMataKuliah
            // 
            this.PilihMataKuliah.Location = new System.Drawing.Point(887, 244);
            this.PilihMataKuliah.Name = "PilihMataKuliah";
            this.PilihMataKuliah.Size = new System.Drawing.Size(152, 39);
            this.PilihMataKuliah.TabIndex = 18;
            this.PilihMataKuliah.Text = "Pilih Mata Kuliah";
            this.PilihMataKuliah.UseVisualStyleBackColor = true;
            this.PilihMataKuliah.Click += new System.EventHandler(this.PilihMataKuliah_Click);
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(348, 689);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(75, 23);
            this.Simpan.TabIndex = 19;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Batal
            // 
            this.Batal.Location = new System.Drawing.Point(701, 689);
            this.Batal.Name = "Batal";
            this.Batal.Size = new System.Drawing.Size(75, 23);
            this.Batal.TabIndex = 20;
            this.Batal.Text = "Batal";
            this.Batal.UseVisualStyleBackColor = true;
            this.Batal.Click += new System.EventHandler(this.Batal_Click);
            // 
            // Laki
            // 
            this.Laki.AutoSize = true;
            this.Laki.Location = new System.Drawing.Point(318, 201);
            this.Laki.Name = "Laki";
            this.Laki.Size = new System.Drawing.Size(82, 20);
            this.Laki.TabIndex = 8;
            this.Laki.TabStop = true;
            this.Laki.Text = "Laki-Laki";
            this.Laki.UseVisualStyleBackColor = true;
            // 
            // Perempuan
            // 
            this.Perempuan.AutoSize = true;
            this.Perempuan.Location = new System.Drawing.Point(420, 201);
            this.Perempuan.Name = "Perempuan";
            this.Perempuan.Size = new System.Drawing.Size(98, 20);
            this.Perempuan.TabIndex = 21;
            this.Perempuan.TabStop = true;
            this.Perempuan.Text = "Perempuan";
            this.Perempuan.UseVisualStyleBackColor = true;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // MaulanaP7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 743);
            this.Controls.Add(this.Perempuan);
            this.Controls.Add(this.Laki);
            this.Controls.Add(this.Batal);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.PilihMataKuliah);
            this.Controls.Add(this.MataKuliah);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.NIM);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.TahunAkademik);
            this.Controls.Add(this.ProgramStudi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kurikulum);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNIM);
            this.Name = "MaulanaP7";
            this.Text = "Form1";
            this.Kurikulum.ResumeLayout(false);
            this.Kurikulum.PerformLayout();
            this.MataKuliah.ResumeLayout(false);
            this.MataKuliah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox Kurikulum;
        private System.Windows.Forms.RadioButton Kurikulum2006;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label ProgramStudi;
        private System.Windows.Forms.Label TahunAkademik;
        private System.Windows.Forms.Label Semester;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label NIM;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.RadioButton Kurikulum2014;
        private System.Windows.Forms.RadioButton Kurikulum2010;
        private System.Windows.Forms.GroupBox MataKuliah;
        private System.Windows.Forms.CheckBox ManajemenRantaiPasok;
        private System.Windows.Forms.CheckBox JaringanKomputer;
        private System.Windows.Forms.CheckBox SistemOperasi;
        private System.Windows.Forms.CheckBox PengantarLogistik;
        private System.Windows.Forms.CheckBox Pemrograman7;
        private System.Windows.Forms.CheckBox Pemrograman5;
        private System.Windows.Forms.CheckBox Pemrograman6;
        private System.Windows.Forms.CheckBox Pemrograman4;
        private System.Windows.Forms.CheckBox Pemrograman3;
        private System.Windows.Forms.CheckBox Pemrograman1;
        private System.Windows.Forms.CheckBox Pemrograman2;
        private System.Windows.Forms.CheckBox Matematika;
        private System.Windows.Forms.Button PilihMataKuliah;
        private System.Windows.Forms.Button Simpan;
        private System.Windows.Forms.Button Batal;
        private System.Windows.Forms.RadioButton Laki;
        private System.Windows.Forms.RadioButton Perempuan;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

