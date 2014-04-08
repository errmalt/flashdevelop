using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProjectManager.Projects;
using PluginCore;
using FlashDebugger.Debugger.HxCpp.Server;

namespace FlashDebugger.Debugger.HxCpp
{
	class HxCppSourceFile : DbgSourceFile
	{
		private string file;
		private static Dictionary<string, string> pathMap = new Dictionary<string, string>();

		public static DbgSourceFile FromFrame(FrameList.Frame frame)
		{
			return new HxCppSourceFile(frame.fileName);
		}

		public static DbgSourceFile FromString(string file)
		{
			return new HxCppSourceFile(file);
		}

		private HxCppSourceFile(string file)
		{
			this.file = file;
		}

		public string FullPath
		{
			get { return file; }
		}

		public string LocalPath
		{
			get { return getLocalPath(file); }
		}

		public override string ToString()
		{
			return FullPath;
		}

		private static string getLocalPath(string file)
		{
			if (file == null) return null;
			Char pathSeparator = Path.DirectorySeparatorChar;
			file = file.Replace('/', pathSeparator);
			if (File.Exists(file))
			{
				return file;
			}
			if (pathMap.ContainsKey(file))
			{
				return pathMap[file];
			}
			//String pathFromPackage = file.getPackageName().ToString().Replace('/', pathSeparator);
			//foreach (Folder folder in PluginMain.settingObject.SourcePaths)
			//{
			//	String localPath = folder.Path + pathSeparator + pathFromPackage + pathSeparator + file.getName();
			//	if (File.Exists(localPath))
			//	{
			//		m_PathMap[file.getFullPath()] = localPath;
			//		return localPath;
			//	}
			//}
			Project project = PluginBase.CurrentProject as Project;
			if (project != null)
			{
				foreach (string cp in project.Classpaths)
				{
					String localPath = project.Directory + pathSeparator + cp + pathSeparator + file;
					if (File.Exists(localPath))
					{
						pathMap[file] = localPath;
						return localPath;
					}
				}
			}
			// todo, add global class path from library
			return null;
		}

		public static void MapAdd(string shortFileName, string fullFileName)
		{
			Char pathSeparator = Path.DirectorySeparatorChar;
			shortFileName = shortFileName.Replace('/', pathSeparator);
			// small hack. if our local file has drive letter in lower case, change it to upper case
			if (fullFileName.Substring(1, 1) == ":" && Char.IsLower(fullFileName, 0))
			{
				fullFileName = fullFileName.Substring(0, 1).ToUpper() + fullFileName.Substring(1);
			}
			pathMap.Add(shortFileName, fullFileName);
		}

		public static void Clear()
		{
			pathMap.Clear();
		}
	}
}
