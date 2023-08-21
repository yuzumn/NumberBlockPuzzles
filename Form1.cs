using System;
using System.Windows.Forms;

namespace floralplayingcards
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void b_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_easy_Click(object sender, EventArgs e)
        {
            // メイン画面表示
            F_Main fMain = new F_Main 
            {
                // パラメータ受け渡し
                blockSize = 89,
                blockCount = 4,
                blockNumber = 2,
                resultNumber = 10,
                basescore = 10,
                penalty = 1,
            };

            fMain.Show(this);
            //メニュー画面の隠し
            Hide();
        }

        private void b_normal_Click(object sender, EventArgs e)
        {
            Random results = new System.Random();
            int R_result = results.Next(1, 4); // １～３までのランダムな値を生成
            // メイン画面表示
            F_Main fMain = new F_Main 
            {
                // パラメータ受け渡し
                blockSize = 59,
                blockCount = 6,
                blockNumber = 4,
                resultNumber = R_result * 10, // ランダムな値×10の値が正解値
                basescore = 20,
                penalty = 1,
            };

            fMain.Show(this);

            //メニュー画面の隠し
            Hide();
        }

        private void b_hard_Click(object sender, EventArgs e)
        {
            Random results = new System.Random();
            int R_result = results.Next(2,6); // ２～５までのランダムな値を生成
            // メイン画面表示
            F_Main fMain = new F_Main
            {
                // パラメータ受け渡し
                blockSize = 59,
                blockCount = 6,
                blockNumber = 4,
                resultNumber = R_result * 10, // ランダムな値×10の値が正解値
                basescore = 20,
                penalty = 2,
            };

            fMain.Show(this);

            //メニュー画面の隠し
            Hide();
        }

        private void b_veryh_Click(object sender, EventArgs e)
        {
            Random results = new System.Random();
            int R_result = results.Next(5, 11); // 5～10までのランダムな値を生成
            // メイン画面表示
            F_Main fMain = new F_Main
            {
                // パラメータ受け渡し
                blockSize = 44,
                blockCount = 8,
                blockNumber = 4,
                resultNumber = R_result * 10, // ランダムな値×10の値が正解値
                basescore = 50,
                penalty = 5,
            };

            fMain.Show(this);

            //メニュー画面の隠し
            Hide();
        }

        private void b_challenge_Click(object sender, EventArgs e)
        {
            Random results = new System.Random();
            int R_result = results.Next(5, 11); // 5～10までのランダムな値を生成
            // メイン画面表示
            challenge cMain = new challenge
            { 
                // パラメータ受け渡し
                blockSize = 44,
                blockCount = 8,
                blockNumber = 4,
                resultNumber = R_result * 10, // ランダムな値×10の値が正解値
                basescore = 50,
                penalty = 5,
            };

            cMain.Show(this);

            //メニュー画面の隠し
            Hide();
        }
    }
}
