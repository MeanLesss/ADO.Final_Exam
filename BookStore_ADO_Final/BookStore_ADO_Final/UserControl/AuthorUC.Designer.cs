namespace BookStore_ADO_Final.UserControl
{
    partial class AuthorUC
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
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAuthLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButtonSaveAuth = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 44);
            this.label11.TabIndex = 16;
            this.label11.Text = "Authors";
            // 
            // textBoxAuthLastname
            // 
            this.textBoxAuthLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthLastname.Location = new System.Drawing.Point(322, 147);
            this.textBoxAuthLastname.Name = "textBoxAuthLastname";
            this.textBoxAuthLastname.Size = new System.Drawing.Size(241, 31);
            this.textBoxAuthLastname.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lastname";
            // 
            // textBoxAuthFirstname
            // 
            this.textBoxAuthFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthFirstname.Location = new System.Drawing.Point(322, 110);
            this.textBoxAuthFirstname.Name = "textBoxAuthFirstname";
            this.textBoxAuthFirstname.Size = new System.Drawing.Size(241, 31);
            this.textBoxAuthFirstname.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Firstname";
            // 
            // iconButtonSaveAuth
            // 
            this.iconButtonSaveAuth.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSaveAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSaveAuth.FlatAppearance.BorderSize = 0;
            this.iconButtonSaveAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaveAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSaveAuth.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonSaveAuth.IconColor = System.Drawing.Color.Black;
            this.iconButtonSaveAuth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaveAuth.IconSize = 28;
            this.iconButtonSaveAuth.Location = new System.Drawing.Point(322, 260);
            this.iconButtonSaveAuth.Name = "iconButtonSaveAuth";
            this.iconButtonSaveAuth.Size = new System.Drawing.Size(122, 40);
            this.iconButtonSaveAuth.TabIndex = 22;
            this.iconButtonSaveAuth.Text = "Save";
            this.iconButtonSaveAuth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonSaveAuth.UseVisualStyleBackColor = false;
            this.iconButtonSaveAuth.Click += new System.EventHandler(this.iconButtonSaveAuth_Click);
            // 
            // AuthorUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButtonSaveAuth);
            this.Controls.Add(this.textBoxAuthLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAuthFirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "AuthorUC";
            this.Size = new System.Drawing.Size(794, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAuthLastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAuthFirstname;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonSaveAuth;
    }
}
