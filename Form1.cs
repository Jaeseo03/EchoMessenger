namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // [과제 1] 전송 버튼 클릭 시 이벤트 함수
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // 데이터 유효성 검사 추가 (공백 전송 방지)
            string inputContent = txtInputMessage.Text.Trim();

            if (!string.IsNullOrEmpty(inputContent))
            {
                lstEchoWindow.Items.Add(inputContent);
                txtInputMessage.Clear();
                txtInputMessage.Focus(); // 전송 후 포커스 유지

                // 리스트박스 아이템 추가 시 항상 마지막 항목이 보이도록 스크롤 처리
                lstEchoWindow.TopIndex = lstEchoWindow.Items.Count - 1;
            }
        }

        // [과제 2] 사용자 편의성(UX) 강화 - 엔터키 처리 로직
        private void txtInputMessage_KeyDown(object sender, KeyEventArgs e)
        {
            // 1. 눌린 키가 엔터(Enter) 키인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                // 2. 전송 버튼의 클릭 이벤트를 코드로 실행 (마우스 클릭과 동일 효과)
                // PerformClick()은 버튼의 Click 이벤트를 강제로 발생.
                btnSendMessage.PerformClick();

                // 3. 엔터키 입력 시 발생하는 '띵' 소리(시스템 비프음) 방지
                e.SuppressKeyPress = true;
            }
        }
    }
}