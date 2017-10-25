using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;

namespace PDFSplitGUI {
    public partial class Form1 : Form {
        public static PdfReader reader;

        public Form1() {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK) {
                lblSourcePath.Text = fd.FileName;
                btnViewPDF.Visible = true;
                reader = new PdfReader(lblSourcePath.Text);

                for (int i = 1; i <= reader.NumberOfPages; i++) {
                    cboStart.Items.Add(i);
                }
                btnGO.Visible = true;
                btnViewPDF.Visible = true;
            }
        }

        private void cboStart_TextUpdate(object sender, EventArgs e) {
            Console.WriteLine("test");
        }

        private void cboStart_SelectedIndexChanged(object sender, EventArgs e) {
            cboEnd.Visible = true;
            cboEnd.Items.Clear();
            int curr = Convert.ToInt32(cboStart.SelectedItem);
            for (int i = curr; i <= reader.NumberOfPages; i++) {
                cboEnd.Items.Add(i);
            }
        }

        private void btnViewPDF_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(lblSourcePath.Text);
        }

        private void cboStartA_TextUpdate(object sender, EventArgs e) {
            cboEndA.Items.Clear();
            int curr = Convert.ToInt32(cboStartA.SelectedItem);
            for (int i = curr; i <= reader.NumberOfPages; i++) {
                cboEndA.Items.Add(i);
            }
        }

        private void cboEnd_TextUpdate(object sender, EventArgs e) {
            cboStartA.Items.Clear();
            int curr = Convert.ToInt32(cboEnd.SelectedItem)+1;
            for (int i = curr; i <= reader.NumberOfPages; i++) {
                cboStartA.Items.Add(i);
            }

        }

        private void cboEnd_SelectedIndexChanged(object sender, EventArgs e) {
                cboEnd_TextUpdate(sender, e);
        }

        private void cboStartA_SelectedIndexChanged(object sender, EventArgs e) {
            cboStartA_TextUpdate(sender, e);
        }

        private void cboEndA_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void cbRotate_CheckedChanged(object sender, EventArgs e) {
            if(txtRotate.Text == "" || txtRotate.Text == null) {
                txtRotate.Text = "90";
            }
        }

        private void btnGO_Click(object sender, EventArgs e) {
           // string command = "PDFSplitter.exe ";
            string command = "\""+ lblSourcePath.Text + "\" ";
            command += Convert.ToString(cboStart.SelectedItem) + " ";
            command += Convert.ToString(cboEnd.SelectedItem) + " comm 0";
            if (cbAdv.Checked) {
                command +=" " + Convert.ToString(cboStartA.SelectedItem) + " ";
                command += Convert.ToString(cboEndA.SelectedItem) + " adv ";
                if(txtRotate.Text == "" || txtRotate.Text == null) {
                    command += "90";
                } else {
                    command += txtRotate.Text;
                }
            }
            lblStatus.Text = command;
            var temp = System.Diagnostics.Process.Start(".\\PDFSplitter.exe",command);
            lblStatus.Text += " - DONE!";
            btnViewOut.Visible = true;
        }

        private void cbAdv_CheckedChanged(object sender, EventArgs e) {
           
        }

        private void btnViewOut_Click(object sender, EventArgs e) {
            string path = Path.GetDirectoryName(lblSourcePath.Text);
            string ext = Path.GetExtension(lblSourcePath.Text);
            string fileName = Path.GetFileNameWithoutExtension(lblSourcePath.Text);

            System.Diagnostics.Process.Start(path + "\\" + fileName + "_comm" + ext);
            System.Diagnostics.Process.Start(path + "\\" + fileName + "_adv" + ext);

        }
    }
}
