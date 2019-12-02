using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Single_Project
{
    public partial class Form7 : Form
    {
        private string Mode_id;
        private string Mode_Name;
        private string Mode_Group;
        private int selectedRowIndex;

        public Form7()
        {
            InitializeComponent();
        }

        public Form7(int selectedRowIndex, string v1, string v2, string v3)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.Mode_id = v1;
            this.Mode_Name = v2;
            this.Mode_Group = v3;
        }

        Form2 mainForm;
        private void Form7_Load(object sender, EventArgs e)
        {
            Form7_Mode_Id.Text = Mode_id;
            Form7_Mode_Name.Text = Mode_Name;
            Form7_Mode_Group.Text = Mode_Group;

            if (Owner != null)
            {
                mainForm = Owner as Form2;
            }
        }

        private void Mode_Btn_Insert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form7_Mode_Id.Text,
                Form7_Mode_Name.Text,
                Form7_Mode_Group.Text };
            mainForm.Mode_Insert(rowDatas);
            this.Close();
        }

        private void Mode_Btn_Clear1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Form7_Mode_Id.Text = "";
            Form7_Mode_Name.Text = "";
            Form7_Mode_Group.Text = "";
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
    }
}
