
namespace CourseWorkTransport
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransportLbx = new System.Windows.Forms.ListBox();
            this.RouteLbx = new System.Windows.Forms.ListBox();
            this.RouteTbx = new System.Windows.Forms.TextBox();
            this.AddRouteBtn = new System.Windows.Forms.Button();
            this.AddTransportBtn = new System.Windows.Forms.Button();
            this.TransportTbx = new System.Windows.Forms.TextBox();
            this.StationLbx = new System.Windows.Forms.ListBox();
            this.EditTransportBtn = new System.Windows.Forms.Button();
            this.DeleteTransportBtn = new System.Windows.Forms.Button();
            this.DeleteStationTbx = new System.Windows.Forms.Button();
            this.EditStationTbx = new System.Windows.Forms.Button();
            this.AddStationBtn = new System.Windows.Forms.Button();
            this.StationNameTbx = new System.Windows.Forms.TextBox();
            this.DeleteRouteBtn = new System.Windows.Forms.Button();
            this.EditRouteBtn = new System.Windows.Forms.Button();
            this.StationTimeTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RouteStationLinkBtn = new System.Windows.Forms.Button();
            this.RouteStationDislinkBtn = new System.Windows.Forms.Button();
            this.LinkedStationsLbx = new System.Windows.Forms.ListBox();
            this.LinkedRoutesLbx = new System.Windows.Forms.ListBox();
            this.RouteTransportLbx = new System.Windows.Forms.ListBox();
            this.TransportRouteTbx = new System.Windows.Forms.TextBox();
            this.TransportStationsLbx = new System.Windows.Forms.ListBox();
            this.TransportTypeLbx = new System.Windows.Forms.ListBox();
            this.DeleteTransportTypeBtn = new System.Windows.Forms.Button();
            this.EditTransportTypeBtn = new System.Windows.Forms.Button();
            this.AddTransportTypeBtn = new System.Windows.Forms.Button();
            this.TransportTypeNameTbx = new System.Windows.Forms.TextBox();
            this.TransportTypeInfoTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TransportTypeTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TransportInfoTbx = new System.Windows.Forms.TextBox();
            this.TransportTypeTransportLbx = new System.Windows.Forms.ListBox();
            this.StationTransportLbx = new System.Windows.Forms.ListBox();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.AdminPasswordTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransportLbx
            // 
            this.TransportLbx.FormattingEnabled = true;
            this.TransportLbx.ItemHeight = 20;
            this.TransportLbx.Location = new System.Drawing.Point(303, 29);
            this.TransportLbx.Name = "TransportLbx";
            this.TransportLbx.Size = new System.Drawing.Size(172, 224);
            this.TransportLbx.TabIndex = 0;
            this.TransportLbx.SelectedIndexChanged += new System.EventHandler(this.TransportLbx_SelectedIndexChanged);
            // 
            // RouteLbx
            // 
            this.RouteLbx.FormattingEnabled = true;
            this.RouteLbx.ItemHeight = 20;
            this.RouteLbx.Location = new System.Drawing.Point(618, 29);
            this.RouteLbx.Name = "RouteLbx";
            this.RouteLbx.Size = new System.Drawing.Size(203, 224);
            this.RouteLbx.TabIndex = 1;
            this.RouteLbx.SelectedIndexChanged += new System.EventHandler(this.RouteLbx_SelectedIndexChanged);
            // 
            // RouteTbx
            // 
            this.RouteTbx.Location = new System.Drawing.Point(634, 304);
            this.RouteTbx.Name = "RouteTbx";
            this.RouteTbx.Size = new System.Drawing.Size(129, 27);
            this.RouteTbx.TabIndex = 2;
            // 
            // AddRouteBtn
            // 
            this.AddRouteBtn.Location = new System.Drawing.Point(634, 346);
            this.AddRouteBtn.Name = "AddRouteBtn";
            this.AddRouteBtn.Size = new System.Drawing.Size(118, 27);
            this.AddRouteBtn.TabIndex = 3;
            this.AddRouteBtn.Text = "AddRoute";
            this.AddRouteBtn.UseVisualStyleBackColor = true;
            this.AddRouteBtn.Click += new System.EventHandler(this.AddRouteBtn_Click_1);
            // 
            // AddTransportBtn
            // 
            this.AddTransportBtn.Location = new System.Drawing.Point(303, 346);
            this.AddTransportBtn.Name = "AddTransportBtn";
            this.AddTransportBtn.Size = new System.Drawing.Size(118, 27);
            this.AddTransportBtn.TabIndex = 5;
            this.AddTransportBtn.Text = "AddTransport";
            this.AddTransportBtn.UseVisualStyleBackColor = true;
            this.AddTransportBtn.Click += new System.EventHandler(this.AddTransportBtn_Click);
            // 
            // TransportTbx
            // 
            this.TransportTbx.Location = new System.Drawing.Point(303, 277);
            this.TransportTbx.Name = "TransportTbx";
            this.TransportTbx.Size = new System.Drawing.Size(129, 27);
            this.TransportTbx.TabIndex = 4;
            // 
            // StationLbx
            // 
            this.StationLbx.FormattingEnabled = true;
            this.StationLbx.ItemHeight = 20;
            this.StationLbx.Location = new System.Drawing.Point(916, 29);
            this.StationLbx.Name = "StationLbx";
            this.StationLbx.Size = new System.Drawing.Size(267, 224);
            this.StationLbx.TabIndex = 6;
            this.StationLbx.SelectedIndexChanged += new System.EventHandler(this.StationLbx_SelectedIndexChanged);
            // 
            // EditTransportBtn
            // 
            this.EditTransportBtn.Location = new System.Drawing.Point(303, 388);
            this.EditTransportBtn.Name = "EditTransportBtn";
            this.EditTransportBtn.Size = new System.Drawing.Size(118, 27);
            this.EditTransportBtn.TabIndex = 7;
            this.EditTransportBtn.Text = "Edit";
            this.EditTransportBtn.UseVisualStyleBackColor = true;
            this.EditTransportBtn.Click += new System.EventHandler(this.EditTransportBtn_Click);
            // 
            // DeleteTransportBtn
            // 
            this.DeleteTransportBtn.Location = new System.Drawing.Point(303, 433);
            this.DeleteTransportBtn.Name = "DeleteTransportBtn";
            this.DeleteTransportBtn.Size = new System.Drawing.Size(118, 27);
            this.DeleteTransportBtn.TabIndex = 8;
            this.DeleteTransportBtn.Text = "Delete";
            this.DeleteTransportBtn.UseVisualStyleBackColor = true;
            this.DeleteTransportBtn.Click += new System.EventHandler(this.DeleteTransportBtn_Click);
            // 
            // DeleteStationTbx
            // 
            this.DeleteStationTbx.Location = new System.Drawing.Point(916, 433);
            this.DeleteStationTbx.Name = "DeleteStationTbx";
            this.DeleteStationTbx.Size = new System.Drawing.Size(118, 27);
            this.DeleteStationTbx.TabIndex = 12;
            this.DeleteStationTbx.Text = "Delete";
            this.DeleteStationTbx.UseVisualStyleBackColor = true;
            this.DeleteStationTbx.Click += new System.EventHandler(this.DeleteStationTbx_Click);
            // 
            // EditStationTbx
            // 
            this.EditStationTbx.Location = new System.Drawing.Point(916, 388);
            this.EditStationTbx.Name = "EditStationTbx";
            this.EditStationTbx.Size = new System.Drawing.Size(118, 27);
            this.EditStationTbx.TabIndex = 11;
            this.EditStationTbx.Text = "Edit";
            this.EditStationTbx.UseVisualStyleBackColor = true;
            this.EditStationTbx.Click += new System.EventHandler(this.EditStationTbx_Click);
            // 
            // AddStationBtn
            // 
            this.AddStationBtn.Location = new System.Drawing.Point(916, 346);
            this.AddStationBtn.Name = "AddStationBtn";
            this.AddStationBtn.Size = new System.Drawing.Size(118, 27);
            this.AddStationBtn.TabIndex = 10;
            this.AddStationBtn.Text = "AddStation";
            this.AddStationBtn.UseVisualStyleBackColor = true;
            this.AddStationBtn.Click += new System.EventHandler(this.AddStationBtn_Click_1);
            // 
            // StationNameTbx
            // 
            this.StationNameTbx.Location = new System.Drawing.Point(916, 274);
            this.StationNameTbx.Name = "StationNameTbx";
            this.StationNameTbx.Size = new System.Drawing.Size(129, 27);
            this.StationNameTbx.TabIndex = 9;
            // 
            // DeleteRouteBtn
            // 
            this.DeleteRouteBtn.Location = new System.Drawing.Point(634, 433);
            this.DeleteRouteBtn.Name = "DeleteRouteBtn";
            this.DeleteRouteBtn.Size = new System.Drawing.Size(118, 27);
            this.DeleteRouteBtn.TabIndex = 14;
            this.DeleteRouteBtn.Text = "Delete";
            this.DeleteRouteBtn.UseVisualStyleBackColor = true;
            this.DeleteRouteBtn.Click += new System.EventHandler(this.DeleteRouteBtn_Click);
            // 
            // EditRouteBtn
            // 
            this.EditRouteBtn.Location = new System.Drawing.Point(634, 388);
            this.EditRouteBtn.Name = "EditRouteBtn";
            this.EditRouteBtn.Size = new System.Drawing.Size(118, 27);
            this.EditRouteBtn.TabIndex = 13;
            this.EditRouteBtn.Text = "Edit";
            this.EditRouteBtn.UseVisualStyleBackColor = true;
            this.EditRouteBtn.Click += new System.EventHandler(this.EditRouteBtn_Click);
            // 
            // StationTimeTbx
            // 
            this.StationTimeTbx.Location = new System.Drawing.Point(916, 313);
            this.StationTimeTbx.Name = "StationTimeTbx";
            this.StationTimeTbx.Size = new System.Drawing.Size(129, 27);
            this.StationTimeTbx.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(860, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time :";
            // 
            // RouteStationLinkBtn
            // 
            this.RouteStationLinkBtn.Location = new System.Drawing.Point(836, 68);
            this.RouteStationLinkBtn.Name = "RouteStationLinkBtn";
            this.RouteStationLinkBtn.Size = new System.Drawing.Size(73, 55);
            this.RouteStationLinkBtn.TabIndex = 18;
            this.RouteStationLinkBtn.Text = "Link";
            this.RouteStationLinkBtn.UseVisualStyleBackColor = true;
            this.RouteStationLinkBtn.Click += new System.EventHandler(this.RouteStationLinkBtn_Click);
            // 
            // RouteStationDislinkBtn
            // 
            this.RouteStationDislinkBtn.Location = new System.Drawing.Point(836, 153);
            this.RouteStationDislinkBtn.Name = "RouteStationDislinkBtn";
            this.RouteStationDislinkBtn.Size = new System.Drawing.Size(73, 55);
            this.RouteStationDislinkBtn.TabIndex = 19;
            this.RouteStationDislinkBtn.Text = "Dislink";
            this.RouteStationDislinkBtn.UseVisualStyleBackColor = true;
            this.RouteStationDislinkBtn.Click += new System.EventHandler(this.RouteStationDislinkBtn_Click);
            // 
            // LinkedStationsLbx
            // 
            this.LinkedStationsLbx.FormattingEnabled = true;
            this.LinkedStationsLbx.ItemHeight = 20;
            this.LinkedStationsLbx.Location = new System.Drawing.Point(608, 517);
            this.LinkedStationsLbx.Name = "LinkedStationsLbx";
            this.LinkedStationsLbx.Size = new System.Drawing.Size(243, 204);
            this.LinkedStationsLbx.TabIndex = 20;
            // 
            // LinkedRoutesLbx
            // 
            this.LinkedRoutesLbx.FormattingEnabled = true;
            this.LinkedRoutesLbx.ItemHeight = 20;
            this.LinkedRoutesLbx.Location = new System.Drawing.Point(893, 497);
            this.LinkedRoutesLbx.Name = "LinkedRoutesLbx";
            this.LinkedRoutesLbx.Size = new System.Drawing.Size(202, 204);
            this.LinkedRoutesLbx.TabIndex = 21;
            // 
            // RouteTransportLbx
            // 
            this.RouteTransportLbx.FormattingEnabled = true;
            this.RouteTransportLbx.ItemHeight = 20;
            this.RouteTransportLbx.Location = new System.Drawing.Point(618, 763);
            this.RouteTransportLbx.Name = "RouteTransportLbx";
            this.RouteTransportLbx.Size = new System.Drawing.Size(201, 184);
            this.RouteTransportLbx.TabIndex = 22;
            // 
            // TransportRouteTbx
            // 
            this.TransportRouteTbx.Location = new System.Drawing.Point(347, 497);
            this.TransportRouteTbx.Name = "TransportRouteTbx";
            this.TransportRouteTbx.ReadOnly = true;
            this.TransportRouteTbx.Size = new System.Drawing.Size(127, 27);
            this.TransportRouteTbx.TabIndex = 23;
            // 
            // TransportStationsLbx
            // 
            this.TransportStationsLbx.FormattingEnabled = true;
            this.TransportStationsLbx.ItemHeight = 20;
            this.TransportStationsLbx.Location = new System.Drawing.Point(313, 740);
            this.TransportStationsLbx.Name = "TransportStationsLbx";
            this.TransportStationsLbx.Size = new System.Drawing.Size(260, 264);
            this.TransportStationsLbx.TabIndex = 24;
            // 
            // TransportTypeLbx
            // 
            this.TransportTypeLbx.FormattingEnabled = true;
            this.TransportTypeLbx.ItemHeight = 20;
            this.TransportTypeLbx.Location = new System.Drawing.Point(46, 34);
            this.TransportTypeLbx.Name = "TransportTypeLbx";
            this.TransportTypeLbx.Size = new System.Drawing.Size(179, 224);
            this.TransportTypeLbx.TabIndex = 25;
            this.TransportTypeLbx.SelectedIndexChanged += new System.EventHandler(this.TransportTypeLbx_SelectedIndexChanged);
            // 
            // DeleteTransportTypeBtn
            // 
            this.DeleteTransportTypeBtn.Location = new System.Drawing.Point(46, 459);
            this.DeleteTransportTypeBtn.Name = "DeleteTransportTypeBtn";
            this.DeleteTransportTypeBtn.Size = new System.Drawing.Size(118, 27);
            this.DeleteTransportTypeBtn.TabIndex = 29;
            this.DeleteTransportTypeBtn.Text = "Delete";
            this.DeleteTransportTypeBtn.UseVisualStyleBackColor = true;
            this.DeleteTransportTypeBtn.Click += new System.EventHandler(this.DeleteTransportTypeBtn_Click);
            // 
            // EditTransportTypeBtn
            // 
            this.EditTransportTypeBtn.Location = new System.Drawing.Point(46, 414);
            this.EditTransportTypeBtn.Name = "EditTransportTypeBtn";
            this.EditTransportTypeBtn.Size = new System.Drawing.Size(118, 27);
            this.EditTransportTypeBtn.TabIndex = 28;
            this.EditTransportTypeBtn.Text = "Edit";
            this.EditTransportTypeBtn.UseVisualStyleBackColor = true;
            this.EditTransportTypeBtn.Click += new System.EventHandler(this.EditTransportTypeBtn_Click);
            // 
            // AddTransportTypeBtn
            // 
            this.AddTransportTypeBtn.Location = new System.Drawing.Point(46, 372);
            this.AddTransportTypeBtn.Name = "AddTransportTypeBtn";
            this.AddTransportTypeBtn.Size = new System.Drawing.Size(149, 27);
            this.AddTransportTypeBtn.TabIndex = 27;
            this.AddTransportTypeBtn.Text = "AddTransportType";
            this.AddTransportTypeBtn.UseVisualStyleBackColor = true;
            this.AddTransportTypeBtn.Click += new System.EventHandler(this.AddTransportTypeBtn_Click);
            // 
            // TransportTypeNameTbx
            // 
            this.TransportTypeNameTbx.Location = new System.Drawing.Point(96, 277);
            this.TransportTypeNameTbx.Name = "TransportTypeNameTbx";
            this.TransportTypeNameTbx.Size = new System.Drawing.Size(129, 27);
            this.TransportTypeNameTbx.TabIndex = 26;
            // 
            // TransportTypeInfoTbx
            // 
            this.TransportTypeInfoTbx.Location = new System.Drawing.Point(96, 325);
            this.TransportTypeInfoTbx.Name = "TransportTypeInfoTbx";
            this.TransportTypeInfoTbx.Size = new System.Drawing.Size(129, 27);
            this.TransportTypeInfoTbx.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "TransportRoute :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "TransportType :";
            // 
            // TransportTypeTbx
            // 
            this.TransportTypeTbx.Location = new System.Drawing.Point(347, 538);
            this.TransportTypeTbx.Name = "TransportTypeTbx";
            this.TransportTypeTbx.ReadOnly = true;
            this.TransportTypeTbx.Size = new System.Drawing.Size(127, 27);
            this.TransportTypeTbx.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "TransportInfo :";
            // 
            // TransportInfoTbx
            // 
            this.TransportInfoTbx.Location = new System.Drawing.Point(347, 588);
            this.TransportInfoTbx.Multiline = true;
            this.TransportInfoTbx.Name = "TransportInfoTbx";
            this.TransportInfoTbx.ReadOnly = true;
            this.TransportInfoTbx.Size = new System.Drawing.Size(226, 113);
            this.TransportInfoTbx.TabIndex = 34;
            // 
            // TransportTypeTransportLbx
            // 
            this.TransportTypeTransportLbx.FormattingEnabled = true;
            this.TransportTypeTransportLbx.ItemHeight = 20;
            this.TransportTypeTransportLbx.Location = new System.Drawing.Point(46, 684);
            this.TransportTypeTransportLbx.Name = "TransportTypeTransportLbx";
            this.TransportTypeTransportLbx.Size = new System.Drawing.Size(159, 264);
            this.TransportTypeTransportLbx.TabIndex = 36;
            // 
            // StationTransportLbx
            // 
            this.StationTransportLbx.FormattingEnabled = true;
            this.StationTransportLbx.ItemHeight = 20;
            this.StationTransportLbx.Location = new System.Drawing.Point(897, 759);
            this.StationTransportLbx.Name = "StationTransportLbx";
            this.StationTransportLbx.Size = new System.Drawing.Size(197, 184);
            this.StationTransportLbx.TabIndex = 37;
            // 
            // AdminBtn
            // 
            this.AdminBtn.Location = new System.Drawing.Point(496, 43);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(94, 41);
            this.AdminBtn.TabIndex = 38;
            this.AdminBtn.Text = "Admin";
            this.AdminBtn.UseVisualStyleBackColor = true;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click);
            // 
            // AdminPasswordTbx
            // 
            this.AdminPasswordTbx.Location = new System.Drawing.Point(496, 122);
            this.AdminPasswordTbx.Name = "AdminPasswordTbx";
            this.AdminPasswordTbx.Size = new System.Drawing.Size(83, 27);
            this.AdminPasswordTbx.TabIndex = 39;
            this.AdminPasswordTbx.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "TransportType :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Info :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Transport :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(646, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Route :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(938, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Station :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 661);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Transports with this transport type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(313, 717);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(214, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Stations` route of this transport";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(629, 494);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Stations of this route";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(907, 472);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Routes of this station";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(619, 740);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 20);
            this.label17.TabIndex = 51;
            this.label17.Text = "Transports of this route";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(897, 736);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 20);
            this.label18.TabIndex = 52;
            this.label18.Text = "Transports of this station";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 1055);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AdminPasswordTbx);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.StationTransportLbx);
            this.Controls.Add(this.TransportTypeTransportLbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransportInfoTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransportTypeTbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransportTypeInfoTbx);
            this.Controls.Add(this.DeleteTransportTypeBtn);
            this.Controls.Add(this.EditTransportTypeBtn);
            this.Controls.Add(this.AddTransportTypeBtn);
            this.Controls.Add(this.TransportTypeNameTbx);
            this.Controls.Add(this.TransportTypeLbx);
            this.Controls.Add(this.TransportStationsLbx);
            this.Controls.Add(this.TransportRouteTbx);
            this.Controls.Add(this.RouteTransportLbx);
            this.Controls.Add(this.LinkedRoutesLbx);
            this.Controls.Add(this.LinkedStationsLbx);
            this.Controls.Add(this.RouteStationDislinkBtn);
            this.Controls.Add(this.RouteStationLinkBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StationTimeTbx);
            this.Controls.Add(this.DeleteRouteBtn);
            this.Controls.Add(this.EditRouteBtn);
            this.Controls.Add(this.DeleteStationTbx);
            this.Controls.Add(this.EditStationTbx);
            this.Controls.Add(this.AddStationBtn);
            this.Controls.Add(this.StationNameTbx);
            this.Controls.Add(this.DeleteTransportBtn);
            this.Controls.Add(this.EditTransportBtn);
            this.Controls.Add(this.StationLbx);
            this.Controls.Add(this.AddTransportBtn);
            this.Controls.Add(this.TransportTbx);
            this.Controls.Add(this.AddRouteBtn);
            this.Controls.Add(this.RouteTbx);
            this.Controls.Add(this.RouteLbx);
            this.Controls.Add(this.TransportLbx);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TransportLbx;
        private System.Windows.Forms.ListBox RouteLbx;
        private System.Windows.Forms.TextBox RouteTbx;
        private System.Windows.Forms.Button AddRouteBtn;
        private System.Windows.Forms.Button AddTransportBtn;
        private System.Windows.Forms.TextBox TransportTbx;
        private System.Windows.Forms.ListBox StationLbx;
        private System.Windows.Forms.Button EditTransportBtn;
        private System.Windows.Forms.Button DeleteTransportBtn;
        private System.Windows.Forms.Button DeleteStationTbx;
        private System.Windows.Forms.Button EditStationTbx;
        private System.Windows.Forms.Button AddStationBtn;
        private System.Windows.Forms.TextBox StationNameTbx;
        private System.Windows.Forms.Button DeleteRouteBtn;
        private System.Windows.Forms.Button EditRouteBtn;
        private System.Windows.Forms.TextBox StationTimeTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RouteStationLinkBtn;
        private System.Windows.Forms.Button RouteStationDislinkBtn;
        private System.Windows.Forms.ListBox LinkedStationsLbx;
        private System.Windows.Forms.ListBox LinkedRoutesLbx;
        private System.Windows.Forms.ListBox RouteTransportLbx;
        private System.Windows.Forms.TextBox TransportRouteTbx;
        private System.Windows.Forms.ListBox TransportStationsLbx;
        private System.Windows.Forms.ListBox TransportTypeLbx;
        private System.Windows.Forms.Button DeleteTransportTypeBtn;
        private System.Windows.Forms.Button EditTransportTypeBtn;
        private System.Windows.Forms.Button AddTransportTypeBtn;
        private System.Windows.Forms.TextBox TransportTypeNameTbx;
        private System.Windows.Forms.TextBox TransportTypeInfoTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TransportTypeTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TransportInfoTbx;
        private System.Windows.Forms.ListBox TransportTypeTransportLbx;
        private System.Windows.Forms.ListBox StationTransportLbx;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.TextBox AdminPasswordTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

