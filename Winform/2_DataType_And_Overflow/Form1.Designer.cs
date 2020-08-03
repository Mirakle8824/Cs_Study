namespace _2_DataType_And_Overflow
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
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_short = new System.Windows.Forms.Label();
            this.lbl_int = new System.Windows.Forms.Label();
            this.lbl_double = new System.Windows.Forms.Label();
            this.lbl_exception = new System.Windows.Forms.Label();
            this.btn_short = new System.Windows.Forms.Button();
            this.btn_int = new System.Windows.Forms.Button();
            this.btn_double = new System.Windows.Forms.Button();
            this.btn_exception = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(12, 12);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(423, 21);
            this.tboxNumber.TabIndex = 0;
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(459, 9);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 1;
            this.btn_all.Text = "Click";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exception";
            // 
            // lbl_short
            // 
            this.lbl_short.AutoSize = true;
            this.lbl_short.Location = new System.Drawing.Point(110, 74);
            this.lbl_short.Name = "lbl_short";
            this.lbl_short.Size = new System.Drawing.Size(11, 12);
            this.lbl_short.TabIndex = 6;
            this.lbl_short.Text = "-";
            // 
            // lbl_int
            // 
            this.lbl_int.AutoSize = true;
            this.lbl_int.Location = new System.Drawing.Point(110, 101);
            this.lbl_int.Name = "lbl_int";
            this.lbl_int.Size = new System.Drawing.Size(11, 12);
            this.lbl_int.TabIndex = 7;
            this.lbl_int.Text = "-";
            // 
            // lbl_double
            // 
            this.lbl_double.AutoSize = true;
            this.lbl_double.Location = new System.Drawing.Point(110, 129);
            this.lbl_double.Name = "lbl_double";
            this.lbl_double.Size = new System.Drawing.Size(11, 12);
            this.lbl_double.TabIndex = 8;
            this.lbl_double.Text = "-";
            // 
            // lbl_exception
            // 
            this.lbl_exception.AutoSize = true;
            this.lbl_exception.Location = new System.Drawing.Point(110, 161);
            this.lbl_exception.Name = "lbl_exception";
            this.lbl_exception.Size = new System.Drawing.Size(11, 12);
            this.lbl_exception.TabIndex = 9;
            this.lbl_exception.Text = "-";
            // 
            // btn_short
            // 
            this.btn_short.Location = new System.Drawing.Point(194, 63);
            this.btn_short.Name = "btn_short";
            this.btn_short.Size = new System.Drawing.Size(75, 23);
            this.btn_short.TabIndex = 10;
            this.btn_short.Text = "Click";
            this.btn_short.UseVisualStyleBackColor = true;
            this.btn_short.Click += new System.EventHandler(this.btn_short_Click);
            // 
            // btn_int
            // 
            this.btn_int.Location = new System.Drawing.Point(194, 90);
            this.btn_int.Name = "btn_int";
            this.btn_int.Size = new System.Drawing.Size(75, 23);
            this.btn_int.TabIndex = 11;
            this.btn_int.Text = "Click";
            this.btn_int.UseVisualStyleBackColor = true;
            this.btn_int.Click += new System.EventHandler(this.btn_int_Click);
            // 
            // btn_double
            // 
            this.btn_double.Location = new System.Drawing.Point(194, 118);
            this.btn_double.Name = "btn_double";
            this.btn_double.Size = new System.Drawing.Size(75, 23);
            this.btn_double.TabIndex = 12;
            this.btn_double.Text = "Click";
            this.btn_double.UseVisualStyleBackColor = true;
            this.btn_double.Click += new System.EventHandler(this.btn_double_Click);
            // 
            // btn_exception
            // 
            this.btn_exception.Location = new System.Drawing.Point(194, 150);
            this.btn_exception.Name = "btn_exception";
            this.btn_exception.Size = new System.Drawing.Size(75, 23);
            this.btn_exception.TabIndex = 13;
            this.btn_exception.Text = "Click";
            this.btn_exception.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 191);
            this.Controls.Add(this.btn_exception);
            this.Controls.Add(this.btn_double);
            this.Controls.Add(this.btn_int);
            this.Controls.Add(this.btn_short);
            this.Controls.Add(this.lbl_exception);
            this.Controls.Add(this.lbl_double);
            this.Controls.Add(this.lbl_int);
            this.Controls.Add(this.lbl_short);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.tboxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_short;
        private System.Windows.Forms.Label lbl_int;
        private System.Windows.Forms.Label lbl_double;
        private System.Windows.Forms.Label lbl_exception;
        private System.Windows.Forms.Button btn_short;
        private System.Windows.Forms.Button btn_int;
        private System.Windows.Forms.Button btn_double;
        private System.Windows.Forms.Button btn_exception;
    }
}

