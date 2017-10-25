namespace PDFSplitGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.btnViewPDF = new System.Windows.Forms.Button();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.cboEndA = new System.Windows.Forms.ComboBox();
            this.cboStartA = new System.Windows.Forms.ComboBox();
            this.lblCommPages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdv = new System.Windows.Forms.Label();
            this.cbRotate = new System.Windows.Forms.CheckBox();
            this.txtRotate = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.cbAdv = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnViewOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(98, 24);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Source";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.AutoSize = true;
            this.lblSourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourcePath.Location = new System.Drawing.Point(117, 18);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(160, 24);
            this.lblSourcePath.TabIndex = 1;
            this.lblSourcePath.Text = "Load Source PDF";
            // 
            // cboStart
            // 
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Location = new System.Drawing.Point(121, 83);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(59, 21);
            this.cboStart.TabIndex = 2;
            this.cboStart.SelectedIndexChanged += new System.EventHandler(this.cboStart_SelectedIndexChanged);
            this.cboStart.TextUpdate += new System.EventHandler(this.cboStart_TextUpdate);
            // 
            // btnViewPDF
            // 
            this.btnViewPDF.Location = new System.Drawing.Point(12, 48);
            this.btnViewPDF.Name = "btnViewPDF";
            this.btnViewPDF.Size = new System.Drawing.Size(98, 23);
            this.btnViewPDF.TabIndex = 3;
            this.btnViewPDF.Text = "View PDF";
            this.btnViewPDF.UseVisualStyleBackColor = true;
            this.btnViewPDF.Visible = false;
            this.btnViewPDF.Click += new System.EventHandler(this.btnViewPDF_Click);
            // 
            // cboEnd
            // 
            this.cboEnd.FormattingEnabled = true;
            this.cboEnd.Location = new System.Drawing.Point(218, 83);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(59, 21);
            this.cboEnd.TabIndex = 4;
            this.cboEnd.SelectedIndexChanged += new System.EventHandler(this.cboEnd_SelectedIndexChanged);
            this.cboEnd.TextUpdate += new System.EventHandler(this.cboEnd_TextUpdate);
            // 
            // cboEndA
            // 
            this.cboEndA.FormattingEnabled = true;
            this.cboEndA.Location = new System.Drawing.Point(222, 139);
            this.cboEndA.Name = "cboEndA";
            this.cboEndA.Size = new System.Drawing.Size(59, 21);
            this.cboEndA.TabIndex = 6;
            this.cboEndA.SelectedIndexChanged += new System.EventHandler(this.cboEndA_SelectedIndexChanged);
            // 
            // cboStartA
            // 
            this.cboStartA.FormattingEnabled = true;
            this.cboStartA.Location = new System.Drawing.Point(125, 139);
            this.cboStartA.Name = "cboStartA";
            this.cboStartA.Size = new System.Drawing.Size(59, 21);
            this.cboStartA.TabIndex = 5;
            this.cboStartA.SelectedIndexChanged += new System.EventHandler(this.cboStartA_SelectedIndexChanged);
            this.cboStartA.TextUpdate += new System.EventHandler(this.cboStartA_TextUpdate);
            // 
            // lblCommPages
            // 
            this.lblCommPages.AutoSize = true;
            this.lblCommPages.Location = new System.Drawing.Point(13, 83);
            this.lblCommPages.MaximumSize = new System.Drawing.Size(100, 40);
            this.lblCommPages.Name = "lblCommPages";
            this.lblCommPages.Size = new System.Drawing.Size(86, 26);
            this.lblCommPages.TabIndex = 7;
            this.lblCommPages.Text = "Pages for Commission PDF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start";
            // 
            // lblAdv
            // 
            this.lblAdv.AutoSize = true;
            this.lblAdv.Location = new System.Drawing.Point(13, 134);
            this.lblAdv.MaximumSize = new System.Drawing.Size(100, 40);
            this.lblAdv.Name = "lblAdv";
            this.lblAdv.Size = new System.Drawing.Size(97, 26);
            this.lblAdv.TabIndex = 12;
            this.lblAdv.Text = "Pages for Advancement PDF";
            // 
            // cbRotate
            // 
            this.cbRotate.AutoSize = true;
            this.cbRotate.Checked = true;
            this.cbRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRotate.Location = new System.Drawing.Point(301, 142);
            this.cbRotate.Name = "cbRotate";
            this.cbRotate.Size = new System.Drawing.Size(64, 17);
            this.cbRotate.TabIndex = 13;
            this.cbRotate.Text = "Rotate?";
            this.cbRotate.UseVisualStyleBackColor = true;
            this.cbRotate.CheckedChanged += new System.EventHandler(this.cbRotate_CheckedChanged);
            // 
            // txtRotate
            // 
            this.txtRotate.Location = new System.Drawing.Point(362, 140);
            this.txtRotate.Name = "txtRotate";
            this.txtRotate.Size = new System.Drawing.Size(100, 20);
            this.txtRotate.TabIndex = 14;
            this.txtRotate.Text = "90";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(13, 178);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(75, 23);
            this.btnGO.TabIndex = 15;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Visible = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // cbAdv
            // 
            this.cbAdv.AutoSize = true;
            this.cbAdv.Checked = true;
            this.cbAdv.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdv.Location = new System.Drawing.Point(301, 83);
            this.cbAdv.Name = "cbAdv";
            this.cbAdv.Size = new System.Drawing.Size(165, 17);
            this.cbAdv.TabIndex = 16;
            this.cbAdv.Text = "Add Advancment Statement?";
            this.cbAdv.UseVisualStyleBackColor = true;
            this.cbAdv.CheckedChanged += new System.EventHandler(this.cbAdv_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 17;
            // 
            // btnViewOut
            // 
            this.btnViewOut.Location = new System.Drawing.Point(121, 178);
            this.btnViewOut.Name = "btnViewOut";
            this.btnViewOut.Size = new System.Drawing.Size(75, 23);
            this.btnViewOut.TabIndex = 18;
            this.btnViewOut.Text = "View Output Files";
            this.btnViewOut.UseVisualStyleBackColor = true;
            this.btnViewOut.Visible = false;
            this.btnViewOut.Click += new System.EventHandler(this.btnViewOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 252);
            this.Controls.Add(this.btnViewOut);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbAdv);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtRotate);
            this.Controls.Add(this.cbRotate);
            this.Controls.Add(this.lblAdv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCommPages);
            this.Controls.Add(this.cboEndA);
            this.Controls.Add(this.cboStartA);
            this.Controls.Add(this.cboEnd);
            this.Controls.Add(this.btnViewPDF);
            this.Controls.Add(this.cboStart);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.btnLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDFSplitterGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.ComboBox cboStart;
        private System.Windows.Forms.Button btnViewPDF;
        private System.Windows.Forms.ComboBox cboEnd;
        private System.Windows.Forms.ComboBox cboEndA;
        private System.Windows.Forms.ComboBox cboStartA;
        private System.Windows.Forms.Label lblCommPages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdv;
        private System.Windows.Forms.CheckBox cbRotate;
        private System.Windows.Forms.TextBox txtRotate;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.CheckBox cbAdv;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnViewOut;
    }
}

