namespace Quan_Ly_Khach_San_2024.GUI.All_User_Control
{
    partial class UC_History
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
            this.cbb_Month = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbb_quarter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbb_year = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_DoanhThuMonth = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DoanhThuQuarter = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_year = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.flow_pnl_UC_Book_DontCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Visable = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txt_hotelName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_roomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CheckIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_CheckOut = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cancelBook = new Guna.UI2.WinForms.Guna2Button();
            this.flow_pnl_UC_Book_CanCancel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_reload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbb_lidoHuy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_Month
            // 
            this.cbb_Month.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Month.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Month.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Month.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Month.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Month.ItemHeight = 30;
            this.cbb_Month.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbb_Month.Location = new System.Drawing.Point(4, 54);
            this.cbb_Month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_Month.Name = "cbb_Month";
            this.cbb_Month.Size = new System.Drawing.Size(146, 36);
            this.cbb_Month.TabIndex = 62;
            this.cbb_Month.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // cbb_quarter
            // 
            this.cbb_quarter.BackColor = System.Drawing.Color.Transparent;
            this.cbb_quarter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_quarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_quarter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_quarter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_quarter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_quarter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_quarter.ItemHeight = 30;
            this.cbb_quarter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbb_quarter.Location = new System.Drawing.Point(4, 134);
            this.cbb_quarter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_quarter.Name = "cbb_quarter";
            this.cbb_quarter.Size = new System.Drawing.Size(146, 36);
            this.cbb_quarter.TabIndex = 63;
            this.cbb_quarter.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(15, 35);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(119, 15);
            this.guna2HtmlLabel1.TabIndex = 64;
            this.guna2HtmlLabel1.Text = "Doanh Thu Theo Tháng";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 115);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(107, 15);
            this.guna2HtmlLabel2.TabIndex = 65;
            this.guna2HtmlLabel2.Text = "Doanh Thu Theo Quý";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(12, 3);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(110, 15);
            this.guna2HtmlLabel3.TabIndex = 66;
            this.guna2HtmlLabel3.Text = "Doanh Thu Theo Năm";
            // 
            // cbb_year
            // 
            this.cbb_year.BackColor = System.Drawing.Color.Transparent;
            this.cbb_year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_year.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_year.ItemHeight = 30;
            this.cbb_year.Location = new System.Drawing.Point(6, 22);
            this.cbb_year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(145, 36);
            this.cbb_year.TabIndex = 67;
            this.cbb_year.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox3_SelectedIndexChanged);
            // 
            // txt_DoanhThuMonth
            // 
            this.txt_DoanhThuMonth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DoanhThuMonth.DefaultText = "";
            this.txt_DoanhThuMonth.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DoanhThuMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DoanhThuMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DoanhThuMonth.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DoanhThuMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DoanhThuMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DoanhThuMonth.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DoanhThuMonth.Location = new System.Drawing.Point(152, 54);
            this.txt_DoanhThuMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DoanhThuMonth.Name = "txt_DoanhThuMonth";
            this.txt_DoanhThuMonth.PasswordChar = '\0';
            this.txt_DoanhThuMonth.PlaceholderText = "";
            this.txt_DoanhThuMonth.SelectedText = "";
            this.txt_DoanhThuMonth.Size = new System.Drawing.Size(146, 36);
            this.txt_DoanhThuMonth.TabIndex = 68;
            // 
            // txt_DoanhThuQuarter
            // 
            this.txt_DoanhThuQuarter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DoanhThuQuarter.DefaultText = "";
            this.txt_DoanhThuQuarter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DoanhThuQuarter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DoanhThuQuarter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DoanhThuQuarter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DoanhThuQuarter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DoanhThuQuarter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DoanhThuQuarter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DoanhThuQuarter.Location = new System.Drawing.Point(152, 133);
            this.txt_DoanhThuQuarter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_DoanhThuQuarter.Name = "txt_DoanhThuQuarter";
            this.txt_DoanhThuQuarter.PasswordChar = '\0';
            this.txt_DoanhThuQuarter.PlaceholderText = "";
            this.txt_DoanhThuQuarter.SelectedText = "";
            this.txt_DoanhThuQuarter.Size = new System.Drawing.Size(146, 36);
            this.txt_DoanhThuQuarter.TabIndex = 69;
            // 
            // txt_year
            // 
            this.txt_year.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_year.DefaultText = "";
            this.txt_year.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_year.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_year.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_year.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_year.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_year.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_year.Location = new System.Drawing.Point(153, 22);
            this.txt_year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_year.Name = "txt_year";
            this.txt_year.PasswordChar = '\0';
            this.txt_year.PlaceholderText = "";
            this.txt_year.SelectedText = "";
            this.txt_year.Size = new System.Drawing.Size(145, 36);
            this.txt_year.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.cbb_year);
            this.panel1.Controls.Add(this.txt_year);
            this.panel1.Location = new System.Drawing.Point(718, 557);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 77);
            this.panel1.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu Trong Năm";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightCyan;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.txt_DoanhThuMonth);
            this.panel.Controls.Add(this.txt_DoanhThuQuarter);
            this.panel.Controls.Add(this.guna2HtmlLabel1);
            this.panel.Controls.Add(this.cbb_Month);
            this.panel.Controls.Add(this.cbb_quarter);
            this.panel.Controls.Add(this.guna2HtmlLabel2);
            this.panel.Location = new System.Drawing.Point(718, 356);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(308, 197);
            this.panel.TabIndex = 71;
            // 
            // flow_pnl_UC_Book_DontCancel
            // 
            this.flow_pnl_UC_Book_DontCancel.AutoScroll = true;
            this.flow_pnl_UC_Book_DontCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flow_pnl_UC_Book_DontCancel.Location = new System.Drawing.Point(11, 26);
            this.flow_pnl_UC_Book_DontCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flow_pnl_UC_Book_DontCancel.Name = "flow_pnl_UC_Book_DontCancel";
            this.flow_pnl_UC_Book_DontCancel.Size = new System.Drawing.Size(676, 258);
            this.flow_pnl_UC_Book_DontCancel.TabIndex = 77;
            // 
            // Panel_Visable
            // 
            this.Panel_Visable.Location = new System.Drawing.Point(718, 356);
            this.Panel_Visable.Name = "Panel_Visable";
            this.Panel_Visable.Size = new System.Drawing.Size(315, 287);
            this.Panel_Visable.TabIndex = 78;
            this.Panel_Visable.Visible = false;
            // 
            // txt_hotelName
            // 
            this.txt_hotelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hotelName.DefaultText = "";
            this.txt_hotelName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hotelName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hotelName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hotelName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hotelName.FillColor = System.Drawing.Color.LightCyan;
            this.txt_hotelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hotelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hotelName.ForeColor = System.Drawing.Color.Navy;
            this.txt_hotelName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hotelName.Location = new System.Drawing.Point(5, 32);
            this.txt_hotelName.Name = "txt_hotelName";
            this.txt_hotelName.PasswordChar = '\0';
            this.txt_hotelName.PlaceholderText = "";
            this.txt_hotelName.SelectedText = "";
            this.txt_hotelName.Size = new System.Drawing.Size(289, 35);
            this.txt_hotelName.TabIndex = 79;
            // 
            // txt_roomNumber
            // 
            this.txt_roomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_roomNumber.DefaultText = "";
            this.txt_roomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_roomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_roomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_roomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_roomNumber.FillColor = System.Drawing.Color.LightCyan;
            this.txt_roomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_roomNumber.ForeColor = System.Drawing.Color.Navy;
            this.txt_roomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_roomNumber.Location = new System.Drawing.Point(5, 74);
            this.txt_roomNumber.Name = "txt_roomNumber";
            this.txt_roomNumber.PasswordChar = '\0';
            this.txt_roomNumber.PlaceholderText = "";
            this.txt_roomNumber.SelectedText = "";
            this.txt_roomNumber.Size = new System.Drawing.Size(144, 35);
            this.txt_roomNumber.TabIndex = 80;
            // 
            // txt_CheckIn
            // 
            this.txt_CheckIn.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_CheckIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CheckIn.DefaultText = "";
            this.txt_CheckIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CheckIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CheckIn.FillColor = System.Drawing.Color.LightCyan;
            this.txt_CheckIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_CheckIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CheckIn.Location = new System.Drawing.Point(128, 116);
            this.txt_CheckIn.Name = "txt_CheckIn";
            this.txt_CheckIn.PasswordChar = '\0';
            this.txt_CheckIn.PlaceholderText = "";
            this.txt_CheckIn.SelectedText = "";
            this.txt_CheckIn.Size = new System.Drawing.Size(165, 35);
            this.txt_CheckIn.TabIndex = 81;
            // 
            // txt_CheckOut
            // 
            this.txt_CheckOut.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CheckOut.DefaultText = "";
            this.txt_CheckOut.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_CheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_CheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CheckOut.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_CheckOut.FillColor = System.Drawing.Color.LightCyan;
            this.txt_CheckOut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_CheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_CheckOut.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_CheckOut.Location = new System.Drawing.Point(128, 157);
            this.txt_CheckOut.Name = "txt_CheckOut";
            this.txt_CheckOut.PasswordChar = '\0';
            this.txt_CheckOut.PlaceholderText = "";
            this.txt_CheckOut.SelectedText = "";
            this.txt_CheckOut.Size = new System.Drawing.Size(165, 35);
            this.txt_CheckOut.TabIndex = 82;
            // 
            // txt_Price
            // 
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FillColor = System.Drawing.Color.LightCyan;
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.Location = new System.Drawing.Point(154, 74);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.SelectedText = "";
            this.txt_Price.Size = new System.Drawing.Size(139, 35);
            this.txt_Price.TabIndex = 83;
            // 
            // btn_cancelBook
            // 
            this.btn_cancelBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelBook.FillColor = System.Drawing.Color.Red;
            this.btn_cancelBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancelBook.ForeColor = System.Drawing.Color.White;
            this.btn_cancelBook.Location = new System.Drawing.Point(90, 241);
            this.btn_cancelBook.Name = "btn_cancelBook";
            this.btn_cancelBook.Size = new System.Drawing.Size(132, 36);
            this.btn_cancelBook.TabIndex = 84;
            this.btn_cancelBook.Text = "Cancel Booking";
            this.btn_cancelBook.Click += new System.EventHandler(this.btn_cancelBook_Click);
            // 
            // flow_pnl_UC_Book_CanCancel
            // 
            this.flow_pnl_UC_Book_CanCancel.AutoScroll = true;
            this.flow_pnl_UC_Book_CanCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flow_pnl_UC_Book_CanCancel.Location = new System.Drawing.Point(11, 32);
            this.flow_pnl_UC_Book_CanCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.flow_pnl_UC_Book_CanCancel.Name = "flow_pnl_UC_Book_CanCancel";
            this.flow_pnl_UC_Book_CanCancel.Size = new System.Drawing.Size(676, 253);
            this.flow_pnl_UC_Book_CanCancel.TabIndex = 76;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Panel1.Controls.Add(this.flow_pnl_UC_Book_CanCancel);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Location = new System.Drawing.Point(15, 50);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(697, 293);
            this.guna2Panel1.TabIndex = 85;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Navy;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(11, 6);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(136, 20);
            this.guna2HtmlLabel4.TabIndex = 77;
            this.guna2HtmlLabel4.Text = "Lịch sử đặt phòng";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.flow_pnl_UC_Book_DontCancel);
            this.guna2Panel2.Location = new System.Drawing.Point(15, 350);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(697, 293);
            this.guna2Panel2.TabIndex = 86;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Green;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(11, 6);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(247, 20);
            this.guna2HtmlLabel5.TabIndex = 77;
            this.guna2HtmlLabel5.Text = "Lịch sử đặt và lưu trú thành công";
            // 
            // btn_reload
            // 
            this.btn_reload.BorderRadius = 15;
            this.btn_reload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reload.FillColor = System.Drawing.Color.LightGray;
            this.btn_reload.FillColor2 = System.Drawing.Color.Gainsboro;
            this.btn_reload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.Color.White;
            this.btn_reload.Image = global::Quan_Ly_Khach_San_2024.Properties.Resources.circular_loading;
            this.btn_reload.Location = new System.Drawing.Point(2, 3);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(45, 41);
            this.btn_reload.TabIndex = 61;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(5, 168);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(118, 20);
            this.guna2HtmlLabel7.TabIndex = 88;
            this.guna2HtmlLabel7.Text = "CheckOutDate:";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.PaleTurquoise;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(5, 125);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(104, 20);
            this.guna2HtmlLabel8.TabIndex = 89;
            this.guna2HtmlLabel8.Text = "CheckInDate: ";
            this.guna2HtmlLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.guna2Panel3.Controls.Add(this.cbb_lidoHuy);
            this.guna2Panel3.Controls.Add(this.txt_hotelName);
            this.guna2Panel3.Controls.Add(this.txt_roomNumber);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel3.Controls.Add(this.txt_CheckIn);
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel3.Controls.Add(this.txt_CheckOut);
            this.guna2Panel3.Controls.Add(this.txt_Price);
            this.guna2Panel3.Controls.Add(this.btn_cancelBook);
            this.guna2Panel3.Location = new System.Drawing.Point(718, 50);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(308, 294);
            this.guna2Panel3.TabIndex = 93;
            // 
            // cbb_lidoHuy
            // 
            this.cbb_lidoHuy.BackColor = System.Drawing.Color.Transparent;
            this.cbb_lidoHuy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_lidoHuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_lidoHuy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_lidoHuy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_lidoHuy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_lidoHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_lidoHuy.ItemHeight = 30;
            this.cbb_lidoHuy.Items.AddRange(new object[] {
            "1. Thay đổi kế hoạch",
            "2. Thay đổi lịch trình",
            "3. Vấn đề sức khỏe",
            "4. Không thích dịch vụ",
            "5. Khẩn cấp",
            "6. thay đổi kế hoạch du lịch",
            "7. Khác",
            ""});
            this.cbb_lidoHuy.Location = new System.Drawing.Point(5, 198);
            this.cbb_lidoHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_lidoHuy.Name = "cbb_lidoHuy";
            this.cbb_lidoHuy.Size = new System.Drawing.Size(290, 36);
            this.cbb_lidoHuy.TabIndex = 90;
            // 
            // UC_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.Panel_Visable);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_History";
            this.Size = new System.Drawing.Size(1093, 679);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2GradientButton btn_reload;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_Month;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_quarter;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Guna.UI2.WinForms.Guna2ComboBox cbb_year;
        public Guna.UI2.WinForms.Guna2TextBox txt_DoanhThuMonth;
        public Guna.UI2.WinForms.Guna2TextBox txt_DoanhThuQuarter;
        public Guna.UI2.WinForms.Guna2TextBox txt_year;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel flow_pnl_UC_Book_DontCancel;
        private Guna.UI2.WinForms.Guna2GradientPanel Panel_Visable;
        private Guna.UI2.WinForms.Guna2TextBox txt_hotelName;
        private Guna.UI2.WinForms.Guna2TextBox txt_roomNumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_CheckIn;
        private Guna.UI2.WinForms.Guna2TextBox txt_CheckOut;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private Guna.UI2.WinForms.Guna2Button btn_cancelBook;
        private System.Windows.Forms.FlowLayoutPanel flow_pnl_UC_Book_CanCancel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_lidoHuy;
    }
}
