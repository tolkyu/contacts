namespace testing
{
    partial class frmAddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContact));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnAddContact = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblCurTab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.isFriend = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.isCoWorker = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.isBusiness = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.isFamily = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SuspendLayout();
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.Transparent;
            this.btnAddContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddContact.BackgroundImage")));
            this.btnAddContact.ButtonText = "Add Contact";
            this.btnAddContact.ButtonTextMarginLeft = 0;
            this.btnAddContact.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddContact.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddContact.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddContact.ForeColor = System.Drawing.Color.White;
            this.btnAddContact.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddContact.IconPadding = 10;
            this.btnAddContact.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddContact.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleBorderRadius = 1;
            this.btnAddContact.IdleBorderThickness = 0;
            this.btnAddContact.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddContact.IdleIconLeftImage = null;
            this.btnAddContact.IdleIconRightImage = null;
            this.btnAddContact.Location = new System.Drawing.Point(87, 403);
            this.btnAddContact.Name = "btnAddContact";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 10;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddContact.onHoverState = stateProperties1;
            this.btnAddContact.Size = new System.Drawing.Size(239, 45);
            this.btnAddContact.TabIndex = 31;
            this.btnAddContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(12, 305);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(398, 15);
            this.bunifuSeparator2.TabIndex = 30;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(398, 15);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblCurTab
            // 
            this.lblCurTab.AutoSize = true;
            this.lblCurTab.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblCurTab.ForeColor = System.Drawing.Color.Black;
            this.lblCurTab.Location = new System.Drawing.Point(141, 29);
            this.lblCurTab.Name = "lblCurTab";
            this.lblCurTab.Size = new System.Drawing.Size(130, 21);
            this.lblCurTab.TabIndex = 28;
            this.lblCurTab.Text = "Add Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(296, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Business";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(102, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Co-worker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(296, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Family";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Friend";
            // 
            // txtAddress
            // 
            this.txtAddress.AcceptsReturn = false;
            this.txtAddress.AcceptsTab = false;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAddress.BackgroundImage")));
            this.txtAddress.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtAddress.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAddress.BorderColorHover = System.Drawing.Color.DeepSkyBlue;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtAddress.BorderRadius = 30;
            this.txtAddress.BorderThickness = 1;
            this.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAddress.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAddress.DefaultText = "";
            this.txtAddress.FillColor = System.Drawing.Color.White;
            this.txtAddress.HideSelection = true;
            this.txtAddress.IconLeft = null;
            this.txtAddress.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.IconPadding = 10;
            this.txtAddress.IconRight = null;
            this.txtAddress.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAddress.Location = new System.Drawing.Point(75, 261);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAddress.Modified = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(269, 35);
            this.txtAddress.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAddress.TabIndex = 23;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMarginLeft = 5;
            this.txtAddress.TextPlaceholder = "Address";
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.DeepSkyBlue;
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPhone.BorderRadius = 30;
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = null;
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPhone.Location = new System.Drawing.Point(75, 201);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPhone.Modified = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(269, 35);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 22;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginLeft = 5;
            this.txtPhone.TextPlaceholder = "Phone";
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.DeepSkyBlue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtEmail.BorderRadius = 30;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.Location = new System.Drawing.Point(75, 140);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtEmail.Modified = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(269, 35);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 21;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginLeft = 5;
            this.txtEmail.TextPlaceholder = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(45)))), ((int)(((byte)(145)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.DeepSkyBlue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 30;
            this.txtName.BorderThickness = 1;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(75, 79);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(269, 35);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 20;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // isFriend
            // 
            this.isFriend.AllowBindingControlAnimation = true;
            this.isFriend.AllowBindingControlColorChanges = false;
            this.isFriend.AllowBindingControlLocation = true;
            this.isFriend.AllowCheckBoxAnimation = false;
            this.isFriend.AllowCheckmarkAnimation = true;
            this.isFriend.AllowOnHoverStates = true;
            this.isFriend.AutoCheck = true;
            this.isFriend.BackColor = System.Drawing.Color.Transparent;
            this.isFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isFriend.BackgroundImage")));
            this.isFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFriend.BindingControl = null;
            this.isFriend.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isFriend.Checked = true;
            this.isFriend.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isFriend.CustomCheckmarkImage = null;
            this.isFriend.Location = new System.Drawing.Point(75, 328);
            this.isFriend.MinimumSize = new System.Drawing.Size(17, 17);
            this.isFriend.Name = "isFriend";
            this.isFriend.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFriend.OnCheck.BorderRadius = 2;
            this.isFriend.OnCheck.BorderThickness = 2;
            this.isFriend.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFriend.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isFriend.OnCheck.CheckmarkThickness = 2;
            this.isFriend.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isFriend.OnDisable.BorderRadius = 2;
            this.isFriend.OnDisable.BorderThickness = 2;
            this.isFriend.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFriend.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isFriend.OnDisable.CheckmarkThickness = 2;
            this.isFriend.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFriend.OnHoverChecked.BorderRadius = 2;
            this.isFriend.OnHoverChecked.BorderThickness = 2;
            this.isFriend.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFriend.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isFriend.OnHoverChecked.CheckmarkThickness = 2;
            this.isFriend.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFriend.OnHoverUnchecked.BorderRadius = 2;
            this.isFriend.OnHoverUnchecked.BorderThickness = 2;
            this.isFriend.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFriend.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFriend.OnUncheck.BorderRadius = 2;
            this.isFriend.OnUncheck.BorderThickness = 2;
            this.isFriend.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFriend.Size = new System.Drawing.Size(21, 21);
            this.isFriend.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isFriend.TabIndex = 32;
            this.isFriend.ThreeState = false;
            this.isFriend.ToolTipText = null;
            // 
            // isCoWorker
            // 
            this.isCoWorker.AllowBindingControlAnimation = true;
            this.isCoWorker.AllowBindingControlColorChanges = false;
            this.isCoWorker.AllowBindingControlLocation = true;
            this.isCoWorker.AllowCheckBoxAnimation = false;
            this.isCoWorker.AllowCheckmarkAnimation = true;
            this.isCoWorker.AllowOnHoverStates = true;
            this.isCoWorker.AutoCheck = true;
            this.isCoWorker.BackColor = System.Drawing.Color.Transparent;
            this.isCoWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isCoWorker.BackgroundImage")));
            this.isCoWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isCoWorker.BindingControl = null;
            this.isCoWorker.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isCoWorker.Checked = true;
            this.isCoWorker.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isCoWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isCoWorker.CustomCheckmarkImage = null;
            this.isCoWorker.Location = new System.Drawing.Point(75, 356);
            this.isCoWorker.MinimumSize = new System.Drawing.Size(17, 17);
            this.isCoWorker.Name = "isCoWorker";
            this.isCoWorker.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isCoWorker.OnCheck.BorderRadius = 2;
            this.isCoWorker.OnCheck.BorderThickness = 2;
            this.isCoWorker.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isCoWorker.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isCoWorker.OnCheck.CheckmarkThickness = 2;
            this.isCoWorker.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isCoWorker.OnDisable.BorderRadius = 2;
            this.isCoWorker.OnDisable.BorderThickness = 2;
            this.isCoWorker.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isCoWorker.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isCoWorker.OnDisable.CheckmarkThickness = 2;
            this.isCoWorker.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isCoWorker.OnHoverChecked.BorderRadius = 2;
            this.isCoWorker.OnHoverChecked.BorderThickness = 2;
            this.isCoWorker.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isCoWorker.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isCoWorker.OnHoverChecked.CheckmarkThickness = 2;
            this.isCoWorker.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isCoWorker.OnHoverUnchecked.BorderRadius = 2;
            this.isCoWorker.OnHoverUnchecked.BorderThickness = 2;
            this.isCoWorker.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isCoWorker.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isCoWorker.OnUncheck.BorderRadius = 2;
            this.isCoWorker.OnUncheck.BorderThickness = 2;
            this.isCoWorker.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isCoWorker.Size = new System.Drawing.Size(21, 21);
            this.isCoWorker.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isCoWorker.TabIndex = 33;
            this.isCoWorker.ThreeState = false;
            this.isCoWorker.ToolTipText = null;
            // 
            // isBusiness
            // 
            this.isBusiness.AllowBindingControlAnimation = true;
            this.isBusiness.AllowBindingControlColorChanges = false;
            this.isBusiness.AllowBindingControlLocation = true;
            this.isBusiness.AllowCheckBoxAnimation = false;
            this.isBusiness.AllowCheckmarkAnimation = true;
            this.isBusiness.AllowOnHoverStates = true;
            this.isBusiness.AutoCheck = true;
            this.isBusiness.BackColor = System.Drawing.Color.Transparent;
            this.isBusiness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isBusiness.BackgroundImage")));
            this.isBusiness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isBusiness.BindingControl = null;
            this.isBusiness.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isBusiness.Checked = true;
            this.isBusiness.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isBusiness.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isBusiness.CustomCheckmarkImage = null;
            this.isBusiness.Location = new System.Drawing.Point(269, 356);
            this.isBusiness.MinimumSize = new System.Drawing.Size(17, 17);
            this.isBusiness.Name = "isBusiness";
            this.isBusiness.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isBusiness.OnCheck.BorderRadius = 2;
            this.isBusiness.OnCheck.BorderThickness = 2;
            this.isBusiness.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isBusiness.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isBusiness.OnCheck.CheckmarkThickness = 2;
            this.isBusiness.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isBusiness.OnDisable.BorderRadius = 2;
            this.isBusiness.OnDisable.BorderThickness = 2;
            this.isBusiness.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isBusiness.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isBusiness.OnDisable.CheckmarkThickness = 2;
            this.isBusiness.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isBusiness.OnHoverChecked.BorderRadius = 2;
            this.isBusiness.OnHoverChecked.BorderThickness = 2;
            this.isBusiness.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isBusiness.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isBusiness.OnHoverChecked.CheckmarkThickness = 2;
            this.isBusiness.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isBusiness.OnHoverUnchecked.BorderRadius = 2;
            this.isBusiness.OnHoverUnchecked.BorderThickness = 2;
            this.isBusiness.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isBusiness.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isBusiness.OnUncheck.BorderRadius = 2;
            this.isBusiness.OnUncheck.BorderThickness = 2;
            this.isBusiness.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isBusiness.Size = new System.Drawing.Size(21, 21);
            this.isBusiness.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isBusiness.TabIndex = 35;
            this.isBusiness.ThreeState = false;
            this.isBusiness.ToolTipText = null;
            // 
            // isFamily
            // 
            this.isFamily.AllowBindingControlAnimation = true;
            this.isFamily.AllowBindingControlColorChanges = false;
            this.isFamily.AllowBindingControlLocation = true;
            this.isFamily.AllowCheckBoxAnimation = false;
            this.isFamily.AllowCheckmarkAnimation = true;
            this.isFamily.AllowOnHoverStates = true;
            this.isFamily.AutoCheck = true;
            this.isFamily.BackColor = System.Drawing.Color.Transparent;
            this.isFamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("isFamily.BackgroundImage")));
            this.isFamily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.isFamily.BindingControl = null;
            this.isFamily.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.isFamily.Checked = true;
            this.isFamily.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.isFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.isFamily.CustomCheckmarkImage = null;
            this.isFamily.Location = new System.Drawing.Point(269, 328);
            this.isFamily.MinimumSize = new System.Drawing.Size(17, 17);
            this.isFamily.Name = "isFamily";
            this.isFamily.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFamily.OnCheck.BorderRadius = 2;
            this.isFamily.OnCheck.BorderThickness = 2;
            this.isFamily.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFamily.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.isFamily.OnCheck.CheckmarkThickness = 2;
            this.isFamily.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.isFamily.OnDisable.BorderRadius = 2;
            this.isFamily.OnDisable.BorderThickness = 2;
            this.isFamily.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFamily.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.isFamily.OnDisable.CheckmarkThickness = 2;
            this.isFamily.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFamily.OnHoverChecked.BorderRadius = 2;
            this.isFamily.OnHoverChecked.BorderThickness = 2;
            this.isFamily.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFamily.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.isFamily.OnHoverChecked.CheckmarkThickness = 2;
            this.isFamily.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.isFamily.OnHoverUnchecked.BorderRadius = 2;
            this.isFamily.OnHoverUnchecked.BorderThickness = 2;
            this.isFamily.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFamily.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.isFamily.OnUncheck.BorderRadius = 2;
            this.isFamily.OnUncheck.BorderThickness = 2;
            this.isFamily.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.isFamily.Size = new System.Drawing.Size(21, 21);
            this.isFamily.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.isFamily.TabIndex = 34;
            this.isFamily.ThreeState = false;
            this.isFamily.ToolTipText = null;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowZooming = true;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ErrorImage = null;
            this.btnClose.FadeWhenInactive = true;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 40;
            this.btnClose.ImageSize = new System.Drawing.Size(-10, -10);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(395, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = false;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 36;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 40;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 475);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.isBusiness);
            this.Controls.Add(this.isFamily);
            this.Controls.Add(this.isCoWorker);
            this.Controls.Add(this.isFriend);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblCurTab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddContact;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCurTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAddress;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPhone;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuCheckBox isFriend;
        private Bunifu.UI.WinForms.BunifuCheckBox isCoWorker;
        private Bunifu.UI.WinForms.BunifuCheckBox isBusiness;
        private Bunifu.UI.WinForms.BunifuCheckBox isFamily;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
    }
}