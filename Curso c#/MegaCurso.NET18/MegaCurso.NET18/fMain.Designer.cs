namespace MegaCurso.NET18
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
            this.btnTestDebug = new System.Windows.Forms.Button();
            this.btnReadConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Image = global::MegaCurso.NET18.Properties.Resources.Alonso_Logo;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(691, 102);
            this.label3.TabIndex = 18;
            // 
            // btnTestDebug
            // 
            this.btnTestDebug.Location = new System.Drawing.Point(137, 213);
            this.btnTestDebug.Name = "btnTestDebug";
            this.btnTestDebug.Size = new System.Drawing.Size(157, 23);
            this.btnTestDebug.TabIndex = 19;
            this.btnTestDebug.Text = "Test debug";
            this.btnTestDebug.UseVisualStyleBackColor = true;
            this.btnTestDebug.Click += new System.EventHandler(this.btnTestDebug_Click);
            // 
            // btnReadConfig
            // 
            this.btnReadConfig.Location = new System.Drawing.Point(137, 295);
            this.btnReadConfig.Name = "btnReadConfig";
            this.btnReadConfig.Size = new System.Drawing.Size(157, 23);
            this.btnReadConfig.TabIndex = 20;
            this.btnReadConfig.Text = "Read config";
            this.btnReadConfig.UseVisualStyleBackColor = true;
            this.btnReadConfig.Click += new System.EventHandler(this.btnReadConfig_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 542);
            this.Controls.Add(this.btnReadConfig);
            this.Controls.Add(this.btnTestDebug);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaCurso.NET18 - Depuración de aguas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestDebug;
        private System.Windows.Forms.Button btnReadConfig;
    }
}

