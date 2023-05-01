namespace lab2
{
    partial class uc_item
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
            panel1 = new Panel();
            radio_item = new Guna.UI2.WinForms.Guna2RadioButton();
            pic_item = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_item).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(radio_item);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 50);
            panel1.TabIndex = 0;
            // 
            // radio_item
            // 
            radio_item.AutoSize = true;
            radio_item.CheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radio_item.CheckedState.BorderThickness = 2;
            radio_item.CheckedState.FillColor = Color.Transparent;
            radio_item.CheckedState.InnerColor = Color.FromArgb(125, 137, 149);
            radio_item.CheckedState.InnerOffset = -2;
            radio_item.Dock = DockStyle.Fill;
            radio_item.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radio_item.Location = new Point(0, 0);
            radio_item.Name = "radio_item";
            radio_item.Size = new Size(228, 50);
            radio_item.TabIndex = 0;
            radio_item.Text = "guna2RadioButton1";
            radio_item.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radio_item.UncheckedState.BorderThickness = 2;
            radio_item.UncheckedState.FillColor = Color.Transparent;
            radio_item.UncheckedState.InnerColor = Color.Transparent;
            // 
            // pic_item
            // 
            pic_item.BackColor = Color.FromArgb(255, 192, 192);
            pic_item.Dock = DockStyle.Fill;
            pic_item.Location = new Point(0, 0);
            pic_item.Name = "pic_item";
            pic_item.Size = new Size(228, 217);
            pic_item.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_item.TabIndex = 1;
            pic_item.TabStop = false;
            // 
            // uc_item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pic_item);
            Controls.Add(panel1);
            Name = "uc_item";
            Size = new Size(228, 267);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_item).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2RadioButton radio_item;
        private PictureBox pic_item;
    }
}
