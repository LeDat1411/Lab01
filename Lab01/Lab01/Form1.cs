using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode rootNode = new TreeNode("Root");
            TreeNode childNode1 = new TreeNode("Child 1");
            TreeNode childNode2 = new TreeNode("Child 2");
            rootNode.Nodes.Add(childNode1);
            rootNode.Nodes.Add(childNode2);
            treeView1.Nodes.Add(rootNode);

            listView1.View = View.Details;
            listView1.Columns.Add("Column 1", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            ListViewItem item1 = new ListViewItem("Item 1");
            item1.SubItems.Add("Subitem 1");
            ListViewItem item2 = new ListViewItem("Item 2");
            item2.SubItems.Add("Subitem 2");
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);

            TabPage tabPage1 = new TabPage("Tab 1");
            TabPage tabPage2 = new TabPage("Tab 2");
            Label label1 = new Label() { Text = "Content of Tab 1", Location = new Point(20, 20) };
            Label label2 = new Label() { Text = "Content of Tab 2", Location = new Point(20, 20) };
            tabPage1.Controls.Add(label1);
            tabPage2.Controls.Add(label2);
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Add(tabPage2);

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem openItem = new ToolStripMenuItem("Open");
            ToolStripMenuItem saveItem = new ToolStripMenuItem("Save");
            fileMenu.DropDownItems.Add(openItem);
            fileMenu.DropDownItems.Add(saveItem);
            menuStrip1.Items.Add(fileMenu);

            ToolStripMenuItem cutItem = new ToolStripMenuItem("Cut");
            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("Paste");
            contextMenuStrip1.Items.Add(cutItem);
            contextMenuStrip1.Items.Add(copyItem);
            contextMenuStrip1.Items.Add(pasteItem);
            textBox1.ContextMenuStrip = contextMenuStrip1;

            ToolStripButton newButton = new ToolStripButton("New");
            ToolStripButton openButton = new ToolStripButton("Open");
            ToolStripButton saveButton = new ToolStripButton("Save");
            toolStrip1.Items.Add(newButton);
            toolStrip1.Items.Add(openButton);
            toolStrip1.Items.Add(saveButton);

            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel("Ready");
            statusStrip1.Items.Add(statusLabel);

            Label tag1 = new Label() { Text = "Panel 1", Dock = DockStyle.Fill };
            Label tag2 = new Label() { Text = "Panel 2", Dock = DockStyle.Fill };
            splitContainer1.Panel1.Controls.Add(tag1);
            splitContainer1.Panel2.Controls.Add(tag2);

            Button button1 = new Button() { Text = "Button 1" };
            Button button2 = new Button() { Text = "Button 2" };
            Button button3 = new Button() { Text = "Button 3" };
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);

            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            // Add controls to the TableLayoutPanel
            Button b1 = new Button() { Text = "Button 1" };
            Button b2 = new Button() { Text = "Button 2" };
            Button b3 = new Button() { Text = "Button 3" };
            Button b4 = new Button() { Text = "Button 4" };
            tableLayoutPanel1.Controls.Add(b1, 0, 0); // Add b1 to column 0, row 0
            tableLayoutPanel1.Controls.Add(b2, 1, 0); // Add b2 to column 1, row 0
            tableLayoutPanel1.Controls.Add(b3, 0, 1); // Add b3 to column 0, row 1
            tableLayoutPanel1.Controls.Add(b4, 1, 1); // Add b4 to column 1, row 1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging in...");
        }
    }
}
