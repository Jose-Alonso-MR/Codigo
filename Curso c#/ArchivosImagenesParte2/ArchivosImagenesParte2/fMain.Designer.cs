namespace ArchivosImagenesParte2
{
    partial class fMain
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnWriteBinary = new System.Windows.Forms.Button();
            this.btnReadBinary = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = global::ArchivosImagenesParte2.Properties.Resources.Alonso_Logo;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(949, 102);
            this.label3.TabIndex = 16;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(35, 179);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Leer";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(129, 179);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 18;
            this.btnWrite.Text = "Escribir";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(35, 233);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(322, 285);
            this.txtResult.TabIndex = 19;
            // 
            // btnWriteBinary
            // 
            this.btnWriteBinary.Location = new System.Drawing.Point(404, 179);
            this.btnWriteBinary.Name = "btnWriteBinary";
            this.btnWriteBinary.Size = new System.Drawing.Size(124, 23);
            this.btnWriteBinary.TabIndex = 21;
            this.btnWriteBinary.Text = "Escribir binario";
            this.btnWriteBinary.UseVisualStyleBackColor = true;
            this.btnWriteBinary.Click += new System.EventHandler(this.btnWriteBinary_Click);
            // 
            // btnReadBinary
            // 
            this.btnReadBinary.Location = new System.Drawing.Point(301, 179);
            this.btnReadBinary.Name = "btnReadBinary";
            this.btnReadBinary.Size = new System.Drawing.Size(75, 23);
            this.btnReadBinary.TabIndex = 20;
            this.btnReadBinary.Text = "Leer binario";
            this.btnReadBinary.UseVisualStyleBackColor = true;
            this.btnReadBinary.Click += new System.EventHandler(this.btnReadBinary_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(512, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 285);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(605, 179);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(124, 23);
            this.btnOpenImage.TabIndex = 23;
            this.btnOpenImage.Text = "Abrir imagen";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivos de imágenes|*.jpg;*.bmp;*.gif";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 713);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWriteBinary);
            this.Controls.Add(this.btnReadBinary);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "Archivos e imágenes parte 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnWriteBinary;
        private System.Windows.Forms.Button btnReadBinary;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

