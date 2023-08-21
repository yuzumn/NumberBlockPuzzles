namespace floralplayingcards
{
    partial class challenge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Label();
            this.p_block = new System.Windows.Forms.Panel();
            this.b_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.Point = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(11, 12);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(35, 12);
            this.Timer.TabIndex = 9;
            this.Timer.Text = "label1";
            // 
            // p_block
            // 
            this.p_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.p_block.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_block.Location = new System.Drawing.Point(13, 109);
            this.p_block.Name = "p_block";
            this.p_block.Size = new System.Drawing.Size(360, 360);
            this.p_block.TabIndex = 8;
            this.p_block.Paint += new System.Windows.Forms.PaintEventHandler(this.p_block_Paint);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(13, 70);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(105, 33);
            this.b_start.TabIndex = 7;
            this.b_start.Text = "スタート";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(147, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "狙う数字は";
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.result.Location = new System.Drawing.Point(141, 44);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(99, 44);
            this.result.TabIndex = 12;
            this.result.Text = "label1";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sum.Location = new System.Drawing.Point(246, 44);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(123, 44);
            this.Sum.TabIndex = 11;
            this.Sum.Text = "0";
            this.Sum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Point.Location = new System.Drawing.Point(271, 12);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(39, 16);
            this.Point.TabIndex = 10;
            this.Point.Text = "得点";
            // 
            // challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.p_block);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Point);
            this.Name = "challenge";
            this.Text = "Challenge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.challenge_FormClosed_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Panel p_block;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Point;
    }
}