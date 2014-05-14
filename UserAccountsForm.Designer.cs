namespace ChatServer3AA
{
    partial class UserAccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountsForm));
            this.accountListView = new System.Windows.Forms.ListView();
            this.columnHeaderNickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEnabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.listHeaderImageList = new System.Windows.Forms.ImageList(this.components);
            this.userAccountsLabel = new System.Windows.Forms.Label();
            this.listContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountListView
            // 
            this.accountListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNickname,
            this.columnHeaderUsername,
            this.columnHeaderPassword,
            this.columnHeaderEnabled});
            this.accountListView.ContextMenuStrip = this.listContextMenu;
            this.accountListView.FullRowSelect = true;
            this.accountListView.HideSelection = false;
            this.accountListView.Location = new System.Drawing.Point(12, 25);
            this.accountListView.Name = "accountListView";
            this.accountListView.Size = new System.Drawing.Size(550, 260);
            this.accountListView.SmallImageList = this.listHeaderImageList;
            this.accountListView.TabIndex = 1;
            this.accountListView.UseCompatibleStateImageBehavior = false;
            this.accountListView.View = System.Windows.Forms.View.Details;
            this.accountListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.OnColumnClick);
            // 
            // columnHeaderNickname
            // 
            this.columnHeaderNickname.Text = "Nickname";
            this.columnHeaderNickname.Width = 150;
            // 
            // columnHeaderUsername
            // 
            this.columnHeaderUsername.Text = "Username";
            this.columnHeaderUsername.Width = 150;
            // 
            // columnHeaderPassword
            // 
            this.columnHeaderPassword.Text = "Password";
            this.columnHeaderPassword.Width = 150;
            // 
            // columnHeaderEnabled
            // 
            this.columnHeaderEnabled.Text = "Enabled";
            this.columnHeaderEnabled.Width = 74;
            // 
            // listContextMenu
            // 
            this.listContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRefresh,
            this.toolStripSeparator1,
            this.menuEnable,
            this.menuDelete});
            this.listContextMenu.Name = "listContextMenu";
            this.listContextMenu.ShowCheckMargin = true;
            this.listContextMenu.ShowImageMargin = false;
            this.listContextMenu.Size = new System.Drawing.Size(272, 76);
            this.listContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnOpeningContextMenu);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.ShortcutKeyDisplayString = "";
            this.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuRefresh.Size = new System.Drawing.Size(271, 22);
            this.menuRefresh.Text = "Refresh";
            this.menuRefresh.Click += new System.EventHandler(this.OnRefresh);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // menuEnable
            // 
            this.menuEnable.Name = "menuEnable";
            this.menuEnable.ShortcutKeyDisplayString = "";
            this.menuEnable.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.menuEnable.Size = new System.Drawing.Size(271, 22);
            this.menuEnable.Text = "Enable selected accounts";
            this.menuEnable.Click += new System.EventHandler(this.OnEnable);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeyDisplayString = "Delete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(271, 22);
            this.menuDelete.Text = "Delete selected accounts";
            this.menuDelete.Click += new System.EventHandler(this.OnDelete);
            // 
            // listHeaderImageList
            // 
            this.listHeaderImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listHeaderImageList.ImageStream")));
            this.listHeaderImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.listHeaderImageList.Images.SetKeyName(0, "ArrowUp.ico");
            this.listHeaderImageList.Images.SetKeyName(1, "ArrowDown.ico");
            this.listHeaderImageList.Images.SetKeyName(2, "ArrowNone.ico");
            // 
            // userAccountsLabel
            // 
            this.userAccountsLabel.AutoSize = true;
            this.userAccountsLabel.Location = new System.Drawing.Point(12, 9);
            this.userAccountsLabel.Name = "userAccountsLabel";
            this.userAccountsLabel.Size = new System.Drawing.Size(80, 13);
            this.userAccountsLabel.TabIndex = 0;
            this.userAccountsLabel.Text = "User Accounts:";
            // 
            // UserAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 296);
            this.Controls.Add(this.userAccountsLabel);
            this.Controls.Add(this.accountListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccountsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Accounts";
            this.listContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView accountListView;
        private System.Windows.Forms.Label userAccountsLabel;
        private System.Windows.Forms.ColumnHeader columnHeaderNickname;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderPassword;
        private System.Windows.Forms.ColumnHeader columnHeaderEnabled;
        private System.Windows.Forms.ContextMenuStrip listContextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ImageList listHeaderImageList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuEnable;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
    }
}