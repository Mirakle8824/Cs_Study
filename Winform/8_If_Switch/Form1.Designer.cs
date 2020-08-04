namespace _8_If_Switch
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
            this.num_updown1 = new System.Windows.Forms.NumericUpDown();
            this.num_updown2 = new System.Windows.Forms.NumericUpDown();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl_count = new System.Windows.Forms.Label();
            this.cbox_day = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbl_days = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_updown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_updown2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // num_updown1
            // 
            this.num_updown1.Location = new System.Drawing.Point(12, 39);
            this.num_updown1.Name = "num_updown1";
            this.num_updown1.Size = new System.Drawing.Size(51, 21);
            this.num_updown1.TabIndex = 2;
            // 
            // num_updown2
            // 
            this.num_updown2.Location = new System.Drawing.Point(88, 39);
            this.num_updown2.Name = "num_updown2";
            this.num_updown2.Size = new System.Drawing.Size(51, 21);
            this.num_updown2.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(220, 23);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Location = new System.Drawing.Point(13, 75);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(11, 12);
            this.lbl_count.TabIndex = 5;
            this.lbl_count.Text = "-";
            // 
            // cbox_day
            // 
            this.cbox_day.AutoCompleteCustomSource.AddRange(new string[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cbox_day.FormattingEnabled = true;
            this.cbox_day.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cbox_day.Location = new System.Drawing.Point(12, 130);
            this.cbox_day.Name = "cbox_day";
            this.cbox_day.Size = new System.Drawing.Size(121, 20);
            this.cbox_day.TabIndex = 6;
            this.cbox_day.Text = "월";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "요일";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(220, 128);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.Location = new System.Drawing.Point(10, 178);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(11, 12);
            this.lbl_days.TabIndex = 9;
            this.lbl_days.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 214);
            this.Controls.Add(this.lbl_days);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_day);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.num_updown2);
            this.Controls.Add(this.num_updown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.num_updown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_updown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_updown1;
        private System.Windows.Forms.NumericUpDown num_updown2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.ComboBox cbox_day;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbl_days;
    }
}

