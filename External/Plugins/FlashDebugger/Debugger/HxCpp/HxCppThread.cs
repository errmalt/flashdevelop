using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDebugger.Debugger.HxCpp
{
	class HxCppThread : DbgThread
	{
		private string name;
		private int id;
		private bool suspended;

		public HxCppThread(int id)
		{
			this.id = id;
			this.name = "Thread " + id;
		}

		#region DbgThread Members

		public string Name
		{
			get { return name; }
		}

		public int Id
		{
			get { return id; }
		}

		public bool IsSuspended
		{
			get { return suspended; }
			set { suspended = value; }
		}

		#endregion
	}
}
