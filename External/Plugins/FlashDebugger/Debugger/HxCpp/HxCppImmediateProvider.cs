using System;
using System.Collections.Generic;
using System.Text;
using FlashDebugger.Debugger.HxCpp.Server;

namespace FlashDebugger.Debugger.HxCpp
{
	class HxCppImmediateProvider : ImmediateProvider
	{
		Session session;

		public HxCppImmediateProvider(Session session)
		{
			this.session = session;
		}

		public string ProcessLine(string line)
		{
			if (line.StartsWith("p "))
			{
				Message ret = session.Request(Command.PrintExpression(false, line.Substring(2)));
				return ret.ToString();
			}
			return "p expression\r\n";
		}
	}
}
