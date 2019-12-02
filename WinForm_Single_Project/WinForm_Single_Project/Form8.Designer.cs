namespace WinForm_Single_Project
{
    partial class Form8
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form8_Mode_Group = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form8_Mode_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Form8_Mode_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mode_btn_Update = new System.Windows.Forms.Button();
            this.Mode_Btn_Delete = new System.Windows.Forms.Button();
            this.Mode_Btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Form8_Mode_Group);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Form8_Mode_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Form8_Mode_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 178);
            this.panel1.TabIndex = 0;
            // 
            // Form8_Mode_Group
            // 
            this.Form8_Mode_Group.Location = new System.Drawing.Point(91, 104);
            this.Form8_Mode_Group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form8_Mode_Group.Name = "Form8_Mode_Group";
            this.Form8_Mode_Group.Size = new System.Drawing.Size(140, 21);
            this.Form8_Mode_Group.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Group";
            // 
            // Form8_Mode_Name
            // 
            this.Form8_Mode_Name.Location = new System.Drawing.Point(91, 79);
            this.Form8_Mode_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form8_Mode_Name.Name = "Form8_Mode_Name";
            this.Form8_Mode_Name.Size = new System.Drawing.Size(140, 21);
            this.Form8_Mode_Name.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // Form8_Mode_Id
            // 
            this.Form8_Mode_Id.Location = new System.Drawing.Point(91, 54);
            this.Form8_Mode_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form8_Mode_Id.Name = "Form8_Mode_Id";
            this.Form8_Mode_Id.Size = new System.Drawing.Size(140, 21);
            this.Form8_Mode_Id.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // Mode_btn_Update
            // 
            this.Mode_btn_Update.Font = new System.Drawing.Font("굴림", 40F);
            this.Mode_btn_Update.Location = new System.Drawing.Point(324, 23);
            this.Mode_btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mode_btn_Update.Name = "Mode_btn_Update";
            this.Mode_btn_Update.Size = new System.Drawing.Size(245, 91);
            this.Mode_btn_Update.TabIndex = 2;
            this.Mode_btn_Update.Text = "수정";
            this.Mode_btn_Update.UseVisualStyleBackColor = true;
            this.Mode_btn_Update.Click += new System.EventHandler(this.Mode_btn_Update_Click);
            // 
            // Mode_Btn_Delete
            // 
            this.Mode_Btn_Delete.Font = new System.Drawing.Font("굴림", 40F);
            this.Mode_Btn_Delete.Location = new System.Drawing.Point(324, 121);
            this.Mode_Btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mode_Btn_Delete.Name = "Mode_Btn_Delete";
            this.Mode_Btn_Delete.Size = new System.Drawing.Size(245, 91);
            this.Mode_Btn_Delete.TabIndex = 4;
            this.Mode_Btn_Delete.Text = "삭제";
            this.Mode_Btn_Delete.UseVisualStyleBackColor = true;
            this.Mode_Btn_Delete.Click += new System.EventHandler(this.Mode_Btn_Delete_Click);
            // 
            // Mode_Btn_Clear
            // 
            this.Mode_Btn_Clear.Font = new System.Drawing.Font("굴림", 40F);
            this.Mode_Btn_Clear.Location = new System.Drawing.Point(324, 220);
            this.Mode_Btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mode_Btn_Clear.Name = "Mode_Btn_Clear";
            this.Mode_Btn_Clear.Size = new System.Drawing.Size(245, 91);
            this.Mode_Btn_Clear.TabIndex = 6;
            this.Mode_Btn_Clear.Text = "초기화";
            this.Mode_Btn_Clear.UseVisualStyleBackColor = true;
            this.Mode_Btn_Clear.Click += new System.EventHandler(this.Mode_Btn_Clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(245, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "모드 수정";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(12, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 121);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 338);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mode_Btn_Clear);
            this.Controls.Add(this.Mode_Btn_Delete);
            this.Controls.Add(this.Mode_btn_Update);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form8";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Mode_btn_Update;
        private System.Windows.Forms.Button Mode_Btn_Delete;
        private System.Windows.Forms.Button Mode_Btn_Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Form8_Mode_Group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Form8_Mode_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Form8_Mode_Id;
        private System.Windows.Forms.Label label1;
    }
}