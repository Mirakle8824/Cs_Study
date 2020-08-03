namespace _3_Method
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
            this.tbox_result = new System.Windows.Forms.TextBox();
            this.tbox_Num1 = new System.Windows.Forms.TextBox();
            this.tbox_Num2 = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_result
            // 
            this.tbox_result.Enabled = false;
            this.tbox_result.Location = new System.Drawing.Point(13, 13);
            this.tbox_result.Name = "tbox_result";
            this.tbox_result.Size = new System.Drawing.Size(293, 21);
            this.tbox_result.TabIndex = 0;
            // 
            // tbox_Num1
            // 
            this.tbox_Num1.Location = new System.Drawing.Point(13, 40);
            this.tbox_Num1.Name = "tbox_Num1";
            this.tbox_Num1.Size = new System.Drawing.Size(138, 21);
            this.tbox_Num1.TabIndex = 1;
            // 
            // tbox_Num2
            // 
            this.tbox_Num2.Location = new System.Drawing.Point(168, 40);
            this.tbox_Num2.Name = "tbox_Num2";
            this.tbox_Num2.Size = new System.Drawing.Size(138, 21);
            this.tbox_Num2.TabIndex = 2;
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(13, 80);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(60, 33);
            this.btn_plus.TabIndex = 3;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(91, 80);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(60, 33);
            this.btn_minus.TabIndex = 4;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(246, 80);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(60, 33);
            this.btn_div.TabIndex = 6;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(168, 80);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(60, 33);
            this.btn_multi.TabIndex = 5;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 132);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.tbox_Num2);
            this.Controls.Add(this.tbox_Num1);
            this.Controls.Add(this.tbox_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_result;
        private System.Windows.Forms.TextBox tbox_Num1;
        private System.Windows.Forms.TextBox tbox_Num2;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_multi;
    }
}

