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
            if (txtInputMessage.Text == "(여기에 입력)") return;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 리스트박스의 모든 항목을 제거
            lstEchoWindow.Items.Clear();

            // 항목이 모두 지워졌으므로 상태 라벨의 개수를 0으로 업데이트
            // 과제 3에서 구현한 개수 표시 기능과 연동
            lblStatus.Text = "현재 대화: 0개";

            // (선택 사항) 사용자 편의를 위해 입력창에 포커스를 둡니다.
            txtInputMessage.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInputMessage_TextChanged(object sender, EventArgs e)
        {
            // 현재 텍스트박스에 입력된 글자 수 계산 (공백 포함)
            int currentLength = txtInputMessage.Text.Length;

            // 글자 수 표시 레이블 업데이트
            lblCharCount.Text = $"{currentLength} / 50";

            // 50자가 넘어가면 글자색을 빨간색으로 변경하여 경고 (시각적 피드백)
            if (currentLength >= 50)
            {
                lblCharCount.ForeColor = Color.Red;
            }
            else
            {
                lblCharCount.ForeColor = Color.Black;
            }
        }

        private void txtInputMessage_Enter(object sender, EventArgs e)
        {
            if (txtInputMessage.Text == "(여기에 입력)")
            {
                txtInputMessage.Text = ""; // 힌트 텍스트 지우기
                txtInputMessage.ForeColor = Color.Black; // 글자색을 검정으로 변경
            }
        }

        private void txtInputMessage_Leave(object sender, EventArgs e)
        {
            // 아무것도 입력하지 않았다면 다시 힌트 텍스트 출력
            if (string.IsNullOrWhiteSpace(txtInputMessage.Text))
            {
                txtInputMessage.Text = "(여기에 입력)";
                txtInputMessage.ForeColor = Color.Silver; // 다시 흐린 색으로 변경
            }
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            // 1. 리스트박스에서 항목이 선택되었는지 확인 (아무것도 선택 안 하면 -1 반환)
            if (lstEchoWindow.SelectedIndex != -1)
            {
                // 2. 선택된 인덱스(위치)의 항목을 삭제
                lstEchoWindow.Items.RemoveAt(lstEchoWindow.SelectedIndex);

                // 3. 항목이 삭제되었으므로 실시간 메시지 개수 라벨 업데이트 (과제 3 연계)
                lblStatus.Text = $"현재 대화: {lstEchoWindow.Items.Count}개";
            }
            else
            {
                // 선택을 안 하고 삭제 버튼을 눌렀을 때의 예외 처리 (선택 사항)
                MessageBox.Show("삭제할 메시지를 먼저 선택해주세요.", "알림");
            }
        }
    }
}