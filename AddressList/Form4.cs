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
	public partial class Form4 : Form
	{
		string starpath = @"..\..\";
		DataTable dt = new DataTable();
		public string Res = "Cancel";
		public DataTable GetTable()
		{
			return dt;
		}
		public Form4()
		{
			InitializeComponent();
		}

		private void Form4_Load(object sender, EventArgs e)
		{
			ReadList();
		}

		private void ReadList()
		{
			XmlDocument xd = new XmlDocument();
			xd.Load(starpath + @"\List.xml");
			XmlNodeList xnl = xd.SelectSingleNode("List").ChildNodes;
			foreach(XmlNode xn in xnl)
			{
				XmlElement xe = (XmlElement)xn;
				comboBox1.Items.Add(xe.InnerText);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Res = "OK";
			DataSet ds = new DataSet();
			ds.ReadXml(starpath + @"\AddressList.xml", XmlReadMode.Auto);
			DataView dv = ds.Tables["PersonList"].DefaultView;
			string con = "";
			if(textBox1.Text.Trim() != "")
			{
				con += "姓名='" + textBox1.Text.Trim() + "'";
			}
			if (textBox2.Text.Trim() != "")
			{
				if (con != "") con += " AND ";
				con += "QQ='" + textBox2.Text.Trim() + "'";
			}
			if (textBox3.Text.Trim() != "")
			{
				if (con != "") con += " AND ";
				con += "Email='" + textBox3.Text.Trim() + "'";
			}
			if (textBox4.Text.Trim() != "")
			{
				if (con != "") con += " AND ";
				con += "电话='" + textBox4.Text.Trim() + "'";
			}
			if (comboBox1.Text != "")
			{
				if (con != "") con += " AND ";
				con += "所在分组='" + comboBox1.Text + "'";
			}
			dv.RowFilter = con;
			dt = dv.ToTable();
			this.Close();
		}

	}
}
