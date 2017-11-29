using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace AddressList
{
	public partial class Form1 : Form
	{
		DataSet DataSet1;
		string starpath = @"..\..\";
		public static int allPersonNum;

		public Form1()
		{
			InitializeComponent();
		}

		private void ToolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "登陆时间" + DateTime.Now.ToString();
			toolStripButton4_Click(null, null);
			treeView1.Nodes.Clear();
			TreeXML TreeXml = new TreeXML();
			TreeXml.XMLToTree(starpath + @"\List.xml", treeView1);
		}

		private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
			if(form2.groupName != "")
			{
				TreeNode tn = new TreeNode();
				tn.Text = form2.groupName;
				treeView1.Nodes.Add(tn);
				if(treeView1.SelectedNode.Parent == null)
				{
					TreeXML tx = new TreeXML();
					tx.AddXmlNode(starpath + @"\List.xml", form2.groupName);
				}
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			if(treeView1.SelectedNode == null)
			{
				MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				DialogResult result = MessageBox.Show("确定要删除此节点的所有内容吗？", "删除节点", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				switch (result)
				{
					case DialogResult.Yes:
						TreeXML tx = new TreeXML();
						tx.DeleXml(starpath + @"\List.xml", treeView1.SelectedNode.Text);
						treeView1.SelectedNode.Remove();
						break;
					case DialogResult.No:
						break;
					case DialogResult.Cancel:
						break;
				}
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.ShowDialog();
			if(form2.groupName!= "")
			{
				if (treeView1.SelectedNode == null)
				{
					MessageBox.Show("请选择一个节点", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					TreeXML tx = new TreeXML();
					tx.AlterXml(starpath + @"\List.xml", treeView1.SelectedNode.Text, form2.groupName);
					treeView1.SelectedNode.Text = form2.groupName;
				}
			}
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			DataSet1 = new DataSet();
			DataSet1.ReadXml(starpath + @"\AddressList.xml", XmlReadMode.Auto);

			//MessageBox.Show(DataSet1.Tables["PersonList"].Rows[2]["ID"].ToString());

			dataGridView1.AutoGenerateColumns = true;
			dataGridView1.DataSource = DataSet1;
			dataGridView1.DataMember = "PersonList";
			allPersonNum = dataGridView1.RowCount;
			toolStripStatusLabel2.Text = "共有" + allPersonNum.ToString() + "条记录";
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3(true);
			form.ShowDialog();
			toolStripButton4_Click(null, null);
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			Form4 form = new Form4();
			form.ShowDialog();
			if(form.Res == "OK")
			{
				DataTable dt = form.GetTable();
				dataGridView1.DataSource = dt;
			}
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection selectedRows = dataGridView1.SelectedRows;
			if (selectedRows.Count > 0)
			{
				DialogResult result = MessageBox.Show("你确定要删除选定的数据吗？", "删除数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(result == DialogResult.Yes)
				{
					foreach(DataGridViewRow row in selectedRows)
					{
						int i = Convert.ToInt32(row.Cells["ID"].Value);
						DataSet ds = new DataSet();
						ds.ReadXml(starpath + @"\AddressList.xml");
						ds.Tables["PersonList"].Rows[i - 1].Delete();
						for(int k = i - 1; k < ds.Tables["PersonList"].Rows.Count; k++)
						{
							ds.Tables["PersonList"].Rows[k]["ID"] = (k + 1).ToString();
						}
						ds.WriteXml(starpath + @"\AddressList.xml");
						MessageBox.Show("删除成功！");
						toolStripButton4_Click(null, null);
					}
				}
			}
		}

		private void toolStripButton8_Click(object sender, EventArgs e)
		{
			DataSet1 = new DataSet();
			DataSet1.ReadXml(starpath + @"\AddressList.xml", XmlReadMode.Auto);
			DataView dv = DataSet1.Tables["PersonList"].DefaultView;
			dv.RowFilter = "姓名='" + toolStripTextBox1.Text.Trim() + "'";
			dataGridView1.DataSource = dv.ToTable();
		}

		private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeXML TreeXml = new TreeXML();
			dataGridView1.DataSource = TreeXml.GetPersonInfo(starpath + @"\AddressList.xml", treeView1.SelectedNode.Text);
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex>=0 && e.RowIndex >= 0)
			{
				string PersonId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
				Form3 form = new Form3(PersonId);
				form.ShowDialog();
				toolStripButton4_Click(null, null);
			}
		}

		private void 添加下级分组ToolStripMenuItem_Click(object sender, EventArgs e)
		{
/*			Form2 form2 = new Form2();
			form2.Text = "添加下级分组";
			form2.ShowDialog();
			if (form2.groupName != "")
			{
				TreeNode tn = new TreeNode();
				tn.Text = form2.groupName;
				treeView1.SelectedNode.Nodes.Add(tn);
				TreeXML tx = new TreeXML();
				tx.AddChildNode(starpath + @"\List.xml", form2.groupName);
			}*/
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
