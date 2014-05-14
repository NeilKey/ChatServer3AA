namespace ChatServer3AA
{
    partial class ChatServerForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.nickname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.connectTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersListLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.hostIPLabel = new System.Windows.Forms.Label();
            this.hostPortLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.accountsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nickname,
            this.username,
            this.password,
            this.connectTime});
            this.listView1.Location = new System.Drawing.Point(9, 24);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(672, 265);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nickname
            // 
            this.nickname.Text = "Nickname";
            this.nickname.Width = 206;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 205;
            // 
            // password
            // 
            this.password.Text = "Password";
            this.password.Width = 180;
            // 
            // connectTime
            // 
            this.connectTime.Text = "Connect time";
            this.connectTime.Width = 219;
            // 
            // usersListLabel
            // 
            this.usersListLabel.AutoSize = true;
            this.usersListLabel.Location = new System.Drawing.Point(9, 7);
            this.usersListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usersListLabel.Name = "usersListLabel";
            this.usersListLabel.Size = new System.Drawing.Size(68, 13);
            this.usersListLabel.TabIndex = 1;
            this.usersListLabel.Text = "Users online:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(18, 306);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Host Name:";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(18, 329);
            this.ipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(45, 13);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "Host IP:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.portLabel.Location = new System.Drawing.Point(18, 353);
            this.portLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(54, 13);
            this.portLabel.TabIndex = 4;
            this.portLabel.Text = "Host Port:";
            this.portLabel.Click += new System.EventHandler(this.portLabel_Click);
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(89, 306);
            this.hostNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(35, 13);
            this.hostNameLabel.TabIndex = 5;
            this.hostNameLabel.Text = "label4";
            // 
            // hostIPLabel
            // 
            this.hostIPLabel.AutoSize = true;
            this.hostIPLabel.Location = new System.Drawing.Point(89, 329);
            this.hostIPLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostIPLabel.Name = "hostIPLabel";
            this.hostIPLabel.Size = new System.Drawing.Size(35, 13);
            this.hostIPLabel.TabIndex = 6;
            this.hostIPLabel.Text = "label5";
            // 
            // hostPortLabel
            // 
            this.hostPortLabel.AutoSize = true;
            this.hostPortLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.hostPortLabel.Location = new System.Drawing.Point(89, 353);
            this.hostPortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hostPortLabel.Name = "hostPortLabel";
            this.hostPortLabel.Size = new System.Drawing.Size(35, 13);
            this.hostPortLabel.TabIndex = 7;
            this.hostPortLabel.Text = "label6";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(615, 298);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(66, 22);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(615, 324);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(66, 22);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // accountsButton
            // 
            this.accountsButton.Location = new System.Drawing.Point(615, 350);
            this.accountsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountsButton.Name = "accountsButton";
            this.accountsButton.Size = new System.Drawing.Size(66, 22);
            this.accountsButton.TabIndex = 10;
            this.accountsButton.Text = "Accounts";
            this.accountsButton.UseVisualStyleBackColor = true;
            this.accountsButton.Click += new System.EventHandler(this.OnUserAccounts);
            // 
            // ChatServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 378);
            this.Controls.Add(this.accountsButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.hostPortLabel);
            this.Controls.Add(this.hostIPLabel);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.usersListLabel);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ChatServerForm";
            this.Text = "Chat Server - CPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nickname;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader connectTime;
        private System.Windows.Forms.Label usersListLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.Label hostIPLabel;
        private System.Windows.Forms.Label hostPortLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button accountsButton;
    }
}

