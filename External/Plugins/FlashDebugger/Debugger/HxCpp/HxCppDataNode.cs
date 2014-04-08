using System;
using System.Collections.Generic;
using System.Text;
using FlashDebugger.Controls;
using FlashDebugger.Debugger.HxCpp.Server;

namespace FlashDebugger.Debugger.HxCpp
{
	class HxCppDataNode : DataNode
	{
		private Session session;
		private VariableValue.Item item;
		private VariableName[] children;
		private string fullName;

		public HxCppDataNode(string name, string fullName, Session session)
			: base(name)
		{
			this.session = session;
			this.fullName = fullName;
			try
			{
				Message ret = session.Request(Command.GetExpression(false, fullName));
				if (ret is Message.Variable)
				{
					Message.Variable var_ = (Message.Variable)ret;
					item = (VariableValue.Item)var_.value;
					children = item.children;
					Value = item.value;
				}
				else if (ret is Message.ErrorEvaluatingExpression)
				{
					Message.ErrorEvaluatingExpression err = (Message.ErrorEvaluatingExpression)ret;
					Value = "ERR: " + err.details;

				}
				else
				{
					Value = "ERR: " + ret.ToString();
				}
			}
			catch (Exception ex)
			{
				Value = "EX: " + ex.Message;
			}
		}

		public override string Value
		{
			get
			{
				// show type? do we add another column? do we get hx backend to tell us when? list all known types?
				return base.Value;
			}
			set
			{
				// todo
#if false
				Message ret = session.Request(Command.SetExpression(false, fullName, value));
#endif
				base.Value = value;
			}
		}

		public override bool EditEnabled
		{
			get
			{
				// todo
				return base.EditEnabled;
			}
		}

		public override bool IsLeaf
		{
			get
			{
				return children == null || children.Length == 0;
			}
		}

		public override bool HasValueChanged
		{
			get
			{
				// todo
				return base.HasValueChanged;
			}
		}

		public override string VariablePath
		{
			get
			{
				return fullName;
			}
		}

		public override void LoadChildren()
		{
			// todo
			Nodes.Clear();
			if (children == null) return;
			List<DataNode> nodes = new List<DataNode>(children.Length);
			//List<DataNode> inherited = new List<DataNode>();
			List<DataNode> statics = new List<DataNode>();
			foreach (VariableName child in children)
			{
				if (child is VariableName.Variable)
				{
					VariableName.Variable varchild = (VariableName.Variable)child;
					if (varchild.isStatic)
					{
						statics.Add(new HxCppDataNode(varchild.name, varchild.fullName, session));
					}
					else
					{
						nodes.Add(new HxCppDataNode(varchild.name, varchild.fullName, session));
					}
				}
			}
			if (statics.Count > 0)
			{
				DataNode staticNode = new DataNode("[static]");
				statics.Sort();
				foreach (DataNode item in statics)
				{
					staticNode.Nodes.Add(item);
				}
				Nodes.Add(staticNode);
			}
			nodes.Sort();
			foreach (DataNode item in nodes)
			{
				Nodes.Add(item);
			}
		}

	}
}
