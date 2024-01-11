namespace DailyDiary {
    public class WriteMode {
        public void Write() {
            // 날짜, 시간 받기
            string dateOnly = DateTime.Now.ToString("yyMMdd");
            //Console.WriteLine(dateOnly);
            string writeTime = DateTime.Now.ToString("h:mm:ss tt");
            //Console.WriteLine(writeTime);

            //Todo. 받은 날짜와 같은 날짜의 파일이 있는지 확인 >> 있으면 거따
            //Todo. 없을 시 새 파일 생성

            // 제목(head), 본문(body) 받음
            string? head, body;
            Console.WriteLine("제목을 입력해주세요.");
            head = Console.ReadLine();

            Console.WriteLine("\n내용을 입력해주세요.");
            body = Console.ReadLine();

        }

        // 아까 받은 시간 기록하고 마찬가지로 미리 받았던 날짜(yyMMdd)를 파일명으로 .txt 만듦
        // 파일 저장시 다시 모드 선택 화면으로 넘어감.
        // 폴더에서 날짜명 txt파일 열었을 때 시간, 제목, 내용이 나와야함.
    }
}
