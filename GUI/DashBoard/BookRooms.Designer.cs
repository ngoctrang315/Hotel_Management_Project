namespace Quan_Ly_Khach_San_2024.GUI.DashBoard
{
    partial class BookRooms
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.cbb_typeRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.dtCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtCheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_BookRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ImgRoom = new System.Windows.Forms.PictureBox();
            this.btnopen = new Guna.UI2.WinForms.Guna2Button();
            this.txt_totalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_infor4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_infor3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_infor2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_infor1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRoom)).BeginInit();
            this.guna2GradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_typeRoom
            // 
            this.cbb_typeRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbb_typeRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_typeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_typeRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_typeRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_typeRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_typeRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_typeRoom.ItemHeight = 30;
            this.cbb_typeRoom.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Suite"});
            this.cbb_typeRoom.Location = new System.Drawing.Point(34, 452);
            this.cbb_typeRoom.Name = "cbb_typeRoom";
            this.cbb_typeRoom.Size = new System.Drawing.Size(313, 36);
            this.cbb_typeRoom.TabIndex = 39;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(381, 522);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(132, 22);
            this.guna2HtmlLabel2.TabIndex = 37;
            this.guna2HtmlLabel2.Text = "Date CheckOut ---";
            // 
            // btn_save
            // 
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.Green;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(34, 557);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(315, 43);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.Checked = true;
            this.dtCheckOut.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.dtCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckOut.Location = new System.Drawing.Point(534, 511);
            this.dtCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.Size = new System.Drawing.Size(273, 45);
            this.dtCheckOut.TabIndex = 33;
            this.dtCheckOut.Value = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.Checked = true;
            this.dtCheckIn.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.dtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtCheckIn.Location = new System.Drawing.Point(534, 412);
            this.dtCheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtCheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.Size = new System.Drawing.Size(273, 45);
            this.dtCheckIn.TabIndex = 32;
            this.dtCheckIn.Value = new System.DateTime(2024, 4, 25, 0, 0, 0, 0);
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.ForeColor = System.Drawing.Color.Navy;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(34, 389);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(315, 55);
            this.txtPrice.TabIndex = 31;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNumber.DefaultText = "";
            this.txtRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomNumber.ForeColor = System.Drawing.Color.Navy;
            this.txtRoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomNumber.Location = new System.Drawing.Point(34, 325);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.PlaceholderText = "RoomNumber";
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(315, 55);
            this.txtRoomNumber.TabIndex = 30;
            // 
            // btn_BookRoom
            // 
            this.btn_BookRoom.BorderRadius = 5;
            this.btn_BookRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_BookRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_BookRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_BookRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_BookRoom.FillColor = System.Drawing.Color.Green;
            this.btn_BookRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_BookRoom.ForeColor = System.Drawing.Color.White;
            this.btn_BookRoom.Location = new System.Drawing.Point(882, 518);
            this.btn_BookRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BookRoom.Name = "btn_BookRoom";
            this.btn_BookRoom.Size = new System.Drawing.Size(183, 49);
            this.btn_BookRoom.TabIndex = 29;
            this.btn_BookRoom.Text = "Bookings";
            this.btn_BookRoom.Visible = false;
            this.btn_BookRoom.Click += new System.EventHandler(this.btn_BookRoom_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.ImgRoom);
            this.guna2GradientPanel1.Controls.Add(this.btnopen);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(34, 18);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(315, 298);
            this.guna2GradientPanel1.TabIndex = 35;
            // 
            // ImgRoom
            // 
            this.ImgRoom.BackColor = System.Drawing.Color.Gainsboro;
            this.ImgRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgRoom.Location = new System.Drawing.Point(0, 0);
            this.ImgRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImgRoom.Name = "ImgRoom";
            this.ImgRoom.Size = new System.Drawing.Size(315, 264);
            this.ImgRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgRoom.TabIndex = 1;
            this.ImgRoom.TabStop = false;
            // 
            // btnopen
            // 
            this.btnopen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnopen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnopen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnopen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnopen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnopen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnopen.ForeColor = System.Drawing.Color.White;
            this.btnopen.Location = new System.Drawing.Point(0, 264);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(315, 34);
            this.btnopen.TabIndex = 23;
            this.btnopen.Text = "import image";
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_totalPrice.DefaultText = "";
            this.txt_totalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_totalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_totalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_totalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_totalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_totalPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_totalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_totalPrice.Location = new System.Drawing.Point(882, 443);
            this.txt_totalPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.PasswordChar = '\0';
            this.txt_totalPrice.PlaceholderText = "";
            this.txt_totalPrice.ReadOnly = true;
            this.txt_totalPrice.SelectedText = "";
            this.txt_totalPrice.Size = new System.Drawing.Size(183, 65);
            this.txt_totalPrice.TabIndex = 44;
            this.txt_totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(882, 412);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(183, 32);
            this.guna2Button1.TabIndex = 46;
            this.guna2Button1.Text = "THÀNH TIỀN";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(381, 425);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(130, 22);
            this.guna2HtmlLabel1.TabIndex = 36;
            this.guna2HtmlLabel1.Text = "Date CheckIn -----";
            this.guna2HtmlLabel1.UseGdiPlusTextRendering = true;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2GradientPanel2.Controls.Add(this.lbl_infor4);
            this.guna2GradientPanel2.Controls.Add(this.lbl_infor3);
            this.guna2GradientPanel2.Controls.Add(this.lbl_infor2);
            this.guna2GradientPanel2.Controls.Add(this.lbl_infor1);
            this.guna2GradientPanel2.Location = new System.Drawing.Point(381, 18);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(684, 362);
            this.guna2GradientPanel2.TabIndex = 84;
            // 
            // lbl_infor4
            // 
            this.lbl_infor4.AutoSize = false;
            this.lbl_infor4.AutoSizeHeightOnly = true;
            this.lbl_infor4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_infor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infor4.Location = new System.Drawing.Point(42, 229);
            this.lbl_infor4.Name = "lbl_infor4";
            this.lbl_infor4.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lbl_infor4.Size = new System.Drawing.Size(606, 44);
            this.lbl_infor4.TabIndex = 87;
            this.lbl_infor4.Text = "infor4";
            // 
            // lbl_infor3
            // 
            this.lbl_infor3.AutoSize = false;
            this.lbl_infor3.AutoSizeHeightOnly = true;
            this.lbl_infor3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_infor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infor3.Location = new System.Drawing.Point(42, 163);
            this.lbl_infor3.Name = "lbl_infor3";
            this.lbl_infor3.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lbl_infor3.Size = new System.Drawing.Size(606, 44);
            this.lbl_infor3.TabIndex = 86;
            this.lbl_infor3.Text = "infor3";
            // 
            // lbl_infor2
            // 
            this.lbl_infor2.AutoSize = false;
            this.lbl_infor2.AutoSizeHeightOnly = true;
            this.lbl_infor2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_infor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infor2.Location = new System.Drawing.Point(42, 97);
            this.lbl_infor2.Name = "lbl_infor2";
            this.lbl_infor2.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lbl_infor2.Size = new System.Drawing.Size(606, 44);
            this.lbl_infor2.TabIndex = 85;
            this.lbl_infor2.Text = "infor2";
            // 
            // lbl_infor1
            // 
            this.lbl_infor1.AutoSize = false;
            this.lbl_infor1.AutoSizeHeightOnly = true;
            this.lbl_infor1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_infor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_infor1.Location = new System.Drawing.Point(42, 29);
            this.lbl_infor1.Name = "lbl_infor1";
            this.lbl_infor1.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.lbl_infor1.Size = new System.Drawing.Size(616, 44);
            this.lbl_infor1.TabIndex = 84;
            this.lbl_infor1.Text = "infor1";
            // 
            // BookRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1102, 648);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txt_totalPrice);
            this.Controls.Add(this.cbb_typeRoom);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtCheckOut);
            this.Controls.Add(this.dtCheckIn);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.btn_BookRoom);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookRooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookRoom";
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgRoom)).EndInit();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_typeRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtCheckIn;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomNumber;
        public Guna.UI2.WinForms.Guna2Button btn_BookRoom;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.PictureBox ImgRoom;
        private Guna.UI2.WinForms.Guna2Button btnopen;
        private Guna.UI2.WinForms.Guna2TextBox txt_totalPrice;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_infor4;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_infor3;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_infor2;
        public Guna.UI2.WinForms.Guna2HtmlLabel lbl_infor1;
    }
}