namespace lab2
{
    partial class uc_trangchu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            img_slide = new Guna.UI2.WinForms.Guna2PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)img_slide).BeginInit();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BorderRadius = 10;
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.FillColor = Color.FromArgb(168, 187, 227);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(128, 223, 217);
            guna2GradientPanel1.Location = new Point(25, 22);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(429, 236);
            guna2GradientPanel1.TabIndex = 63;
            // 
            // img_slide
            // 
            img_slide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            img_slide.BackColor = Color.Transparent;
            img_slide.CustomizableEdges = customizableEdges3;
            img_slide.ErrorImage = Properties.Resources._4;
            img_slide.FillColor = Color.FromArgb(255, 224, 192);
            img_slide.ImageRotate = 0F;
            img_slide.Location = new Point(13, 297);
            img_slide.Name = "img_slide";
            img_slide.ShadowDecoration.CustomizableEdges = customizableEdges4;
            img_slide.Size = new Size(456, 314);
            img_slide.SizeMode = PictureBoxSizeMode.StretchImage;
            img_slide.TabIndex = 62;
            img_slide.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // uc_trangchu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2GradientPanel1);
            Controls.Add(img_slide);
            Name = "uc_trangchu";
            Size = new Size(485, 665);
            Load += uc_trangchu_Load;
            ((System.ComponentModel.ISupportInitialize)img_slide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox img_slide;
        private System.Windows.Forms.Timer timer1;
    }
}
