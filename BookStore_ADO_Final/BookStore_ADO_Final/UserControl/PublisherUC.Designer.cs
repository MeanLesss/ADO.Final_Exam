namespace BookStore_ADO_Final.UserControl
{
    partial class PublisherUC
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
            this.iconButtonSavePub = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPubName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerPubDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // iconButtonSavePub
            // 
            this.iconButtonSavePub.BackColor = System.Drawing.Color.Lime;
            this.iconButtonSavePub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSavePub.FlatAppearance.BorderSize = 0;
            this.iconButtonSavePub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSavePub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSavePub.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButtonSavePub.IconColor = System.Drawing.Color.Black;
            this.iconButtonSavePub.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSavePub.IconSize = 28;
            this.iconButtonSavePub.Location = new System.Drawing.Point(320, 260);
            this.iconButtonSavePub.Name = "iconButtonSavePub";
            this.iconButtonSavePub.Size = new System.Drawing.Size(122, 40);
            this.iconButtonSavePub.TabIndex = 29;
            this.iconButtonSavePub.Text = "Save";
            this.iconButtonSavePub.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonSavePub.UseVisualStyleBackColor = false;
            this.iconButtonSavePub.Click += new System.EventHandler(this.iconButtonSavePub_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Publish Date";
            // 
            // textBoxPubName
            // 
            this.textBoxPubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPubName.Location = new System.Drawing.Point(320, 112);
            this.textBoxPubName.Name = "textBoxPubName";
            this.textBoxPubName.Size = new System.Drawing.Size(241, 31);
            this.textBoxPubName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Publisher name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(1, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(222, 44);
            this.label11.TabIndex = 23;
            this.label11.Text = "Publishers";
            // 
            // dateTimePickerPubDate
            // 
            this.dateTimePickerPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerPubDate.Location = new System.Drawing.Point(320, 156);
            this.dateTimePickerPubDate.Name = "dateTimePickerPubDate";
            this.dateTimePickerPubDate.Size = new System.Drawing.Size(241, 22);
            this.dateTimePickerPubDate.TabIndex = 30;
            // 
            // PublisherUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerPubDate);
            this.Controls.Add(this.iconButtonSavePub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPubName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "PublisherUC";
            this.Size = new System.Drawing.Size(794, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonSavePub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPubName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerPubDate;
    }
}
