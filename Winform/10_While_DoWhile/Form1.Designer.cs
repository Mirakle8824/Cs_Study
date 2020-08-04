namespace _10_While_DoWhile
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
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbox_result = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.lbl_random = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_result.Location = new System.Drawing.Point(13, 13);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(221, 37);
            this.lbl_result.TabIndex = 0;
            this.lbl_result.Text = "0, 0, 0, 0, 0, 0, 0";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(253, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbox_result
            // 
            this.lbox_result.FormattingEnabled = true;
            this.lbox_result.ItemHeight = 12;
            this.lbox_result.Location = new System.Drawing.Point(13, 54);
            this.lbox_result.Name = "lbox_result";
            this.lbox_result.Size = new System.Drawing.Size(221, 88);
            this.lbox_result.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(13, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 10);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "1~100 사이 숫자를 입력하시오.,";
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(159, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "button1";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // tbox1
            // 
            this.tbox1.Location = new System.Drawing.Point(12, 185);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(141, 21);
            this.tbox1.TabIndex = 6;
            // 
            // lbl_random
            // 
            this.lbl_random.AutoSize = true;
            this.lbl_random.Location = new System.Drawing.Point(10, 219);
            this.lbl_random.Name = "lbl_random";
            this.lbl_random.Size = new System.Drawing.Size(11, 12);
            this.lbl_random.TabIndex = 7;
            this.lbl_random.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 240);
            this.Controls.Add(this.lbl_random);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbox_result);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox lbox_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.Label lbl_random;
    }
}

