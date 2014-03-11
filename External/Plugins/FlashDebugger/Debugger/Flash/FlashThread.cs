using System;
using System.Collections.Generic;
using System.Text;
using flash.tools.debugger;

namespace FlashDebugger.Debugger.Flash
{
	class FlashThread : DbgThread
	{
		private string name;
		private int id;
		private Session session;
		private IsolateSession isolateSession;

		public static DbgThread FromSession(Session session)
		{
			return new FlashThread(1, "Main thread", session);
		}

		public static DbgThread FromIsolateSession(int id, IsolateSession session)
		{
			return new FlashThread(id, "Worker "+id, session);
		}

		private FlashThread(int id, string name, Session session)
		{
			this.id = id;
			this.name = name;
			this.session = session;
		}

		private FlashThread(int id, string name, IsolateSession session)
		{
			this.id = id;
			this.name = name;
			this.isolateSession = session;
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
			get
			{
				if (isolateSession != null)
				{
					return isolateSession.isSuspended();
				}
				return session.isSuspended();
			}
		}

		#endregion
	}
}
