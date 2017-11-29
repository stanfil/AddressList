using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Windows.Forms;

namespace AddressList
{
	class TreeXML
	{
		TreeView thetreeview;
		XmlDocument xmldocument;
		public TreeXML()
		{
			xmldocument = new XmlDocument();
		}
		~TreeXML()
		{

		}

		public void AddXmlNode(string XMLFilePath, string NodeName)
		{
			xmldocument.Load(XMLFilePath);
			XmlNode root = xmldocument.SelectSingleNode("List");
			XmlElement xel = xmldocument.CreateElement("组名");
			xel.InnerText = NodeName;
			root.AppendChild(xel);
			xmldocument.Save(XMLFilePath);
		}
/*		public void AddChildBode(string XMLFilePath, string NodeName)
		{
			xmldocument.Load(XMLFilePath);

		}*/
		public void XMLToTree(string XMLFilePath, TreeView TheTreeView)
		{
			thetreeview = TheTreeView;
			xmldocument.Load(XMLFilePath);
			XmlNode root = xmldocument.SelectSingleNode("List");
			foreach(XmlNode xn in root.ChildNodes)
			{
				if(xn.Name == "组名")
				{
					TreeNode tn = new TreeNode();
					tn.Text = xn.InnerText;
					thetreeview.Nodes.Add(tn);
				}
			}
		}

		public void DeleXml(string XMLFilePath, string NodeName)
		{
			xmldocument.Load(XMLFilePath);
			XmlNodeList xnl = xmldocument.SelectSingleNode("List").ChildNodes;
			foreach(XmlNode xn in xnl)
			{
				XmlElement xe = (XmlElement)xn;
				if(xe.InnerText == NodeName)
				{
					xe.ParentNode.RemoveChild(xe);
					xmldocument.Save(XMLFilePath);
					break;
				}
			}
		}

		public void AlterXml(string XMLFilePath, string OldNodeName, string NewNodeName)
		{
			xmldocument.Load(XMLFilePath);
			XmlNodeList xnl = xmldocument.SelectSingleNode("List").ChildNodes;
			foreach(XmlNode xn in xnl)
			{
				XmlElement xe = (XmlElement)xn;
				if(xe.InnerText == OldNodeName)
				{
					xe.InnerText = NewNodeName;
					xmldocument.Save(XMLFilePath);
					break;
				}
			}
		}

		public DataTable GetPersonInfo(string XMLFilePath, string NodeName)
		{
			xmldocument.Load(XMLFilePath);
			XmlNodeList xnl = xmldocument.SelectSingleNode("CONTENTS").ChildNodes;
			DataTable dt = new DataTable();
			dt.Columns.Add("ID", typeof(string));
			dt.Columns.Add("姓名", typeof(string));
			dt.Columns.Add("出生时间", typeof(string));
			dt.Columns.Add("电话", typeof(string));
			dt.Columns.Add("Email", typeof(string));
			dt.Columns.Add("QQ", typeof(string));
			dt.Columns.Add("性别", typeof(string));
			dt.Columns.Add("地址", typeof(string));
			dt.Columns.Add("备注", typeof(string));
			foreach(XmlNode xn in xnl)
			{
				XmlElement xe = (XmlElement)xn;
				if(xe.GetAttribute("所在分组") == NodeName)
				{
					DataRow dr = dt.NewRow();
					dr["ID"] = xe.ChildNodes.Item(0).InnerText;
					dr["姓名"] = xe.ChildNodes.Item(1).InnerText;
					dr["出生时间"] = xe.ChildNodes.Item(2).InnerText;
					dr["电话"] = xe.ChildNodes.Item(3).InnerText;
					dr["Email"] = xe.ChildNodes.Item(4).InnerText;
					dr["QQ"] = xe.ChildNodes.Item(5).InnerText;
					dr["性别"] = xe.ChildNodes.Item(6).InnerText;
					dr["地址"] = xe.ChildNodes.Item(7).InnerText;
					dr["备注"] = xe.ChildNodes.Item(8).InnerText;
					dt.Rows.Add(dr);
				}
			}
			return dt;
		}
	}
}
