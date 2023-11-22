namespace Copy_App
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddressFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDestenation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumOfCopy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUnscCopy = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectDestenation = new System.Windows.Forms.Button();
            this.btnOperate = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.prgrsBar = new System.Windows.Forms.ProgressBar();
            this.numericOFCopy = new System.Windows.Forms.NumericUpDown();
            this.numericOfUnSuccesCopy = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOFCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfUnSuccesCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(580, 95);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address of Files: ";
            // 
            // lblAddressFile
            // 
            this.lblAddressFile.AutoSize = true;
            this.lblAddressFile.Location = new System.Drawing.Point(106, 120);
            this.lblAddressFile.Name = "lblAddressFile";
            this.lblAddressFile.Size = new System.Drawing.Size(71, 13);
            this.lblAddressFile.TabIndex = 2;
            this.lblAddressFile.Text = "lblAddressFile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Destenation :";
            // 
            // lblDestenation
            // 
            this.lblDestenation.AutoSize = true;
            this.lblDestenation.Location = new System.Drawing.Point(82, 27);
            this.lblDestenation.Name = "lblDestenation";
            this.lblDestenation.Size = new System.Drawing.Size(74, 13);
            this.lblDestenation.TabIndex = 4;
            this.lblDestenation.Text = "lblDestenation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number Of Copy :";
            // 
            // lblNumOfCopy
            // 
            this.lblNumOfCopy.AutoSize = true;
            this.lblNumOfCopy.Location = new System.Drawing.Point(103, 57);
            this.lblNumOfCopy.Name = "lblNumOfCopy";
            this.lblNumOfCopy.Size = new System.Drawing.Size(74, 13);
            this.lblNumOfCopy.TabIndex = 6;
            this.lblNumOfCopy.Text = "lblNumOfCopy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total of file :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(408, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "lblTotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "unsuccessfull Copy :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericOfUnSuccesCopy);
            this.groupBox1.Controls.Add(this.numericOFCopy);
            this.groupBox1.Controls.Add(this.lblUnscCopy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblDestenation);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblNumOfCopy);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblUnscCopy
            // 
            this.lblUnscCopy.AutoSize = true;
            this.lblUnscCopy.Location = new System.Drawing.Point(446, 57);
            this.lblUnscCopy.Name = "lblUnscCopy";
            this.lblUnscCopy.Size = new System.Drawing.Size(66, 13);
            this.lblUnscCopy.TabIndex = 10;
            this.lblUnscCopy.Text = "lblUnscCopy";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 255);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 36);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectDestenation
            // 
            this.btnSelectDestenation.Location = new System.Drawing.Point(173, 255);
            this.btnSelectDestenation.Name = "btnSelectDestenation";
            this.btnSelectDestenation.Size = new System.Drawing.Size(75, 36);
            this.btnSelectDestenation.TabIndex = 11;
            this.btnSelectDestenation.Text = "Select Destenation";
            this.btnSelectDestenation.UseVisualStyleBackColor = true;
            this.btnSelectDestenation.Click += new System.EventHandler(this.btnSelectDestenation_Click);
            // 
            // btnOperate
            // 
            this.btnOperate.Location = new System.Drawing.Point(254, 255);
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.Size = new System.Drawing.Size(75, 36);
            this.btnOperate.TabIndex = 11;
            this.btnOperate.Text = "Operate";
            this.btnOperate.UseVisualStyleBackColor = true;
            this.btnOperate.Click += new System.EventHandler(this.btnOperate_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(93, 255);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteFile.TabIndex = 11;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 266);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Status of File";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // prgrsBar
            // 
            this.prgrsBar.Location = new System.Drawing.Point(15, 298);
            this.prgrsBar.Name = "prgrsBar";
            this.prgrsBar.Size = new System.Drawing.Size(577, 23);
            this.prgrsBar.TabIndex = 13;
            // 
            // numericOFCopy
            // 
            this.numericOFCopy.Location = new System.Drawing.Point(183, 55);
            this.numericOFCopy.Name = "numericOFCopy";
            this.numericOFCopy.ReadOnly = true;
            this.numericOFCopy.Size = new System.Drawing.Size(53, 20);
            this.numericOFCopy.TabIndex = 11;
            // 
            // numericOfUnSuccesCopy
            // 
            this.numericOfUnSuccesCopy.Location = new System.Drawing.Point(518, 55);
            this.numericOfUnSuccesCopy.Name = "numericOfUnSuccesCopy";
            this.numericOfUnSuccesCopy.ReadOnly = true;
            this.numericOfUnSuccesCopy.Size = new System.Drawing.Size(53, 20);
            this.numericOfUnSuccesCopy.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 341);
            this.Controls.Add(this.prgrsBar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnOperate);
            this.Controls.Add(this.btnSelectDestenation);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddressFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced Copy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericOFCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericOfUnSuccesCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddressFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDestenation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumOfCopy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUnscCopy;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSelectDestenation;
        private System.Windows.Forms.Button btnOperate;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ProgressBar prgrsBar;
        private System.Windows.Forms.NumericUpDown numericOFCopy;
        private System.Windows.Forms.NumericUpDown numericOfUnSuccesCopy;
    }
}

