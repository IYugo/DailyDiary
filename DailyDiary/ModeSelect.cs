namespace DailyDiary {
    public class ModeSelect { 
        public Boolean IsRunning { get; set; } = true;

        WriteMode _writeCall = new();
        ReadMode _readCall = new();

        public void Run() {
            while (IsRunning) {
                Console.WriteLine("-------------------\n모드를 선택해주세요.\n-------------------");
                Console.WriteLine("[1] 쓰기 모드\n[2] 읽기 모드");

                string? input = Console.ReadLine();

                switch (input) {
                    case "1":
                        Console.WriteLine("쓰기 모드를 선택하셨습니다.\n");
                        _writeCall.Write();
                        return;
                    case "2":
                        Console.WriteLine("읽기 모드를 선택하셨습니다.\n");
                        _readCall.Read();
                        return;
                    default:
                        Console.WriteLine("올바른 값을 입력해주세요.\n");
                        continue;
                }


            }
        }

        // (1) 쓰기 모드 (2) 읽기 모드 입력 받고 입력한 값에 따라 ReadMode, WriteMode 연결하기
        // 1, 2가 아닌 값 입력시 다시 입력해 달라고 하기.

    }
}
