namespace floralplayingcards
{
    partial class F_Menu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.b_easy = new System.Windows.Forms.Button();
            this.b_normal = new System.Windows.Forms.Button();
            this.b_hard = new System.Windows.Forms.Button();
            this.b_veryh = new System.Windows.Forms.Button();
            this.b_close = new System.Windows.Forms.Button();
            this.b_challenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_easy
            // 
            this.b_easy.Location = new System.Drawing.Point(10, 12);
            this.b_easy.Name = "b_easy";
            this.b_easy.Size = new System.Drawing.Size(130, 74);
            this.b_easy.TabIndex = 0;
            this.b_easy.Text = "初級";
            this.b_easy.UseVisualStyleBackColor = true;
            this.b_easy.Click += new System.EventHandler(this.b_easy_Click);
            // 
            // b_normal
            // 
            this.b_normal.Location = new System.Drawing.Point(144, 12);
            this.b_normal.Name = "b_normal";
            this.b_normal.Size = new System.Drawing.Size(130, 74);
            this.b_normal.TabIndex = 1;
            this.b_normal.Text = "中級";
            this.b_normal.UseVisualStyleBackColor = true;
            this.b_normal.Click += new System.EventHandler(this.b_normal_Click);
            // 
            // b_hard
            // 
            this.b_hard.Location = new System.Drawing.Point(10, 92);
            this.b_hard.Name = "b_hard";
            this.b_hard.Size = new System.Drawing.Size(130, 74);
            this.b_hard.TabIndex = 2;
            this.b_hard.Text = "上級";
            this.b_hard.UseVisualStyleBackColor = true;
            this.b_hard.Click += new System.EventHandler(this.b_hard_Click);
            // 
            // b_veryh
            // 
            this.b_veryh.Location = new System.Drawing.Point(144, 92);
            this.b_veryh.Name = "b_veryh";
            this.b_veryh.Size = new System.Drawing.Size(130, 74);
            this.b_veryh.TabIndex = 3;
            this.b_veryh.Text = "最上級";
            this.b_veryh.UseVisualStyleBackColor = true;
            this.b_veryh.Click += new System.EventHandler(this.b_veryh_Click);
            // 
            // b_close
            // 
            this.b_close.Location = new System.Drawing.Point(12, 265);
            this.b_close.Name = "b_close";
            this.b_close.Size = new System.Drawing.Size(260, 74);
            this.b_close.TabIndex = 4;
            this.b_close.Text = "終了";
            this.b_close.UseVisualStyleBackColor = true;
            this.b_close.Click += new System.EventHandler(this.b_close_Click);
            // 
            // b_challenge
            // 
            this.b_challenge.Location = new System.Drawing.Point(12, 179);
            this.b_challenge.Name = "b_challenge";
            this.b_challenge.Size = new System.Drawing.Size(260, 74);
            this.b_challenge.TabIndex = 5;
            this.b_challenge.Text = "限界チャレンジ";
            this.b_challenge.UseVisualStyleBackColor = true;
            this.b_challenge.Click += new System.EventHandler(this.b_challenge_Click);
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.b_challenge);
            this.Controls.Add(this.b_close);
            this.Controls.Add(this.b_veryh);
            this.Controls.Add(this.b_hard);
            this.Controls.Add(this.b_normal);
            this.Controls.Add(this.b_easy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number block game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_easy;
        private System.Windows.Forms.Button b_normal;
        private System.Windows.Forms.Button b_hard;
        private System.Windows.Forms.Button b_veryh;
        private System.Windows.Forms.Button b_close;
        private System.Windows.Forms.Button b_challenge;
    }
}

