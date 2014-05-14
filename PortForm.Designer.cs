namespace ChatServer3AA
{
    partial class PortForm
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
            this.setPortLabel = new System.Windows.Forms.Label();
            this.setPortTextBox = new System.Windows.Forms.TextBox();
            this.savePortButton = new System.Windows.Forms.Button();
            this.cancelPortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setPortLabel
            // 
            this.setPortLabel.AutoSize = true;
            this.setPortLabel.Location = new System.Drawing.Point(19, 18);
            this.setPortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.setPortLabel.Name = "setPortLabel";
            this.setPortLabel.Size = new System.Drawing.Size(54, 13);
            this.setPortLabel.TabIndex = 0;
            this.setPortLabel.Text = "Host Port:";
            // 
            // setPortTextBox
            // 
            this.setPortTextBox.Location = new System.Drawing.Point(76, 15);
            this.setPortTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.setPortTextBox.Name = "setPortTextBox";
            this.setPortTextBox.Size = new System.Drawing.Size(127, 20);
            this.setPortTextBox.TabIndex = 1;
            this.setPortTextBox.TextChanged += new System.EventHandler(this.OnPortChanged);
            // 
            // savePortButton
            // 
            this.savePortButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.savePortButton.Location = new System.Drawing.Point(38, 55);
            this.savePortButton.Margin = new System.Windows.Forms.Padding(2);
            this.savePortButton.Name = "savePortButton";
            this.savePortButton.Size = new System.Drawing.Size(56, 28);
            this.savePortButton.TabIndex = 2;
            this.savePortButton.Text = "Save";
            this.savePortButton.UseVisualStyleBackColor = true;
            this.savePortButton.Click += new System.EventHandler(this.savePortButton_Click);
            // 
            // cancelPortButton
            // 
            this.cancelPortButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelPortButton.Location = new System.Drawing.Point(122, 55);
            this.cancelPortButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelPortButton.Name = "cancelPortButton";
            this.cancelPortButton.Size = new System.Drawing.Size(56, 28);
            this.cancelPortButton.TabIndex = 3;
            this.cancelPortButton.Text = "Cancel";
            this.cancelPortButton.UseVisualStyleBackColor = true;
            this.cancelPortButton.Click += new System.EventHandler(this.cancelPortButton_Click);
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 93);
            this.Controls.Add(this.cancelPortButton);
            this.Controls.Add(this.savePortButton);
            this.Controls.Add(this.setPortTextBox);
            this.Controls.Add(this.setPortLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PortForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Port Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label setPortLabel;
        private System.Windows.Forms.TextBox setPortTextBox;
        private System.Windows.Forms.Button savePortButton;
        private System.Windows.Forms.Button cancelPortButton;
    }
}