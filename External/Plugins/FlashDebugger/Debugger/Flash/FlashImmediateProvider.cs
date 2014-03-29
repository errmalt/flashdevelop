using System;
using System.Collections.Generic;
using System.Text;
using flash.tools.debugger;
using flash.tools.debugger.expression;

namespace FlashDebugger.Debugger.Flash
{
	class FlashImmediateProvider : ImmediateProvider
	{
		FlashInterface flashInterface;

		public FlashImmediateProvider(FlashInterface flashInterface)
		{
			this.flashInterface = flashInterface;
		}

		public string ProcessLine(string line)
		{
			if (line == "swfs")
			{
				return processSwfs();
			}
			else if (line.StartsWith("p "))
			{
				return processExpr(line.Substring(2));
			}
			else if (line.StartsWith("g "))
			{
				return processGlobal(line.Substring(2));
			}
			else
			{
				return "Commands: swfs, p <exptr>, g <value id>";
			}
		}

		private string processSwfs()
		{
			string ret = "";

			foreach (SwfInfo info in flashInterface.Session.getSwfs())
			{
				if (info == null) continue;
				ret += info.getPath() + "\tswfsize " + info.getSwfSize() + "\tprocesscomplete " + info.isProcessingComplete() + "\tunloaded " + info.isUnloaded() + "\turl " + info.getUrl() + "\tsourcecount " + info.getSourceCount(PluginMain.debugManager.FlashInterface.Session) + "\r\n";
			}
			return ret;
		}

		private string processExpr(string expr)
		{
			IASTBuilder builder = new ASTBuilder(true);
			ValueExp exp = builder.parse(new java.io.StringReader(expr));
			var ctx = new ExpressionContext(flashInterface.Session, flashInterface.Session.getFrames()[PluginMain.debugManager.CurrentFrame]);
			var obj = exp.evaluate(ctx);
			if (obj is Variable) return ctx.FormatValue(((Variable)obj).getValue());
			if (obj is Value) return ctx.FormatValue((Value)obj);
			return obj.toString();
		}

		private string processGlobal(string expr)
		{
			var val = flashInterface.Session.getGlobal(expr);
			//var val = flashInterface.Session.getValue(Convert.ToInt64(expr));
			var ctx = new ExpressionContext(flashInterface.Session, flashInterface.Session.getFrames()[PluginMain.debugManager.CurrentFrame]);
			return ctx.FormatValue(val);
		}

	}
}
