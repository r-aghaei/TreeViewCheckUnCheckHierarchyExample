using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewCheckUnCheckHierarchyExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            exTreeView1.CheckBoxes = true;
            exTreeView1.Nodes.Clear();
            exTreeView1.Nodes.AddRange(new TreeNode[] {
                new TreeNode("1", new TreeNode[] {
                        new TreeNode("11", new TreeNode[]{
                            new TreeNode("111"),
                            new TreeNode("112"),
                        }),
                        new TreeNode("12", new TreeNode[]{
                            new TreeNode("121"),
                            new TreeNode("122"),
                            new TreeNode("123"),
                        }),
                }),
                new TreeNode("2", new TreeNode[] {
                        new TreeNode("21", new TreeNode[]{
                            new TreeNode("211"),
                            new TreeNode("212"),
                        }),
                        new TreeNode("22", new TreeNode[]{
                            new TreeNode("221"),
                            new TreeNode("222"),
                            new TreeNode("223"),
                        }),
                })
            });
            exTreeView1.ExpandAll();
        }

        private void exTreeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                e.Node.Descendants().ToList().ForEach(x =>
                {
                    x.Checked = e.Node.Checked;
                });
                e.Node.Ancestors().ToList().ForEach(x =>
                {
                    x.Checked = x.Descendants().ToList().Any(y => y.Checked);
                });
            }
        }
    }
}
