namespace VWorks_Plate_Format
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
            this.bnTest = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdSelectFormatFile = new System.Windows.Forms.Button();
            this.cmdSelectSampleFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnTest
            // 
            this.bnTest.Location = new System.Drawing.Point(367, 58);
            this.bnTest.Name = "bnTest";
            this.bnTest.Size = new System.Drawing.Size(152, 46);
            this.bnTest.TabIndex = 0;
            this.bnTest.Text = "test";
            this.bnTest.UseVisualStyleBackColor = true;
            this.bnTest.Click += new System.EventHandler(this.bnTest_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdSelectFormatFile
            // 
            this.cmdSelectFormatFile.Location = new System.Drawing.Point(147, 81);
            this.cmdSelectFormatFile.Name = "cmdSelectFormatFile";
            this.cmdSelectFormatFile.Size = new System.Drawing.Size(135, 23);
            this.cmdSelectFormatFile.TabIndex = 1;
            this.cmdSelectFormatFile.Text = "Select Format File";
            this.cmdSelectFormatFile.UseVisualStyleBackColor = true;
            this.cmdSelectFormatFile.Click += new System.EventHandler(this.cmdSelectFormatFile_Click);
            // 
            // cmdSelectSampleFile
            // 
            this.cmdSelectSampleFile.Location = new System.Drawing.Point(147, 122);
            this.cmdSelectSampleFile.Name = "cmdSelectSampleFile";
            this.cmdSelectSampleFile.Size = new System.Drawing.Size(135, 23);
            this.cmdSelectSampleFile.TabIndex = 2;
            this.cmdSelectSampleFile.Text = "Select Sample File";
            this.cmdSelectSampleFile.UseVisualStyleBackColor = true;
            this.cmdSelectSampleFile.Click += new System.EventHandler(this.cmdSelectSampleFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSelectSampleFile);
            this.Controls.Add(this.cmdSelectFormatFile);
            this.Controls.Add(this.bnTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnTest;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button cmdSelectFormatFile;
        private System.Windows.Forms.Button cmdSelectSampleFile;
    }
}

