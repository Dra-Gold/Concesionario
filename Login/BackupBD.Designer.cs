namespace Login
{
    partial class BackupBD
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(385, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Seleccione Carpeta Donde Almacenar Respaldo ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(385, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cargar Respaldo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BackupBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 144);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "BackupBD";
            this.Text = "Manejo De Respaldos BD";
            this.Load += new System.EventHandler(this.BackupBD_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}