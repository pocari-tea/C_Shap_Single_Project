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
    public partial class Form8 : Form
    {
        private string Mode_id;
        private string Mode_Name;
        private string Mode_Group;
        private int selectedRowIndex;

        public Form8(int selectedRowIndex, string v1, string v2, string v3)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.Mode_id = v1;
            this.Mode_Name = v2;
            this.Mode_Group = v3;
        }

        Form2 mainForm;
        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + Mode_Name + ".jpeg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (FileNotFoundException)
            {
                pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Form8_Mode_Id.Text = Mode_id;
            Form8_Mode_Name.Text = Mode_Name;
            Form8_Mode_Group.Text = Mode_Group;

            if (Owner != null)
            {
                mainForm = Owner as Form2;
            }
        }

        private void Mode_btn_Update_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form8_Mode_Id.Text,
                Form8_Mode_Name.Text,
                Form8_Mode_Group.Text };
            mainForm.Mode_Update(rowDatas);
            this.Close();
        }

        private void Mode_Btn_Delete_Click(object sender, EventArgs e)
        {
            mainForm.Mode_Delete(Mode_id);
            this.Close();
        }

        private void Mode_Btn_Clear_Click(object sender, EventArgs e)
        {
            pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Form8_Mode_Id.Text = "";
            Form8_Mode_Name.Text = "";
            Form8_Mode_Group.Text = "";
        }
    }
}
