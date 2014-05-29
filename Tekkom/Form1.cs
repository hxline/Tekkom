using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekkom
{
    public partial class Form1 : Form
    {
        private tekkomEntities db = new tekkomEntities();
        private string isiSub = "";
        private string isiPre = "";
        private string isiObj = "";
        private string isiPel = "";
        private int subPos;
        private int prePos;
        private int objPos;
        private int pelPos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var sub = (from table in db.subjek select table.subjek1).ToList();
            var pre = (from table in db.predikat select table.predikat1).ToList();
            var obj = (from table in db.objek select table.objek1).ToList();
            var pel = (from table in db.pelengkap select table.pel).ToList();
            int pos = 0;

            string[] kalimat = textBoxInput.Text.Split(' ');
            
            foreach (string kal in kalimat)
            {
                pos++;

                if (sub.Contains(kal.ToLower()))
                {
                    isiSub = kal;
                    subPos = pos;
                }
                else if (pre.Contains(kal.ToLower()))
                {
                    isiPre = kal;
                    prePos = pos;
                }
                else if (obj.Contains(kal.ToLower()))
                {
                    isiObj = kal;
                    objPos = pos;
                }
                else if (pel.Contains(kal.ToLower()))
                {
                    isiPel = kal;
                    pelPos = pos;
                }
            }

            if (pos == 4)
            {
                if (subPos == 1 && prePos == 2 && objPos == 3 && pelPos == 4)
                {
                    MessageBox.Show("Pola kalimat anda S-P-O-Pel", "Benar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kode kesalahan 03 : Pola kalimat S-P-O-Pel salah", "Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (pos == 3)
            {
                if (subPos == 1 && prePos == 2 && objPos == 3)
                {
                    MessageBox.Show("Pola kalimat anda S-P-O", "Benar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kode kesalahan 02 : Pola kalimat S-P-O salah", "Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kode kesalahan 01 : Kalimat anda salah atau kata tidak ada dalam kamus","Salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            labelSub.Text = isiSub;
            labelPre.Text = isiPre;
            labelObj.Text = isiObj;
            labelPel.Text = isiPel;

            isiSub = "";
            isiPre = "";
            isiObj = "";
            isiPel = "";
            subPos = 0;
            prePos = 0;
            objPos = 0;
            pelPos = 0;
        }
    }
}
