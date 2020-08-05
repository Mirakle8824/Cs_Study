namespace _15_Capsulation_And_PartialClass
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
            this.lbox_item = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_item = new System.Windows.Forms.ComboBox();
            this.cbox_disc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_updown = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new System.Windows.Forms.Button();
            this.tbox_result = new System.Windows.Forms.TextBox();
            this.tbox_error = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // lbox_item
            // 
            this.lbox_item.FormattingEnabled = true;
            this.lbox_item.ItemHeight = 12;
            this.lbox_item.Location = new System.Drawing.Point(13, 13);
            this.lbox_item.Name = "lbox_item";
            this.lbox_item.Size = new System.Drawing.Size(260, 220);
            this.lbox_item.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "물건";
            // 
            // cbox_item
            // 
            this.cbox_item.FormattingEnabled = true;
            this.cbox_item.Location = new System.Drawing.Point(282, 29);
            this.cbox_item.Name = "cbox_item";
            this.cbox_item.Size = new System.Drawing.Size(121, 20);
            this.cbox_item.TabIndex = 2;
            // 
            // cbox_disc
            // 
            this.cbox_disc.FormattingEnabled = true;
            this.cbox_disc.Location = new System.Drawing.Point(282, 80);
            this.cbox_disc.Name = "cbox_disc";
            this.cbox_disc.Size = new System.Drawing.Size(121, 20);
            this.cbox_disc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "할인율(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "개수";
            // 
            // num_updown
            // 
            this.num_updown.Location = new System.Drawing.Point(282, 140);
            this.num_updown.Name = "num_updown";
            this.num_updown.Size = new System.Drawing.Size(120, 21);
            this.num_updown.TabIndex = 6;
            this.num_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(280, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 23);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "닫기";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tbox_result
            // 
            this.tbox_result.Location = new System.Drawing.Point(13, 240);
            this.tbox_result.Name = "tbox_result";
            this.tbox_result.Size = new System.Drawing.Size(260, 21);
            this.tbox_result.TabIndex = 8;
            // 
            // tbox_error
            // 
            this.tbox_error.Location = new System.Drawing.Point(12, 267);
            this.tbox_error.Name = "tbox_error";
            this.tbox_error.Size = new System.Drawing.Size(390, 21);
            this.tbox_error.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 302);
            this.Controls.Add(this.tbox_error);
            this.Controls.Add(this.tbox_result);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.num_updown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbox_disc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_item);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_item;
        private System.Windows.Forms.ComboBox cbox_disc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_updown;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tbox_result;
        private System.Windows.Forms.TextBox tbox_error;
    }
}

