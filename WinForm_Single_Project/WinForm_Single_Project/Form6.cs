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
    public partial class Form6 : Form
    {
        private string Item_id;
        private string Item_Name;
        private string Item_Price;
        private string Item_Group;
        private string Item_Active;
        private int selectedRowIndex;

        public Form6(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.Item_id = v1;
            this.Item_Name = v2;
            this.Item_Price = v3;
            this.Item_Group = v4;
            this.Item_Active = v5;
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

        Form2 mainForm;
        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + Item_Name + ".jpeg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (FileNotFoundException)
            {
                pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Form6_Item_Id.Text = Item_id;
            Form6_Item_Name.Text = Item_Name;
            Form6_Item_Group.Text = Item_Group;
            Form6_Item_Price.Text = Item_Price;
            Form6_Item_Active.Text = Item_Active;

            if (Owner != null)
            {
                mainForm = Owner as Form2;
            }
        }

        private void Item_btn_Update_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form6_Item_Id.Text,
                Form6_Item_Name.Text,
                Form6_Item_Group.Text,
                Form6_Item_Price.Text,
                Form6_Item_Active.Text};
            mainForm.Item_Update(rowDatas);
            this.Close();

        }

        private void Item_Btn_Delete_Click(object sender, EventArgs e)
        {
            mainForm.Item_Delete(Item_id);
            this.Close();
        }

        private void Item_Btn_Clear_Click(object sender, EventArgs e)
        {
            pictureBox2.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            Form6_Item_Id.Text = "";
            Form6_Item_Name.Text = "";
            Form6_Item_Group.Text = "";
            Form6_Item_Active.Text = "";
            Form6_Item_Price.Text = "";
        }
    }
}
