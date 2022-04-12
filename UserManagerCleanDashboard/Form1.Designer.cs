
namespace UserManagerCleanDashboard
{
    partial class MainPage
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
            this.SideNav = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SideNavButtonContainer = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.BlueTrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.GreenTrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.RedTrack = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.LogoHub = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.DragPanel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.TopHeader = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.SettingBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SalesBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.NotificationBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ChatBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.DashboardBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.SideNav.SuspendLayout();
            this.SideNavButtonContainer.SuspendLayout();
            this.LogoHub.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.TopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideNav
            // 
            this.SideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.SideNav.Controls.Add(this.SideNavButtonContainer);
            this.SideNav.Controls.Add(this.LogoHub);
            this.SideNav.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SideNav.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.SideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(49)))));
            this.SideNav.Location = new System.Drawing.Point(0, 0);
            this.SideNav.Name = "SideNav";
            this.SideNav.ShadowDecoration.Parent = this.SideNav;
            this.SideNav.Size = new System.Drawing.Size(200, 646);
            this.SideNav.TabIndex = 0;
            // 
            // SideNavButtonContainer
            // 
            this.SideNavButtonContainer.BackColor = System.Drawing.Color.Transparent;
            this.SideNavButtonContainer.Controls.Add(this.siticoneHtmlLabel1);
            this.SideNavButtonContainer.Controls.Add(this.BlueTrack);
            this.SideNavButtonContainer.Controls.Add(this.GreenTrack);
            this.SideNavButtonContainer.Controls.Add(this.RedTrack);
            this.SideNavButtonContainer.Controls.Add(this.SettingBtn);
            this.SideNavButtonContainer.Controls.Add(this.SalesBtn);
            this.SideNavButtonContainer.Controls.Add(this.NotificationBtn);
            this.SideNavButtonContainer.Controls.Add(this.ChatBtn);
            this.SideNavButtonContainer.Controls.Add(this.DashboardBtn);
            this.SideNavButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideNavButtonContainer.FillColor = System.Drawing.Color.Transparent;
            this.SideNavButtonContainer.Location = new System.Drawing.Point(0, 138);
            this.SideNavButtonContainer.Name = "SideNavButtonContainer";
            this.SideNavButtonContainer.ShadowDecoration.Parent = this.SideNavButtonContainer;
            this.SideNavButtonContainer.Size = new System.Drawing.Size(200, 508);
            this.SideNavButtonContainer.TabIndex = 1;
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(11, 389);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(91, 14);
            this.siticoneHtmlLabel1.TabIndex = 11;
            this.siticoneHtmlLabel1.Text = "CONFIGURE THEME";
            // 
            // BlueTrack
            // 
            this.BlueTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlueTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.BlueTrack.HoverState.Parent = this.BlueTrack;
            this.BlueTrack.Location = new System.Drawing.Point(13, 480);
            this.BlueTrack.Name = "BlueTrack";
            this.BlueTrack.Size = new System.Drawing.Size(170, 23);
            this.BlueTrack.TabIndex = 10;
            this.BlueTrack.ThumbColor = System.Drawing.SystemColors.HotTrack;
            this.BlueTrack.Value = 49;
            this.BlueTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueTrack_Scroll);
            // 
            // GreenTrack
            // 
            this.GreenTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreenTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.GreenTrack.HoverState.Parent = this.GreenTrack;
            this.GreenTrack.Location = new System.Drawing.Point(13, 450);
            this.GreenTrack.Name = "GreenTrack";
            this.GreenTrack.Size = new System.Drawing.Size(170, 23);
            this.GreenTrack.TabIndex = 9;
            this.GreenTrack.ThumbColor = System.Drawing.Color.Lime;
            this.GreenTrack.Value = 33;
            this.GreenTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenTrack_Scroll);
            // 
            // RedTrack
            // 
            this.RedTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RedTrack.HoverState.Parent = this.RedTrack;
            this.RedTrack.Location = new System.Drawing.Point(13, 420);
            this.RedTrack.Name = "RedTrack";
            this.RedTrack.Size = new System.Drawing.Size(170, 23);
            this.RedTrack.TabIndex = 8;
            this.RedTrack.ThumbColor = System.Drawing.Color.Red;
            this.RedTrack.Value = 35;
            this.RedTrack.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedTrack_Scroll);
            // 
            // LogoHub
            // 
            this.LogoHub.Controls.Add(this.siticonePictureBox1);
            this.LogoHub.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.LogoHub.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LogoHub.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.LogoHub.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoHub.Location = new System.Drawing.Point(0, 0);
            this.LogoHub.Name = "LogoHub";
            this.LogoHub.ShadowDecoration.Parent = this.LogoHub;
            this.LogoHub.Size = new System.Drawing.Size(200, 138);
            this.LogoHub.TabIndex = 0;
            // 
            // DragPanel
            // 
            this.DragPanel.Controls.Add(this.TopHeader);
            this.DragPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.DragPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DragPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(200, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.ShadowDecoration.Parent = this.DragPanel;
            this.DragPanel.Size = new System.Drawing.Size(905, 138);
            this.DragPanel.TabIndex = 1;
            // 
            // TopHeader
            // 
            this.TopHeader.Controls.Add(this.siticoneControlBox2);
            this.TopHeader.Controls.Add(this.siticoneControlBox1);
            this.TopHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopHeader.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TopHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.TopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.ShadowDecoration.Parent = this.TopHeader;
            this.TopHeader.Size = new System.Drawing.Size(905, 60);
            this.TopHeader.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Silver;
            this.siticoneControlBox2.Location = new System.Drawing.Point(809, 8);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 45);
            this.siticoneControlBox2.TabIndex = 2;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Silver;
            this.siticoneControlBox1.Location = new System.Drawing.Point(854, 8);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 45);
            this.siticoneControlBox1.TabIndex = 1;
            // 
            // PanelSlider
            // 
            this.PanelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.PanelSlider.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PanelSlider.CustomBorderThickness = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.PanelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(70)))));
            this.PanelSlider.Location = new System.Drawing.Point(200, 138);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(905, 508);
            this.PanelSlider.TabIndex = 2;
            this.PanelSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSlider_Paint);
            // 
            // SettingBtn
            // 
            this.SettingBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.SettingBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.SettingBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SettingBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.SettingBtn.CheckedState.Image = global::UserManagerCleanDashboard.Properties.Resources.settings_light;
            this.SettingBtn.CheckedState.Parent = this.SettingBtn;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SettingBtn.CustomImages.Parent = this.SettingBtn;
            this.SettingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SettingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SettingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SettingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SettingBtn.DisabledState.Parent = this.SettingBtn;
            this.SettingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingBtn.FillColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.SettingBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SettingBtn.ForeColor = System.Drawing.Color.Gray;
            this.SettingBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.SettingBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SettingBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.HoverState.Parent = this.SettingBtn;
            this.SettingBtn.Image = global::UserManagerCleanDashboard.Properties.Resources.settings_dark;
            this.SettingBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.SettingBtn.Location = new System.Drawing.Point(0, 200);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.ShadowDecoration.Parent = this.SettingBtn;
            this.SettingBtn.Size = new System.Drawing.Size(200, 50);
            this.SettingBtn.TabIndex = 6;
            this.SettingBtn.Text = "Settings";
            this.SettingBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.SalesBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.SalesBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.SalesBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.SalesBtn.CheckedState.Image = global::UserManagerCleanDashboard.Properties.Resources.sales_light;
            this.SalesBtn.CheckedState.Parent = this.SalesBtn;
            this.SalesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SalesBtn.CustomImages.Parent = this.SalesBtn;
            this.SalesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SalesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SalesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SalesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SalesBtn.DisabledState.Parent = this.SalesBtn;
            this.SalesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesBtn.FillColor = System.Drawing.Color.Transparent;
            this.SalesBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.SalesBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SalesBtn.ForeColor = System.Drawing.Color.Gray;
            this.SalesBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.SalesBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SalesBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.SalesBtn.HoverState.Parent = this.SalesBtn;
            this.SalesBtn.Image = global::UserManagerCleanDashboard.Properties.Resources.sales_dark;
            this.SalesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.SalesBtn.Location = new System.Drawing.Point(0, 150);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.ShadowDecoration.Parent = this.SalesBtn;
            this.SalesBtn.Size = new System.Drawing.Size(200, 50);
            this.SalesBtn.TabIndex = 4;
            this.SalesBtn.Text = "Krunker";
            this.SalesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // NotificationBtn
            // 
            this.NotificationBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.NotificationBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.NotificationBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.NotificationBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.NotificationBtn.CheckedState.Image = global::UserManagerCleanDashboard.Properties.Resources.notification_light;
            this.NotificationBtn.CheckedState.Parent = this.NotificationBtn;
            this.NotificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NotificationBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.NotificationBtn.CustomImages.Parent = this.NotificationBtn;
            this.NotificationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.NotificationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.NotificationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.NotificationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.NotificationBtn.DisabledState.Parent = this.NotificationBtn;
            this.NotificationBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationBtn.FillColor = System.Drawing.Color.Transparent;
            this.NotificationBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.NotificationBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NotificationBtn.ForeColor = System.Drawing.Color.Gray;
            this.NotificationBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.NotificationBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.NotificationBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.NotificationBtn.HoverState.Parent = this.NotificationBtn;
            this.NotificationBtn.Image = global::UserManagerCleanDashboard.Properties.Resources.notification_dark;
            this.NotificationBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NotificationBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.NotificationBtn.Location = new System.Drawing.Point(0, 100);
            this.NotificationBtn.Name = "NotificationBtn";
            this.NotificationBtn.ShadowDecoration.Parent = this.NotificationBtn;
            this.NotificationBtn.Size = new System.Drawing.Size(200, 50);
            this.NotificationBtn.TabIndex = 3;
            this.NotificationBtn.Text = "CS:GO";
            this.NotificationBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NotificationBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.NotificationBtn.Click += new System.EventHandler(this.NotificationBtn_Click);
            // 
            // ChatBtn
            // 
            this.ChatBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.ChatBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.ChatBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.ChatBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.ChatBtn.CheckedState.Image = global::UserManagerCleanDashboard.Properties.Resources.chat_lightpng;
            this.ChatBtn.CheckedState.Parent = this.ChatBtn;
            this.ChatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChatBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.ChatBtn.CustomImages.Parent = this.ChatBtn;
            this.ChatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ChatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ChatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ChatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ChatBtn.DisabledState.Parent = this.ChatBtn;
            this.ChatBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChatBtn.FillColor = System.Drawing.Color.Transparent;
            this.ChatBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.ChatBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ChatBtn.ForeColor = System.Drawing.Color.Gray;
            this.ChatBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.ChatBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.ChatBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.ChatBtn.HoverState.Parent = this.ChatBtn;
            this.ChatBtn.Image = global::UserManagerCleanDashboard.Properties.Resources.chat_dark;
            this.ChatBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChatBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.ChatBtn.Location = new System.Drawing.Point(0, 50);
            this.ChatBtn.Name = "ChatBtn";
            this.ChatBtn.ShadowDecoration.Parent = this.ChatBtn;
            this.ChatBtn.Size = new System.Drawing.Size(200, 50);
            this.ChatBtn.TabIndex = 2;
            this.ChatBtn.Text = "GTA V";
            this.ChatBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChatBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.ChatBtn.Click += new System.EventHandler(this.ChatBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.DashboardBtn.Checked = true;
            this.DashboardBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Cyan;
            this.DashboardBtn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.CheckedState.ForeColor = System.Drawing.Color.Cyan;
            this.DashboardBtn.CheckedState.Image = global::UserManagerCleanDashboard.Properties.Resources.dashboard_light;
            this.DashboardBtn.CheckedState.Parent = this.DashboardBtn;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.DashboardBtn.CustomImages.Parent = this.DashboardBtn;
            this.DashboardBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashboardBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashboardBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashboardBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashboardBtn.DisabledState.Parent = this.DashboardBtn;
            this.DashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashboardBtn.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.FocusedColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DashboardBtn.ForeColor = System.Drawing.Color.Gray;
            this.DashboardBtn.HoverState.CustomBorderColor = System.Drawing.Color.Gray;
            this.DashboardBtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.DashboardBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.DashboardBtn.HoverState.Parent = this.DashboardBtn;
            this.DashboardBtn.Image = global::UserManagerCleanDashboard.Properties.Resources.dashboard_dark;
            this.DashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.DashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.ShadowDecoration.Parent = this.DashboardBtn;
            this.DashboardBtn.Size = new System.Drawing.Size(200, 50);
            this.DashboardBtn.TabIndex = 1;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashboardBtn.TextOffset = new System.Drawing.Point(20, 0);
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Enabled = false;
            this.siticonePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = global::UserManagerCleanDashboard.Properties.Resources.logo;
            this.siticonePictureBox1.ImageRotate = 0F;
            this.siticonePictureBox1.Location = new System.Drawing.Point(50, 19);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(100, 100);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            this.siticonePictureBox1.UseTransparentBackground = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1105, 646);
            this.Controls.Add(this.PanelSlider);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.SideNav);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.SideNav.ResumeLayout(false);
            this.SideNavButtonContainer.ResumeLayout(false);
            this.SideNavButtonContainer.PerformLayout();
            this.LogoHub.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.TopHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel SideNav;
        private Siticone.Desktop.UI.WinForms.SiticonePanel DragPanel;
        private Siticone.Desktop.UI.WinForms.SiticonePanel PanelSlider;
        private Siticone.Desktop.UI.WinForms.SiticonePanel TopHeader;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel LogoHub;
        private Siticone.Desktop.UI.WinForms.SiticonePanel SideNavButtonContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneButton DashboardBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SettingBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SalesBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton NotificationBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneButton ChatBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar BlueTrack;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar GreenTrack;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar RedTrack;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}

