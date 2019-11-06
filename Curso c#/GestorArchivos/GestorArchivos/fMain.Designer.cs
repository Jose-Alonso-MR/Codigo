namespace GestorArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.label3 = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.txtFileContents = new System.Windows.Forms.TextBox();
            this.pctImageContents = new System.Windows.Forms.PictureBox();
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pctImageContents)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(893, 102);
            this.label3.TabIndex = 22;
            // 
            // lstFiles
            // 
            this.lstFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize});
            this.lstFiles.FullRowSelect = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 158);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(412, 392);
            this.lstFiles.TabIndex = 23;
            this.lstFiles.UseCompatibleStateImageBehavior = false;
            this.lstFiles.View = System.Windows.Forms.View.Details;
            this.lstFiles.DoubleClick += new System.EventHandler(this.lstFiles_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 286;
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.BackColor = System.Drawing.Color.White;
            this.lblCurrentPath.Location = new System.Drawing.Point(13, 115);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(868, 23);
            this.lblCurrentPath.TabIndex = 24;
            this.lblCurrentPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFileContents
            // 
            this.txtFileContents.Location = new System.Drawing.Point(468, 158);
            this.txtFileContents.Multiline = true;
            this.txtFileContents.Name = "txtFileContents";
            this.txtFileContents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileContents.Size = new System.Drawing.Size(402, 392);
            this.txtFileContents.TabIndex = 25;
            this.txtFileContents.Visible = false;
            // 
            // pctImageContents
            // 
            this.pctImageContents.Location = new System.Drawing.Point(468, 158);
            this.pctImageContents.Name = "pctImageContents";
            this.pctImageContents.Size = new System.Drawing.Size(402, 392);
            this.pctImageContents.TabIndex = 26;
            this.pctImageContents.TabStop = false;
            this.pctImageContents.Visible = false;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colSize.Width = 80;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 671);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pctImageContents);
            this.Controls.Add(this.txtFileContents);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de archivos";
            ((System.ComponentModel.ISupportInitialize)(this.pctImageContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstFiles;
        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.TextBox txtFileContents;
        private System.Windows.Forms.PictureBox pctImageContents;
        private System.Windows.Forms.ColumnHeader colSize;
    }
}

