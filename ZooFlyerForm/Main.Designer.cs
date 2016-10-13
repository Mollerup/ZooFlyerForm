namespace ZooFlyerForm
{
    partial class Main
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
            this.uploadPics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadPics
            // 
            this.uploadPics.Location = new System.Drawing.Point(41, 32);
            this.uploadPics.Name = "uploadPics";
            this.uploadPics.Size = new System.Drawing.Size(75, 23);
            this.uploadPics.TabIndex = 0;
            this.uploadPics.Text = "Upload";
            this.uploadPics.UseVisualStyleBackColor = true;
            this.uploadPics.Click += new System.EventHandler(this.uploadPics_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 400);
            this.Controls.Add(this.uploadPics);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadPics;
    }
}