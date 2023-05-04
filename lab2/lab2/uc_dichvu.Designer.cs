namespace lab2
{
    partial class uc_dichvu
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btn_launchdry = new Guna.UI2.WinForms.Guna2ImageButton();
            btn_clean = new Guna.UI2.WinForms.Guna2ImageButton();
            btn_cook = new Guna.UI2.WinForms.Guna2ImageButton();
            panelControl = new FlowLayoutPanel();
            pic_giohang = new Guna.UI2.WinForms.Guna2PictureBox();
            lb_so_luong = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_giohang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lb_so_luong);
            panel1.Controls.Add(pic_giohang);
            panel1.Controls.Add(btn_launchdry);
            panel1.Controls.Add(btn_clean);
            panel1.Controls.Add(btn_cook);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(485, 82);
            panel1.TabIndex = 0;
            // 
            // btn_launchdry
            // 
            btn_launchdry.CheckedState.Image = Properties.Resources.washing_machine__1_;
            btn_launchdry.CheckedState.ImageSize = new Size(64, 64);
            btn_launchdry.HoverState.ImageSize = new Size(64, 64);
            btn_launchdry.Image = Properties.Resources.washing_machine;
            btn_launchdry.ImageOffset = new Point(0, 0);
            btn_launchdry.ImageRotate = 0F;
            btn_launchdry.Location = new Point(231, 3);
            btn_launchdry.Name = "btn_launchdry";
            btn_launchdry.PressedState.ImageSize = new Size(64, 64);
            btn_launchdry.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_launchdry.Size = new Size(64, 75);
            btn_launchdry.TabIndex = 2;
            btn_launchdry.Click += btn_launchdry_Click;
            // 
            // btn_clean
            // 
            btn_clean.CheckedState.Image = Properties.Resources.broom__1_;
            btn_clean.CheckedState.ImageSize = new Size(64, 64);
            btn_clean.HoverState.ImageSize = new Size(64, 64);
            btn_clean.Image = Properties.Resources.broom;
            btn_clean.ImageOffset = new Point(0, 0);
            btn_clean.ImageRotate = 0F;
            btn_clean.Location = new Point(122, 3);
            btn_clean.Name = "btn_clean";
            btn_clean.PressedState.ImageSize = new Size(64, 64);
            btn_clean.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_clean.Size = new Size(64, 75);
            btn_clean.TabIndex = 1;
            btn_clean.Click += btn_clean_Click;
            // 
            // btn_cook
            // 
            btn_cook.CheckedState.Image = Properties.Resources.cooking__1_;
            btn_cook.CheckedState.ImageSize = new Size(64, 64);
            btn_cook.HoverState.ImageSize = new Size(64, 64);
            btn_cook.Image = Properties.Resources.cooking;
            btn_cook.ImageOffset = new Point(0, 0);
            btn_cook.ImageRotate = 0F;
            btn_cook.Location = new Point(20, 3);
            btn_cook.Name = "btn_cook";
            btn_cook.PressedState.ImageSize = new Size(64, 64);
            btn_cook.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btn_cook.Size = new Size(64, 75);
            btn_cook.TabIndex = 0;
            btn_cook.Click += btn_cook_Click;
            // 
            // panelControl
            // 
            panelControl.AutoScroll = true;
            panelControl.BackColor = Color.White;
            panelControl.Location = new Point(0, 82);
            panelControl.Margin = new Padding(5);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(485, 583);
            panelControl.TabIndex = 1;
            panelControl.Paint += panelControl_Paint;
            // 
            // pic_giohang
            // 
            pic_giohang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pic_giohang.CustomizableEdges = customizableEdges1;
            pic_giohang.Image = Properties.Resources.cart;
            pic_giohang.ImageRotate = 0F;
            pic_giohang.Location = new Point(422, 15);
            pic_giohang.Name = "pic_giohang";
            pic_giohang.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pic_giohang.Size = new Size(50, 50);
            pic_giohang.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_giohang.TabIndex = 3;
            pic_giohang.TabStop = false;
            pic_giohang.Click += pic_giohang_Click;
            // 
            // lb_so_luong
            // 
            lb_so_luong.AutoSize = true;
            lb_so_luong.BackColor = Color.FromArgb(192, 192, 255);
            lb_so_luong.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_so_luong.Location = new Point(459, 15);
            lb_so_luong.Name = "lb_so_luong";
            lb_so_luong.Size = new Size(14, 15);
            lb_so_luong.TabIndex = 4;
            lb_so_luong.Text = "1";
            // 
            // uc_dichvu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelControl);
            Controls.Add(panel1);
            Name = "uc_dichvu";
            Size = new Size(485, 665);
            Load += uc_dichvu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_giohang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_launchdry;
        private Guna.UI2.WinForms.Guna2ImageButton btn_clean;
        private Guna.UI2.WinForms.Guna2ImageButton btn_cook;
        private FlowLayoutPanel panelControl;
        private Label lb_so_luong;
        private Guna.UI2.WinForms.Guna2PictureBox pic_giohang;
    }
}
