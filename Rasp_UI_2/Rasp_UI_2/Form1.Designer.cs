namespace Rasp_UI_2
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Interface_rpi = new MetroFramework.Controls.MetroUserControl();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Interface_rpi
            // 
            this.Interface_rpi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Interface_rpi.BackgroundImage")));
            this.Interface_rpi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Interface_rpi.Location = new System.Drawing.Point(54, 88);
            this.Interface_rpi.Name = "Interface_rpi";
            this.Interface_rpi.Size = new System.Drawing.Size(293, 150);
            this.Interface_rpi.TabIndex = 0;
            this.Interface_rpi.UseSelectable = true;
            this.Interface_rpi.Load += new System.EventHandler(this.metroUserControl1_Load_1);
            // 
            // metroButton1
            // 
            this.metroButton1.AllowDrop = true;
            this.metroButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroButton1.Location = new System.Drawing.Point(54, 255);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(326, 89);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 565);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Interface_rpi);
            this.KeyPreview = true;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroUserControl Interface_rpi;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

