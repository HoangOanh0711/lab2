namespace lab2
{
    partial class uc_traodoi
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tk_panel = new Guna.UI2.WinForms.Guna2Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tk_tentk = new Label();
            tk_avatartk = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label5 = new Label();
            tk_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tk_avatartk).BeginInit();
            SuspendLayout();
            // 
            // tk_panel
            // 
            tk_panel.BackColor = Color.White;
            tk_panel.Controls.Add(label3);
            tk_panel.Controls.Add(label1);
            tk_panel.Controls.Add(label2);
            tk_panel.Controls.Add(tk_tentk);
            tk_panel.Controls.Add(tk_avatartk);
            tk_panel.CustomizableEdges = customizableEdges2;
            tk_panel.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            tk_panel.Location = new Point(0, 57);
            tk_panel.Name = "tk_panel";
            tk_panel.ShadowDecoration.CustomizableEdges = customizableEdges3;
            tk_panel.Size = new Size(485, 119);
            tk_panel.TabIndex = 1;
            tk_panel.Click += tk_avatartk_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(429, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 18);
            label3.TabIndex = 4;
            label3.Text = "15/4";
            label3.Click += tk_avatartk_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(370, 66);
            label1.Name = "label1";
            label1.Size = new Size(101, 34);
            label1.TabIndex = 3;
            label1.Text = "Lưu trữ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += tk_avatartk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(132, 66);
            label2.Name = "label2";
            label2.Size = new Size(201, 18);
            label2.TabIndex = 2;
            label2.Text = "Cảm ơn anh/chị đã liên hệ...";
            label2.Click += tk_avatartk_Click;
            // 
            // tk_tentk
            // 
            tk_tentk.AutoSize = true;
            tk_tentk.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tk_tentk.Location = new Point(132, 32);
            tk_tentk.Name = "tk_tentk";
            tk_tentk.Size = new Size(148, 22);
            tk_tentk.TabIndex = 1;
            tk_tentk.Text = "Trung tâm hỗ trợ";
            tk_tentk.Click += tk_avatartk_Click;
            // 
            // tk_avatartk
            // 
            tk_avatartk.FillColor = Color.Transparent;
            tk_avatartk.Image = Properties.Resources.customer_service__1_;
            tk_avatartk.ImageRotate = 0F;
            tk_avatartk.Location = new Point(23, 15);
            tk_avatartk.Name = "tk_avatartk";
            tk_avatartk.ShadowDecoration.CustomizableEdges = customizableEdges1;
            tk_avatartk.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            tk_avatartk.Size = new Size(85, 85);
            tk_avatartk.SizeMode = PictureBoxSizeMode.StretchImage;
            tk_avatartk.TabIndex = 0;
            tk_avatartk.TabStop = false;
            tk_avatartk.Click += tk_avatartk_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(18, 17);
            label5.Name = "label5";
            label5.Size = new Size(98, 24);
            label5.TabIndex = 3;
            label5.Text = "Tin nhắn";
            // 
            // uc_traodoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label5);
            Controls.Add(tk_panel);
            Name = "uc_traodoi";
            Size = new Size(485, 665);
            tk_panel.ResumeLayout(false);
            tk_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tk_avatartk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel tk_panel;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label tk_tentk;
        private Guna.UI2.WinForms.Guna2CirclePictureBox tk_avatartk;
        private Label label5;
    }
}
