﻿namespace AddressList
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点1");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.系统YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.联系人分组GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加同级分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加下级分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.修改分组名称ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除分组ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.联系人CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.添加联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.删除联系人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统YToolStripMenuItem,
            this.联系人分组GToolStripMenuItem,
            this.联系人CToolStripMenuItem,
            this.帮助HToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(899, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 系统YToolStripMenuItem
			// 
			this.系统YToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出系统ToolStripMenuItem});
			this.系统YToolStripMenuItem.Name = "系统YToolStripMenuItem";
			this.系统YToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.系统YToolStripMenuItem.Text = "系统(&Y)";
			// 
			// 退出系统ToolStripMenuItem
			// 
			this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
			this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.退出系统ToolStripMenuItem.Text = "退出系统(&E)";
			this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
			// 
			// 联系人分组GToolStripMenuItem
			// 
			this.联系人分组GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加同级分组ToolStripMenuItem,
            this.添加下级分组ToolStripMenuItem,
            this.修改分组名称ToolStripMenuItem,
            this.删除分组ToolStripMenuItem});
			this.联系人分组GToolStripMenuItem.Name = "联系人分组GToolStripMenuItem";
			this.联系人分组GToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
			this.联系人分组GToolStripMenuItem.Text = "联系人分组(&G)";
			// 
			// 添加同级分组ToolStripMenuItem
			// 
			this.添加同级分组ToolStripMenuItem.Name = "添加同级分组ToolStripMenuItem";
			this.添加同级分组ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.添加同级分组ToolStripMenuItem.Text = "添加同级分组";
			this.添加同级分组ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// 添加下级分组ToolStripMenuItem
			// 
			this.添加下级分组ToolStripMenuItem.Name = "添加下级分组ToolStripMenuItem";
			this.添加下级分组ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.添加下级分组ToolStripMenuItem.Text = "添加下级分组";
			this.添加下级分组ToolStripMenuItem.Click += new System.EventHandler(this.添加下级分组ToolStripMenuItem_Click);
			// 
			// 修改分组名称ToolStripMenuItem
			// 
			this.修改分组名称ToolStripMenuItem.Name = "修改分组名称ToolStripMenuItem";
			this.修改分组名称ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.修改分组名称ToolStripMenuItem.Text = "修改分组名称";
			this.修改分组名称ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// 删除分组ToolStripMenuItem
			// 
			this.删除分组ToolStripMenuItem.Name = "删除分组ToolStripMenuItem";
			this.删除分组ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.删除分组ToolStripMenuItem.Text = "删除分组";
			this.删除分组ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// 联系人CToolStripMenuItem
			// 
			this.联系人CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加联系人ToolStripMenuItem,
            this.删除联系人ToolStripMenuItem});
			this.联系人CToolStripMenuItem.Name = "联系人CToolStripMenuItem";
			this.联系人CToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
			this.联系人CToolStripMenuItem.Text = "联系人(&C)";
			// 
			// 添加联系人ToolStripMenuItem
			// 
			this.添加联系人ToolStripMenuItem.Name = "添加联系人ToolStripMenuItem";
			this.添加联系人ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.添加联系人ToolStripMenuItem.Text = "添加联系人";
			this.添加联系人ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton5_Click);
			// 
			// 删除联系人ToolStripMenuItem
			// 
			this.删除联系人ToolStripMenuItem.Name = "删除联系人ToolStripMenuItem";
			this.删除联系人ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.删除联系人ToolStripMenuItem.Text = "删除联系人";
			this.删除联系人ToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton7_Click);
			// 
			// 帮助HToolStripMenuItem
			// 
			this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
			this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
			this.帮助HToolStripMenuItem.Text = "帮助(&H)";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton8});
			this.toolStrip1.Location = new System.Drawing.Point(0, 25);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(899, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(64, 22);
			this.toolStripButton1.Text = "添加组";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(64, 22);
			this.toolStripButton2.Text = "删除组";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(64, 22);
			this.toolStripButton3.Text = "修改组";
			this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton4.Text = "读取";
			this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton5.Text = "新建";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton6.Text = "查找";
			this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(52, 22);
			this.toolStripButton7.Text = "删除";
			this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(44, 22);
			this.toolStripLabel1.Text = "姓名：";
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
			// 
			// toolStripButton8
			// 
			this.toolStripButton8.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
			this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new System.Drawing.Size(36, 22);
			this.toolStripButton8.Text = "搜索";
			this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
			this.statusStrip1.Location = new System.Drawing.Point(0, 442);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(899, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(0, 50);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "节点0";
			treeNode1.Text = "节点0";
			treeNode2.Name = "节点1";
			treeNode2.Text = "节点1";
			treeNode3.Name = "节点2";
			treeNode3.Text = "节点2";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
			this.treeView1.SelectedImageIndex = 1;
			this.treeView1.Size = new System.Drawing.Size(157, 392);
			this.treeView1.TabIndex = 3;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "未选中.png");
			this.imageList1.Images.SetKeyName(1, "选中.png");
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(157, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(742, 392);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(899, 392);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 50);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.Size = new System.Drawing.Size(899, 392);
			this.toolStripContainer1.TabIndex = 5;
			this.toolStripContainer1.Text = "toolStripContainer1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 464);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.toolStripContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = " 通讯录";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 系统YToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 联系人分组GToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加同级分组ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加下级分组ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 修改分组名称ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除分组ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 联系人CToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 添加联系人ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 删除联系人ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripButton toolStripButton7;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripButton toolStripButton8;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
	}
}

