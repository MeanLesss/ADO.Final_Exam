namespace BookStore_ADO_Final.UserControl
{
    partial class PublisherInfoUC
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
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconButtonAddPub = new FontAwesome.Sharp.IconButton();
            this.listBoxPublisher = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.FlatAppearance.BorderSize = 0;
            this.iconButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Lime;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 28;
            this.iconButtonRefresh.Location = new System.Drawing.Point(1180, 93);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(44, 34);
            this.iconButtonRefresh.TabIndex = 24;
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
            this.iconButtonSearch.Location = new System.Drawing.Point(1056, 90);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(102, 34);
            this.iconButtonSearch.TabIndex = 23;
            this.iconButtonSearch.Text = "Search";
            this.iconButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch.UseVisualStyleBackColor = false;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxSearch.Location = new System.Drawing.Point(506, 89);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(525, 35);
            this.textBoxSearch.TabIndex = 22;
            this.textBoxSearch.Text = "Publisher";
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 44);
            this.label3.TabIndex = 21;
            this.label3.Text = "Publishers";
            // 
            // iconButtonAddPub
            // 
            this.iconButtonAddPub.FlatAppearance.BorderSize = 0;
            this.iconButtonAddPub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddPub.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddPub.IconColor = System.Drawing.Color.Lime;
            this.iconButtonAddPub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddPub.IconSize = 28;
            this.iconButtonAddPub.Location = new System.Drawing.Point(357, 191);
            this.iconButtonAddPub.Name = "iconButtonAddPub";
            this.iconButtonAddPub.Size = new System.Drawing.Size(44, 34);
            this.iconButtonAddPub.TabIndex = 25;
            this.iconButtonAddPub.UseVisualStyleBackColor = true;
            this.iconButtonAddPub.Click += new System.EventHandler(this.iconButtonAddPub_Click);
            // 
            // listBoxPublisher
            // 
            this.listBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPublisher.FormattingEnabled = true;
            this.listBoxPublisher.ItemHeight = 29;
            this.listBoxPublisher.Items.AddRange(new object[] {
            "sdf",
            "sd",
            "fs",
            "df",
            "sd",
            "fd"});
            this.listBoxPublisher.Location = new System.Drawing.Point(357, 247);
            this.listBoxPublisher.Name = "listBoxPublisher";
            this.listBoxPublisher.Size = new System.Drawing.Size(1001, 613);
            this.listBoxPublisher.TabIndex = 26;
            this.listBoxPublisher.Click += new System.EventHandler(this.listBoxPublisher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(666, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "click on the name to edit";
            // 
            // PublisherInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPublisher);
            this.Controls.Add(this.iconButtonAddPub);
            this.Controls.Add(this.iconButtonRefresh);
            this.Controls.Add(this.iconButtonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Name = "PublisherInfoUC";
            this.Size = new System.Drawing.Size(1829, 975);
            this.Load += new System.EventHandler(this.PublisherInfoUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButtonAddPub;
        private System.Windows.Forms.ListBox listBoxPublisher;
        private System.Windows.Forms.Label label1;
    }
}
