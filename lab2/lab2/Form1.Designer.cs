namespace lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            img_slide = new Guna.UI2.WinForms.Guna2PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)img_slide).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // img_slide
            // 
            img_slide.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            img_slide.BackColor = Color.Transparent;
            img_slide.CustomizableEdges = customizableEdges1;
            img_slide.FillColor = Color.FromArgb(255, 224, 192);
            img_slide.ImageRotate = 0F;
            img_slide.Location = new Point(9, 317);
            img_slide.Name = "img_slide";
            img_slide.ShadowDecoration.CustomizableEdges = customizableEdges2;
            img_slide.Size = new Size(458, 314);
            img_slide.SizeMode = PictureBoxSizeMode.StretchImage;
            img_slide.TabIndex = 60;
            img_slide.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(guna2Panel1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges5;
            guna2GradientPanel1.FillColor = Color.FromArgb(168, 187, 227);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(128, 223, 217);
            guna2GradientPanel1.Location = new Point(-3, -2);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel1.Size = new Size(485, 294);
            guna2GradientPanel1.TabIndex = 61;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(66, 78);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(370, 200);
            guna2Panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(482, 763);
            Controls.Add(guna2GradientPanel1);
            Controls.Add(img_slide);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)img_slide).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox img_slide;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}