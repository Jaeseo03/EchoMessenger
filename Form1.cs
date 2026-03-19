namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMessage_Click(object sender, EventArgs e) // 전송 버튼 클릭 시 이벤트 함수
        {
            string typed_msg = txtInputMessage.Text; 
            lstEchoWindow.Items.Add(typed_msg); // 입력 박스에 입력된 메시지를 리스트 박스에 추가
            txtInputMessage.Clear(); // 입력 박스 초기화

        }
    }
}
