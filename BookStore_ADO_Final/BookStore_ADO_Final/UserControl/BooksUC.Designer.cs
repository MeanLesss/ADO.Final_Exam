namespace BookStore_ADO_Final.UserControl
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
            this.iconButtonRefresh = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddPublisher = new FontAwesome.Sharp.IconButton();
            this.iconButtonAddAuthor = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.iconButtonSaveAdd = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancelAdd = new FontAwesome.Sharp.IconButton();
            this.checkBoxSequel = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.iconPictureBoxBookCover = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrimeCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelDisplayBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBookCover)).BeginInit();
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
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.iconButtonRefresh);
            this.tabPage1.Controls.Add(this.iconButtonAddPublisher);
            this.tabPage1.Controls.Add(this.iconButtonAddAuthor);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.iconButtonSaveAdd);
            this.tabPage1.Controls.Add(this.iconButtonCancelAdd);
            this.tabPage1.Controls.Add(this.checkBoxSequel);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.comboBoxPublisher);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.comboBoxAuthor);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.iconPictureBoxBookCover);
            this.tabPage1.Controls.Add(this.textBoxGenre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxPages);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxSalePrice);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxPrimeCost);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1829, 975);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iconButtonRefresh
            // 
            this.iconButtonRefresh.FlatAppearance.BorderSize = 0;
            this.iconButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRefresh.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconButtonRefresh.IconColor = System.Drawing.Color.Lime;
            this.iconButtonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRefresh.IconSize = 28;
            this.iconButtonRefresh.Location = new System.Drawing.Point(914, 456);
            this.iconButtonRefresh.Name = "iconButtonRefresh";
            this.iconButtonRefresh.Size = new System.Drawing.Size(45, 33);
            this.iconButtonRefresh.TabIndex = 22;
            this.iconButtonRefresh.UseVisualStyleBackColor = true;
            this.iconButtonRefresh.Click += new System.EventHandler(this.iconButtonRefresh_Click);
            // 
            // iconButtonAddPublisher
            // 
            this.iconButtonAddPublisher.FlatAppearance.BorderSize = 0;
            this.iconButtonAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddPublisher.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddPublisher.IconColor = System.Drawing.Color.Lime;
            this.iconButtonAddPublisher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddPublisher.IconSize = 28;
            this.iconButtonAddPublisher.Location = new System.Drawing.Point(863, 459);
            this.iconButtonAddPublisher.Name = "iconButtonAddPublisher";
            this.iconButtonAddPublisher.Size = new System.Drawing.Size(45, 33);
            this.iconButtonAddPublisher.TabIndex = 21;
            this.iconButtonAddPublisher.UseVisualStyleBackColor = true;
            this.iconButtonAddPublisher.Click += new System.EventHandler(this.iconButtonAddPublisher_Click);
            // 
            // iconButtonAddAuthor
            // 
            this.iconButtonAddAuthor.FlatAppearance.BorderSize = 0;
            this.iconButtonAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddAuthor.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddAuthor.IconColor = System.Drawing.Color.Lime;
            this.iconButtonAddAuthor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddAuthor.IconSize = 28;
            this.iconButtonAddAuthor.Location = new System.Drawing.Point(863, 417);
            this.iconButtonAddAuthor.Name = "iconButtonAddAuthor";
            this.iconButtonAddAuthor.Size = new System.Drawing.Size(45, 33);
            this.iconButtonAddAuthor.TabIndex = 20;
            this.iconButtonAddAuthor.UseVisualStyleBackColor = true;
            this.iconButtonAddAuthor.Click += new System.EventHandler(this.iconButtonAddAuthor_Click);
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
            // iconButtonSaveAdd
            // 
            this.iconButtonSaveAdd.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSaveAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSaveAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonSaveAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaveAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSaveAdd.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonSaveAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonSaveAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaveAdd.IconSize = 28;
            this.iconButtonSaveAdd.Location = new System.Drawing.Point(893, 567);
            this.iconButtonSaveAdd.Name = "iconButtonSaveAdd";
            this.iconButtonSaveAdd.Size = new System.Drawing.Size(122, 40);
            this.iconButtonSaveAdd.TabIndex = 19;
            this.iconButtonSaveAdd.Text = "Save";
            this.iconButtonSaveAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonSaveAdd.UseVisualStyleBackColor = false;
            this.iconButtonSaveAdd.Click += new System.EventHandler(this.iconButtonSaveAdd_Click);
            // 
            // iconButtonCancelAdd
            // 
            this.iconButtonCancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancelAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancelAdd.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.iconButtonCancelAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonCancelAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancelAdd.IconSize = 28;
            this.iconButtonCancelAdd.Location = new System.Drawing.Point(672, 567);
            this.iconButtonCancelAdd.Name = "iconButtonCancelAdd";
            this.iconButtonCancelAdd.Size = new System.Drawing.Size(122, 40);
            this.iconButtonCancelAdd.TabIndex = 18;
            this.iconButtonCancelAdd.Text = "Cancel";
            this.iconButtonCancelAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancelAdd.UseVisualStyleBackColor = true;
            this.iconButtonCancelAdd.Click += new System.EventHandler(this.iconButtonCancelAdd_Click);
            // 
            // checkBoxSequel
            // 
            this.checkBoxSequel.AutoSize = true;
            this.checkBoxSequel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSequel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSequel.Location = new System.Drawing.Point(616, 503);
            this.checkBoxSequel.Name = "checkBoxSequel";
            this.checkBoxSequel.Size = new System.Drawing.Size(114, 29);
            this.checkBoxSequel.TabIndex = 17;
            this.checkBoxSequel.Text = "IsSequel";
            this.checkBoxSequel.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(449, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Sequel";
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Items.AddRange(new object[] {
            "asdf",
            "s",
            "dgg",
            "f",
            "g",
            "dh"});
            this.comboBoxPublisher.Location = new System.Drawing.Point(616, 456);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(241, 33);
            this.comboBoxPublisher.TabIndex = 15;
            this.comboBoxPublisher.Click += new System.EventHandler(this.comboBoxPublisher_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(449, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Publisher name";
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Items.AddRange(new object[] {
            "sadf",
            "asdf",
            "asdf",
            "sadf"});
            this.comboBoxAuthor.Location = new System.Drawing.Point(616, 417);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(241, 33);
            this.comboBoxAuthor.TabIndex = 13;
            this.comboBoxAuthor.Click += new System.EventHandler(this.comboBoxAuthor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(449, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1021, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Book Cover";
            // 
            // iconPictureBoxBookCover
            // 
            this.iconPictureBoxBookCover.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBoxBookCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxBookCover.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBoxBookCover.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBoxBookCover.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBoxBookCover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxBookCover.IconSize = 206;
            this.iconPictureBoxBookCover.Location = new System.Drawing.Point(980, 214);
            this.iconPictureBoxBookCover.Name = "iconPictureBoxBookCover";
            this.iconPictureBoxBookCover.Size = new System.Drawing.Size(206, 236);
            this.iconPictureBoxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBoxBookCover.TabIndex = 10;
            this.iconPictureBoxBookCover.TabStop = false;
            this.iconPictureBoxBookCover.Click += new System.EventHandler(this.iconPictureBoxBookCover_Click);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.Location = new System.Drawing.Point(616, 341);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(241, 31);
            this.textBoxGenre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre";
            // 
            // textBoxPages
            // 
            this.textBoxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPages.Location = new System.Drawing.Point(616, 304);
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.Size = new System.Drawing.Size(241, 31);
            this.textBoxPages.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pages";
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalePrice.Location = new System.Drawing.Point(616, 267);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(241, 31);
            this.textBoxSalePrice.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sale Price";
            // 
            // textBoxPrimeCost
            // 
            this.textBoxPrimeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrimeCost.Location = new System.Drawing.Point(616, 230);
            this.textBoxPrimeCost.Name = "textBoxPrimeCost";
            this.textBoxPrimeCost.Size = new System.Drawing.Size(241, 31);
            this.textBoxPrimeCost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prime cost";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(616, 193);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(241, 31);
            this.textBoxTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelDisplayBooks);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1829, 975);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1829, 975);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Promotion";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(449, 381);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Publish Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 24);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // panelDisplayBooks
            // 
            this.panelDisplayBooks.Location = new System.Drawing.Point(41, 89);
            this.panelDisplayBooks.Name = "panelDisplayBooks";
            this.panelDisplayBooks.Size = new System.Drawing.Size(1762, 866);
            this.panelDisplayBooks.TabIndex = 17;
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
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxBookCover)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrimeCost;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBookCover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxSequel;
        private FontAwesome.Sharp.IconButton iconButtonSaveAdd;
        private FontAwesome.Sharp.IconButton iconButtonCancelAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton iconButtonAddPublisher;
        private FontAwesome.Sharp.IconButton iconButtonAddAuthor;
        private FontAwesome.Sharp.IconButton iconButtonRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel panelDisplayBooks;
    }
}
