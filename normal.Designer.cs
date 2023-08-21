namespace floralplayingcards
{
    partial class F_Main_normal
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
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(11, 12);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(35, 12);
            this.Timer.TabIndex = 5;
            this.Timer.Text = "label1";
            // 
            // p_block
            // 
            this.p_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.p_block.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_block.Location = new System.Drawing.Point(13, 109);
            this.p_block.Name = "p_block";
            this.p_block.Size = new System.Drawing.Size(360, 360);
            this.p_block.TabIndex = 4;
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(13, 70);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(105, 33);
            this.b_start.TabIndex = 3;
            this.b_start.Text = "スタート";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // F_Main_normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.p_block);
            this.Controls.Add(this.b_start);
            this.Name = "F_Main_normal";
            this.Text = "Number block game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Panel p_block;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Timer timer1;
    }
}