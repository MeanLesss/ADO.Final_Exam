﻿namespace BookStore_ADO_Final.UserControl
{
    partial class BooksUC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelDisplayBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.panelOnSale = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButtonRefreshSale = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearchStock = new FontAwesome.Sharp.IconButton();
            this.textBoxSearchStock = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1837, 1001);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelBookInfo);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1829, 975);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.Location = new System.Drawing.Point(458, 178);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(858, 575);
            this.panelBookInfo.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(6, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 44);
            this.label11.TabIndex = 15;
            this.label11.Text = "Books";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.iconButtonRefresh);
            this.tabPage2.Controls.Add(this.iconButtonSearch);
            this.tabPage2.Controls.Add(this.textBoxSearch);
            this.tabPage2.Controls.Add(this.panelDisplayBooks);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1829, 975);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.FlatAppearance.BorderSize = 0;
            this.iconButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Lime;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 28;
            this.iconButtonRefresh.Location = new System.Drawing.Point(500, 26);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(44, 34);
            this.iconButtonRefresh.TabIndex = 20;
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
            this.iconButtonSearch.Location = new System.Drawing.Point(1109, 23);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(102, 34);
            this.iconButtonSearch.TabIndex = 19;
            this.iconButtonSearch.Text = "Search";
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.Location = new System.Drawing.Point(559, 22);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(525, 35);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.Text = "Title, Author, Genre";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // panelDisplayBooks
            // 
            this.panelDisplayBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDisplayBooks.AutoScroll = true;
            this.panelDisplayBooks.Location = new System.Drawing.Point(250, 103);
            this.panelDisplayBooks.Name = "panelDisplayBooks";
            this.panelDisplayBooks.Size = new System.Drawing.Size(1253, 866);
            this.panelDisplayBooks.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 44);
            this.label3.TabIndex = 16;
            this.label3.Text = "Books";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.iconButtonRefreshSale);
            this.tabPage3.Controls.Add(this.iconButtonSearchStock);
            this.tabPage3.Controls.Add(this.textBoxSearchStock);
            this.tabPage3.Controls.Add(this.panelOnSale);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1829, 975);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "On Sale";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(6, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 44);
            this.label12.TabIndex = 16;
            this.label12.Text = "Books";
            // 
            // panelOnSale
            // 
            this.panelOnSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOnSale.AutoScroll = true;
            this.panelOnSale.Location = new System.Drawing.Point(285, 171);
            this.panelOnSale.Name = "panelOnSale";
            this.panelOnSale.Size = new System.Drawing.Size(1253, 798);
            this.panelOnSale.TabIndex = 18;
            // 
            // iconButtonRefreshSale
            // 
            this.iconButtonRefreshSale.FlatAppearance.BorderSize = 0;
            this.iconButtonRefreshSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefreshSale.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButtonRefreshSale.IconColor = System.Drawing.Color.Lime;
            this.iconButtonRefreshSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefreshSale.IconSize = 28;
            this.iconButtonRefreshSale.Location = new System.Drawing.Point(544, 92);
            this.iconButtonRefreshSale.Name = "iconButtonRefreshSale";
            this.iconButtonRefreshSale.Size = new System.Drawing.Size(44, 34);
            this.iconButtonRefreshSale.TabIndex = 23;
            this.iconButtonRefreshSale.UseVisualStyleBackColor = true;
            this.iconButtonRefreshSale.Click += new System.EventHandler(this.iconButtonRefreshSale_Click);
            // 
            // iconButtonSearchStock
            // 
            this.iconButtonSearchStock.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSearchStock.FlatAppearance.BorderSize = 0;
            this.iconButtonSearchStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearchStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearchStock.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonSearchStock.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearchStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchStock.IconSize = 28;
            this.iconButtonSearchStock.Location = new System.Drawing.Point(1153, 89);
            this.iconButtonSearchStock.Name = "iconButtonSearchStock";
            this.iconButtonSearchStock.Size = new System.Drawing.Size(102, 34);
            this.iconButtonSearchStock.TabIndex = 22;
            this.iconButtonSearchStock.Text = "Search";
            this.iconButtonSearchStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearchStock.UseVisualStyleBackColor = false;
            this.iconButtonSearchStock.Click += new System.EventHandler(this.iconButtonSearchStock_Click);
            // 
            // textBoxSearchStock
            // 
            this.textBoxSearchStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchStock.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSearchStock.Location = new System.Drawing.Point(603, 88);
            this.textBoxSearchStock.Name = "textBoxSearchStock";
            this.textBoxSearchStock.Size = new System.Drawing.Size(525, 35);
            this.textBoxSearchStock.TabIndex = 21;
            this.textBoxSearchStock.Text = "Title, Author, Genre";
            this.textBoxSearchStock.Click += new System.EventHandler(this.textBoxSearchStock_Click);
            // 
            // BooksUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "BooksUC";
            this.Size = new System.Drawing.Size(1837, 1001);
            this.Load += new System.EventHandler(this.BooksUC_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel panelDisplayBooks;
        private System.Windows.Forms.Panel panelBookInfo;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private System.Windows.Forms.FlowLayoutPanel panelOnSale;
        private FontAwesome.Sharp.IconButton iconButtonRefreshSale;
        private FontAwesome.Sharp.IconButton iconButtonSearchStock;
        private System.Windows.Forms.TextBox textBoxSearchStock;
    }
}
