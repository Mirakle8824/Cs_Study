namespace Winform
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_contain = new System.Windows.Forms.Label();
            this.lbl_equals = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_replace = new System.Windows.Forms.Label();
            this.lbl_split1 = new System.Windows.Forms.Label();
            this.lbl_trim = new System.Windows.Forms.Label();
            this.lbl_toupper = new System.Windows.Forms.Label();
            this.lbl_tolower = new System.Windows.Forms.Label();
            this.lbl_substring = new System.Windows.Forms.Label();
            this.lbl_split2 = new System.Windows.Forms.Label();
            this.lbl_split3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(47, 18);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(114, 12);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "Sample, Test, Text";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "실행";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Equals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Replace";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Split";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Substring";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "ToLower";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "ToUpper";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "Trim";
            // 
            // lbl_contain
            // 
            this.lbl_contain.AutoSize = true;
            this.lbl_contain.Location = new System.Drawing.Point(79, 58);
            this.lbl_contain.Name = "lbl_contain";
            this.lbl_contain.Size = new System.Drawing.Size(12, 12);
            this.lbl_contain.TabIndex = 11;
            this.lbl_contain.Text = "a";
            // 
            // lbl_equals
            // 
            this.lbl_equals.AutoSize = true;
            this.lbl_equals.Location = new System.Drawing.Point(79, 79);
            this.lbl_equals.Name = "lbl_equals";
            this.lbl_equals.Size = new System.Drawing.Size(12, 12);
            this.lbl_equals.TabIndex = 12;
            this.lbl_equals.Text = "a";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(79, 102);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(12, 12);
            this.lbl_length.TabIndex = 13;
            this.lbl_length.Text = "a";
            // 
            // lbl_replace
            // 
            this.lbl_replace.AutoSize = true;
            this.lbl_replace.Location = new System.Drawing.Point(79, 123);
            this.lbl_replace.Name = "lbl_replace";
            this.lbl_replace.Size = new System.Drawing.Size(12, 12);
            this.lbl_replace.TabIndex = 14;
            this.lbl_replace.Text = "a";
            // 
            // lbl_split1
            // 
            this.lbl_split1.AutoSize = true;
            this.lbl_split1.Location = new System.Drawing.Point(79, 146);
            this.lbl_split1.Name = "lbl_split1";
            this.lbl_split1.Size = new System.Drawing.Size(12, 12);
            this.lbl_split1.TabIndex = 15;
            this.lbl_split1.Text = "a";
            // 
            // lbl_trim
            // 
            this.lbl_trim.AutoSize = true;
            this.lbl_trim.Location = new System.Drawing.Point(319, 123);
            this.lbl_trim.Name = "lbl_trim";
            this.lbl_trim.Size = new System.Drawing.Size(12, 12);
            this.lbl_trim.TabIndex = 19;
            this.lbl_trim.Text = "a";
            // 
            // lbl_toupper
            // 
            this.lbl_toupper.AutoSize = true;
            this.lbl_toupper.Location = new System.Drawing.Point(319, 102);
            this.lbl_toupper.Name = "lbl_toupper";
            this.lbl_toupper.Size = new System.Drawing.Size(12, 12);
            this.lbl_toupper.TabIndex = 18;
            this.lbl_toupper.Text = "a";
            // 
            // lbl_tolower
            // 
            this.lbl_tolower.AutoSize = true;
            this.lbl_tolower.Location = new System.Drawing.Point(319, 79);
            this.lbl_tolower.Name = "lbl_tolower";
            this.lbl_tolower.Size = new System.Drawing.Size(12, 12);
            this.lbl_tolower.TabIndex = 17;
            this.lbl_tolower.Text = "a";
            // 
            // lbl_substring
            // 
            this.lbl_substring.AutoSize = true;
            this.lbl_substring.Location = new System.Drawing.Point(319, 58);
            this.lbl_substring.Name = "lbl_substring";
            this.lbl_substring.Size = new System.Drawing.Size(12, 12);
            this.lbl_substring.TabIndex = 16;
            this.lbl_substring.Text = "a";
            // 
            // lbl_split2
            // 
            this.lbl_split2.AutoSize = true;
            this.lbl_split2.Location = new System.Drawing.Point(79, 172);
            this.lbl_split2.Name = "lbl_split2";
            this.lbl_split2.Size = new System.Drawing.Size(12, 12);
            this.lbl_split2.TabIndex = 20;
            this.lbl_split2.Text = "a";
            // 
            // lbl_split3
            // 
            this.lbl_split3.AutoSize = true;
            this.lbl_split3.Location = new System.Drawing.Point(79, 199);
            this.lbl_split3.Name = "lbl_split3";
            this.lbl_split3.Size = new System.Drawing.Size(12, 12);
            this.lbl_split3.TabIndex = 21;
            this.lbl_split3.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 243);
            this.Controls.Add(this.lbl_split3);
            this.Controls.Add(this.lbl_split2);
            this.Controls.Add(this.lbl_trim);
            this.Controls.Add(this.lbl_toupper);
            this.Controls.Add(this.lbl_tolower);
            this.Controls.Add(this.lbl_substring);
            this.Controls.Add(this.lbl_split1);
            this.Controls.Add(this.lbl_replace);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.lbl_equals);
            this.Controls.Add(this.lbl_contain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_contain;
        private System.Windows.Forms.Label lbl_equals;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_replace;
        private System.Windows.Forms.Label lbl_split1;
        private System.Windows.Forms.Label lbl_trim;
        private System.Windows.Forms.Label lbl_toupper;
        private System.Windows.Forms.Label lbl_tolower;
        private System.Windows.Forms.Label lbl_substring;
        private System.Windows.Forms.Label lbl_split2;
        private System.Windows.Forms.Label lbl_split3;
    }
}

