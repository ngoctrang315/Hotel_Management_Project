namespace Quan_Ly_Khach_San_2024.GUI.DashBoard
{
    partial class CheckDate
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
            this.dtp_checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_checkout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_searchroom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // dtp_checkin
            // 
            this.dtp_checkin.Checked = true;
            this.dtp_checkin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_checkin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_checkin.Location = new System.Drawing.Point(36, 58);
            this.dtp_checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_checkin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_checkin.Name = "dtp_checkin";
            this.dtp_checkin.Size = new System.Drawing.Size(395, 36);
            this.dtp_checkin.TabIndex = 0;
            this.dtp_checkin.Value = new System.DateTime(2024, 5, 7, 10, 26, 39, 885);
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Checked = true;
            this.dtp_checkout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_checkout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_checkout.Location = new System.Drawing.Point(36, 147);
            this.dtp_checkout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_checkout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(395, 36);
            this.dtp_checkout.TabIndex = 1;
            this.dtp_checkout.Value = new System.DateTime(2024, 5, 7, 10, 26, 39, 885);
            // 
            // btn_searchroom
            // 
            this.btn_searchroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_searchroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_searchroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_searchroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_searchroom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_searchroom.ForeColor = System.Drawing.Color.White;
            this.btn_searchroom.Location = new System.Drawing.Point(142, 224);
            this.btn_searchroom.Name = "btn_searchroom";
            this.btn_searchroom.Size = new System.Drawing.Size(180, 45);
            this.btn_searchroom.TabIndex = 2;
            this.btn_searchroom.Text = "SEARCH";
            this.btn_searchroom.Click += new System.EventHandler(this.btn_searchroom_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(36, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(178, 22);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Day Check In";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(36, 119);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(178, 22);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Day Check In";
            // 
            // CheckDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 280);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_searchroom);
            this.Controls.Add(this.dtp_checkout);
            this.Controls.Add(this.dtp_checkin);
            this.Name = "CheckDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckDate";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_checkin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_checkout;
        private Guna.UI2.WinForms.Guna2Button btn_searchroom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}