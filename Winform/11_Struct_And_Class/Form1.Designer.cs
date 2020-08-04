namespace _11_1_Struct_And_Class
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbox_1 = new System.Windows.Forms.PictureBox();
            this.pbox_2 = new System.Windows.Forms.PictureBox();
            this.pbox_3 = new System.Windows.Forms.PictureBox();
            this.pbox_4 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lbox_result1 = new System.Windows.Forms.ListBox();
            this.lbox_result2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "각 플레이어는 한번 씩 돌아가면서 선택한다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "각 5회 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리한다.";
            // 
            // pbox_1
            // 
            this.pbox_1.Image = global::_11_1_Struct_And_Class.Properties.Resources._1;
            this.pbox_1.Location = new System.Drawing.Point(15, 64);
            this.pbox_1.Name = "pbox_1";
            this.pbox_1.Size = new System.Drawing.Size(111, 164);
            this.pbox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_1.TabIndex = 2;
            this.pbox_1.TabStop = false;
            this.pbox_1.Click += new System.EventHandler(this.pbox_1_Click);
            // 
            // pbox_2
            // 
            this.pbox_2.Image = global::_11_1_Struct_And_Class.Properties.Resources._2;
            this.pbox_2.Location = new System.Drawing.Point(132, 64);
            this.pbox_2.Name = "pbox_2";
            this.pbox_2.Size = new System.Drawing.Size(111, 164);
            this.pbox_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_2.TabIndex = 3;
            this.pbox_2.TabStop = false;
            this.pbox_2.Click += new System.EventHandler(this.pbox_2_Click);
            // 
            // pbox_3
            // 
            this.pbox_3.Image = global::_11_1_Struct_And_Class.Properties.Resources._3;
            this.pbox_3.Location = new System.Drawing.Point(249, 64);
            this.pbox_3.Name = "pbox_3";
            this.pbox_3.Size = new System.Drawing.Size(111, 164);
            this.pbox_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_3.TabIndex = 4;
            this.pbox_3.TabStop = false;
            this.pbox_3.Click += new System.EventHandler(this.pbox_3_Click);
            // 
            // pbox_4
            // 
            this.pbox_4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbox_4.Location = new System.Drawing.Point(366, 64);
            this.pbox_4.Name = "pbox_4";
            this.pbox_4.Size = new System.Drawing.Size(111, 164);
            this.pbox_4.TabIndex = 5;
            this.pbox_4.TabStop = false;
            this.pbox_4.Click += new System.EventHandler(this.pbox_4_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 254);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 16);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Player1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(249, 254);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 16);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Player2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lbox_result1
            // 
            this.lbox_result1.FormattingEnabled = true;
            this.lbox_result1.ItemHeight = 12;
            this.lbox_result1.Location = new System.Drawing.Point(15, 276);
            this.lbox_result1.Name = "lbox_result1";
            this.lbox_result1.Size = new System.Drawing.Size(228, 88);
            this.lbox_result1.TabIndex = 10;
            // 
            // lbox_result2
            // 
            this.lbox_result2.FormattingEnabled = true;
            this.lbox_result2.ItemHeight = 12;
            this.lbox_result2.Location = new System.Drawing.Point(249, 276);
            this.lbox_result2.Name = "lbox_result2";
            this.lbox_result2.Size = new System.Drawing.Size(228, 88);
            this.lbox_result2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 384);
            this.Controls.Add(this.lbox_result2);
            this.Controls.Add(this.lbox_result1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pbox_4);
            this.Controls.Add(this.pbox_3);
            this.Controls.Add(this.pbox_2);
            this.Controls.Add(this.pbox_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbox_1;
        private System.Windows.Forms.PictureBox pbox_2;
        private System.Windows.Forms.PictureBox pbox_3;
        private System.Windows.Forms.PictureBox pbox_4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListBox lbox_result1;
        private System.Windows.Forms.ListBox lbox_result2;
    }
}

