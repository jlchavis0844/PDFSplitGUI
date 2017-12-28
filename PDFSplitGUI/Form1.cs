using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections.Generic;

namespace PDFSplitComplete {
    public partial class Form1 : Form {
        public static PdfReader reader;
        public static List<string> outFiles;
        public static PDFSplit split;

        /// <summary>
        /// initialization
        /// </summary>
        public Form1() {
            InitializeComponent();
            outFiles = new List<string>();
        }

        /// <summary>
        /// Loads PDF file and populates start and end comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = @"P:\RALFG\Common Files\Commissions & Insurance\Commission Statements\" + 
                DateTime.Now.Year.ToString() + @"\LSW Ann\";
            if (fd.ShowDialog() == DialogResult.OK) {
                lblSourcePath.Text = fd.FileName;
                lblOutPath.Text = Path.GetDirectoryName(fd.FileName);
                btnViewPDF.Visible = true;
                reader = new PdfReader(lblSourcePath.Text);

                for (int i = 1; i <= reader.NumberOfPages; i++) {
                    cboStart.Items.Add(i);
                }
                btnGO.Visible = true;
                btnViewPDF.Visible = true;
            }
        }

        /// <summary>
        /// When the starting page number is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStart_SelectedIndexChanged(object sender, EventArgs e) {
            cboEnd.Visible = true;
            cboEnd.Items.Clear();
            int curr = Convert.ToInt32(cboStart.SelectedItem);
            for (int i = curr; i <= reader.NumberOfPages; i++) {
                cboEnd.Items.Add(i);
            }
        }

        /// <summary>
        /// Opens the pdf after being loaded. Calls Process.Start()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewPDF_Click(object sender, EventArgs e) {
            if (lblSourcePath.Text != null && lblSourcePath.Text != "") {
                System.Diagnostics.Process.Start(lblSourcePath.Text);
            }
        }

        /// <summary>
        /// When the starting page for the Advanced Portition is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStartA_TextUpdate(object sender, EventArgs e) {
            cboEndA.Items.Clear();
            int curr = Convert.ToInt32(cboStartA.SelectedItem);
            for (int i = curr; i <= reader.NumberOfPages; i++) {
                cboEndA.Items.Add(i);
            }
        }

        /// <summary>
        /// When the ending page number is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEnd_TextUpdate(object sender, EventArgs e) {
            cboStartA.Items.Clear();
            int curr = Convert.ToInt32(cboEnd.SelectedItem)+1;
            for (int i = curr; i <= reader.NumberOfPages; i++) {
                cboStartA.Items.Add(i);
            }
        }

        /// <summary>
        /// Calls cboEnd_TextUpdate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboEnd_SelectedIndexChanged(object sender, EventArgs e) {
                cboEnd_TextUpdate(sender, e);
        }

        /// <summary>
        /// Calls cboStartA_TextUpdate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboStartA_SelectedIndexChanged(object sender, EventArgs e) {
            cboStartA_TextUpdate(sender, e);
        }

        /// <summary>
        /// When the rotation number is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbRotate_CheckedChanged(object sender, EventArgs e) {
            if(txtRotate.Text == "" || txtRotate.Text == null) {
                txtRotate.Text = "90";
            }
        }

        /// <summary>
        /// Starts the splitting process.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGO_Click(object sender, EventArgs e) {
            lblStatus.Text = "";
            if(cboStart.SelectedText == null ||
                lblSourcePath.Text == "") {
                return;
            }

            var startA = cboStartA.SelectedItem;
            var endA = cboEndA.SelectedItem;

            if (startA == null || endA == null ||
                startA.ToString() == "" || endA.ToString() == "") {
                cbAdv.Checked = false;
            }

            List<string> myParams = new List<string>();
            myParams.Add(lblSourcePath.Text);
            myParams.Add(Convert.ToString(lblOutPath.Text));
            myParams.Add(Convert.ToString(cboStart.SelectedItem));
            myParams.Add(Convert.ToString(cboEnd.SelectedItem));
            myParams.Add("comm");
            myParams.Add("0");

            if (cbAdv.Checked) {
                myParams.Add(Convert.ToString(cboStartA.SelectedItem));
                myParams.Add(Convert.ToString(cboEndA.SelectedItem));
                myParams.Add("adv");

                if (txtRotate.Text == "" || txtRotate.Text == null) {
                    myParams.Add("90");
                } else {
                    myParams.Add(txtRotate.Text);
                }
            }
            split = new PDFSplit(myParams.ToArray());
            lblStatus.Text += " - DONE!";
            btnViewOut.Visible = true;
        }

        /// <summary>
        /// Opens all the previously created PDF files from the split.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewOut_Click(object sender, EventArgs e) {
            //start all outfiles
            split.GetOutFiles().ForEach(file => System.Diagnostics.Process.Start(file));
        }

        /// <summary>
        /// Sets the output path to the desktop.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                lblOutPath.Text = fbd.SelectedPath;
            }
        }
    }
}
