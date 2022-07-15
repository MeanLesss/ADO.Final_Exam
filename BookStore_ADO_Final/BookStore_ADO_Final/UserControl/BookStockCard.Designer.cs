namespace BookStore_ADO_Final.UserControl
{
    partial class BookStockCard
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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.iconPictureBoxBookCover = new FontAwesome.Sharp.IconPictureBox();
            this.iconButtonAddQuantity = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinus = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(14, 318);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(192, 24);
            this.textBoxTitle.TabIndex = 3;
            this.textBoxTitle.Text = "Title";
            // 
            // iconPictureBoxBookCover
            // 
            this.iconPictureBoxBookCover.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxBookCover.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBoxBookCover.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBoxBookCover.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBoxBookCover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBookCover.IconSize = 289;
            this.iconPictureBoxBookCover.Location = new System.Drawing.Point(3, 8);
            this.iconPictureBoxBookCover.Name = "iconPictureBoxBookCover";
            this.iconPictureBoxBookCover.Size = new System.Drawing.Size(319, 289);
            this.iconPictureBoxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxBookCover.TabIndex = 2;
            this.iconPictureBoxBookCover.TabStop = false;
            // 
            // iconButtonAddQuantity
            // 
            this.iconButtonAddQuantity.FlatAppearance.BorderSize = 0;
            this.iconButtonAddQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddQuantity.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddQuantity.IconColor = System.Drawing.Color.Lime;
            this.iconButtonAddQuantity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddQuantity.IconSize = 38;
            this.iconButtonAddQuantity.Location = new System.Drawing.Point(130, 362);
            this.iconButtonAddQuantity.Name = "iconButtonAddQuantity";
            this.iconButtonAddQuantity.Size = new System.Drawing.Size(43, 41);
            this.iconButtonAddQuantity.TabIndex = 4;
            this.iconButtonAddQuantity.UseVisualStyleBackColor = true;
            this.iconButtonAddQuantity.Click += new System.EventHandler(this.iconButtonAddQuantity_Click);
            // 
            // iconButtonMinus
            // 
            this.iconButtonMinus.FlatAppearance.BorderSize = 0;
            this.iconButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButtonMinus.IconColor = System.Drawing.Color.Lime;
            this.iconButtonMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinus.IconSize = 38;
            this.iconButtonMinus.Location = new System.Drawing.Point(14, 362);
            this.iconButtonMinus.Name = "iconButtonMinus";
            this.iconButtonMinus.Size = new System.Drawing.Size(43, 41);
            this.iconButtonMinus.TabIndex = 5;
            this.iconButtonMinus.UseVisualStyleBackColor = true;
            this.iconButtonMinus.Click += new System.EventHandler(this.iconButtonMinus_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSave.FlatAppearance.BorderSize = 0;
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonSave.IconColor = System.Drawing.Color.Black;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 28;
            this.iconButtonSave.Location = new System.Drawing.Point(201, 366);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(109, 31);
            this.iconButtonSave.TabIndex = 6;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(63, 366);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(61, 31);
            this.textBoxQuantity.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Lime;
            this.labelPrice.Location = new System.Drawing.Point(227, 322);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "$100,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(212, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "$";
            // 
            // BookStockCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.iconButtonMinus);
            this.Controls.Add(this.iconButtonAddQuantity);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.iconPictureBoxBookCover);
            this.Name = "BookStockCard";
            this.Size = new System.Drawing.Size(325, 419);
            this.Load += new System.EventHandler(this.BookStockCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBookCover;
        private FontAwesome.Sharp.IconButton iconButtonAddQuantity;
        private FontAwesome.Sharp.IconButton iconButtonMinus;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label1;
    }
}
