namespace JukeBox
{
    partial class About_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About_Frm));
            this.JukeBox_PctBox = new System.Windows.Forms.PictureBox();
            this.JukeBoxTitle_Lbl = new System.Windows.Forms.Label();
            this.Description_TxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.JukeBox_PctBox)).BeginInit();
            this.SuspendLayout();
            // 
            // JukeBox_PctBox
            // 
            this.JukeBox_PctBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JukeBox_PctBox.BackgroundImage")));
            this.JukeBox_PctBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.JukeBox_PctBox.Location = new System.Drawing.Point(21, 26);
            this.JukeBox_PctBox.Name = "JukeBox_PctBox";
            this.JukeBox_PctBox.Size = new System.Drawing.Size(323, 486);
            this.JukeBox_PctBox.TabIndex = 0;
            this.JukeBox_PctBox.TabStop = false;
            this.JukeBox_PctBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // JukeBoxTitle_Lbl
            // 
            this.JukeBoxTitle_Lbl.AutoSize = true;
            this.JukeBoxTitle_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JukeBoxTitle_Lbl.Location = new System.Drawing.Point(473, 81);
            this.JukeBoxTitle_Lbl.Name = "JukeBoxTitle_Lbl";
            this.JukeBoxTitle_Lbl.Size = new System.Drawing.Size(366, 51);
            this.JukeBoxTitle_Lbl.TabIndex = 1;
            this.JukeBoxTitle_Lbl.Text = "My JukeBox v1.0";
            // 
            // Description_TxtBox
            // 
            this.Description_TxtBox.Location = new System.Drawing.Point(387, 151);
            this.Description_TxtBox.Multiline = true;
            this.Description_TxtBox.Name = "Description_TxtBox";
            this.Description_TxtBox.ReadOnly = true;
            this.Description_TxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Description_TxtBox.Size = new System.Drawing.Size(511, 314);
            this.Description_TxtBox.TabIndex = 2;
            this.Description_TxtBox.Text = resources.GetString("Description_TxtBox.Text");
            // 
            // About_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 524);
            this.Controls.Add(this.Description_TxtBox);
            this.Controls.Add(this.JukeBoxTitle_Lbl);
            this.Controls.Add(this.JukeBox_PctBox);
            this.Name = "About_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.JukeBox_PctBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JukeBox_PctBox;
        private System.Windows.Forms.Label JukeBoxTitle_Lbl;
        private System.Windows.Forms.TextBox Description_TxtBox;
    }
}