namespace floralplayingcards
{
    partial class F_Main
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
            this.b_start = new System.Windows.Forms.Button();
            this.p_block = new System.Windows.Forms.Panel();
            this.Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Point = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(12, 70);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(105, 33);
            this.b_start.TabIndex = 0;
            this.b_start.Text = "スタート";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // p_block
            // 
            this.p_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.p_block.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_block.Location = new System.Drawing.Point(12, 109);
            this.p_block.Name = "p_block";
            this.p_block.Size = new System.Drawing.Size(360, 360);
            this.p_block.TabIndex = 1;
            this.p_block.Paint += new System.Windows.Forms.PaintEventHandler(this.p_block_Paint);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(10, 12);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(35, 12);
            this.Timer.TabIndex = 2;
            this.Timer.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Point
            // 
            this.Point.AutoSize = true;
            this.Point.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Point.Location = new System.Drawing.Point(270, 12);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(39, 16);
            this.Point.TabIndex = 3;
            this.Point.Text = "得点";
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Sum.Location = new System.Drawing.Point(245, 44);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(123, 44);
            this.Sum.TabIndex = 4;
            this.Sum.Text = "0";
            this.Sum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.result.Location = new System.Drawing.Point(140, 44);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(99, 44);
            this.result.TabIndex = 5;
            this.result.Text = "label1";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(146, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "狙う数字は";
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.p_block);
            this.Controls.Add(this.b_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number block game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Main_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Panel p_block;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Point;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
    }
}