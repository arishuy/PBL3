﻿namespace PBL3.View
{
    partial class frmNhanvien
        
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
            FontAwesome.Sharp.IconButton btnHD;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            FontAwesome.Sharp.IconButton btnTrangchu;
            this.btnKH = new FontAwesome.Sharp.IconButton();
            this.btnDM = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTl = new System.Windows.Forms.Panel();
            this.iconInfo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            btnHD = new FontAwesome.Sharp.IconButton();
            btnTrangchu = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHD
            // 
            btnHD.FlatAppearance.BorderSize = 0;
            btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnHD.ForeColor = System.Drawing.SystemColors.Control;
            btnHD.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            btnHD.IconColor = System.Drawing.Color.White;
            btnHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHD.IconSize = 36;
            btnHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHD.Location = new System.Drawing.Point(0, 260);
            btnHD.Name = "btnHD";
            btnHD.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnHD.Size = new System.Drawing.Size(200, 60);
            btnHD.TabIndex = 3;
            btnHD.Text = "Hóa đơn";
            btnHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnHD.UseVisualStyleBackColor = true;
            btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnKH
            // 
            this.btnKH.FlatAppearance.BorderSize = 0;
            this.btnKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKH.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnKH.IconColor = System.Drawing.Color.White;
            this.btnKH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKH.IconSize = 36;
            this.btnKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.Location = new System.Drawing.Point(0, 140);
            this.btnKH.Name = "btnKH";
            this.btnKH.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnKH.Size = new System.Drawing.Size(200, 60);
            this.btnKH.TabIndex = 1;
            this.btnKH.Text = "Khách hàng";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // btnDM
            // 
            this.btnDM.FlatAppearance.BorderSize = 0;
            this.btnDM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDM.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDM.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.btnDM.IconColor = System.Drawing.Color.White;
            this.btnDM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDM.IconSize = 36;
            this.btnDM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDM.Location = new System.Drawing.Point(0, 200);
            this.btnDM.Name = "btnDM";
            this.btnDM.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDM.Size = new System.Drawing.Size(200, 60);
            this.btnDM.TabIndex = 1;
            this.btnDM.Text = "Đặt món";
            this.btnDM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDM.UseVisualStyleBackColor = true;
            this.btnDM.Click += new System.EventHandler(this.btnDM_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(btnTrangchu);
            this.panelMenu.Controls.Add(btnHD);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnDM);
            this.panelMenu.Controls.Add(this.btnKH);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 625);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 74);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 36;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 320);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconButton1.Size = new System.Drawing.Size(200, 60);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Thoát";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTl
            // 
            this.panelTl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTl.Controls.Add(this.iconInfo);
            this.panelTl.Controls.Add(this.label1);
            this.panelTl.Controls.Add(this.iconPictureBox1);
            this.panelTl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTl.Location = new System.Drawing.Point(200, 0);
            this.panelTl.Name = "panelTl";
            this.panelTl.Size = new System.Drawing.Size(930, 74);
            this.panelTl.TabIndex = 1;
            // 
            // iconInfo
            // 
            this.iconInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconInfo.FlatAppearance.BorderSize = 0;
            this.iconInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.iconInfo.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconInfo.IconColor = System.Drawing.Color.White;
            this.iconInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconInfo.IconSize = 36;
            this.iconInfo.Location = new System.Drawing.Point(854, 0);
            this.iconInfo.Name = "iconInfo";
            this.iconInfo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.iconInfo.Size = new System.Drawing.Size(76, 74);
            this.iconInfo.TabIndex = 3;
            this.iconInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconInfo.UseVisualStyleBackColor = true;
            this.iconInfo.Click += new System.EventHandler(this.iconInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.PeachPuff;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.Color.PeachPuff;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 54;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(54, 62);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 74);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(930, 551);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnTrangchu
            // 
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTrangchu.ForeColor = System.Drawing.SystemColors.Control;
            btnTrangchu.IconChar = FontAwesome.Sharp.IconChar.Home;
            btnTrangchu.IconColor = System.Drawing.Color.White;
            btnTrangchu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrangchu.IconSize = 36;
            btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTrangchu.Location = new System.Drawing.Point(0, 74);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            btnTrangchu.Size = new System.Drawing.Size(200, 60);
            btnTrangchu.TabIndex = 4;
            btnTrangchu.Text = "Trang chủ";
            btnTrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTrangchu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnTrangchu.UseVisualStyleBackColor = true;
            btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1130, 625);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTl);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmNhanvien";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNhanvien_FormClosed);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTl.ResumeLayout(false);
            this.panelTl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTl;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnKH;
        private FontAwesome.Sharp.IconButton btnDM;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconInfo;
    }
}