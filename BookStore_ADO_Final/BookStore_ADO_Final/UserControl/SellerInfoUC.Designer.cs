namespace BookStore_ADO_Final.UserControl
{
    partial class SellerInfoUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSeller = new System.Windows.Forms.ListBox();
            this.iconButtonAddSeller = new FontAwesome.Sharp.IconButton();
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "click on the name to edit";
            // 
            // listBoxSeller
            // 
            this.listBoxSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSeller.FormattingEnabled = true;
            this.listBoxSeller.ItemHeight = 29;
            this.listBoxSeller.Items.AddRange(new object[] {
            "sdf",
            "sd",
            "fs",
            "df",
            "sd",
            "fd"});
            this.listBoxSeller.Location = new System.Drawing.Point(357, 243);
            this.listBoxSeller.Name = "listBoxSeller";
            this.listBoxSeller.Size = new System.Drawing.Size(1001, 613);
            this.listBoxSeller.TabIndex = 33;
            this.listBoxSeller.Click += new System.EventHandler(this.listBoxSeller_Click);
            // 
            // iconButtonAddSeller
            // 
            this.iconButtonAddSeller.FlatAppearance.BorderSize = 0;
            this.iconButtonAddSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddSeller.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddSeller.IconColor = System.Drawing.Color.Lime;
            this.iconButtonAddSeller.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddSeller.IconSize = 28;
            this.iconButtonAddSeller.Location = new System.Drawing.Point(357, 187);
            this.iconButtonAddSeller.Name = "iconButtonAddSeller";
            this.iconButtonAddSeller.Size = new System.Drawing.Size(44, 34);
            this.iconButtonAddSeller.TabIndex = 32;
            this.iconButtonAddSeller.UseVisualStyleBackColor = true;
            this.iconButtonAddSeller.Click += new System.EventHandler(this.iconButtonAddSeller_Click);
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.FlatAppearance.BorderSize = 0;
            this.iconButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Lime;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 28;
            this.iconButtonRefresh.Location = new System.Drawing.Point(1180, 89);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(44, 34);
            this.iconButtonRefresh.TabIndex = 31;
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
            this.iconButtonSearch.Location = new System.Drawing.Point(1056, 86);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(102, 34);
            this.iconButtonSearch.TabIndex = 30;
            this.iconButtonSearch.Text = "Search";
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.Location = new System.Drawing.Point(506, 85);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(525, 35);
            this.textBoxSearch.TabIndex = 29;
            this.textBoxSearch.Text = "Sellers";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 44);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sellers";
            // 
            // SellerInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSeller);
            this.Controls.Add(this.iconButtonAddSeller);
            this.Controls.Add(this.iconButtonRefresh);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Name = "SellerInfoUC";
            this.Size = new System.Drawing.Size(1829, 975);
            this.Load += new System.EventHandler(this.SellerInfoUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSeller;
        private FontAwesome.Sharp.IconButton iconButtonAddSeller;
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
    }
}
