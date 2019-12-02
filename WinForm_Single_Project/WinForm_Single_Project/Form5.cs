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
    public partial class Form5 : Form
    {
        private string Item_id;
        private string Item_Name;
        private string Item_Group;
        private string Item_Active;
        private string Item_Price;
        private int selectedRowIndex;

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(int selectedRowIndex, string v1, string v2, string v3, string v4, string v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.Item_id = v1;
            this.Item_Name = v2;
            this.Item_Group = v3;
            this.Item_Active = v4;
            this.Item_Price = v5;
        }

        Form2 mainForm;
        private void Form5_Load(object sender, EventArgs e)
        {
            Form5_Item_Id.Text = Item_id;
            Form5_Item_Name.Text = Item_Name;
            Form5_Item_Group.Text = Item_Group;
            Form5_Item_Active.Text = Item_Active;
            Form5_Item_Price.Text = Item_Price;

            if (Owner != null)
            {
                mainForm = Owner as Form2;
            }
        }

        private void Item_Btn_Insert_Click(object sender, EventArgs e)
        {
            string[] rowDatas = {
                Form5_Item_Id.Text,
                Form5_Item_Name.Text,
                Form5_Item_Group.Text,
                Form5_Item_Price.Text,
                Form5_Item_Active.Text};
            mainForm.Item_Insert(rowDatas);
            this.Close();
        }

        private void Item_Btn_Clear1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(@"C:\Users\USER\Pictures\Winform\" + "Null" + ".jpeg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Form5_Item_Id.Text = "";
            Form5_Item_Name.Text = "";
            Form5_Item_Group.Text = "";
            Form5_Item_Price.Text = "";
            Form5_Item_Active.Text = "";
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
