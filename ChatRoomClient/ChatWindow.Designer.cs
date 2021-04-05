namespace ChatRoomClient
{
    partial class ChatWindow
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
            this.ChatRichTextBox = new System.Windows.Forms.RichTextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatRichTextBox
            // 
            this.ChatRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatRichTextBox.Location = new System.Drawing.Point(12, 70);
            this.ChatRichTextBox.Name = "ChatRichTextBox";
            this.ChatRichTextBox.Size = new System.Drawing.Size(683, 363);
            this.ChatRichTextBox.TabIndex = 0;
            this.ChatRichTextBox.Text = "";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(12, 463);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(596, 26);
            this.UserTextBox.TabIndex = 1;
            this.UserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserTextBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(609, 463);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(86, 26);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(259, 22);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(166, 32);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Chat Room";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(590, 22);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(105, 32);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 560);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.ChatRichTextBox);
            this.Name = "ChatWindow";
            this.Text = "ChatWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatRichTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ConnectButton;
    }
}