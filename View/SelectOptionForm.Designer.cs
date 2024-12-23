﻿namespace Coffee_Kiosk.View
{
    partial class SelectOptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectOptionForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel_info = new System.Windows.Forms.Panel();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.panel_pic = new System.Windows.Forms.Panel();
            this.pic_drink = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.panel_addBtn = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel_type = new System.Windows.Forms.Panel();
            this.panel_option = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel_pic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_drink)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.panel_addBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.btn_cancel);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(10);
            this.panel_top.Size = new System.Drawing.Size(400, 50);
            this.panel_top.TabIndex = 0;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(355, 10);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(35, 30);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel_info
            // 
            this.panel_info.Controls.Add(this.lbl_desc);
            this.panel_info.Controls.Add(this.panel_pic);
            this.panel_info.Controls.Add(this.lbl_name);
            this.panel_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_info.Location = new System.Drawing.Point(0, 50);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(400, 140);
            this.panel_info.TabIndex = 1;
            // 
            // lbl_desc
            // 
            this.lbl_desc.Font = new System.Drawing.Font("Pretendard Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_desc.Location = new System.Drawing.Point(167, 56);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(204, 73);
            this.lbl_desc.TabIndex = 3;
            this.lbl_desc.Text = "음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 음료설명 ";
            // 
            // panel_pic
            // 
            this.panel_pic.Controls.Add(this.pic_drink);
            this.panel_pic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_pic.Location = new System.Drawing.Point(0, 0);
            this.panel_pic.Name = "panel_pic";
            this.panel_pic.Size = new System.Drawing.Size(161, 140);
            this.panel_pic.TabIndex = 0;
            // 
            // pic_drink
            // 
            this.pic_drink.Location = new System.Drawing.Point(21, 0);
            this.pic_drink.Name = "pic_drink";
            this.pic_drink.Size = new System.Drawing.Size(140, 140);
            this.pic_drink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_drink.TabIndex = 0;
            this.pic_drink.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_name.Location = new System.Drawing.Point(166, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 23);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "음료 이름";
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.lbl_totalPrice);
            this.panel_bottom.Controls.Add(this.panel_addBtn);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 612);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(400, 88);
            this.panel_bottom.TabIndex = 4;
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.Font = new System.Drawing.Font("Pretendard", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(49, 28);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(156, 32);
            this.lbl_totalPrice.TabIndex = 1;
            this.lbl_totalPrice.Text = "9,999원";
            this.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_addBtn
            // 
            this.panel_addBtn.Controls.Add(this.btn_add);
            this.panel_addBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_addBtn.Location = new System.Drawing.Point(207, 0);
            this.panel_addBtn.Name = "panel_addBtn";
            this.panel_addBtn.Padding = new System.Windows.Forms.Padding(20);
            this.panel_addBtn.Size = new System.Drawing.Size(193, 88);
            this.panel_addBtn.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(20, 20);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 48);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "추가하기";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel_type
            // 
            this.panel_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_type.Location = new System.Drawing.Point(0, 190);
            this.panel_type.Name = "panel_type";
            this.panel_type.Size = new System.Drawing.Size(400, 100);
            this.panel_type.TabIndex = 5;
            // 
            // panel_option
            // 
            this.panel_option.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_option.Location = new System.Drawing.Point(0, 290);
            this.panel_option.Name = "panel_option";
            this.panel_option.Size = new System.Drawing.Size(400, 322);
            this.panel_option.TabIndex = 6;
            // 
            // SelectOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.panel_option);
            this.Controls.Add(this.panel_type);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_info);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SelectOptionForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel_pic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_drink)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_addBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Panel panel_pic;
        private System.Windows.Forms.PictureBox pic_drink;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_addBtn;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel_type;
        private System.Windows.Forms.Panel panel_option;
        private System.Windows.Forms.Label lbl_totalPrice;
    }
}