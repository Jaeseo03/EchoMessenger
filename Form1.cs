namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 전송 버튼 클릭 시 이벤트 함수
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // 입력창의 텍스트 가져오기
            string cleaned_msg = txtInputMessage.Text.Trim();

            // 현재 시간 정보 생성 (시:분:초 형식)
            string time = DateTime.Now.ToString("HH:mm:ss");

            // 데이터 가공: 시간과 메시지 결합
            string formatted_msg = "[" + time + "] " + cleaned_msg;

            // 리스트박스에 가공된 메시지 추가
            lstEchoWindow.Items.Add(formatted_msg);

            // 상태 표시 라벨에 현재 메시지 개수 업데이트
            lblStatus.Text = "현재 대화: " + lstEchoWindow.Items.Count.ToString() + "개";

            // 1~2단계에서 구현했던 기본 UI 정리
            txtInputMessage.Clear();
            txtInputMessage.Focus();
            lstEchoWindow.TopIndex = lstEchoWindow.Items.Count - 1;
        }

        // 사용자 편의성(UX) 강화 - 엔터키 처리 로직
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