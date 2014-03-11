using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDebugger.Debugger
{
	public interface DbgThread
	{
		string Name { get; }
		int Id { get; }
		bool IsSuspended { get; }
	}
}
