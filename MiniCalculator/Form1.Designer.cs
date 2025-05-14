namespace MiniCalculator
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
            this.num1_lb = new System.Windows.Forms.Label();
            this.num1_txt = new System.Windows.Forms.TextBox();
            this.num2_lb = new System.Windows.Forms.Label();
            this.num2_txt = new System.Windows.Forms.TextBox();
            this.Ready_lb = new System.Windows.Forms.Label();
            this.pluse_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Result_txt = new System.Windows.Forms.TextBox();
            this.Minus_btn = new System.Windows.Forms.Button();
            this.Divide_btn = new System.Windows.Forms.Button();
            this.Hexa_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1_lb
            // 
            this.num1_lb.AutoSize = true;
            this.num1_lb.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num1_lb.Location = new System.Drawing.Point(57, 52);
            this.num1_lb.Name = "num1_lb";
            this.num1_lb.Size = new System.Drawing.Size(134, 27);
            this.num1_lb.TabIndex = 0;
            this.num1_lb.Text = "첫번째 수";
            this.num1_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // num1_txt
            // 
            this.num1_txt.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num1_txt.Location = new System.Drawing.Point(227, 40);
            this.num1_txt.Name = "num1_txt";
            this.num1_txt.Size = new System.Drawing.Size(436, 39);
            this.num1_txt.TabIndex = 1;
            // 
            // num2_lb
            // 
            this.num2_lb.AutoSize = true;
            this.num2_lb.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num2_lb.Location = new System.Drawing.Point(57, 135);
            this.num2_lb.Name = "num2_lb";
            this.num2_lb.Size = new System.Drawing.Size(134, 27);
            this.num2_lb.TabIndex = 0;
            this.num2_lb.Text = "두번째 수";
            this.num2_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // num2_txt
            // 
            this.num2_txt.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num2_txt.Location = new System.Drawing.Point(227, 135);
            this.num2_txt.Name = "num2_txt";
            this.num2_txt.Size = new System.Drawing.Size(436, 39);
            this.num2_txt.TabIndex = 2;
            // 
            // Ready_lb
            // 
            this.Ready_lb.AutoSize = true;
            this.Ready_lb.Font = new System.Drawing.Font("돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ready_lb.Location = new System.Drawing.Point(71, 223);
            this.Ready_lb.Name = "Ready_lb";
            this.Ready_lb.Size = new System.Drawing.Size(592, 21);
            this.Ready_lb.TabIndex = 3;
            this.Ready_lb.Text = "Ready!-------------------------------------------";
            // 
            // pluse_btn
            // 
            this.pluse_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pluse_btn.Location = new System.Drawing.Point(75, 330);
            this.pluse_btn.Name = "pluse_btn";
            this.pluse_btn.Size = new System.Drawing.Size(116, 72);
            this.pluse_btn.TabIndex = 4;
            this.pluse_btn.Text = "+";
            this.pluse_btn.UseVisualStyleBackColor = true;
            this.pluse_btn.Click += new System.EventHandler(this.pluse_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Clear_btn.Location = new System.Drawing.Point(697, 388);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(91, 50);
            this.Clear_btn.TabIndex = 5;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result.Location = new System.Drawing.Point(70, 272);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(78, 27);
            this.Result.TabIndex = 6;
            this.Result.Text = "결 과";
            // 
            // Result_txt
            // 
            this.Result_txt.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result_txt.Location = new System.Drawing.Point(227, 269);
            this.Result_txt.Name = "Result_txt";
            this.Result_txt.Size = new System.Drawing.Size(436, 39);
            this.Result_txt.TabIndex = 7;
            // 
            // Minus_btn
            // 
            this.Minus_btn.Font = new System.Drawing.Font("궁서", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minus_btn.Location = new System.Drawing.Point(237, 330);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.Size = new System.Drawing.Size(118, 72);
            this.Minus_btn.TabIndex = 8;
            this.Minus_btn.Text = "-";
            this.Minus_btn.UseVisualStyleBackColor = true;
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click);
            // 
            // Divide_btn
            // 
            this.Divide_btn.Font = new System.Drawing.Font("돋움", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Divide_btn.Location = new System.Drawing.Point(396, 330);
            this.Divide_btn.Name = "Divide_btn";
            this.Divide_btn.Size = new System.Drawing.Size(113, 70);
            this.Divide_btn.TabIndex = 9;
            this.Divide_btn.Text = "/";
            this.Divide_btn.UseVisualStyleBackColor = true;
            this.Divide_btn.Click += new System.EventHandler(this.Divide_btn_Click);
            // 
            // Hexa_btn
            // 
            this.Hexa_btn.Font = new System.Drawing.Font("돋움", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hexa_btn.Location = new System.Drawing.Point(550, 328);
            this.Hexa_btn.Name = "Hexa_btn";
            this.Hexa_btn.Size = new System.Drawing.Size(113, 70);
            this.Hexa_btn.TabIndex = 9;
            this.Hexa_btn.Text = "*";
            this.Hexa_btn.UseVisualStyleBackColor = true;
            this.Hexa_btn.Click += new System.EventHandler(this.Hexa_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hexa_btn);
            this.Controls.Add(this.Divide_btn);
            this.Controls.Add(this.Minus_btn);
            this.Controls.Add(this.Result_txt);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.pluse_btn);
            this.Controls.Add(this.Ready_lb);
            this.Controls.Add(this.num2_txt);
            this.Controls.Add(this.num1_txt);
            this.Controls.Add(this.num2_lb);
            this.Controls.Add(this.num1_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1_lb;
        private System.Windows.Forms.TextBox num1_txt;
        private System.Windows.Forms.Label num2_lb;
        private System.Windows.Forms.TextBox num2_txt;
        private System.Windows.Forms.Label Ready_lb;
        private System.Windows.Forms.Button pluse_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Result_txt;
        private System.Windows.Forms.Button Minus_btn;
        private System.Windows.Forms.Button Divide_btn;
        private System.Windows.Forms.Button Hexa_btn;
    }
}

