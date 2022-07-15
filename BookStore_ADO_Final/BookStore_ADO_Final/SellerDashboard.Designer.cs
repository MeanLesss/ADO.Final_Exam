namespace BookStore_ADO_Final
{
    partial class SellerDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOption = new System.Windows.Forms.Panel();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelUserbanner = new System.Windows.Forms.Panel();
            this.iconButtonUserConf = new FontAwesome.Sharp.IconButton();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.ButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.iconButtonBooks = new FontAwesome.Sharp.IconButton();
            this.panelOption.SuspendLayout();
            this.panelUserbanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOption.Controls.Add(this.iconButtonDashboard);
            this.panelOption.Controls.Add(this.iconButtonBooks);
            this.panelOption.Controls.Add(this.panelUserbanner);
            this.panelOption.Controls.Add(this.ButtonLogOut);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(313, 751);
            this.panelOption.TabIndex = 3;
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.BackColor = System.Drawing.Color.Lime;
            this.iconButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDashboard.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.Black;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.IconSize = 28;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 143);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Size = new System.Drawing.Size(313, 45);
            this.iconButtonDashboard.TabIndex = 2;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonDashboard.UseVisualStyleBackColor = false;
            // 
            // panelUserbanner
            // 
            this.panelUserbanner.Controls.Add(this.iconButtonUserConf);
            this.panelUserbanner.Controls.Add(this.labelID);
            this.panelUserbanner.Controls.Add(this.label3);
            this.panelUserbanner.Controls.Add(this.labelUsername);
            this.panelUserbanner.Controls.Add(this.label1);
            this.panelUserbanner.Controls.Add(this.iconPictureBoxUser);
            this.panelUserbanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserbanner.Location = new System.Drawing.Point(0, 0);
            this.panelUserbanner.Name = "panelUserbanner";
            this.panelUserbanner.Size = new System.Drawing.Size(313, 98);
            this.panelUserbanner.TabIndex = 1;
            // 
            // iconButtonUserConf
            // 
            this.iconButtonUserConf.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonUserConf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonUserConf.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonUserConf.FlatAppearance.BorderSize = 0;
            this.iconButtonUserConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUserConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUserConf.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.iconButtonUserConf.IconColor = System.Drawing.Color.DarkGreen;
            this.iconButtonUserConf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUserConf.IconSize = 28;
            this.iconButtonUserConf.Location = new System.Drawing.Point(278, 3);
            this.iconButtonUserConf.Name = "iconButtonUserConf";
            this.iconButtonUserConf.Size = new System.Drawing.Size(32, 45);
            this.iconButtonUserConf.TabIndex = 4;
            this.iconButtonUserConf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonUserConf.UseVisualStyleBackColor = false;
            this.iconButtonUserConf.Click += new System.EventHandler(this.iconButtonUserConf_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(131, 60);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(70, 16);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(129, 25);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(118, 25);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // iconPictureBoxUser
            // 
            this.iconPictureBoxUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBoxUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBoxUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxUser.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBoxUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUser.IconSize = 98;
            this.iconPictureBoxUser.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBoxUser.Name = "iconPictureBoxUser";
            this.iconPictureBoxUser.Size = new System.Drawing.Size(98, 98);
            this.iconPictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBoxUser.TabIndex = 0;
            this.iconPictureBoxUser.TabStop = false;
            // 
            // ButtonLogOut
            // 
            this.ButtonLogOut.BackColor = System.Drawing.Color.Lime;
            this.ButtonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLogOut.FlatAppearance.BorderSize = 0;
            this.ButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.ButtonLogOut.IconColor = System.Drawing.Color.Black;
            this.ButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonLogOut.IconSize = 28;
            this.ButtonLogOut.Location = new System.Drawing.Point(0, 706);
            this.ButtonLogOut.Name = "ButtonLogOut";
            this.ButtonLogOut.Size = new System.Drawing.Size(313, 45);
            this.ButtonLogOut.TabIndex = 0;
            this.ButtonLogOut.Text = "Log out";
            this.ButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonLogOut.UseVisualStyleBackColor = false;
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1219, 751);
            this.panelControl.TabIndex = 4;
            // 
            // iconButtonBooks
            // 
            this.iconButtonBooks.BackColor = System.Drawing.Color.Lime;
            this.iconButtonBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonBooks.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBooks.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButtonBooks.IconColor = System.Drawing.Color.Black;
            this.iconButtonBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBooks.IconSize = 28;
            this.iconButtonBooks.Location = new System.Drawing.Point(0, 98);
            this.iconButtonBooks.Name = "iconButtonBooks";
            this.iconButtonBooks.Size = new System.Drawing.Size(313, 45);
            this.iconButtonBooks.TabIndex = 4;
            this.iconButtonBooks.Text = "Books";
            this.iconButtonBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonBooks.UseVisualStyleBackColor = false;
            // 
            // SellerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 751);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panelControl);
            this.Name = "SellerDashboard";
            this.Text = "SellerDashboard";
            this.panelOption.ResumeLayout(false);
            this.panelUserbanner.ResumeLayout(false);
            this.panelUserbanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonBooks;
        private System.Windows.Forms.Panel panelUserbanner;
        private FontAwesome.Sharp.IconButton iconButtonUserConf;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private FontAwesome.Sharp.IconButton ButtonLogOut;
        private System.Windows.Forms.Panel panelControl;
    }
}