namespace BookStore_ADO_Final.UserControl
{
    partial class AuthorInfoUC
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
            this.listBoxAuthor = new System.Windows.Forms.ListBox();
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.iconButtonAddAuthor = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 44);
            this.label3.TabIndex = 17;
            this.label3.Text = "Authors";
            // 
            // listBoxAuthor
            // 
            this.listBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAuthor.FormattingEnabled = true;
            this.listBoxAuthor.ItemHeight = 29;
            this.listBoxAuthor.Items.AddRange(new object[] {
            "sdf",
            "sd",
            "fs",
            "df",
            "sd",
            "fd"});
            this.listBoxAuthor.Location = new System.Drawing.Point(355, 270);
            this.listBoxAuthor.Name = "listBoxAuthor";
            this.listBoxAuthor.Size = new System.Drawing.Size(1001, 613);
            this.listBoxAuthor.TabIndex = 18;
            this.listBoxAuthor.Click += new System.EventHandler(this.listBoxAuthor_Click);
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.FlatAppearance.BorderSize = 0;
            this.iconButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Lime;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 28;
            this.iconButtonRefresh.Location = new System.Drawing.Point(1193, 113);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(44, 34);
            this.iconButtonRefresh.TabIndex = 23;
            this.iconButtonRefresh.UseVisualStyleBackColor = true;
            this.iconButtonRefresh.Click += new System.EventHandler(this.iconButtonRefresh_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 28;
            this.iconButtonSearch.Location = new System.Drawing.Point(1065, 110);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(102, 34);
            this.iconButtonSearch.TabIndex = 22;
            this.iconButtonSearch.Text = "Search";
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.Location = new System.Drawing.Point(515, 109);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(525, 35);
            this.textBoxSearch.TabIndex = 21;
            this.textBoxSearch.Text = "Author";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            // 
            // iconButtonAddAuthor
            // 
            this.iconButtonAddAuthor.FlatAppearance.BorderSize = 0;
            this.iconButtonAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddAuthor.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddAuthor.IconColor = System.Drawing.Color.Lime;
            this.iconButtonAddAuthor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddAuthor.IconSize = 28;
            this.iconButtonAddAuthor.Location = new System.Drawing.Point(355, 208);
            this.iconButtonAddAuthor.Name = "iconButtonAddAuthor";
            this.iconButtonAddAuthor.Size = new System.Drawing.Size(44, 34);
            this.iconButtonAddAuthor.TabIndex = 24;
            this.iconButtonAddAuthor.UseVisualStyleBackColor = true;
            this.iconButtonAddAuthor.Click += new System.EventHandler(this.iconButtonAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(695, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "click on the name to edit";
            // 
            // AuthorInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButtonAddAuthor);
            this.Controls.Add(this.iconButtonRefresh);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBoxAuthor);
            this.Controls.Add(this.label3);
            this.Name = "AuthorInfoUC";
            this.Size = new System.Drawing.Size(1829, 975);
            this.Load += new System.EventHandler(this.AuthorInfoUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxAuthor;
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonAddAuthor;
        private System.Windows.Forms.Label label1;
    }
}
