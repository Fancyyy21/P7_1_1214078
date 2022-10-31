using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace P7_1_1214078
{
    public partial class MaulanaP7 : Form
    {
        public MaulanaP7()
        {
            InitializeComponent();
            this.Size = new Size(1123, 360);
        }

        private void PilihMataKuliah_Click(object sender, EventArgs e)
        {
            if (txtNIM.Text != "")
            {
                if (txtNama.Text != "")
                {
                    if (Laki.Checked || Perempuan.Checked)
                    {
                        if (Alamat.Text != "")
                        {
                            if (comboBox1.GetItemText(comboBox1.SelectedItem) != "")
                            {
                                if (txtTA.Text != "" && Regex.IsMatch(txtTA.Text, @"^\d{4}/\d{4}$"))
                                {
                                    if (txtSemester.Text != "" && (txtSemester.Text).All(Char.IsNumber))
                                    {
                                        MessageBox.Show
                                    ("LENGKAP!!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        this.Size = new Size(1280, 790); 

                                    }
                                    else
                                    {
                                        MessageBox.Show
                                    ("Semester Belum Diisi!!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                ("Tahun Akademik Belum Diisi!!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                            ("Program Studi Belum Diisi!!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                        ("Alamat Belum Diisi!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                    ("Jenis Kelamin Belum Diisi!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                ("Nama Belum Diisi!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                ("NIM Belum Diisi!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
    }

        private void txtTA_TextChanged(object sender, EventArgs e)
        {
            if (txtTA.Text == "")
            {
                epWarning.SetError(txtTA, "Textbox Tahun Akademik tidak boleh kosong");
                epWrong.SetError(txtTA, "");
                epCorrect.SetError(txtTA, "");
            }
            else
            {
                if (Regex.IsMatch(txtTA.Text, @"^\d{4}/\d{4}$"))
                {
                    epWarning.SetError(txtTA, "");
                    epWrong.SetError(txtTA, "");
                    epCorrect.SetError(txtTA, "Betul");
                }
                else
                {
                    epWarning.SetError(txtTA, "Format Tahun Akademik salah!\nContoh: nnnn/nnnn");
                    epWrong.SetError(txtTA, "");
                    epCorrect.SetError(txtTA, "");
                }
            }
        }

        private void txtSemester_TextChanged(object sender, EventArgs e)
        {
            if (txtSemester.Text == "")
            {
                epCorrect.SetError(txtSemester, "");
                epWarning.SetError(txtSemester, "Textbox Semester tidak boleh kosong");
                epWrong.SetError(txtSemester, "");
            }
            else
            {
                if ((txtSemester.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtSemester, "Betul");
                    epWarning.SetError(txtSemester, "");
                    epWrong.SetError(txtSemester, "");
                }
                else
                {
                    epCorrect.SetError(txtSemester, "");
                    epWarning.SetError(txtSemester, "");
                    epWrong.SetError(txtSemester, "Inputan hanya boleh angka!");
                }
            }
        }

        private void Kurikulum2006_CheckedChanged(object sender, EventArgs e)
        {
            if (Kurikulum2006.Checked)
            {
                Matematika.Enabled = true; 
                Pemrograman1.Enabled = true;
                Pemrograman2.Enabled = true;
                Pemrograman3.Enabled = true;
                Pemrograman4.Enabled = true;
                Pemrograman5.Enabled = true;
                Pemrograman6.Enabled = true;
                Pemrograman7.Enabled = true;
                PengantarLogistik.Enabled = false;
                JaringanKomputer.Enabled = true;
                SistemOperasi.Enabled = true;
                ManajemenRantaiPasok.Enabled = false;
            }
        }

        private void Kurikulum2010_CheckedChanged(object sender, EventArgs e)
        {
            if (Kurikulum2010.Checked)
            {
                Matematika.Enabled = false;
                Pemrograman1.Enabled = true;
                Pemrograman2.Enabled = true;
                Pemrograman3.Enabled = true;
                Pemrograman4.Enabled = true;
                Pemrograman5.Enabled = true;
                Pemrograman6.Enabled = true;
                Pemrograman7.Enabled = true;
                PengantarLogistik.Enabled = false;
                JaringanKomputer.Enabled = true;
                SistemOperasi.Enabled = true;
                ManajemenRantaiPasok.Enabled = true;
            }
        }

        private void Kurikulum2014_CheckedChanged(object sender, EventArgs e)
        {
            if (Kurikulum2014.Checked)
            {
                Matematika.Enabled = false;
                Pemrograman1.Enabled = true;
                Pemrograman2.Enabled = true;
                Pemrograman3.Enabled = true;
                Pemrograman4.Enabled = true;
                Pemrograman5.Enabled = true;
                Pemrograman6.Enabled = true;
                Pemrograman7.Enabled = true;
                PengantarLogistik.Enabled = true;
                JaringanKomputer.Enabled = true;
                SistemOperasi.Enabled = true;
                ManajemenRantaiPasok.Enabled = false;
            }
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            string Kurikulum = "";
            string MataKuliah = null;

            if (Kurikulum2006.Checked)
            {
                Kurikulum += Kurikulum2006.Text;
            }
            if (Kurikulum2010.Checked)
            {
                Kurikulum += Kurikulum2010.Text;
            }
            if (Kurikulum2014.Checked)
            {
                Kurikulum += Kurikulum2014.Text;
            }
            
            
            if (Kurikulum == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan Kurikulum", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           

            if (Matematika.Checked)
            {
                MataKuliah += Matematika.Text + ", ";
            }
            if (Pemrograman1.Checked)
            {
                MataKuliah += Pemrograman1.Text + ", ";
            }
            if (Pemrograman2.Checked)
            {
                MataKuliah += Pemrograman2.Text + ", ";
            }
            if (Pemrograman3.Checked)
            {
                MataKuliah += Pemrograman3.Text + ", ";
            }
            if (Pemrograman4.Checked)
            {
                MataKuliah += Pemrograman4.Text + ", ";
            }
            if (Pemrograman5.Checked)
            {
                MataKuliah += Pemrograman5.Text + ", ";
            }
            if (Pemrograman6.Checked)
            {
                MataKuliah += Pemrograman6.Text + ", ";
            }
            if (Pemrograman7.Checked)
            {
                MataKuliah += Pemrograman7.Text + ", ";
            }
            if (PengantarLogistik.Checked)
            {
                MataKuliah += PengantarLogistik.Text + ", ";
            }
            if (JaringanKomputer.Checked)
            {
                MataKuliah += JaringanKomputer.Text + ", ";
            }
            if (SistemOperasi.Checked)
            {
                MataKuliah += SistemOperasi.Text + ", ";
            }
            if (ManajemenRantaiPasok.Checked)
            {
                MataKuliah += ManajemenRantaiPasok.Text + ", ";
            }

            string jk = null;
            if (Laki.Checked)
            {
                jk = Laki.Text;
            }
            else
            {
                jk = Perempuan.Text;
            }

            {
                MessageBox.Show
                        ("NIM : " + txtNIM.Text +
                        "\nNama : " + txtNama.Text +
                        "\nJenis Kelamin : " + jk +
                        "\nAlamat : " + Alamat.Text +
                        "\nProgram Studi: " + comboBox1.Text +
                        "\nTahun Akademik : " + txtTA.Text +
                        "\nSemester : " + txtSemester.Text +
                        "\n------------------------------------------------"+
                        "\nKurikulum Pilihan: " + Kurikulum +
                        "\nMataKuliah Pilihan : " + MataKuliah,
                       

                        "Informasi Formulir",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Batal_Click(object sender, EventArgs e)
        {
            txtNIM.Text = null;
            txtNama.Text = null;
            Laki.Checked = false;
            Perempuan.Checked = false;
            Alamat.Text = null;
            comboBox1.Text = null;
            txtTA.Text = null;
            txtSemester.Text = null;

            Kurikulum2006.Checked = false;
            Kurikulum2010.Checked = false;
            Kurikulum2014.Checked = false;

            Matematika.Checked = false;
            Pemrograman1.Checked = false;
            Pemrograman2.Checked = false;
            Pemrograman3.Checked = false;
            Pemrograman4.Checked = false;
            Pemrograman5.Checked = false;
            Pemrograman6.Checked = false;
            Pemrograman7.Checked = false;
            PengantarLogistik.Checked = false;
            JaringanKomputer.Checked = false;
            SistemOperasi.Checked = false;
            ManajemenRantaiPasok.Checked = false;

            this.Size = new Size(1123, 360);

        }
        private void MataKuliah_Enter(object sender, EventArgs e)
        {

        }
    }
}
