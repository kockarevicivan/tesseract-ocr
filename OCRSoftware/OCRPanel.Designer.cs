namespace OCRSoftware
{
    partial class OCRPanel
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
            this.tlpTextBoxAndImageBox = new System.Windows.Forms.TableLayoutPanel();
            this.txtOCR = new System.Windows.Forms.TextBox();
            this.ibImage = new System.Windows.Forms.PictureBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.speak = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.tlpTextBoxAndImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTextBoxAndImageBox
            // 
            this.tlpTextBoxAndImageBox.ColumnCount = 1;
            this.tlpTextBoxAndImageBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextBoxAndImageBox.Controls.Add(this.txtOCR, 0, 0);
            this.tlpTextBoxAndImageBox.Controls.Add(this.ibImage, 0, 1);
            this.tlpTextBoxAndImageBox.Location = new System.Drawing.Point(15, 52);
            this.tlpTextBoxAndImageBox.Name = "tlpTextBoxAndImageBox";
            this.tlpTextBoxAndImageBox.RowCount = 2;
            this.tlpTextBoxAndImageBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpTextBoxAndImageBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpTextBoxAndImageBox.Size = new System.Drawing.Size(711, 492);
            this.tlpTextBoxAndImageBox.TabIndex = 0;
            // 
            // txtOCR
            // 
            this.txtOCR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOCR.Location = new System.Drawing.Point(3, 3);
            this.txtOCR.Multiline = true;
            this.txtOCR.Name = "txtOCR";
            this.txtOCR.ReadOnly = true;
            this.txtOCR.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOCR.Size = new System.Drawing.Size(705, 166);
            this.txtOCR.TabIndex = 0;
            // 
            // ibImage
            // 
            this.ibImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibImage.Enabled = false;
            this.ibImage.Location = new System.Drawing.Point(3, 175);
            this.ibImage.Name = "ibImage";
            this.ibImage.Size = new System.Drawing.Size(705, 314);
            this.ibImage.TabIndex = 0;
            this.ibImage.TabStop = false;
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(105, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(527, 22);
            this.txtFile.TabIndex = 1;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // lblFile
            // 
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(12, 10);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(87, 24);
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "Choose file:";
            this.lblFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(638, 11);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(88, 24);
            this.btnFile.TabIndex = 3;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // speak
            // 
            this.speak.Location = new System.Drawing.Point(748, 55);
            this.speak.Name = "speak";
            this.speak.Size = new System.Drawing.Size(75, 23);
            this.speak.TabIndex = 4;
            this.speak.Text = "Speak";
            this.speak.UseVisualStyleBackColor = true;
            this.speak.Click += new System.EventHandler(this.speak_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(748, 97);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 5;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(748, 139);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(75, 23);
            this.resume.TabIndex = 6;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(748, 182);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 7;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // OCRPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 559);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.speak);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.tlpTextBoxAndImageBox);
            this.Name = "OCRPanel";
            this.Text = "OCR Panel";
            this.Resize += new System.EventHandler(this.OCRPanel_Resize);
            this.tlpTextBoxAndImageBox.ResumeLayout(false);
            this.tlpTextBoxAndImageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTextBoxAndImageBox;
        private System.Windows.Forms.TextBox txtOCR;
        private System.Windows.Forms.PictureBox ibImage;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button speak;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button stop;
    }
}

