namespace Quan_Ly_Khach_San_2024.GUI.All_User_Control
{
    partial class UC_Plow_Panel
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
            this.picHotel = new System.Windows.Forms.PictureBox();
            this.lbl_flow_pannel_01 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_flow_pannel_02 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_flow_pannel_03 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // picHotel
            // 
            this.picHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHotel.Location = new System.Drawing.Point(38, 10);
            this.picHotel.Margin = new System.Windows.Forms.Padding(2);
            this.picHotel.Name = "picHotel";
            this.picHotel.Size = new System.Drawing.Size(135, 111);
            this.picHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHotel.TabIndex = 0;
            this.picHotel.TabStop = false;
            // 
            // lbl_flow_pannel_01
            // 
            this.lbl_flow_pannel_01.AutoSize = false;
            this.lbl_flow_pannel_01.BackColor = System.Drawing.Color.Transparent;
            this.lbl_flow_pannel_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_flow_pannel_01.Location = new System.Drawing.Point(10, 137);
            this.lbl_flow_pannel_01.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_flow_pannel_01.Name = "lbl_flow_pannel_01";
            this.lbl_flow_pannel_01.Size = new System.Drawing.Size(191, 27);
            this.lbl_flow_pannel_01.TabIndex = 3;
            this.lbl_flow_pannel_01.Text = "ThongTin01";
            this.lbl_flow_pannel_01.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_flow_pannel_02
            // 
            this.lbl_flow_pannel_02.AutoSize = false;
            this.lbl_flow_pannel_02.BackColor = System.Drawing.Color.Transparent;
            this.lbl_flow_pannel_02.Location = new System.Drawing.Point(10, 165);
            this.lbl_flow_pannel_02.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_flow_pannel_02.Name = "lbl_flow_pannel_02";
            this.lbl_flow_pannel_02.Size = new System.Drawing.Size(191, 27);
            this.lbl_flow_pannel_02.TabIndex = 4;
            this.lbl_flow_pannel_02.Text = "ThongTin02";
            this.lbl_flow_pannel_02.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(7, 121);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.Transparent;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = global::Quan_Ly_Khach_San_2024.Properties.Resources.cancel_25px;
            this.btn_delete.Location = new System.Drawing.Point(178, -1);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(32, 29);
            this.btn_delete.TabIndex = 6;
            // 
            // lbl_flow_pannel_03
            // 
            this.lbl_flow_pannel_03.AutoSize = false;
            this.lbl_flow_pannel_03.BackColor = System.Drawing.Color.Transparent;
            this.lbl_flow_pannel_03.Location = new System.Drawing.Point(10, 195);
            this.lbl_flow_pannel_03.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_flow_pannel_03.Name = "lbl_flow_pannel_03";
            this.lbl_flow_pannel_03.Size = new System.Drawing.Size(191, 67);
            this.lbl_flow_pannel_03.TabIndex = 7;
            this.lbl_flow_pannel_03.Text = "ThongTin03";
            this.lbl_flow_pannel_03.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UC_Plow_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_flow_pannel_03);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lbl_flow_pannel_01);
            this.Controls.Add(this.picHotel);
            this.Controls.Add(this.lbl_flow_pannel_02);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Plow_Panel";
            this.Size = new System.Drawing.Size(210, 256);
            ((System.ComponentModel.ISupportInitialize)(this.picHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picHotel;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_flow_pannel_01;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_flow_pannel_02;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Guna.UI2.WinForms.Guna2Button btn_delete;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_flow_pannel_03;
    }
}
