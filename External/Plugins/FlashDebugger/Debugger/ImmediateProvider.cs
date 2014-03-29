using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDebugger.Debugger
{
	public interface ImmediateProvider
	{
		string ProcessLine(string line);
	}
}
