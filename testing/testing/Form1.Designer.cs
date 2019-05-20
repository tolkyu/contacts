namespace testing
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBusiness = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCoWorkers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFriends = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFamily = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAllContacts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new Bunifu.UI.WinForms.BunifuLabel();
            this.grid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.BorderRadius = 5;
            this.Header.BottomSahddow = true;
            this.Header.color = System.Drawing.Color.White;
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.Header.Controls.Add(this.bunifuLabel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.LeftSahddow = false;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.RightSahddow = true;
            this.Header.ShadowDepth = 20;
            this.Header.Size = new System.Drawing.Size(884, 50);
            this.Header.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.Header, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Header, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Header, "");
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(-10, -10);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(853, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuLabel1.Location = new System.Drawing.Point(118, 5);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(149, 42);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Contacts";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.bunifuLabel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLabel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLabel1, "");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBusiness);
            this.panel1.Controls.Add(this.btnCoWorkers);
            this.panel1.Controls.Add(this.btnFriends);
            this.panel1.Controls.Add(this.btnFamily);
            this.panel1.Controls.Add(this.btnAllContacts);
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 515);
            this.panel1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // btnBusiness
            // 
            this.btnBusiness.Activecolor = System.Drawing.Color.White;
            this.btnBusiness.BackColor = System.Drawing.Color.White;
            this.btnBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusiness.BorderRadius = 0;
            this.btnBusiness.ButtonText = "     Business";
            this.btnBusiness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusiness.DisabledColor = System.Drawing.Color.Gray;
            this.btnBusiness.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBusiness.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBusiness.Iconimage")));
            this.btnBusiness.Iconimage_right = null;
            this.btnBusiness.Iconimage_right_Selected = null;
            this.btnBusiness.Iconimage_Selected = null;
            this.btnBusiness.IconMarginLeft = 0;
            this.btnBusiness.IconMarginRight = 0;
            this.btnBusiness.IconRightVisible = true;
            this.btnBusiness.IconRightZoom = 0D;
            this.btnBusiness.IconVisible = true;
            this.btnBusiness.IconZoom = 60D;
            this.btnBusiness.IsTab = false;
            this.btnBusiness.Location = new System.Drawing.Point(3, 272);
            this.btnBusiness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.Normalcolor = System.Drawing.Color.White;
            this.btnBusiness.OnHovercolor = System.Drawing.Color.White;
            this.btnBusiness.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBusiness.selected = false;
            this.btnBusiness.Size = new System.Drawing.Size(261, 59);
            this.btnBusiness.TabIndex = 4;
            this.btnBusiness.Text = "     Business";
            this.btnBusiness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusiness.Textcolor = System.Drawing.Color.Gray;
            this.btnBusiness.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.SetToolTip(this.btnBusiness, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBusiness, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnBusiness, "");
            this.btnBusiness.Click += new System.EventHandler(this.BtnAllContacts_Click);
            // 
            // btnCoWorkers
            // 
            this.btnCoWorkers.Activecolor = System.Drawing.Color.White;
            this.btnCoWorkers.BackColor = System.Drawing.Color.White;
            this.btnCoWorkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoWorkers.BorderRadius = 0;
            this.btnCoWorkers.ButtonText = "     Co-workers";
            this.btnCoWorkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoWorkers.DisabledColor = System.Drawing.Color.Gray;
            this.btnCoWorkers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCoWorkers.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCoWorkers.Iconimage")));
            this.btnCoWorkers.Iconimage_right = null;
            this.btnCoWorkers.Iconimage_right_Selected = null;
            this.btnCoWorkers.Iconimage_Selected = null;
            this.btnCoWorkers.IconMarginLeft = 0;
            this.btnCoWorkers.IconMarginRight = 0;
            this.btnCoWorkers.IconRightVisible = true;
            this.btnCoWorkers.IconRightZoom = 0D;
            this.btnCoWorkers.IconVisible = true;
            this.btnCoWorkers.IconZoom = 60D;
            this.btnCoWorkers.IsTab = false;
            this.btnCoWorkers.Location = new System.Drawing.Point(3, 205);
            this.btnCoWorkers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCoWorkers.Name = "btnCoWorkers";
            this.btnCoWorkers.Normalcolor = System.Drawing.Color.White;
            this.btnCoWorkers.OnHovercolor = System.Drawing.Color.White;
            this.btnCoWorkers.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCoWorkers.selected = false;
            this.btnCoWorkers.Size = new System.Drawing.Size(261, 59);
            this.btnCoWorkers.TabIndex = 3;
            this.btnCoWorkers.Text = "     Co-workers";
            this.btnCoWorkers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoWorkers.Textcolor = System.Drawing.Color.Gray;
            this.btnCoWorkers.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.SetToolTip(this.btnCoWorkers, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnCoWorkers, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnCoWorkers, "");
            this.btnCoWorkers.Click += new System.EventHandler(this.BtnAllContacts_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Activecolor = System.Drawing.Color.White;
            this.btnFriends.BackColor = System.Drawing.Color.White;
            this.btnFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFriends.BorderRadius = 0;
            this.btnFriends.ButtonText = "     Friends";
            this.btnFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFriends.DisabledColor = System.Drawing.Color.Gray;
            this.btnFriends.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFriends.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFriends.Iconimage")));
            this.btnFriends.Iconimage_right = null;
            this.btnFriends.Iconimage_right_Selected = null;
            this.btnFriends.Iconimage_Selected = null;
            this.btnFriends.IconMarginLeft = 0;
            this.btnFriends.IconMarginRight = 0;
            this.btnFriends.IconRightVisible = true;
            this.btnFriends.IconRightZoom = 0D;
            this.btnFriends.IconVisible = true;
            this.btnFriends.IconZoom = 60D;
            this.btnFriends.IsTab = false;
            this.btnFriends.Location = new System.Drawing.Point(3, 138);
            this.btnFriends.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Normalcolor = System.Drawing.Color.White;
            this.btnFriends.OnHovercolor = System.Drawing.Color.White;
            this.btnFriends.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFriends.selected = false;
            this.btnFriends.Size = new System.Drawing.Size(261, 59);
            this.btnFriends.TabIndex = 2;
            this.btnFriends.Text = "     Friends";
            this.btnFriends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriends.Textcolor = System.Drawing.Color.Gray;
            this.btnFriends.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.SetToolTip(this.btnFriends, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnFriends, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnFriends, "");
            this.btnFriends.Click += new System.EventHandler(this.BtnAllContacts_Click);
            // 
            // btnFamily
            // 
            this.btnFamily.Activecolor = System.Drawing.Color.White;
            this.btnFamily.BackColor = System.Drawing.Color.White;
            this.btnFamily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFamily.BorderRadius = 0;
            this.btnFamily.ButtonText = "     Family";
            this.btnFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamily.DisabledColor = System.Drawing.Color.Gray;
            this.btnFamily.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFamily.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFamily.Iconimage")));
            this.btnFamily.Iconimage_right = null;
            this.btnFamily.Iconimage_right_Selected = null;
            this.btnFamily.Iconimage_Selected = null;
            this.btnFamily.IconMarginLeft = 0;
            this.btnFamily.IconMarginRight = 0;
            this.btnFamily.IconRightVisible = true;
            this.btnFamily.IconRightZoom = 0D;
            this.btnFamily.IconVisible = true;
            this.btnFamily.IconZoom = 60D;
            this.btnFamily.IsTab = false;
            this.btnFamily.Location = new System.Drawing.Point(3, 71);
            this.btnFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Normalcolor = System.Drawing.Color.White;
            this.btnFamily.OnHovercolor = System.Drawing.Color.White;
            this.btnFamily.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFamily.selected = false;
            this.btnFamily.Size = new System.Drawing.Size(261, 59);
            this.btnFamily.TabIndex = 1;
            this.btnFamily.Text = "     Family";
            this.btnFamily.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamily.Textcolor = System.Drawing.Color.Gray;
            this.btnFamily.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.SetToolTip(this.btnFamily, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnFamily, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnFamily, "");
            this.btnFamily.Click += new System.EventHandler(this.BtnAllContacts_Click);
            // 
            // btnAllContacts
            // 
            this.btnAllContacts.Activecolor = System.Drawing.Color.White;
            this.btnAllContacts.BackColor = System.Drawing.Color.White;
            this.btnAllContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllContacts.BorderRadius = 0;
            this.btnAllContacts.ButtonText = "     All Contacts";
            this.btnAllContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllContacts.DisabledColor = System.Drawing.Color.Gray;
            this.btnAllContacts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAllContacts.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAllContacts.Iconimage")));
            this.btnAllContacts.Iconimage_right = null;
            this.btnAllContacts.Iconimage_right_Selected = null;
            this.btnAllContacts.Iconimage_Selected = null;
            this.btnAllContacts.IconMarginLeft = 0;
            this.btnAllContacts.IconMarginRight = 0;
            this.btnAllContacts.IconRightVisible = true;
            this.btnAllContacts.IconRightZoom = 0D;
            this.btnAllContacts.IconVisible = true;
            this.btnAllContacts.IconZoom = 60D;
            this.btnAllContacts.IsTab = false;
            this.btnAllContacts.Location = new System.Drawing.Point(3, 4);
            this.btnAllContacts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAllContacts.Name = "btnAllContacts";
            this.btnAllContacts.Normalcolor = System.Drawing.Color.White;
            this.btnAllContacts.OnHovercolor = System.Drawing.Color.White;
            this.btnAllContacts.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAllContacts.selected = false;
            this.btnAllContacts.Size = new System.Drawing.Size(261, 59);
            this.btnAllContacts.TabIndex = 0;
            this.btnAllContacts.Text = "     All Contacts";
            this.btnAllContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllContacts.Textcolor = System.Drawing.Color.Gray;
            this.btnAllContacts.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuToolTip1.SetToolTip(this.btnAllContacts, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAllContacts, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnAllContacts, "");
            this.btnAllContacts.Click += new System.EventHandler(this.BtnAllContacts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuSeparator2);
            this.panel2.Controls.Add(this.bunifuImageButton4);
            this.panel2.Controls.Add(this.bunifuImageButton5);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.lblCurTab);
            this.panel2.Controls.Add(this.grid);
            this.panel2.Location = new System.Drawing.Point(273, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 515);
            this.panel2.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(4, 110);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(603, 22);
            this.bunifuSeparator2.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator2, "");
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowZooming = true;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.ErrorImage = null;
            this.bunifuImageButton4.FadeWhenInactive = false;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 0;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton4.InitialImage = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(573, 74);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = false;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton4.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton4, "Print");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton4, null);
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton4, "");
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 0;
            this.bunifuImageButton4.ZoomSpeed = 10;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.ActiveImage = null;
            this.bunifuImageButton5.AllowAnimations = true;
            this.bunifuImageButton5.AllowZooming = true;
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.ErrorImage = null;
            this.bunifuImageButton5.FadeWhenInactive = false;
            this.bunifuImageButton5.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.ImageLocation = null;
            this.bunifuImageButton5.ImageMargin = 0;
            this.bunifuImageButton5.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton5.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.bunifuImageButton5.InitialImage = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(537, 74);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Rotation = 0;
            this.bunifuImageButton5.ShowActiveImage = true;
            this.bunifuImageButton5.ShowCursorChanges = true;
            this.bunifuImageButton5.ShowImageBorders = false;
            this.bunifuImageButton5.ShowSizeMarkers = false;
            this.bunifuImageButton5.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton5.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton5, "Export to Excel");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton5, null);
            this.bunifuImageButton5.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton5, "");
            this.bunifuImageButton5.WaitOnLoad = false;
            this.bunifuImageButton5.Zoom = 0;
            this.bunifuImageButton5.ZoomSpeed = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveImage = null;
            this.btnDelete.AllowAnimations = true;
            this.btnDelete.AllowZooming = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ErrorImage = null;
            this.btnDelete.FadeWhenInactive = false;
            this.btnDelete.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.ImageLocation = null;
            this.btnDelete.ImageMargin = 0;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnDelete.InitialImage = null;
            this.btnDelete.Location = new System.Drawing.Point(289, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0;
            this.btnDelete.ShowActiveImage = true;
            this.btnDelete.ShowCursorChanges = true;
            this.btnDelete.ShowImageBorders = false;
            this.btnDelete.ShowSizeMarkers = false;
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.btnDelete, "Delete selected contact");
            this.bunifuToolTip1.SetToolTipIcon(this.btnDelete, null);
            this.btnDelete.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnDelete, "");
            this.btnDelete.WaitOnLoad = false;
            this.btnDelete.Zoom = 0;
            this.btnDelete.ZoomSpeed = 10;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveImage = null;
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowZooming = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ErrorImage")));
            this.btnAdd.FadeWhenInactive = false;
            this.btnAdd.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.ImageLocation = null;
            this.btnAdd.ImageMargin = 0;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnAdd.InitialImage = null;
            this.btnAdd.Location = new System.Drawing.Point(253, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0;
            this.btnAdd.ShowActiveImage = true;
            this.btnAdd.ShowCursorChanges = true;
            this.btnAdd.ShowImageBorders = false;
            this.btnAdd.ShowSizeMarkers = false;
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.btnAdd, "Add contact");
            this.bunifuToolTip1.SetToolTipIcon(this.btnAdd, null);
            this.btnAdd.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.btnAdd, "");
            this.btnAdd.WaitOnLoad = false;
            this.btnAdd.Zoom = 0;
            this.btnAdd.ZoomSpeed = 10;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.DeepSkyBlue;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtSearch.BorderRadius = 30;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconRight")));
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtSearch.Location = new System.Drawing.Point(4, 71);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSearch.Modified = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ReadOnly = false;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(243, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginLeft = 5;
            this.txtSearch.TextPlaceholder = "";
            this.bunifuToolTip1.SetToolTip(this.txtSearch, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtSearch, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtSearch, "");
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 27);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(603, 35);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.bunifuSeparator1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuSeparator1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuSeparator1, "");
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoEllipsis = false;
            this.lblCurTab.CursorType = null;
            this.lblCurTab.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurTab.Location = new System.Drawing.Point(14, 6);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurTab.Size = new System.Drawing.Size(111, 24);
            this.lblCurTab.TabIndex = 3;
            this.lblCurTab.Text = "All contacts";
            this.lblCurTab.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCurTab.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.lblCurTab, "");
            this.bunifuToolTip1.SetToolTipIcon(this.lblCurTab, null);
            this.bunifuToolTip1.SetToolTipTitle(this.lblCurTab, "");
            // 
            // grid
            // 
            this.grid.AllowCustomTheming = false;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colEmail,
            this.colPhone,
            this.colAddress});
            this.grid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.grid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.Name = null;
            this.grid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.grid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.grid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.grid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.grid.HeaderBgColor = System.Drawing.Color.Empty;
            this.grid.HeaderForeColor = System.Drawing.Color.White;
            this.grid.Location = new System.Drawing.Point(4, 138);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 40;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(603, 374);
            this.grid.TabIndex = 0;
            this.grid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuToolTip1.SetToolTip(this.grid, "");
            this.bunifuToolTip1.SetToolTipIcon(this.grid, null);
            this.bunifuToolTip1.SetToolTipTitle(this.grid, "");
            // 
            // colName
            // 
            this.colName.HeaderText = "   Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards Header;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBusiness;
        private Bunifu.Framework.UI.BunifuFlatButton btnCoWorkers;
        private Bunifu.Framework.UI.BunifuFlatButton btnFriends;
        private Bunifu.Framework.UI.BunifuFlatButton btnFamily;
        private Bunifu.Framework.UI.BunifuFlatButton btnAllContacts;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel lblCurTab;
        private Bunifu.UI.WinForms.BunifuDataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSearch;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton5;
        private Bunifu.UI.WinForms.BunifuImageButton btnDelete;
        private Bunifu.UI.WinForms.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}

