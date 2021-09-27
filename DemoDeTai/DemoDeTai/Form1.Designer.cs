
namespace DemoDeTai
{
    partial class frm_GiaoDien
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
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.pn_Logo = new System.Windows.Forms.Panel();
            this.pn_title = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pn_GiaoDien = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_doitra = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_hoadon = new System.Windows.Forms.Button();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.btn_trangchu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Menu.SuspendLayout();
            this.pn_Logo.SuspendLayout();
            this.pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.pn_Menu.Controls.Add(this.button1);
            this.pn_Menu.Controls.Add(this.btn_doitra);
            this.pn_Menu.Controls.Add(this.btn_thongke);
            this.pn_Menu.Controls.Add(this.btn_hoadon);
            this.pn_Menu.Controls.Add(this.btn_sanpham);
            this.pn_Menu.Controls.Add(this.btn_trangchu);
            this.pn_Menu.Controls.Add(this.pn_Logo);
            this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Menu.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_Menu.Location = new System.Drawing.Point(0, 0);
            this.pn_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(165, 601);
            this.pn_Menu.TabIndex = 0;
            // 
            // pn_Logo
            // 
            this.pn_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(209)))));
            this.pn_Logo.Controls.Add(this.pictureBox1);
            this.pn_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Logo.Location = new System.Drawing.Point(0, 0);
            this.pn_Logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_Logo.Name = "pn_Logo";
            this.pn_Logo.Size = new System.Drawing.Size(165, 65);
            this.pn_Logo.TabIndex = 0;
            // 
            // pn_title
            // 
            this.pn_title.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pn_title.Controls.Add(this.lblTitle);
            this.pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_title.Location = new System.Drawing.Point(165, 0);
            this.pn_title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_title.Name = "pn_title";
            this.pn_title.Size = new System.Drawing.Size(716, 65);
            this.pn_title.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(320, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // pn_GiaoDien
            // 
            this.pn_GiaoDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_GiaoDien.Location = new System.Drawing.Point(165, 65);
            this.pn_GiaoDien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pn_GiaoDien.Name = "pn_GiaoDien";
            this.pn_GiaoDien.Size = new System.Drawing.Size(716, 536);
            this.pn_GiaoDien.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::DemoDeTai.Properties.Resources.cancel123;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_doitra
            // 
            this.btn_doitra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_doitra.FlatAppearance.BorderSize = 0;
            this.btn_doitra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doitra.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doitra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_doitra.Image = global::DemoDeTai.Properties.Resources.ic_transfer;
            this.btn_doitra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doitra.Location = new System.Drawing.Point(0, 333);
            this.btn_doitra.Margin = new System.Windows.Forms.Padding(2);
            this.btn_doitra.Name = "btn_doitra";
            this.btn_doitra.Size = new System.Drawing.Size(165, 67);
            this.btn_doitra.TabIndex = 5;
            this.btn_doitra.Text = "RETURNS";
            this.btn_doitra.UseVisualStyleBackColor = true;
            this.btn_doitra.Click += new System.EventHandler(this.btn_doitra_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_thongke.Image = global::DemoDeTai.Properties.Resources.statics;
            this.btn_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thongke.Location = new System.Drawing.Point(0, 266);
            this.btn_thongke.Margin = new System.Windows.Forms.Padding(2);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(165, 67);
            this.btn_thongke.TabIndex = 4;
            this.btn_thongke.Text = "STATISTICS";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hoadon.FlatAppearance.BorderSize = 0;
            this.btn_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hoadon.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoadon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_hoadon.Image = global::DemoDeTai.Properties.Resources.bill;
            this.btn_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hoadon.Location = new System.Drawing.Point(0, 199);
            this.btn_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.Size = new System.Drawing.Size(165, 67);
            this.btn_hoadon.TabIndex = 3;
            this.btn_hoadon.Text = "RECEIPT";
            this.btn_hoadon.UseVisualStyleBackColor = true;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sanpham.FlatAppearance.BorderSize = 0;
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanpham.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sanpham.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_sanpham.Image = global::DemoDeTai.Properties.Resources.shopping;
            this.btn_sanpham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sanpham.Location = new System.Drawing.Point(0, 132);
            this.btn_sanpham.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(165, 67);
            this.btn_sanpham.TabIndex = 2;
            this.btn_sanpham.Text = "PRODUCT";
            this.btn_sanpham.UseVisualStyleBackColor = true;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_trangchu.FlatAppearance.BorderSize = 0;
            this.btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangchu.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trangchu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_trangchu.Image = global::DemoDeTai.Properties.Resources.homee;
            this.btn_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangchu.Location = new System.Drawing.Point(0, 65);
            this.btn_trangchu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(165, 67);
            this.btn_trangchu.TabIndex = 1;
            this.btn_trangchu.Text = "HOME";
            this.btn_trangchu.UseVisualStyleBackColor = true;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DemoDeTai.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frm_GiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 601);
            this.Controls.Add(this.pn_GiaoDien);
            this.Controls.Add(this.pn_title);
            this.Controls.Add(this.pn_Menu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_GiaoDien";
            this.Text = "Giao Diện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_GiaoDien_Load);
            this.pn_Menu.ResumeLayout(false);
            this.pn_Logo.ResumeLayout(false);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Menu;
        private System.Windows.Forms.Button btn_trangchu;
        private System.Windows.Forms.Panel pn_Logo;
        private System.Windows.Forms.Button btn_doitra;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_hoadon;
        private System.Windows.Forms.Button btn_sanpham;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_GiaoDien;
        private System.Windows.Forms.Button button1;
    }
}

