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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_trangchu = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_dichvu = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_traodoi = new Guna.UI2.WinForms.Guna2CircleButton();
            btn_taikhoan = new Guna.UI2.WinForms.Guna2CircleButton();
            panelControl = new Panel();
            guna2GradientPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2GradientPanel2
            // 
            guna2GradientPanel2.Controls.Add(tableLayoutPanel1);
            guna2GradientPanel2.CustomizableEdges = customizableEdges5;
            guna2GradientPanel2.Dock = DockStyle.Bottom;
            guna2GradientPanel2.FillColor = Color.FromArgb(168, 187, 227);
            guna2GradientPanel2.FillColor2 = Color.FromArgb(128, 223, 217);
            guna2GradientPanel2.Location = new Point(0, 665);
            guna2GradientPanel2.Name = "guna2GradientPanel2";
            guna2GradientPanel2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2GradientPanel2.Size = new Size(485, 78);
            guna2GradientPanel2.TabIndex = 62;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_trangchu, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_dichvu, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_traodoi, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_taikhoan, 3, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(485, 78);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_trangchu
            // 
            btn_trangchu.CheckedState.FillColor = Color.Transparent;
            btn_trangchu.CheckedState.ForeColor = Color.White;
            btn_trangchu.CheckedState.Image = Properties.Resources.home__2_;
            btn_trangchu.DisabledState.BorderColor = Color.DarkGray;
            btn_trangchu.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_trangchu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_trangchu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_trangchu.FillColor = Color.Transparent;
            btn_trangchu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_trangchu.ForeColor = Color.Black;
            btn_trangchu.Image = Properties.Resources.home__1_;
            btn_trangchu.Location = new Point(3, 3);
            btn_trangchu.Name = "btn_trangchu";
            btn_trangchu.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btn_trangchu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_trangchu.Size = new Size(115, 72);
            btn_trangchu.TabIndex = 67;
            btn_trangchu.Text = "Trang chủ";
            btn_trangchu.Click += btn_trangchu_Click;
            // 
            // btn_dichvu
            // 
            btn_dichvu.CheckedState.FillColor = Color.Transparent;
            btn_dichvu.CheckedState.ForeColor = Color.White;
            btn_dichvu.CheckedState.Image = Properties.Resources.shopping_bag__1_;
            btn_dichvu.DisabledState.BorderColor = Color.DarkGray;
            btn_dichvu.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_dichvu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_dichvu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_dichvu.FillColor = Color.Transparent;
            btn_dichvu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dichvu.ForeColor = Color.Black;
            btn_dichvu.Image = Properties.Resources.shopping_bag;
            btn_dichvu.Location = new Point(124, 3);
            btn_dichvu.Name = "btn_dichvu";
            btn_dichvu.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_dichvu.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_dichvu.Size = new Size(115, 72);
            btn_dichvu.TabIndex = 67;
            btn_dichvu.Text = "Dịch vụ";
            btn_dichvu.Click += btn_dichvu_Click;
            // 
            // btn_traodoi
            // 
            btn_traodoi.CheckedState.FillColor = Color.Transparent;
            btn_traodoi.CheckedState.ForeColor = Color.White;
            btn_traodoi.CheckedState.Image = Properties.Resources.message_circle__1_;
            btn_traodoi.DisabledState.BorderColor = Color.DarkGray;
            btn_traodoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_traodoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_traodoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_traodoi.FillColor = Color.Transparent;
            btn_traodoi.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_traodoi.ForeColor = Color.Black;
            btn_traodoi.Image = Properties.Resources.message_circle;
            btn_traodoi.Location = new Point(245, 3);
            btn_traodoi.Name = "btn_traodoi";
            btn_traodoi.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_traodoi.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_traodoi.Size = new Size(115, 72);
            btn_traodoi.TabIndex = 67;
            btn_traodoi.Text = "Trao đổi";
            btn_traodoi.Click += btn_traodoi_Click;
            // 
            // btn_taikhoan
            // 
            btn_taikhoan.CheckedState.FillColor = Color.Transparent;
            btn_taikhoan.CheckedState.ForeColor = Color.White;
            btn_taikhoan.CheckedState.Image = Properties.Resources.user__1_;
            btn_taikhoan.DisabledState.BorderColor = Color.DarkGray;
            btn_taikhoan.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_taikhoan.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_taikhoan.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_taikhoan.FillColor = Color.Transparent;
            btn_taikhoan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_taikhoan.ForeColor = Color.Black;
            btn_taikhoan.Image = Properties.Resources.user;
            btn_taikhoan.Location = new Point(366, 3);
            btn_taikhoan.Name = "btn_taikhoan";
            btn_taikhoan.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_taikhoan.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btn_taikhoan.Size = new Size(115, 72);
            btn_taikhoan.TabIndex = 67;
            btn_taikhoan.Text = "Tài khoản";
            btn_taikhoan.Click += btn_taikhoan_Click;
            // 
            // panelControl
            // 
            panelControl.Dock = DockStyle.Fill;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(485, 665);
            panelControl.TabIndex = 63;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(485, 743);
            Controls.Add(panelControl);
            Controls.Add(guna2GradientPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            guna2GradientPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btn_trangchu;
        private Guna.UI2.WinForms.Guna2CircleButton btn_dichvu;
        private Guna.UI2.WinForms.Guna2CircleButton btn_traodoi;
        private Guna.UI2.WinForms.Guna2CircleButton btn_taikhoan;
        private Panel panelControl;
    }
}