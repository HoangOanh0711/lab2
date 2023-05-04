namespace lab2
{
    partial class uc_tinnhan_ngdung
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
            uc_tinnhan_text2 = new Label();
            SuspendLayout();
            // 
            // uc_tinnhan_text2
            // 
            uc_tinnhan_text2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uc_tinnhan_text2.BackColor = Color.FromArgb(192, 192, 255);
            uc_tinnhan_text2.Location = new Point(66, 9);
            uc_tinnhan_text2.Margin = new Padding(4, 0, 4, 0);
            uc_tinnhan_text2.Name = "uc_tinnhan_text2";
            uc_tinnhan_text2.Size = new Size(384, 50);
            uc_tinnhan_text2.TabIndex = 1;
            uc_tinnhan_text2.Text = "  label1";
            uc_tinnhan_text2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uc_tinnhan_ngdung
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(uc_tinnhan_text2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "uc_tinnhan_ngdung";
            Size = new Size(450, 67);
            ResumeLayout(false);
        }

        #endregion

        private Label uc_tinnhan_text2;
    }
}
