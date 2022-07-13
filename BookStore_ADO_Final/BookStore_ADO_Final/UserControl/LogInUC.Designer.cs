namespace BookStore_ADO_Final
{
    partial class LogInUC
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(192, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(430, 78);
            this.label3.TabIndex = 13;
            this.label3.Text = "Book Store";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.Control;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(288, 345);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(122, 35);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "Sign up";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(291, 207);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(258, 31);
            this.textBoxUsername.TabIndex = 8;
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.BackColor = System.Drawing.Color.Lime;
            this.iconButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLogin.FlatAppearance.BorderSize = 0;
            this.iconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.iconButtonLogin.IconColor = System.Drawing.Color.Black;
            this.iconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogin.IconSize = 28;
            this.iconButtonLogin.Location = new System.Drawing.Point(425, 345);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.Size = new System.Drawing.Size(121, 35);
            this.iconButtonLogin.TabIndex = 11;
            this.iconButtonLogin.Text = "Log in";
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonLogin.UseVisualStyleBackColor = false;
            this.iconButtonLogin.Click += new System.EventHandler(this.iconButtonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(291, 274);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(258, 31);
            this.textBoxPass.TabIndex = 10;
            // 
            // LogInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.iconButtonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPass);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LogInUC";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.LogInUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private FontAwesome.Sharp.IconButton iconButtonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}
