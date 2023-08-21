using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace floralplayingcards
{
    public partial class F_Main_normal : Form
    {
        private const int blockSize = 89; // ブロックサイズ(px単位)
        private const int blockCount = 4; // ブロック数
        private List<Blocker> blocks; // ブロックリスト

        private Random random; // ランダム生成
        private List<Button> selects; // 選択されたボタンのリスト

        private Timer timer; // タイマー
        private int minutes; // 分
        private int seconds; // 秒

        public F_Main_normal()
        {
            InitializeComponent();
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

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // メニュー画面表示
            Owner.Show();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            b_start.Enabled = false; // スタートボタンを押せなくなる

            // パネルのクリア
            p_block.Controls.Clear();
            blocks.Clear();

            timer.Start(); // タイマー開始

            // ブロックの作成と配置
            // ブロックは数値のペアが合計１０になるように且つ半々になるように設定する
            List<int> numbers = GenerateRandomNumbers();
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
                        button.Text = numbers[index].ToString();
                    }
                    else
                    {
                        int pairIndex = index - pairCount;
                        button.Text = (10 - numbers[pairIndex]).ToString();
                    }

                    button.Font = new Font(button.Font.FontFamily, block.Size / 2, FontStyle.Bold); // フォントサイズとスタイルの設定
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

            Shuffle(numbers);

            return numbers;
        }

        private void Shuffle(List<int> list)
        {
            int n = list.Count;
            while (n > 0)
            {
                n--;
                int k = random.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;

                // 横方向へのシャッフル
                int row1 = k / blockCount;
                int col1 = k % blockCount;
                int row2 = n / blockCount;
                int col2 = n % blockCount;
                Swap(list, row1, col1, row2, col2);
            }
        }

        private void Swap(List<int> list, int row1, int col1, int row2, int col2)
        {
            int temp = list[row1 * blockCount + col1];
            list[row1 * blockCount + col1] = list[row2 * blockCount + col2];
            list[row2 * blockCount + col2] = temp;
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

                // 数値の合計が10の場合，選択されたブロックを消去
                if (sum == 10)
                {
                    foreach (Button select in selects)
                    {
                        p_block.Controls.Remove(select);
                    }
                }

                selects.Clear();
            }

            // ボタンがすべて消えたらクリア
            if (p_block.Controls.Count == 0)
            {
                ShowClearScreen();
            }
        }

        private void ShowClearScreen()
        {
            timer.Stop(); // タイマー停止
            // クリア画面を表示する
            MessageBox.Show("すべてのブロックを消去しました！クリアです！", "クリア画面");
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
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            Timer.Text = $"{minutes}:{seconds.ToString("00")}";
        }
    }
}
