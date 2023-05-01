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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btn_launchdry = new Guna.UI2.WinForms.Guna2ImageButton();
            btn_clean = new Guna.UI2.WinForms.Guna2ImageButton();
            btn_cook = new Guna.UI2.WinForms.Guna2ImageButton();
            panelControl = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            btn_launchdry.ShadowDecoration.CustomizableEdges = customizableEdges1;
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
            btn_clean.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            btn_cook.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btn_cook.Size = new Size(64, 75);
            btn_cook.TabIndex = 0;
            btn_cook.Click += btn_cook_Click;
            // 
            // panelControl
            // 
            panelControl.AutoScroll = true;
            panelControl.BackColor = Color.White;
            panelControl.Dock = DockStyle.Fill;
            panelControl.Location = new Point(0, 82);
            panelControl.Margin = new Padding(5);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(485, 583);
            panelControl.TabIndex = 1;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_launchdry;
        private Guna.UI2.WinForms.Guna2ImageButton btn_clean;
        private Guna.UI2.WinForms.Guna2ImageButton btn_cook;
        private FlowLayoutPanel panelControl;
    }
}
