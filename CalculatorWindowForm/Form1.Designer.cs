namespace CalculatorWindowForm
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
            this.num2_lb = new System.Windows.Forms.Label();
            this.num1_text = new System.Windows.Forms.TextBox();
            this.num2_text = new System.Windows.Forms.TextBox();
            this.num3_lb = new System.Windows.Forms.Label();
            this.num4_lb = new System.Windows.Forms.Label();
            this.num3_text = new System.Windows.Forms.TextBox();
            this.num1_btn = new System.Windows.Forms.Button();
            this.num3_btn = new System.Windows.Forms.Button();
            this.num4_btn = new System.Windows.Forms.Button();
            this.num5_btn = new System.Windows.Forms.Button();
            this.num2_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1_lb
            // 
            this.num1_lb.AutoSize = true;
            this.num1_lb.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num1_lb.Location = new System.Drawing.Point(67, 37);
            this.num1_lb.Name = "num1_lb";
            this.num1_lb.Size = new System.Drawing.Size(81, 16);
            this.num1_lb.TabIndex = 0;
            this.num1_lb.Text = "첫번째 수";
            // 
            // num2_lb
            // 
            this.num2_lb.AutoSize = true;
            this.num2_lb.Font = new System.Drawing.Font("돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num2_lb.Location = new System.Drawing.Point(67, 105);
            this.num2_lb.Name = "num2_lb";
            this.num2_lb.Size = new System.Drawing.Size(81, 16);
            this.num2_lb.TabIndex = 0;
            this.num2_lb.Text = "두번째 수";
            // 
            // num1_text
            // 
            this.num1_text.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num1_text.Location = new System.Drawing.Point(182, 26);
            this.num1_text.Name = "num1_text";
            this.num1_text.Size = new System.Drawing.Size(446, 39);
            this.num1_text.TabIndex = 1;
            this.num1_text.TextChanged += new System.EventHandler(this.num1_text_TextChanged);
            // 
            // num2_text
            // 
            this.num2_text.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num2_text.Location = new System.Drawing.Point(182, 93);
            this.num2_text.Name = "num2_text";
            this.num2_text.Size = new System.Drawing.Size(446, 39);
            this.num2_text.TabIndex = 1;
            // 
            // num3_lb
            // 
            this.num3_lb.AutoSize = true;
            this.num3_lb.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num3_lb.Location = new System.Drawing.Point(68, 177);
            this.num3_lb.Name = "num3_lb";
            this.num3_lb.Size = new System.Drawing.Size(684, 21);
            this.num3_lb.TabIndex = 2;
            this.num3_lb.Text = "Ready!!--------------------------------------------------";
            // 
            // num4_lb
            // 
            this.num4_lb.AutoSize = true;
            this.num4_lb.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num4_lb.Location = new System.Drawing.Point(66, 235);
            this.num4_lb.Name = "num4_lb";
            this.num4_lb.Size = new System.Drawing.Size(78, 21);
            this.num4_lb.TabIndex = 2;
            this.num4_lb.Text = "결   과";
            // 
            // num3_text
            // 
            this.num3_text.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num3_text.Location = new System.Drawing.Point(182, 225);
            this.num3_text.Name = "num3_text";
            this.num3_text.Size = new System.Drawing.Size(446, 39);
            this.num3_text.TabIndex = 1;
            // 
            // num1_btn
            // 
            this.num1_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num1_btn.Location = new System.Drawing.Point(73, 314);
            this.num1_btn.Name = "num1_btn";
            this.num1_btn.Size = new System.Drawing.Size(122, 45);
            this.num1_btn.TabIndex = 3;
            this.num1_btn.Text = "+";
            this.num1_btn.UseVisualStyleBackColor = true;
            this.num1_btn.Click += new System.EventHandler(this.num1_btn_Click);
            // 
            // num3_btn
            // 
            this.num3_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num3_btn.Location = new System.Drawing.Point(388, 314);
            this.num3_btn.Name = "num3_btn";
            this.num3_btn.Size = new System.Drawing.Size(122, 45);
            this.num3_btn.TabIndex = 3;
            this.num3_btn.Text = "/";
            this.num3_btn.UseVisualStyleBackColor = true;
            this.num3_btn.Click += new System.EventHandler(this.num3_btn_Click);
            // 
            // num4_btn
            // 
            this.num4_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num4_btn.Location = new System.Drawing.Point(539, 314);
            this.num4_btn.Name = "num4_btn";
            this.num4_btn.Size = new System.Drawing.Size(122, 45);
            this.num4_btn.TabIndex = 3;
            this.num4_btn.Text = "*";
            this.num4_btn.UseVisualStyleBackColor = true;
            this.num4_btn.Click += new System.EventHandler(this.num4_btn_Click);
            // 
            // num5_btn
            // 
            this.num5_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num5_btn.Location = new System.Drawing.Point(388, 375);
            this.num5_btn.Name = "num5_btn";
            this.num5_btn.Size = new System.Drawing.Size(273, 45);
            this.num5_btn.TabIndex = 3;
            this.num5_btn.Text = "Clear";
            this.num5_btn.UseVisualStyleBackColor = true;
            this.num5_btn.Click += new System.EventHandler(this.num5_btn_Click);
            // 
            // num2_btn
            // 
            this.num2_btn.Font = new System.Drawing.Font("돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.num2_btn.Location = new System.Drawing.Point(230, 314);
            this.num2_btn.Name = "num2_btn";
            this.num2_btn.Size = new System.Drawing.Size(122, 45);
            this.num2_btn.TabIndex = 3;
            this.num2_btn.Text = "-";
            this.num2_btn.UseVisualStyleBackColor = true;
            this.num2_btn.Click += new System.EventHandler(this.num2_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num5_btn);
            this.Controls.Add(this.num4_btn);
            this.Controls.Add(this.num3_btn);
            this.Controls.Add(this.num2_btn);
            this.Controls.Add(this.num1_btn);
            this.Controls.Add(this.num4_lb);
            this.Controls.Add(this.num3_lb);
            this.Controls.Add(this.num3_text);
            this.Controls.Add(this.num2_text);
            this.Controls.Add(this.num1_text);
            this.Controls.Add(this.num2_lb);
            this.Controls.Add(this.num1_lb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1_lb;
        private System.Windows.Forms.Label num2_lb;
        private System.Windows.Forms.TextBox num1_text;
        private System.Windows.Forms.TextBox num2_text;
        private System.Windows.Forms.Label num3_lb;
        private System.Windows.Forms.Label num4_lb;
        private System.Windows.Forms.TextBox num3_text;
        private System.Windows.Forms.Button num1_btn;
        private System.Windows.Forms.Button num3_btn;
        private System.Windows.Forms.Button num4_btn;
        private System.Windows.Forms.Button num5_btn;
        private System.Windows.Forms.Button num2_btn;
    }
}

