namespace JukeBox
{
    partial class Setup_Frm
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
            this.ImportTracks_TxtBox = new System.Windows.Forms.TextBox();
            this.Import_Btn = new System.Windows.Forms.Button();
            this.ClearImported_Btn = new System.Windows.Forms.Button();
            this.ImportTracks_GrpBox = new System.Windows.Forms.GroupBox();
            this.CopyTrack_Btn = new System.Windows.Forms.Button();
            this.MoveTrack_Btn = new System.Windows.Forms.Button();
            this.DeleteTrackFromGenre_Btn = new System.Windows.Forms.Button();
            this.PresentGenre_GrpBox = new System.Windows.Forms.GroupBox();
            this.PresentGenre_TxtBox = new System.Windows.Forms.TextBox();
            this.GenreTitle_Lbl = new System.Windows.Forms.Label();
            this.GenreTitle_Txtbox = new System.Windows.Forms.TextBox();
            this.Previous_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Ok_Btn = new System.Windows.Forms.Button();
            this.ImportTracks_GrpBox.SuspendLayout();
            this.PresentGenre_GrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportTracks_TxtBox
            // 
            this.ImportTracks_TxtBox.Location = new System.Drawing.Point(27, 41);
            this.ImportTracks_TxtBox.Multiline = true;
            this.ImportTracks_TxtBox.Name = "ImportTracks_TxtBox";
            this.ImportTracks_TxtBox.Size = new System.Drawing.Size(394, 579);
            this.ImportTracks_TxtBox.TabIndex = 1;
            // 
            // Import_Btn
            // 
            this.Import_Btn.Location = new System.Drawing.Point(27, 642);
            this.Import_Btn.Name = "Import_Btn";
            this.Import_Btn.Size = new System.Drawing.Size(394, 53);
            this.Import_Btn.TabIndex = 2;
            this.Import_Btn.Text = "Import Tracks From Directory";
            this.Import_Btn.UseVisualStyleBackColor = true;
            // 
            // ClearImported_Btn
            // 
            this.ClearImported_Btn.Location = new System.Drawing.Point(27, 733);
            this.ClearImported_Btn.Name = "ClearImported_Btn";
            this.ClearImported_Btn.Size = new System.Drawing.Size(394, 53);
            this.ClearImported_Btn.TabIndex = 3;
            this.ClearImported_Btn.Text = "Clear Imported Tracks";
            this.ClearImported_Btn.UseVisualStyleBackColor = true;
            // 
            // ImportTracks_GrpBox
            // 
            this.ImportTracks_GrpBox.Controls.Add(this.ImportTracks_TxtBox);
            this.ImportTracks_GrpBox.Controls.Add(this.ClearImported_Btn);
            this.ImportTracks_GrpBox.Controls.Add(this.Import_Btn);
            this.ImportTracks_GrpBox.Location = new System.Drawing.Point(12, 12);
            this.ImportTracks_GrpBox.Name = "ImportTracks_GrpBox";
            this.ImportTracks_GrpBox.Size = new System.Drawing.Size(450, 820);
            this.ImportTracks_GrpBox.TabIndex = 4;
            this.ImportTracks_GrpBox.TabStop = false;
            this.ImportTracks_GrpBox.Text = "Imported Tracks";
            // 
            // CopyTrack_Btn
            // 
            this.CopyTrack_Btn.Location = new System.Drawing.Point(488, 95);
            this.CopyTrack_Btn.Name = "CopyTrack_Btn";
            this.CopyTrack_Btn.Size = new System.Drawing.Size(241, 59);
            this.CopyTrack_Btn.TabIndex = 5;
            this.CopyTrack_Btn.Text = "Copy Track >>";
            this.CopyTrack_Btn.UseVisualStyleBackColor = true;
            // 
            // MoveTrack_Btn
            // 
            this.MoveTrack_Btn.Location = new System.Drawing.Point(488, 184);
            this.MoveTrack_Btn.Name = "MoveTrack_Btn";
            this.MoveTrack_Btn.Size = new System.Drawing.Size(241, 59);
            this.MoveTrack_Btn.TabIndex = 6;
            this.MoveTrack_Btn.Text = "Move Track >>";
            this.MoveTrack_Btn.UseVisualStyleBackColor = true;
            // 
            // DeleteTrackFromGenre_Btn
            // 
            this.DeleteTrackFromGenre_Btn.Location = new System.Drawing.Point(488, 354);
            this.DeleteTrackFromGenre_Btn.Name = "DeleteTrackFromGenre_Btn";
            this.DeleteTrackFromGenre_Btn.Size = new System.Drawing.Size(241, 229);
            this.DeleteTrackFromGenre_Btn.TabIndex = 7;
            this.DeleteTrackFromGenre_Btn.Text = "Delete Track From Genre";
            this.DeleteTrackFromGenre_Btn.UseVisualStyleBackColor = true;
            // 
            // PresentGenre_GrpBox
            // 
            this.PresentGenre_GrpBox.Controls.Add(this.Next_Btn);
            this.PresentGenre_GrpBox.Controls.Add(this.Delete_Btn);
            this.PresentGenre_GrpBox.Controls.Add(this.Add_Btn);
            this.PresentGenre_GrpBox.Controls.Add(this.Previous_Btn);
            this.PresentGenre_GrpBox.Controls.Add(this.GenreTitle_Txtbox);
            this.PresentGenre_GrpBox.Controls.Add(this.GenreTitle_Lbl);
            this.PresentGenre_GrpBox.Controls.Add(this.PresentGenre_TxtBox);
            this.PresentGenre_GrpBox.Location = new System.Drawing.Point(780, 12);
            this.PresentGenre_GrpBox.Name = "PresentGenre_GrpBox";
            this.PresentGenre_GrpBox.Size = new System.Drawing.Size(468, 820);
            this.PresentGenre_GrpBox.TabIndex = 8;
            this.PresentGenre_GrpBox.TabStop = false;
            this.PresentGenre_GrpBox.Text = "Present Genre";
            // 
            // PresentGenre_TxtBox
            // 
            this.PresentGenre_TxtBox.Location = new System.Drawing.Point(31, 140);
            this.PresentGenre_TxtBox.Multiline = true;
            this.PresentGenre_TxtBox.Name = "PresentGenre_TxtBox";
            this.PresentGenre_TxtBox.Size = new System.Drawing.Size(412, 431);
            this.PresentGenre_TxtBox.TabIndex = 9;
            // 
            // GenreTitle_Lbl
            // 
            this.GenreTitle_Lbl.AutoSize = true;
            this.GenreTitle_Lbl.Location = new System.Drawing.Point(26, 41);
            this.GenreTitle_Lbl.Name = "GenreTitle_Lbl";
            this.GenreTitle_Lbl.Size = new System.Drawing.Size(118, 25);
            this.GenreTitle_Lbl.TabIndex = 10;
            this.GenreTitle_Lbl.Text = "Genre Title";
            // 
            // GenreTitle_Txtbox
            // 
            this.GenreTitle_Txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenreTitle_Txtbox.ForeColor = System.Drawing.Color.Gray;
            this.GenreTitle_Txtbox.Location = new System.Drawing.Point(31, 69);
            this.GenreTitle_Txtbox.Name = "GenreTitle_Txtbox";
            this.GenreTitle_Txtbox.Size = new System.Drawing.Size(394, 31);
            this.GenreTitle_Txtbox.TabIndex = 11;
            this.GenreTitle_Txtbox.Text = "General";
            // 
            // Previous_Btn
            // 
            this.Previous_Btn.Location = new System.Drawing.Point(31, 619);
            this.Previous_Btn.Name = "Previous_Btn";
            this.Previous_Btn.Size = new System.Drawing.Size(134, 150);
            this.Previous_Btn.TabIndex = 12;
            this.Previous_Btn.Text = "<<Previous";
            this.Previous_Btn.UseVisualStyleBackColor = true;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Location = new System.Drawing.Point(181, 619);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(110, 64);
            this.Add_Btn.TabIndex = 13;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(181, 705);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(110, 64);
            this.Delete_Btn.TabIndex = 14;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            // 
            // Next_Btn
            // 
            this.Next_Btn.Location = new System.Drawing.Point(309, 619);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(134, 150);
            this.Next_Btn.TabIndex = 13;
            this.Next_Btn.Text = "Next>>";
            this.Next_Btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(1109, 879);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(127, 44);
            this.Cancel_Btn.TabIndex = 9;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // Ok_Btn
            // 
            this.Ok_Btn.Location = new System.Drawing.Point(944, 879);
            this.Ok_Btn.Name = "Ok_Btn";
            this.Ok_Btn.Size = new System.Drawing.Size(127, 44);
            this.Ok_Btn.TabIndex = 10;
            this.Ok_Btn.Text = "Ok";
            this.Ok_Btn.UseVisualStyleBackColor = true;
            // 
            // Setup_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 935);
            this.Controls.Add(this.Ok_Btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.PresentGenre_GrpBox);
            this.Controls.Add(this.DeleteTrackFromGenre_Btn);
            this.Controls.Add(this.MoveTrack_Btn);
            this.Controls.Add(this.CopyTrack_Btn);
            this.Controls.Add(this.ImportTracks_GrpBox);
            this.Name = "Setup_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Frm_Load);
            this.ImportTracks_GrpBox.ResumeLayout(false);
            this.ImportTracks_GrpBox.PerformLayout();
            this.PresentGenre_GrpBox.ResumeLayout(false);
            this.PresentGenre_GrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox ImportTracks_TxtBox;
        private System.Windows.Forms.Button Import_Btn;
        private System.Windows.Forms.Button ClearImported_Btn;
        private System.Windows.Forms.GroupBox ImportTracks_GrpBox;
        private System.Windows.Forms.Button CopyTrack_Btn;
        private System.Windows.Forms.Button MoveTrack_Btn;
        private System.Windows.Forms.Button DeleteTrackFromGenre_Btn;
        private System.Windows.Forms.GroupBox PresentGenre_GrpBox;
        private System.Windows.Forms.TextBox PresentGenre_TxtBox;
        private System.Windows.Forms.TextBox GenreTitle_Txtbox;
        private System.Windows.Forms.Label GenreTitle_Lbl;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Previous_Btn;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Ok_Btn;
    }
}