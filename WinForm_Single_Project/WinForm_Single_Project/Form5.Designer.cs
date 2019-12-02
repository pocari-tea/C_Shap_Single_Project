namespace WinForm_Single_Project
{
    partial class Form5
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
            this.Item_Btn_Insert = new System.Windows.Forms.Button();
            this.Item_Btn_Clear1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form5_Item_Price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Form5_Item_Active = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Form5_Item_Group = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form5_Item_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Form5_Item_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Item_Btn_Insert
            // 
            this.Item_Btn_Insert.Font = new System.Drawing.Font("굴림", 40F);
            this.Item_Btn_Insert.Location = new System.Drawing.Point(324, 23);
            this.Item_Btn_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item_Btn_Insert.Name = "Item_Btn_Insert";
            this.Item_Btn_Insert.Size = new System.Drawing.Size(245, 135);
            this.Item_Btn_Insert.TabIndex = 2;
            this.Item_Btn_Insert.Text = "추가";
            this.Item_Btn_Insert.UseVisualStyleBackColor = true;
            this.Item_Btn_Insert.Click += new System.EventHandler(this.Item_Btn_Insert_Click);
            // 
            // Item_Btn_Clear1
            // 
            this.Item_Btn_Clear1.Font = new System.Drawing.Font("굴림", 40F);
            this.Item_Btn_Clear1.Location = new System.Drawing.Point(324, 176);
            this.Item_Btn_Clear1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item_Btn_Clear1.Name = "Item_Btn_Clear1";
            this.Item_Btn_Clear1.Size = new System.Drawing.Size(245, 135);
            this.Item_Btn_Clear1.TabIndex = 6;
            this.Item_Btn_Clear1.Text = "초기화";
            this.Item_Btn_Clear1.UseVisualStyleBackColor = true;
            this.Item_Btn_Clear1.Click += new System.EventHandler(this.Item_Btn_Clear1_Click);
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
            this.label6.Text = "아이템 추가";
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
            this.panel1.Controls.Add(this.Form5_Item_Price);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Form5_Item_Active);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Form5_Item_Group);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Form5_Item_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Form5_Item_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 182);
            this.panel1.TabIndex = 9;
            // 
            // Form5_Item_Price
            // 
            this.Form5_Item_Price.Location = new System.Drawing.Point(77, 103);
            this.Form5_Item_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form5_Item_Price.Name = "Form5_Item_Price";
            this.Form5_Item_Price.Size = new System.Drawing.Size(140, 21);
            this.Form5_Item_Price.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Price";
            // 
            // Form5_Item_Active
            // 
            this.Form5_Item_Active.Location = new System.Drawing.Point(77, 128);
            this.Form5_Item_Active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form5_Item_Active.Name = "Form5_Item_Active";
            this.Form5_Item_Active.Size = new System.Drawing.Size(140, 21);
            this.Form5_Item_Active.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Active";
            // 
            // Form5_Item_Group
            // 
            this.Form5_Item_Group.Location = new System.Drawing.Point(77, 78);
            this.Form5_Item_Group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form5_Item_Group.Name = "Form5_Item_Group";
            this.Form5_Item_Group.Size = new System.Drawing.Size(140, 21);
            this.Form5_Item_Group.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group";
            // 
            // Form5_Item_Name
            // 
            this.Form5_Item_Name.Location = new System.Drawing.Point(77, 53);
            this.Form5_Item_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form5_Item_Name.Name = "Form5_Item_Name";
            this.Form5_Item_Name.Size = new System.Drawing.Size(140, 21);
            this.Form5_Item_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // Form5_Item_Id
            // 
            this.Form5_Item_Id.Location = new System.Drawing.Point(77, 28);
            this.Form5_Item_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Form5_Item_Id.Name = "Form5_Item_Id";
            this.Form5_Item_Id.Size = new System.Drawing.Size(140, 21);
            this.Form5_Item_Id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 337);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Item_Btn_Clear1);
            this.Controls.Add(this.Item_Btn_Insert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Item_Btn_Insert;
        private System.Windows.Forms.Button Item_Btn_Clear1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Form5_Item_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Form5_Item_Active;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Form5_Item_Group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Form5_Item_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Form5_Item_Id;
        private System.Windows.Forms.Label label1;
    }
}