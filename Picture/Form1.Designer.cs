namespace Picture
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
            this.btChoose = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btChoose
            // 
            this.btChoose.Location = new System.Drawing.Point(12, 12);
            this.btChoose.Name = "btChoose";
            this.btChoose.Size = new System.Drawing.Size(96, 23);
            this.btChoose.TabIndex = 0;
            this.btChoose.Text = "Wybierz zdjęcie";
            this.btChoose.UseVisualStyleBackColor = true;
            this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(114, 12);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 23);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "Wyczyść zdjęcie";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.Location = new System.Drawing.Point(12, 41);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(776, 397);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btChoose);
            this.Name = "Form1";
            this.Text = "Zdjęcie";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btChoose;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.PictureBox pbMain;
    }
}

