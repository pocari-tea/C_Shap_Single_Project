namespace WinFormProjectSample
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.Champion_Btn_Insert = new System.Windows.Forms.Button();
            this.Champion_Btn_Clear1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form3_Champion_Basic = new System.Windows.Forms.TextBox();
            this.Form3_Champion_Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Form3_Champion_Line2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Form3_Champion_Line1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Form3_Champion_Group = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form3_Champion_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Form3_Champion_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Champion_Btn_Insert
            // 
            this.Champion_Btn_Insert.Font = new System.Drawing.Font("굴림", 40F);
            this.Champion_Btn_Insert.Location = new System.Drawing.Point(324, 23);
            this.Champion_Btn_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Champion_Btn_Insert.Name = "Champion_Btn_Insert";
            this.Champion_Btn_Insert.Size = new System.Drawing.Size(245, 135);
            this.Champion_Btn_Insert.TabIndex = 2;
            this.Champion_Btn_Insert.Text = "추가";
            this.Champion_Btn_Insert.UseVisualStyleBackColor = true;
            this.Champion_Btn_Insert.Click += new System.EventHandler(this.Champion_Btn_Insert_Click);
            // 
            // Champion_Btn_Clear1
            // 
            this.Champion_Btn_Clear1.Font = new System.Drawing.Font("굴림", 40F);
            this.Champion_Btn_Clear1.Location = new System.Drawing.Point(324, 176);
            this.Champion_Btn_Clear1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Champion_Btn_Clear1.Name = "Champion_Btn_Clear1";
            this.Champion_Btn_Clear1.Size = new System.Drawing.Size(245, 135);
            this.Champion_Btn_Clear1.TabIndex = 6;
            this.Champion_Btn_Clear1.Text = "초기화";
            this.Champion_Btn_Clear1.UseVisualStyleBackColor = true;
            this.Champion_Btn_Clear1.Click += new System.EventHandler(this.Champion_Btn_Clear1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(245, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "챔피언 추가";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 121);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Form3_Champion_Basic);
            this.panel1.Controls.Add(this.Form3_Champion_Price);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Form3_Champion_Line2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Form3_Champion_Line1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Form3_Champion_Group);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Form3_Champion_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Form3_Champion_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 182);
            this.panel1.TabIndex = 9;
            // 
            // Form3_Champion_Basic
            // 
            this.Form3_Champion_Basic.Location = new System.Drawing.Point(88, 154);
            this.Form3_Champion_Basic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Basic.Name = "Form3_Champion_Basic";
            this.Form3_Champion_Basic.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Basic.TabIndex = 14;
            // 
            // Form3_Champion_Price
            // 
            this.Form3_Champion_Price.Location = new System.Drawing.Point(88, 129);
            this.Form3_Champion_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Price.Name = "Form3_Champion_Price";
            this.Form3_Champion_Price.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Price.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "AP/AD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Price";
            // 
            // Form3_Champion_Line2
            // 
            this.Form3_Champion_Line2.Location = new System.Drawing.Point(88, 105);
            this.Form3_Champion_Line2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Line2.Name = "Form3_Champion_Line2";
            this.Form3_Champion_Line2.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Line2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Line 2";
            // 
            // Form3_Champion_Line1
            // 
            this.Form3_Champion_Line1.Location = new System.Drawing.Point(88, 80);
            this.Form3_Champion_Line1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Line1.Name = "Form3_Champion_Line1";
            this.Form3_Champion_Line1.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Line1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Line 1";
            // 
            // Form3_Champion_Group
            // 
            this.Form3_Champion_Group.Location = new System.Drawing.Point(88, 56);
            this.Form3_Champion_Group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Group.Name = "Form3_Champion_Group";
            this.Form3_Champion_Group.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Group.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group";
            // 
            // Form3_Champion_Name
            // 
            this.Form3_Champion_Name.Location = new System.Drawing.Point(88, 31);
            this.Form3_Champion_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Name.Name = "Form3_Champion_Name";
            this.Form3_Champion_Name.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Form3_Champion_Id
            // 
            this.Form3_Champion_Id.Location = new System.Drawing.Point(88, 6);
            this.Form3_Champion_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form3_Champion_Id.Name = "Form3_Champion_Id";
            this.Form3_Champion_Id.Size = new System.Drawing.Size(140, 21);
            this.Form3_Champion_Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Champion_Btn_Clear1);
            this.Controls.Add(this.Champion_Btn_Insert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Champion_Btn_Insert;
        private System.Windows.Forms.Button Champion_Btn_Clear1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Form3_Champion_Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Form3_Champion_Line2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Form3_Champion_Line1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Form3_Champion_Group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Form3_Champion_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Form3_Champion_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Form3_Champion_Basic;
    }
}