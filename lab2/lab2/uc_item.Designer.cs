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
            radio_item = new Guna.UI2.WinForms.Guna2RadioButton();
            pic_item = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_item).BeginInit();
            SuspendLayout();
            // 
            // radio_item
            // 
            radio_item.CheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            radio_item.CheckedState.BorderThickness = 2;
            radio_item.CheckedState.FillColor = Color.Transparent;
            radio_item.CheckedState.InnerColor = Color.FromArgb(125, 137, 149);
            radio_item.CheckedState.InnerOffset = -2;
            radio_item.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            radio_item.Location = new Point(0, 217);
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
            Controls.Add(radio_item);
            Controls.Add(pic_item);
            Name = "uc_item";
            Size = new Size(228, 267);
            ((System.ComponentModel.ISupportInitialize)pic_item).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2RadioButton radio_item;
        private PictureBox pic_item;
    }
}
