namespace BookStore_ADO_Final.UserControl
{
    partial class DashboardUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNewRelease = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBestSeller = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPopGenre = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxPopAuthor = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 44);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.listBoxPopAuthor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panelPopGenre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panelBestSeller);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelNewRelease);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1829, 975);
            this.panel1.TabIndex = 25;
            // 
            // panelNewRelease
            // 
            this.panelNewRelease.AutoScroll = true;
            this.panelNewRelease.Location = new System.Drawing.Point(168, 111);
            this.panelNewRelease.Name = "panelNewRelease";
            this.panelNewRelease.Size = new System.Drawing.Size(1261, 453);
            this.panelNewRelease.TabIndex = 26;
            this.panelNewRelease.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(162, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "New release";
            // 
            // panelBestSeller
            // 
            this.panelBestSeller.AutoScroll = true;
            this.panelBestSeller.Location = new System.Drawing.Point(168, 633);
            this.panelBestSeller.Name = "panelBestSeller";
            this.panelBestSeller.Size = new System.Drawing.Size(1261, 453);
            this.panelBestSeller.TabIndex = 28;
            this.panelBestSeller.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(162, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 27;
            this.label2.Text = "Best seller";
            // 
            // panelPopGenre
            // 
            this.panelPopGenre.AutoScroll = true;
            this.panelPopGenre.Location = new System.Drawing.Point(168, 1152);
            this.panelPopGenre.Name = "panelPopGenre";
            this.panelPopGenre.Size = new System.Drawing.Size(1261, 453);
            this.panelPopGenre.TabIndex = 30;
            this.panelPopGenre.WrapContents = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(162, 1104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "Popular genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Magneto", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(162, 1621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 35);
            this.label5.TabIndex = 31;
            this.label5.Text = "Popular authors";
            // 
            // listBoxPopAuthor
            // 
            this.listBoxPopAuthor.FormattingEnabled = true;
            this.listBoxPopAuthor.Location = new System.Drawing.Point(171, 1659);
            this.listBoxPopAuthor.Name = "listBoxPopAuthor";
            this.listBoxPopAuthor.Size = new System.Drawing.Size(1258, 446);
            this.listBoxPopAuthor.TabIndex = 32;
            // 
            // DashboardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "DashboardUC";
            this.Size = new System.Drawing.Size(1829, 975);
            this.Load += new System.EventHandler(this.DashboardUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelNewRelease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelBestSeller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelPopGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxPopAuthor;
    }
}
