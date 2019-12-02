using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProjectSample;

namespace WinForm_Single_Project
{
    public partial class Form2 : Form
    {
        MySqlConnection conn;
        MySqlConnection conn1;
        MySqlConnection conn2;
        MySqlDataAdapter dataAdapter;
        MySqlDataAdapter dataAdapter1;
        MySqlDataAdapter dataAdapter2;
        DataSet dataSet;
        int selectedRowIndex;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=league_of_legends;uid=root;pwd=~!a036400";
            conn = new MySqlConnection(connStr);
            conn1 = new MySqlConnection(connStr);
            conn2 = new MySqlConnection(connStr);
            dataSet = new DataSet();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM champion", conn);

            dataAdapter1 = new MySqlDataAdapter("SELECT * FROM item", conn1);

            dataAdapter2 = new MySqlDataAdapter("SELECT * FROM mode", conn2);

            conn.Open();
            conn1.Open();
            conn2.Open();

            #region 상태
            if (conn.State == ConnectionState.Open)
            {
                Status1.Text = "연결 성공";
            }
            if (conn1.State == ConnectionState.Open)
            {
                Status2.Text = "연결 성공";
            }
            if (conn2.State == ConnectionState.Open)
            {
                Status3.Text = "연결 성공";
            }
            #endregion

            Champion_Basic_ComboBox();
            Champion_Group_ComboBox();
            Champion_Price_ComboBox();
            Champion_Line_ComboBox();
            Item_Id_ComboBox();
            Item_Price_ComboBox();
            Item_Group_ComboBox();
            Item_Active_ComboBox();
            Mode_Id_ComboBox();
            Mode_Group_ComboBox();

        }

        #region 검색 조건
        private void Champion_Basic_ComboBox()
        {
            string sql = "SELECT distinct Champion_Basic FROM champion";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Champion_Basic.Items.Add(reader.GetString("Champion_Basic"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Champion_Group_ComboBox()
        {
            string sql = "SELECT distinct Champion_Group FROM champion";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Champion_Group.Items.Add(reader.GetString("Champion_Group"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Champion_Price_ComboBox()
        {
            string sql = "SELECT distinct Champion_Price FROM champion";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Champion_Price.Items.Add(reader.GetString("Champion_Price"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Champion_Line_ComboBox()
        {
            string sql = "SELECT distinct Champion_Line1 FROM champion";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Champion_Line.Items.Add(reader.GetString("Champion_Line1"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Item_Id_ComboBox()
        {
            string sql = "SELECT distinct Item_Id FROM item";
            MySqlCommand cmd = new MySqlCommand(sql, conn1);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item_Id.Items.Add(reader.GetString("Item_Id"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        private void Item_Price_ComboBox()
        {
            string sql = "SELECT distinct Item_Price FROM Item";
            MySqlCommand cmd = new MySqlCommand(sql, conn1);

            try
            {
                conn1.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item_Price.Items.Add(reader.GetString("Item_Price"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        private void Item_Group_ComboBox()
        {
            string sql = "SELECT distinct Item_Group FROM Item";
            MySqlCommand cmd = new MySqlCommand(sql, conn1);

            try
            {
                conn1.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item_Group.Items.Add(reader.GetString("Item_Group"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        private void Item_Active_ComboBox()
        {
            string sql = "SELECT distinct Item_Active FROM Item";
            MySqlCommand cmd = new MySqlCommand(sql, conn1);

            try
            {
                conn1.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item_Active.Items.Add(reader.GetString("Item_Active"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        private void Mode_Id_ComboBox()
        {
            string sql = "SELECT distinct Mode_Id FROM mode";
            MySqlCommand cmd = new MySqlCommand(sql, conn2);

            try
            {
                conn1.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mode_Id.Items.Add(reader.GetString("Mode_Id"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }

        private void Mode_Group_ComboBox()
        {
            string sql = "SELECT distinct Mode_Group FROM mode";
            MySqlCommand cmd = new MySqlCommand(sql, conn2);

            try
            {
                conn2.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mode_Group.Items.Add(reader.GetString("Mode_Group"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }
        #endregion

        #region Champion Insert, Del, Update
        public void InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO champion (Champion_Id, Champion_Name, Champion_Group, Champion_Line1, Champion_Line2, Champion_Price, Champion_Basic)" +
                "VALUES (@Champion_Id, @Champion_Name, @Champion_Group, @Champion_Line1, @Champion_Line2, @Champion_Price, @Champion_Basic)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Id", MySqlDbType.Int32);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Name", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Group", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Line1", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Line2", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Price", MySqlDbType.VarChar);
                dataAdapter.InsertCommand.Parameters.Add("@Champion_Basic", MySqlDbType.VarChar);

                dataAdapter.InsertCommand.Parameters["@Champion_Id"].Value = rowDatas[0];
                dataAdapter.InsertCommand.Parameters["@Champion_Name"].Value = rowDatas[1];
                dataAdapter.InsertCommand.Parameters["@Champion_Group"].Value = rowDatas[2];
                dataAdapter.InsertCommand.Parameters["@Champion_Line1"].Value = rowDatas[3];
                dataAdapter.InsertCommand.Parameters["@Champion_Line2"].Value = rowDatas[4];
                dataAdapter.InsertCommand.Parameters["@Champion_Price"].Value = rowDatas[5];
                dataAdapter.InsertCommand.Parameters["@Champion_Basic"].Value = rowDatas[6];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                       
                dataAdapter.Fill(dataSet, "champion");                   
                dataGridView1.DataSource = dataSet.Tables["champion"];  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void DeleteRow(string Champion_Id)
        {
            string sql = "DELETE FROM champion WHERE Champion_Id=@Champion_Id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@Champion_Id", Champion_Id);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "champion");
                dataGridView1.DataSource = dataSet.Tables["champion"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        internal void UpdateRow(string[] rowDatas)
        {
            string sql = "UPDATE champion SET Champion_Id=@Champion_Id, Champion_Name=@Champion_Name, Champion_Group=@Champion_Group, Champion_Line1=@Champion_Line1, Champion_Line2=@Champion_Line2, Champion_Price=@Champion_Price, Champion_Basic=@Champion_Basic WHERE Champion_Id=@Champion_Id";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Id", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Name", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Group", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Line1", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Line2", rowDatas[4]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Price", rowDatas[5]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@Champion_Basic", rowDatas[6]);

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "champion");
                dataGridView1.DataSource = dataSet.Tables["champion"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region Item Insert, Del, Update
        public void Item_Insert(string[] rowDatas)
        {
            string queryStr = "INSERT INTO item (Item_Id, Item_Name, Item_Group, Item_Price, Item_Active)" +
                "VALUES (@Item_Id, @Item_Name, @Item_Group, @Item_Price, @Item_Active)";
            dataAdapter1.InsertCommand = new MySqlCommand(queryStr, conn1);
            dataAdapter1.InsertCommand.Parameters.Add("@Item_Id", MySqlDbType.Int32);
            dataAdapter1.InsertCommand.Parameters.Add("@Item_Name", MySqlDbType.VarChar);
            dataAdapter1.InsertCommand.Parameters.Add("@Item_Group", MySqlDbType.VarChar);
            dataAdapter1.InsertCommand.Parameters.Add("@Item_Price", MySqlDbType.VarChar);
            dataAdapter1.InsertCommand.Parameters.Add("@Item_Active", MySqlDbType.VarChar);

            dataAdapter1.InsertCommand.Parameters["@Item_Id"].Value = rowDatas[0];
            dataAdapter1.InsertCommand.Parameters["@Item_Name"].Value = rowDatas[1];
            dataAdapter1.InsertCommand.Parameters["@Item_Group"].Value = rowDatas[2];
            dataAdapter1.InsertCommand.Parameters["@Item_Price"].Value = rowDatas[3];
            dataAdapter1.InsertCommand.Parameters["@Item_Active"].Value = rowDatas[4];

            try
            {
                conn1.Open();
                dataAdapter1.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter1.Fill(dataSet, "Item");
                dataGridView2.DataSource = dataSet.Tables["Item"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        internal void Item_Delete(string Item_Id)
        {
            string sql = "DELETE FROM item WHERE Item_Id=@Item_Id";
            dataAdapter1.DeleteCommand = new MySqlCommand(sql, conn1);
            dataAdapter1.DeleteCommand.Parameters.AddWithValue("@Item_Id", Item_Id);

            try
            {
                conn1.Open();
                dataAdapter1.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter1.Fill(dataSet, "Item");
                dataGridView2.DataSource = dataSet.Tables["Item"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }

        internal void Item_Update(string[] rowDatas)
        {
            string sql = "UPDATE item SET Item_Id=@Item_Id, Item_Name=@Item_Name, Item_Group=@Item_Group, Item_Price=@Item_Price, Item_Active=@Item_Active WHERE Item_Id=@Item_Id";
            dataAdapter1.UpdateCommand = new MySqlCommand(sql, conn1);
            dataAdapter1.UpdateCommand.Parameters.AddWithValue("@Item_Id", rowDatas[0]);
            dataAdapter1.UpdateCommand.Parameters.AddWithValue("@Item_Name", rowDatas[1]);
            dataAdapter1.UpdateCommand.Parameters.AddWithValue("@Item_Group", rowDatas[2]);
            dataAdapter1.UpdateCommand.Parameters.AddWithValue("@Item_Price", rowDatas[3]);
            dataAdapter1.UpdateCommand.Parameters.AddWithValue("@Item_Active", rowDatas[4]);

            try
            {
                conn1.Open();
                dataAdapter1.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter1.Fill(dataSet, "Item");
                dataGridView2.DataSource = dataSet.Tables["Item"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn1.Close();
            }
        }
        #endregion

        #region Mode Insert, Del, Update
        public void Mode_Insert(string[] rowDatas)
        {
            string queryStr = "INSERT INTO mode (Mode_Id, Mode_Name, Mode_Group)" +
                "VALUES (@Mode_Id, @Mode_Name, @Mode_Group)";
            dataAdapter2.InsertCommand = new MySqlCommand(queryStr, conn2);
            dataAdapter2.InsertCommand.Parameters.Add("@Mode_Id", MySqlDbType.Int32);
            dataAdapter2.InsertCommand.Parameters.Add("@Mode_Name", MySqlDbType.VarChar);
            dataAdapter2.InsertCommand.Parameters.Add("@Mode_Group", MySqlDbType.VarChar);

            dataAdapter2.InsertCommand.Parameters["@Mode_Id"].Value = rowDatas[0];
            dataAdapter2.InsertCommand.Parameters["@Mode_Name"].Value = rowDatas[1];
            dataAdapter2.InsertCommand.Parameters["@Mode_Group"].Value = rowDatas[2];

            try
            {
                conn2.Open();
                dataAdapter2.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter2.Fill(dataSet, "Mode");
                dataGridView3.DataSource = dataSet.Tables["Mode"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }

        internal void Mode_Delete(string Mode_Id)
        {
            string sql = "DELETE FROM Mode WHERE Mode_Id=@Mode_Id";
            dataAdapter2.DeleteCommand = new MySqlCommand(sql, conn2);
            dataAdapter2.DeleteCommand.Parameters.AddWithValue("@Mode_Id", Mode_Id);

            try
            {
                conn2.Open();
                dataAdapter2.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter2.Fill(dataSet, "Mode");
                dataGridView3.DataSource = dataSet.Tables["Mode"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }

        internal void Mode_Update(string[] rowDatas)
        {
            string sql = "UPDATE Mode SET Mode_Id=@Mode_Id, Mode_Name=@Mode_Name, Mode_Group=@Mode_Group WHERE Mode_Id=@Mode_Id";
            dataAdapter2.UpdateCommand = new MySqlCommand(sql, conn2);
            dataAdapter2.UpdateCommand.Parameters.AddWithValue("@Mode_Id", rowDatas[0]);
            dataAdapter2.UpdateCommand.Parameters.AddWithValue("@Mode_Name", rowDatas[1]);
            dataAdapter2.UpdateCommand.Parameters.AddWithValue("@Mode_Group", rowDatas[2]);


            try
            {
                conn2.Open();
                dataAdapter2.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter2.Fill(dataSet, "Mode");
                dataGridView3.DataSource = dataSet.Tables["Mode"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn2.Close();
            }
        }
        #endregion

        #region 검색
        private void btnSelect_Click_1(object sender, EventArgs e)
        {
            string queryStr;

            string[] conditions = new string[4];
            conditions[0] = (Champion_Basic.Text != "") ? "Champion_Basic=@Champion_Basic" : null;
            conditions[1] = (Champion_Group.Text != "") ? "Champion_Name=@Champion_Name" : null;
            conditions[2] = (Champion_Price.Text != "") ? "Champion_Price=@Champion_Price" : null;
            conditions[3] = (Champion_Line.Text != "") ? "Champion_Line1=@Champion_Line1" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM champion WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM champion";
            }

            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Champion_Name", Champion_Group.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Champion_Price", Champion_Price.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Champion_Line1", Champion_Line.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Champion_Basic", Champion_Basic.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "champion") > 0)
                    dataGridView1.DataSource = dataSet.Tables["champion"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string queryStr;

            string[] conditions = new string[5];
            conditions[0] = (Item_Id.Text != "") ? "Item_Id=@Item_Id" : null;
            conditions[1] = (Item_Group.Text != "") ? "Item_Group=@Item_Group" : null;
            conditions[2] = (Item_Price.Text != "") ? "Item_Price=@Item_Price" : null;
            conditions[3] = (Item_Active.Text != "") ? "Item_Active=@Item_Active" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM item WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM item";
            }

            dataAdapter1.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter1.SelectCommand.Parameters.AddWithValue("@Item_Id", Item_Id.Text);
            dataAdapter1.SelectCommand.Parameters.AddWithValue("@Item_Group", Item_Group.Text);
            dataAdapter1.SelectCommand.Parameters.AddWithValue("@Item_Price", Item_Price.Text);
            dataAdapter1.SelectCommand.Parameters.AddWithValue("@Item_Active", Item_Active.Text);

            try
            {
                conn.Open();
                dataSet.Clear();  
                if (dataAdapter1.Fill(dataSet, "item") > 0)
                    dataGridView2.DataSource = dataSet.Tables["item"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string queryStr;

            string[] conditions = new string[5];
            conditions[0] = (Mode_Id.Text != "") ? "Mode_Id=@Mode_Id" : null;
            conditions[1] = (Mode_Group.Text != "") ? "Mode_Group=@Mode_Group" : null;
            conditions[2] = (Mode_Name.Text != "") ? "Mode_Name=@Mode_Name" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null)
            {
                queryStr = $"SELECT * FROM mode WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM mode";
            }

            dataAdapter2.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter2.SelectCommand.Parameters.AddWithValue("@Mode_Id", Mode_Id.Text);
            dataAdapter2.SelectCommand.Parameters.AddWithValue("@Mode_Group", Mode_Group.Text);
            dataAdapter2.SelectCommand.Parameters.AddWithValue("@Mode_Name", Mode_Name.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter2.Fill(dataSet, "mode") > 0)
                    dataGridView3.DataSource = dataSet.Tables["mode"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 초기화
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Champion_Basic.Text = "";
            Champion_Group.Text = "";
            Champion_Price.Text = "";
            Champion_Line.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item_Id.Text = "";
            Item_Group.Text = "";
            Item_Price.Text = "";
            Item_Active.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mode_Id.Text = "";
            Mode_Name.Clear();
            Mode_Group.Text = "";
        }
        #endregion

        #region 추가
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form3 Dig = new Form3();
            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 Dig = new Form5();
            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 Dig = new Form7();
            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }
        #endregion

        #region table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            Form4 Dig = new Form4(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString()
                );

            Dig.Owner = this;
            Dig.ShowDialog(); 
            Dig.Dispose();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[selectedRowIndex];

            Form6 Dig = new Form6(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString()
                );

            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView3.Rows[selectedRowIndex];

            Form8 Dig = new Form8(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString()
                );

            Dig.Owner = this;
            Dig.ShowDialog();
            Dig.Dispose();
        }
        #endregion

    }
}
