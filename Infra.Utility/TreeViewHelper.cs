using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Infra.Utility
{

//1.当选勾选的节点下有子节点，所有子结点跟随勾选结点的Checked状态改变. 
//2.当某结点选中，假如其存在父结点，则父结点也选中。父结点若还有父结点，则其父结点也选中。。以此类推。 
//3.当所有同级结点皆未选中，则父结点Checked=false
	public class TreeViewHelper
	{
		/// <summary>
		/// 系列节点 Checked 属性控制
		/// </summary>
		/// <param name="e"></param>
		public static void CheckControl(TreeViewEventArgs e)
		{
			if (e.Action != TreeViewAction.Unknown)
			{
				if (e.Node != null && !Convert.IsDBNull(e.Node))
				{
					//设置父节点
					CheckParentNode(e.Node);

					//有子节点
					if (e.Node.Nodes.Count > 0)
					{
						//设置子节点 与自己状态保持一致
						CheckAllChildNodes(e.Node, e.Node.Checked);
					}
				}
			}
		}

		//改变父节点的选中状态，此处为所有子节点不选中时才取消父节点选中，可以根据需要修改
		private static void CheckParentNode(TreeNode curNode)
		{
			bool bChecked = false;

			if (curNode.Parent != null)
			{
				foreach (TreeNode node in curNode.Parent.Nodes)
				{
					//当前节点的父节点下的子节点   有一个是选中的
					if (node.Checked)
					{
						bChecked = true;
						break;
					}
				}

				// 那么父节点应该是选中  
				if (bChecked)
				{
					curNode.Parent.Checked = true;
					CheckParentNode(curNode.Parent);
				}
				else
				{
					curNode.Parent.Checked = false;
					CheckParentNode(curNode.Parent);
				}
			}
		}

		//改变所有子节点的状态
		private static void CheckAllChildNodes(TreeNode pn, bool isChecked)
		{
			foreach (TreeNode tn in pn.Nodes)
			{
				tn.Checked = isChecked;

				if (tn.Nodes.Count > 0)
				{
					CheckAllChildNodes(tn, isChecked);
				}
			}
		}

		//遍历权限树  获取选中的节点
		public static List<int>  GetRightIds (TreeNode treeNode)
		{
			List<int> rightIds = new List<int>();

			//顶级节点都没选中，说明没有选择权限
			if (!treeNode.Checked) return rightIds;

			GetIDs(treeNode, rightIds);

			return rightIds;
		}

		//获取某个节点下的所有子节点
		private static void  GetIDs(TreeNode treeNode,List<int> ids)
		{
			foreach (TreeNode item in treeNode.Nodes)
			{
				//该节点子节点选中
				if (item.Checked)
				{
					ids.Add(Convert.ToInt32(item.Name));
				}
				else
				{
					//子节点没选中 里面的肯定没勾选
					continue;
				}

				//该节点子节点还有节点
				if (item.Nodes.Count > 0)
				{
					GetIDs(item, ids);
				}
			}
		}
	
	}
}
