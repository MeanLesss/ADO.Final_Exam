namespace BookStore_ADO_Final.UserControl
{
    partial class BookCardUC
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
            this.iconPictureBoxBookCover = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBoxBookCover
            // 
            this.iconPictureBoxBookCover.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxBookCover.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBoxBookCover.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBoxBookCover.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBoxBookCover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBookCover.IconSize = 289;
            this.iconPictureBoxBookCover.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBoxBookCover.Name = "iconPictureBoxBookCover";
            this.iconPictureBoxBookCover.Size = new System.Drawing.Size(319, 289);
            this.iconPictureBoxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxBookCover.TabIndex = 0;
            this.iconPictureBoxBookCover.TabStop = false;
            this.iconPictureBoxBookCover.Click += new System.EventHandler(this.BookCardUC_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(14, 313);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(296, 93);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "Title";
            this.textBoxTitle.Click += new System.EventHandler(this.BookCardUC_Click);
            // 
            // BookCardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.iconPictureBoxBookCover);
            this.Name = "BookCardUC";
            this.Size = new System.Drawing.Size(325, 419);
            this.Load += new System.EventHandler(this.BookCardUC_Load);
            this.Click += new System.EventHandler(this.BookCardUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBookCover;
        private System.Windows.Forms.TextBox textBoxTitle;
    }
}
