namespace _13_Class_Inheritance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_st1 = new System.Windows.Forms.Button();
            this.btn_st2 = new System.Windows.Forms.Button();
            this.btn_st3 = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 300);
            this.panel1.TabIndex = 0;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_item.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_item.Location = new System.Drawing.Point(12, 319);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(110, 49);
            this.lbl_item.TabIndex = 1;
            this.lbl_item.Text = "-";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_st1
            // 
            this.btn_st1.Location = new System.Drawing.Point(129, 319);
            this.btn_st1.Name = "btn_st1";
            this.btn_st1.Size = new System.Drawing.Size(138, 49);
            this.btn_st1.TabIndex = 2;
            this.btn_st1.Text = "1단계 외발";
            this.btn_st1.UseVisualStyleBackColor = true;
            this.btn_st1.Click += new System.EventHandler(this.btn_st1_Click);
            // 
            // btn_st2
            // 
            this.btn_st2.Location = new System.Drawing.Point(299, 318);
            this.btn_st2.Name = "btn_st2";
            this.btn_st2.Size = new System.Drawing.Size(138, 49);
            this.btn_st2.TabIndex = 3;
            this.btn_st2.Text = "2단계 자전거";
            this.btn_st2.UseVisualStyleBackColor = true;
            // 
            // btn_st3
            // 
            this.btn_st3.Location = new System.Drawing.Point(474, 318);
            this.btn_st3.Name = "btn_st3";
            this.btn_st3.Size = new System.Drawing.Size(138, 49);
            this.btn_st3.TabIndex = 4;
            this.btn_st3.Text = "3단계 자동차";
            this.btn_st3.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(212, 374);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(138, 49);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "<<-";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(391, 374);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(138, 49);
            this.btn_right.TabIndex = 6;
            this.btn_right.Text = "->>";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 457);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_st3);
            this.Controls.Add(this.btn_st2);
            this.Controls.Add(this.btn_st1);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Button btn_st1;
        private System.Windows.Forms.Button btn_st2;
        private System.Windows.Forms.Button btn_st3;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
    }
}

