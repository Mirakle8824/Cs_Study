namespace _5_Enum
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
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.btn_result1 = new System.Windows.Forms.Button();
            this.btn_result2 = new System.Windows.Forms.Button();
            this.tboxresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lboxDay
            // 
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 12;
            this.lboxDay.Location = new System.Drawing.Point(12, 39);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(163, 172);
            this.lboxDay.TabIndex = 0;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(12, 12);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(163, 21);
            this.tbox_name.TabIndex = 2;
            // 
            // lboxTime
            // 
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 12;
            this.lboxTime.Location = new System.Drawing.Point(181, 39);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(163, 172);
            this.lboxTime.TabIndex = 3;
            // 
            // btn_result1
            // 
            this.btn_result1.Location = new System.Drawing.Point(12, 217);
            this.btn_result1.Name = "btn_result1";
            this.btn_result1.Size = new System.Drawing.Size(163, 23);
            this.btn_result1.TabIndex = 4;
            this.btn_result1.Text = "button1";
            this.btn_result1.UseVisualStyleBackColor = true;
            this.btn_result1.Click += new System.EventHandler(this.btn_result1_Click);
            // 
            // btn_result2
            // 
            this.btn_result2.Location = new System.Drawing.Point(181, 217);
            this.btn_result2.Name = "btn_result2";
            this.btn_result2.Size = new System.Drawing.Size(163, 23);
            this.btn_result2.TabIndex = 5;
            this.btn_result2.Text = "button2";
            this.btn_result2.UseVisualStyleBackColor = true;
            this.btn_result2.Click += new System.EventHandler(this.btn_result2_Click);
            // 
            // tboxresult
            // 
            this.tboxresult.Enabled = false;
            this.tboxresult.Location = new System.Drawing.Point(12, 246);
            this.tboxresult.Multiline = true;
            this.tboxresult.Name = "tboxresult";
            this.tboxresult.Size = new System.Drawing.Size(332, 45);
            this.tboxresult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 304);
            this.Controls.Add(this.tboxresult);
            this.Controls.Add(this.btn_result2);
            this.Controls.Add(this.btn_result1);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.lboxDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.Button btn_result1;
        private System.Windows.Forms.Button btn_result2;
        private System.Windows.Forms.TextBox tboxresult;
    }
}

