namespace Server
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port : ";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(110, 89);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(171, 25);
            this.txt_port.TabIndex = 8;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(125, 147);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(121, 28);
            this.btn_start.TabIndex = 7;
            this.btn_start.Text = "서버 시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(110, 32);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(171, 25);
            this.txt_ip.TabIndex = 6;
            this.txt_ip.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 207);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label1;
    }
}

