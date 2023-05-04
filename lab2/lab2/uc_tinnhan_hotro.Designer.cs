namespace lab2
{
    partial class uc_tinnhan_hotro
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
            uc_tinnhan_text1 = new Label();
            uc_tinnhan_ava1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)uc_tinnhan_ava1).BeginInit();
            SuspendLayout();
            // 
            // uc_tinnhan_text1
            // 
            uc_tinnhan_text1.BackColor = Color.White;
            uc_tinnhan_text1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uc_tinnhan_text1.Location = new Point(54, 6);
            uc_tinnhan_text1.Margin = new Padding(4, 0, 4, 0);
            uc_tinnhan_text1.Name = "uc_tinnhan_text1";
            uc_tinnhan_text1.Size = new Size(412, 50);
            uc_tinnhan_text1.TabIndex = 2;
            uc_tinnhan_text1.Text = "  label1";
            uc_tinnhan_text1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uc_tinnhan_ava1
            // 
            uc_tinnhan_ava1.FillColor = Color.Transparent;
            uc_tinnhan_ava1.Image = Properties.Resources.customer_service__1_;
            uc_tinnhan_ava1.ImageRotate = 0F;
            uc_tinnhan_ava1.Location = new Point(-3, 6);
            uc_tinnhan_ava1.Name = "uc_tinnhan_ava1";
            uc_tinnhan_ava1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            uc_tinnhan_ava1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            uc_tinnhan_ava1.Size = new Size(50, 50);
            uc_tinnhan_ava1.SizeMode = PictureBoxSizeMode.StretchImage;
            uc_tinnhan_ava1.TabIndex = 3;
            uc_tinnhan_ava1.TabStop = false;
            // 
            // uc_tinnhan_hotro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(uc_tinnhan_ava1);
            Controls.Add(uc_tinnhan_text1);
            Name = "uc_tinnhan_hotro";
            Size = new Size(450, 62);
            ((System.ComponentModel.ISupportInitialize)uc_tinnhan_ava1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label uc_tinnhan_text1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox uc_tinnhan_ava1;
    }
}
