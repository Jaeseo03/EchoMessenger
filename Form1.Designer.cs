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
            btnReset = new Button();
            lblCharCount = new Label();
            btnDeleteSelected = new Button();
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
            txtInputMessage.ForeColor = SystemColors.GrayText;
            txtInputMessage.Location = new Point(29, 441);
            txtInputMessage.MaxLength = 50;
            txtInputMessage.Name = "txtInputMessage";
            txtInputMessage.Size = new Size(785, 38);
            txtInputMessage.TabIndex = 2;
            txtInputMessage.Text = "(여기에 입력)";
            txtInputMessage.TextChanged += txtInputMessage_TextChanged;
            txtInputMessage.Enter += txtInputMessage_Enter;
            txtInputMessage.KeyDown += txtInputMessage_KeyDown;
            txtInputMessage.Leave += txtInputMessage_Leave;
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
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.Transparent;
            btnReset.Location = new Point(838, 102);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 72);
            btnReset.TabIndex = 6;
            btnReset.Text = "대화 기록 삭제";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblCharCount
            // 
            lblCharCount.AutoSize = true;
            lblCharCount.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCharCount.Location = new Point(736, 444);
            lblCharCount.Name = "lblCharCount";
            lblCharCount.Size = new Size(78, 31);
            lblCharCount.TabIndex = 7;
            lblCharCount.Text = "0 / 50";
            lblCharCount.Click += label1_Click;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = SystemColors.ActiveCaption;
            btnDeleteSelected.ForeColor = SystemColors.ControlText;
            btnDeleteSelected.Location = new Point(838, 198);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(95, 72);
            btnDeleteSelected.TabIndex = 8;
            btnDeleteSelected.Text = "선택항목 삭제";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += btnDeleteSelected_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 558);
            Controls.Add(btnDeleteSelected);
            Controls.Add(lblCharCount);
            Controls.Add(btnReset);
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
        private Button btnReset;
        private Label lblCharCount;
        private Button btnDeleteSelected;
    }
}
