namespace PointClient.Forms
{
    partial class VideoForm
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
            this.vlcControl2 = new Vlc.DotNet.Forms.VlcControl();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // vlcControl2
            // 
            this.vlcControl2.BackColor = System.Drawing.Color.Black;
            this.vlcControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl2.Location = new System.Drawing.Point(0, 0);
            this.vlcControl2.Name = "vlcControl2";
            this.vlcControl2.Size = new System.Drawing.Size(738, 420);
            this.vlcControl2.Spu = -1;
            this.vlcControl2.TabIndex = 0;
            this.vlcControl2.Text = "vlcControl2";
            this.vlcControl2.VlcLibDirectory = null;
            this.vlcControl2.VlcMediaplayerOptions = null;
            this.vlcControl2.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl2_VlcLibDirectoryNeeded);
            // 
            // VideoForm
            // 
            this.ClientSize = new System.Drawing.Size(738, 420);
            this.Controls.Add(this.vlcControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Vlc.DotNet.Forms.VlcControl vlcControl2;
    }
}