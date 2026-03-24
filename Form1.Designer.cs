namespace EchoMessenger
{
    partial class Form1
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
            lblTitle = new Label();
            lstEchoWindow = new ListBox();
            txtInputMessage = new TextBox();
            btnSendMessage = new Button();
            lblStatus = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 36F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = SystemColors.MenuHighlight;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(481, 81);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            // 
            // lstEchoWindow
            // 
            lstEchoWindow.BackColor = Color.DarkKhaki;
            lstEchoWindow.FormattingEnabled = true;
            lstEchoWindow.Location = new Point(29, 102);
            lstEchoWindow.Name = "lstEchoWindow";
            lstEchoWindow.Size = new Size(785, 324);
            lstEchoWindow.TabIndex = 1;
            // 
            // txtInputMessage
            // 
            txtInputMessage.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInputMessage.Location = new Point(29, 441);
            txtInputMessage.Name = "txtInputMessage";
            txtInputMessage.Size = new Size(785, 38);
            txtInputMessage.TabIndex = 2;
            txtInputMessage.Text = "(여기에 입력)";
            txtInputMessage.KeyDown += txtInputMessage_KeyDown;
            // 
            // btnSendMessage
            // 
            btnSendMessage.BackColor = Color.ForestGreen;
            btnSendMessage.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendMessage.ForeColor = Color.Black;
            btnSendMessage.Location = new Point(820, 441);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(113, 75);
            btnSendMessage.TabIndex = 3;
            btnSendMessage.Text = "전송";
            btnSendMessage.UseVisualStyleBackColor = false;
            btnSendMessage.Click += btnSendMessage_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = SystemColors.ActiveCaption;
            lblStatus.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblStatus.Location = new Point(29, 505);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "현재 대화:";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(820, 102);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 558);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Controls.Add(btnSendMessage);
            Controls.Add(txtInputMessage);
            Controls.Add(lstEchoWindow);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ListBox lstEchoWindow;
        private TextBox txtInputMessage;
        private Button btnSendMessage;
        private Label lblStatus;
        private Button button1;
        private Button button2;
    }
}
