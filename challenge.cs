using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace floralplayingcards
{
    public partial class challenge : Form
    {
        public int blockSize; // ブロックサイズ(px単位)
        public int blockCount; // ブロック数
        public int blockNumber; // ブロック内数字のサイズ
        public int resultNumber; // 合計値

        private List<Blocker> blocks; // ブロックリスト
        private Random random; // ランダム生成
        private List<Button> selects; // 選択されたボタンのリスト

        private Timer timer; // タイマー
        private int minutes; // 分
        private int seconds; // 秒

        public int basescore; // 基本得点
        public int penalty; // 間違えた時のペナルティ用
        private double time_p = 1000; // 時間短縮ペナルティ用

        private int score; // 現在の得点

        private System.Media.SoundPlayer player = null; // 効果音

        private string path = System.Environment.CurrentDirectory; // カレントディレクトリの取得

        public challenge()
        {
            InitializeComponent();

            blocks = new List<Blocker>();
            random = new Random();
            selects = new List<Button>();

            minutes = 3;
            seconds = 0;

            timer = new Timer();
            timer.Interval = 1000; // タイマーのインターバル(1秒)
            timer.Tick += timer1_Tick; // タイマーのイベントハンドラ

            Timer.Text = "3:00"; // 初期表示
            Timer.Font = new Font(Timer.Font.FontFamily, 40, FontStyle.Bold);

            score = 0;

            result.Text = $"?";

            // 得点表示用のタイマー
            Timer updateScoreTimer = new Timer();
            updateScoreTimer.Interval = 10; // 0.01秒ごとにタイマーイベント発生
            updateScoreTimer.Tick += UpdateScoreTimer_Tick;
            updateScoreTimer.Start();
        }

        private void challenge_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void p_block_Paint(object sender, PaintEventArgs e)
        {
            // 初期はブロックを配置しない
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            score = 0;
            b_start.Enabled = false; // スタートボタンを押せなくなる

            // パネルのクリア
            p_block.Controls.Clear();
            blocks.Clear();

            result.Text = $"{resultNumber}";

            timer.Start(); // タイマー開始

            // ブロックの作成と配置
            // ブロックは数値のペアが合計値になるように且つ半々になるように設定する
            List<int> numbers = GenerateRandomNumbers();
            List<int> shuffledNumbers = ShuffleNumbers(numbers);

            int pairCount = blockCount * blockCount / 2;
            int index = 0;

            for (int row = 0; row < blockCount; row++)
            {
                for (int col = 0; col < blockCount; col++)
                {
                    Blocker block = new Blocker(blockSize, row, col);
                    blocks.Add(block);

                    Button button = new Button();
                    button.Width = block.Size;
                    button.Height = block.Size;
                    button.Left = block.Column * block.Size;
                    button.Top = block.Row * block.Size;

                    if (index < pairCount)
                    {
                        //System.Console.WriteLine(numbers[index]);
                        button.Text = shuffledNumbers[index].ToString();
                    }
                    else
                    {
                        //System.Console.WriteLine(index);
                        int pairIndex = index - pairCount;
                        button.Text = (resultNumber - shuffledNumbers[pairIndex]).ToString();
                    }

                    button.Font = new Font(button.Font.FontFamily, block.Size / blockNumber, FontStyle.Bold); // フォントサイズとスタイルの設定
                    button.TextAlign = ContentAlignment.MiddleCenter;

                    button.Click += b_Click;

                    p_block.Controls.Add(button);

                    index++;
                }
            }
        }

        private List<int> GenerateRandomNumbers()
        {
            List<int> numbers = new List<int>();
            int pairCount = blockCount * blockCount / 2;

            for (int i = 1; i <= pairCount; i++)
            {
                numbers.Add(i);
            }

            foreach (var s in numbers)
            {
                System.Console.WriteLine(s);
            }
            return numbers;
        }

        private List<int> ShuffleNumbers(List<int> numbers)
        {
            List<int> shuffledNumbers = new List<int>(numbers);
            int n = shuffledNumbers.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = shuffledNumbers[k];
                shuffledNumbers[k] = shuffledNumbers[n];
                shuffledNumbers[n] = value;
            }
            return shuffledNumbers;
        }

        private void b_Click(object sender, EventArgs e)
        {
            // 数値が書かれたボタンをクリックされたとき処理
            Button button = (Button)sender;
            selects.Add(button);

            // 選択されたボタンが二つあるか確認
            if (selects.Count == 2)
            {
                int sum = 0;
                foreach (Button select in selects)
                {
                    sum += int.Parse(select.Text);
                }

                // 数値の合計が合計値の場合，選択されたブロックを消去
                if (sum == resultNumber)
                {
                    player = new System.Media.SoundPlayer(path + "\\wav_data\\block_break.wav");
                    player.Play();
                    foreach (Button select in selects)
                    {
                        p_block.Controls.Remove(select);
                    }
                    score += basescore; // ペアが消えたら基本得点を加算
                }
                else
                {
                    score -= 5 * penalty;
                    time_p = time_p * 0.5;
                    timer.Interval = (int)time_p; // タイマーのインターバル(1秒)
                    timer.Tick += timer1_Tick; // タイマーのイベントハンドラ
                }

                selects.Clear();
            }

            // ボタンがすべて消えたら新しいパネルへ
            if (p_block.Controls.Count == 0)
            {
                ShowClearScreen();
                seconds += 30;
            }
        }

        private void ShowClearScreen()
        {
            Random results = new System.Random(); // 新たな結果値を生成
            int resultNumber = results.Next(5, 11) * 10;
            result.Text = $"{resultNumber}";
            // ブロックの作成と配置
            // ブロックは数値のペアが合計値になるように且つ半々になるように設定する
            List<int> numbers = GenerateRandomNumbers();
            List<int> shuffledNumbers = ShuffleNumbers(numbers);

            int pairCount = blockCount * blockCount / 2;
            int index = 0;

            for (int row = 0; row < blockCount; row++)
            {
                for (int col = 0; col < blockCount; col++)
                {
                    Blocker block = new Blocker(blockSize, row, col);
                    blocks.Add(block);

                    Button button = new Button();
                    button.Width = block.Size;
                    button.Height = block.Size;
                    button.Left = block.Column * block.Size;
                    button.Top = block.Row * block.Size;

                    if (index < pairCount)
                    {
                        //System.Console.WriteLine(numbers[index]);
                        button.Text = shuffledNumbers[index].ToString();
                    }
                    else
                    {
                        //System.Console.WriteLine(index);
                        int pairIndex = index - pairCount;
                        button.Text = (resultNumber - shuffledNumbers[pairIndex]).ToString();
                    }

                    button.Font = new Font(button.Font.FontFamily, block.Size / blockNumber, FontStyle.Bold); // フォントサイズとスタイルの設定
                    button.TextAlign = ContentAlignment.MiddleCenter;

                    button.Click += b_Click;

                    p_block.Controls.Add(button);

                    index++;
                }
            }
        }

        private void ShowOverScreen()
        {
            player = new System.Media.SoundPlayer(path + "\\wav_data\\clear.wav");
            player.Play();

            timer.Stop(); // タイマー停止

            // クリア画面を表示する
            MessageBox.Show("時間がなくなりました。\nあなたは" + score + "点です！\"", "リザルト画面");
            b_start.Enabled = true;
            blocks = new List<Blocker>();
            random = new Random();
            selects = new List<Button>();

            minutes = 3;
            seconds = 0;

            timer = new Timer();
            timer.Interval = 1000; // タイマーのインターバル(1秒)
            timer.Tick += timer1_Tick; // タイマーのイベントハンドラ

            Timer.Text = "0:00"; // 初期表示
            Timer.Font = new Font(Timer.Font.FontFamily, 40, FontStyle.Bold);

            Random results = new System.Random(); // 新たな結果値を生成
            resultNumber = results.Next(5, 11) * 10;
            result.Text = $"{resultNumber}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // タイマーのイベントハンドラ
            seconds--;

            if (seconds < 0)
            {
                seconds = 59;
                minutes--;
            }
            Timer.Text = $"{minutes}:{seconds.ToString("00")}";

            // 時間がなくなったら終了
            if (minutes <= 0 && seconds <=0)
            {
                ShowOverScreen();
            }
        }

        private void UpdateScoreTimer_Tick(object sender, EventArgs e)
        {
            // 得点を更新して表示
            Sum.Text = $"{score}";
        }
    }
}
