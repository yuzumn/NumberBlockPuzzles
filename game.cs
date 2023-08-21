using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace floralplayingcards
{
    public partial class F_Main : Form
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
        private int pointer; // 時間経過ペナルティ用
        public int penalty; // 間違えた時のペナルティ用

        private int score; // 現在の得点

        private System.Media.SoundPlayer player = null; // 効果音
        private string path = System.Environment.CurrentDirectory; // カレントディレクトリの取得

        public F_Main()
        {
            InitializeComponent();
            blocks = new List<Blocker>();
            random = new Random();
            selects = new List<Button>();

            minutes = 0;
            seconds = 0;
            pointer = 0;

            timer = new Timer();
            timer.Interval = 1000; // タイマーのインターバル(1秒)
            timer.Tick += timer1_Tick; // タイマーのイベントハンドラ
            
            Timer.Text = "0:00"; // 初期表示
            Timer.Font = new Font(Timer.Font.FontFamily, 40, FontStyle.Bold);

            score = 0;

            result.Text = $"?";

            // 得点表示用のタイマー
            Timer updateScoreTimer = new Timer();
            updateScoreTimer.Interval = 10; // 0.01秒ごとにタイマーイベント発生
            updateScoreTimer.Tick += UpdateScoreTimer_Tick;
            updateScoreTimer.Start();
        }

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // メニュー画面表示
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
                }

                selects.Clear();
            }

            // ボタンがすべて消えたらクリア
            if (p_block.Controls.Count == 0)
            {
                ShowClearScreen();
            }

            if (score < 0)
            {
                ShowOverScreen();
            }
        }

        private void ShowClearScreen()
        {
            player = new System.Media.SoundPlayer(path + "\\wav_data\\clear.wav");
            player.Play();

            timer.Stop(); // タイマー停止

            // クリア画面を表示する
            MessageBox.Show("すべてのブロックを消去しました！クリアです！\nあなたは" + score + "点です！", "クリア画面");
            b_start.Enabled = true;
            blocks = new List<Blocker>();
            random = new Random();
            selects = new List<Button>();

            minutes = 0;
            seconds = 0;

            timer = new Timer();
            timer.Interval = 1000; // タイマーのインターバル(1秒)
            timer.Tick += timer1_Tick; // タイマーのイベントハンドラ

            Timer.Text = "0:00"; // 初期表示
            Timer.Font = new Font(Timer.Font.FontFamily, 40, FontStyle.Bold);
        }

        private void ShowOverScreen()
        {
            player = new System.Media.SoundPlayer(path + "\\wav_data\\gameover.wav");
            player.Play();

            timer.Stop(); // タイマー停止
            
            // クリア画面を表示する
            MessageBox.Show("得点がなくなってしまいました...ゲームオーバーです", "ゲームオーバー画面");
            b_start.Enabled = true;
            blocks = new List<Blocker>();
            random = new Random();
            selects = new List<Button>();

            minutes = 0;
            seconds = 0;

            timer = new Timer();
            timer.Interval = 1000; // タイマーのインターバル(1秒)
            timer.Tick += timer1_Tick; // タイマーのイベントハンドラ

            Timer.Text = "0:00"; // 初期表示
            Timer.Font = new Font(Timer.Font.FontFamily, 40, FontStyle.Bold);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // タイマーのイベントハンドラ
            seconds++;
            pointer++;
            if (pointer > 9)
            {
                basescore -= 2;
                pointer = 0;
            }

            if (basescore <= 0)
            {
                basescore = 0;
            }

            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            Timer.Text = $"{minutes}:{seconds.ToString("00")}";
        }

        private void UpdateScoreTimer_Tick(object sender, EventArgs e)
        {
            // 得点を更新して表示
            Sum.Text = $"{score}";
        }
    }
}
