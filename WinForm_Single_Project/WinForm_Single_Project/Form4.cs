using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Single_Project
{
    public partial class Form4 : Form
    {
        private string Champion_id;
        private string Champion_Name;
        private string Champion_Group;
        private string Champion_Line1;
        private string Champion_Line2;
        private string Champion_Price;
        private string Champion_Basic;
        private int selectedRowIndex;

        public Form4(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5, string v6, string v7)
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
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + Champion_Name + ".jpeg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (FileNotFoundException)
            {
                pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Form4_Champion_Id.Text = Champion_id;
            Form4_Champion_Name.Text = Champion_Name;
            Form4_Champion_Group.Text = Champion_Group;
            Form4_Champion_Line1.Text = Champion_Line1;
            Form4_Champion_Line2.Text = Champion_Line2;
            Form4_Champion_Price.Text = Champion_Price;
            Form4_Champion_Basic.Text = Champion_Basic;

            if (Owner != null)
            {
                mainForm = Owner as Form2;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

            pictureBox2.Image = Bitmap.FromFile(image_file);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Champion_Btn_Clear2_Click(object sender, EventArgs e)
        {
            pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Form4_Champion_Id.Text = "";
            Form4_Champion_Name.Text = "";
            Form4_Champion_Group.Text = "";
            Form4_Champion_Line1.Text = "";
            Form4_Champion_Line2.Text = "";
            Form4_Champion_Price.Text = "";
            Form4_Champion_Basic.Text = "";
        }

        private void Champion_Btn_Update_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form4_Champion_Id.Text,
                Form4_Champion_Name.Text,
                Form4_Champion_Group.Text,
                Form4_Champion_Line1.Text,
                Form4_Champion_Line2.Text,
                Form4_Champion_Price.Text,
                Form4_Champion_Basic.Text};
            mainForm.UpdateRow(rowDatas);
            this.Close();

        }

        private void Champion_Btn_Delete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteRow(Champion_id);
            this.Close();
        }
    }
}
