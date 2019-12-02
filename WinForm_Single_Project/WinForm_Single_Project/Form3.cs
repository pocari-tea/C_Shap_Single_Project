using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Single_Project;

namespace WinFormProjectSample
{
    public partial class Form3 : Form
    {
        private string Champion_id;
        private string Champion_Name;
        private string Champion_Group;
        private string Champion_Line1;
        private string Champion_Line2;
        private string Champion_Price;
        private string Champion_Basic;
        private int selectedRowIndex;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5, string v6, string v7)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.Champion_id = v1;
            this.Champion_Name = v2;
            this.Champion_Group = v3;
            this.Champion_Line1 = v4;
            this.Champion_Line2 = v5;
            this.Champion_Price = v6;
            this.Champion_Basic = v7;
        }

        Form2 mainForm;
        private void Form3_Load(object sender, EventArgs e)
        {
            Form3_Champion_Id.Text = Champion_id;
            Form3_Champion_Name.Text = Champion_Name;
            Form3_Champion_Group.Text = Champion_Group;
            Form3_Champion_Line1.Text = Champion_Line1;
            Form3_Champion_Line2.Text = Champion_Line2;
            Form3_Champion_Price.Text = Champion_Price;
            Form3_Champion_Basic.Text = Champion_Price;

            if (Owner != null)
            {
                mainForm = Owner as Form2;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string image_file = string.Empty;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image_file = dialog.FileName;
            }
            else if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pictureBox1.Image = Bitmap.FromFile(image_file);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Champion_Btn_Insert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form3_Champion_Id.Text,
                Form3_Champion_Name.Text,
                Form3_Champion_Group.Text,
                Form3_Champion_Line1.Text,
                Form3_Champion_Line2.Text,
                Form3_Champion_Price.Text,
                Form3_Champion_Basic.Text};
            mainForm.InsertRow(rowDatas);
            this.Close();
        }

        private void Champion_Btn_Clear1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Form3_Champion_Id.Text = "";
            Form3_Champion_Name.Text = "";
            Form3_Champion_Group.Text = "";
            Form3_Champion_Line1.Text = "";
            Form3_Champion_Line2.Text = "";
            Form3_Champion_Price.Text = "";
            Form3_Champion_Basic.Text = "";
        }
    }
}
