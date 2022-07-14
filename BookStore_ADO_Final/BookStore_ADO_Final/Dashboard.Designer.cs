namespace BookStore_ADO_Final
{
    partial class Dashboard
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
            this.ButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelOption = new System.Windows.Forms.Panel();
            this.iconButtonPublishers = new FontAwesome.Sharp.IconButton();
            this.iconButtonAuthors = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.iconButtonSellers = new FontAwesome.Sharp.IconButton();
            this.iconButtonBooks = new FontAwesome.Sharp.IconButton();
            this.panelUserbanner = new System.Windows.Forms.Panel();
            this.iconButtonUserConf = new FontAwesome.Sharp.IconButton();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBoxUser = new FontAwesome.Sharp.IconPictureBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelOption.SuspendLayout();
            this.panelUserbanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).BeginInit();
            this.SuspendLayout();
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
            this.ButtonLogOut.Location = new System.Drawing.Point(0, 513);
            this.ButtonLogOut.Name = "ButtonLogOut";
            this.ButtonLogOut.Size = new System.Drawing.Size(313, 45);
            this.ButtonLogOut.TabIndex = 0;
            this.ButtonLogOut.Text = "Log out";
            this.ButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonLogOut.UseVisualStyleBackColor = false;
            this.ButtonLogOut.Click += new System.EventHandler(this.ButtonLogOut_Click);
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelOption.Controls.Add(this.iconButtonPublishers);
            this.panelOption.Controls.Add(this.iconButtonAuthors);
            this.panelOption.Controls.Add(this.iconButtonDashboard);
            this.panelOption.Controls.Add(this.iconButtonSellers);
            this.panelOption.Controls.Add(this.iconButtonBooks);
            this.panelOption.Controls.Add(this.panelUserbanner);
            this.panelOption.Controls.Add(this.ButtonLogOut);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(313, 558);
            this.panelOption.TabIndex = 1;
            // 
            // iconButtonPublishers
            // 
            this.iconButtonPublishers.BackColor = System.Drawing.Color.Lime;
            this.iconButtonPublishers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonPublishers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonPublishers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonPublishers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPublishers.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.iconButtonPublishers.IconColor = System.Drawing.Color.Black;
            this.iconButtonPublishers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPublishers.IconSize = 28;
            this.iconButtonPublishers.Location = new System.Drawing.Point(0, 278);
            this.iconButtonPublishers.Name = "iconButtonPublishers";
            this.iconButtonPublishers.Size = new System.Drawing.Size(313, 45);
            this.iconButtonPublishers.TabIndex = 6;
            this.iconButtonPublishers.Text = "Publishers";
            this.iconButtonPublishers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonPublishers.UseVisualStyleBackColor = false;
            this.iconButtonPublishers.Click += new System.EventHandler(this.iconButtonPublishers_Click);
            // 
            // iconButtonAuthors
            // 
            this.iconButtonAuthors.BackColor = System.Drawing.Color.Lime;
            this.iconButtonAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAuthors.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAuthors.IconChar = FontAwesome.Sharp.IconChar.FeatherAlt;
            this.iconButtonAuthors.IconColor = System.Drawing.Color.Black;
            this.iconButtonAuthors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAuthors.IconSize = 28;
            this.iconButtonAuthors.Location = new System.Drawing.Point(0, 233);
            this.iconButtonAuthors.Name = "iconButtonAuthors";
            this.iconButtonAuthors.Size = new System.Drawing.Size(313, 45);
            this.iconButtonAuthors.TabIndex = 5;
            this.iconButtonAuthors.Text = "Auhtors";
            this.iconButtonAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonAuthors.UseVisualStyleBackColor = false;
            this.iconButtonAuthors.Click += new System.EventHandler(this.iconButtonAuthors_Click);
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
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 188);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Size = new System.Drawing.Size(313, 45);
            this.iconButtonDashboard.TabIndex = 2;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonDashboard.UseVisualStyleBackColor = false;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // iconButtonSellers
            // 
            this.iconButtonSellers.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSellers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSellers.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonSellers.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSellers.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonSellers.IconColor = System.Drawing.Color.Black;
            this.iconButtonSellers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSellers.IconSize = 28;
            this.iconButtonSellers.Location = new System.Drawing.Point(0, 143);
            this.iconButtonSellers.Name = "iconButtonSellers";
            this.iconButtonSellers.Size = new System.Drawing.Size(313, 45);
            this.iconButtonSellers.TabIndex = 3;
            this.iconButtonSellers.Text = "Seller";
            this.iconButtonSellers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonSellers.UseVisualStyleBackColor = false;
            this.iconButtonSellers.Click += new System.EventHandler(this.iconButtonSellers_Click);
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
            this.iconButtonBooks.Click += new System.EventHandler(this.iconButtonBooks_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(313, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(910, 558);
            this.panelControl.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonLogOut;
            this.ClientSize = new System.Drawing.Size(1223, 558);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelOption);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelOption.ResumeLayout(false);
            this.panelUserbanner.ResumeLayout(false);
            this.panelUserbanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ButtonLogOut;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panelUserbanner;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUser;
        private System.Windows.Forms.Panel panelControl;
        private FontAwesome.Sharp.IconButton iconButtonSellers;
        private FontAwesome.Sharp.IconButton iconButtonBooks;
        private FontAwesome.Sharp.IconButton iconButtonUserConf;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonPublishers;
        private FontAwesome.Sharp.IconButton iconButtonAuthors;
    }
}