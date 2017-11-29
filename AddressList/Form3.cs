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
using System.IO;

namespace AddressList
{
	public partial class Form3 : Form
	{
		string personId;
		bool insertdate = false;
		string starpath = @"..\..\";

		public Form3()
		{
			InitializeComponent();
		}

		public Form3(string s)
		{
			InitializeComponent();
			personId = s;
			ReadList();
			ReadPerson();
			ShowPicture(personId);
		}

		public Form3(bool b)
		{
			InitializeComponent();
			ReadList();
			insertdate = b;
		}

		private void Form3_Load(object sender, EventArgs e)
		{

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

		private void ReadPerson()
		{
			DataSet ds = new DataSet();
			ds.ReadXml(starpath + @"\AddressList.xml");
			int ipersonid = Convert.ToInt32(personId);
			textBox1.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][1].ToString();
			dateTimePicker1.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][2].ToString();
			textBox2.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][3].ToString();
			textBox3.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][4].ToString();
			textBox4.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][5].ToString();
			comboBox2.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][6].ToString();
			textBox5.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][7].ToString();
			textBox6.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][8].ToString();
			comboBox1.Text = ds.Tables["PersonList"].Rows[ipersonid - 1][9].ToString();
		}

		private void ShowPicture(string userId)
		{
			if (!Directory.Exists(starpath + @"\Picture"))
			{
				Directory.CreateDirectory(starpath + @"\Picture");
			}
			string[] files = Directory.GetFiles(starpath + @"\Picture");
			foreach(string file in files)
			{
				string filename = Path.GetFileName(file);
				if (filename == userId + ".jpg")
				{
					FileStream fs = new FileStream(starpath + @"\Picture\" + userId + ".jpg", FileMode.Open, FileAccess.Read);
					pictureBox1.Image = Image.FromStream(fs);
					fs.Close();
				}
				if(filename == userId + ".TXT")
				{
					textBox7.Text = "";
					using (StreamReader sr = new StreamReader(starpath + @"\Picture\" + filename, System.Text.Encoding.Default))
					{
						while (sr.Peek() > -1)
						{
							string strres = sr.ReadLine();
							textBox7.AppendText(strres + "\r\n");
						}
					}
				}
			}
		}

		private void SavePicture(string userId)
		{
			if (!Directory.Exists(starpath + @"\Picture"))
			{
				Directory.CreateDirectory(starpath + @"Picture");
			}
			if (File.Exists(starpath + @"\Picture\" + personId+".jpg"))
			{
				File.Delete(starpath + @"\Picture\" + personId + ".jpg");
			}
			if (File.Exists(starpath + @"\Picture\" + personId + ".TXT"))
			{
				File.Exists(starpath + @"\Picture\" + personId + ".TXT");
			}
			try
			{
				pictureBox1.Image.Save(starpath + @"\Picture\" + personId + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
			}
			catch(Exception ex)
			{
				string str = ex.Message;
				//MessageBox.Show(str);
			}

			FileStream fs = new FileStream(starpath + @"\Picture\" + personId + ".TXT", FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs, Encoding.Default);
			sw.Flush();
			sw.BaseStream.Seek(0, SeekOrigin.Begin);
			sw.Write(textBox7.Text);
			sw.Flush();
			sw.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DataSet ds = new DataSet();
			ds.ReadXml(starpath + @"\AddressList.xml");
			if(insertdate)
			{
				DataRow dr = ds.Tables["PersonList"].NewRow();
				Form1.allPersonNum++;
				dr["ID"] = Form1.allPersonNum.ToString();
				dr["姓名"] = textBox1.Text.Trim();
				dr["出生时间"] = dateTimePicker1.Text;
				dr["电话"] = textBox2.Text.Trim();
				dr["Email"] = textBox3.Text.Trim();
				dr["QQ"] = textBox4.Text.Trim();
				dr["性别"] = comboBox2.Text;
				dr["地址"] = textBox5.Text.Trim();
				dr["备注"] = textBox6.Text.Trim();
				dr["所在分组"] = comboBox1.Text;
				ds.Tables["PersonList"].Rows.Add(dr);
			}
			else{
				int i = Convert.ToInt32(personId) - 1;
				DataRow dr = ds.Tables["PersonList"].Rows[i];
				dr["姓名"] = textBox1.Text.Trim();
				dr["出生时间"] = dateTimePicker1.Text;
				dr["电话"] = textBox2.Text.Trim();
				dr["Email"] = textBox3.Text.Trim();
				dr["QQ"] = textBox4.Text.Trim();
				dr["性别"] = comboBox2.Text;
				dr["地址"] = textBox5.Text.Trim();
				dr["备注"] = textBox6.Text.Trim();
				dr["所在分组"] = comboBox1.Text;
			}
			ds.WriteXml(starpath + @"\AddressList.xml");
			SavePicture(personId);
			MessageBox.Show("保存成功!");
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			try
			{
				openFileDialog1.RestoreDirectory = true;
				openFileDialog1.DefaultExt = "jpg";
				openFileDialog1.Filter = "Jpeg文件(*.jpg)|*.jpg|gif文件(*.gif)|*.gif|bmp文件(*.bmp)|*.bmp";
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					Image image = new Bitmap(openFileDialog1.FileName);
					pictureBox1.Image = image;
					pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
				}
			}
			finally
			{
				openFileDialog1.Dispose();
			}
		}

		private void textBox7_Click(object sender, EventArgs e)
		{
			textBox7.ReadOnly = false;
		}
	}
}
