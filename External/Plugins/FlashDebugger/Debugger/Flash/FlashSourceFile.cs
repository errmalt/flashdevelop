using System;
using System.Collections.Generic;
using System.Text;
using flash.tools.debugger;
using System.IO;
using ProjectManager.Projects;
using PluginCore;

namespace FlashDebugger.Debugger.Flash
{
	class FlashSourceFile : DbgSourceFile
	{
		private SourceFile sourceFile;
		private static Dictionary<string, string> pathMap = new Dictionary<string, string>();

		public static DbgSourceFile FromSourceFile(SourceFile sourceFile)
		{
			if (sourceFile == null)
			{
				return null;
			}
			return new FlashSourceFile(sourceFile);
		}

		private FlashSourceFile(SourceFile sourceFile)
		{
			this.sourceFile = sourceFile;
		}

		public string FullPath
		{
			get { return sourceFile.getFullPath(); }
		}

		public string LocalPath
		{
			get
			{
				return getLocalPath(sourceFile);
			}
		}

		public override string ToString()
		{
			return sourceFile.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		private static string getLocalPath(SourceFile file)
		{
			if (file == null) return null;
			String fileFullPath = file.getFullPath();
			if (pathMap.ContainsKey(fileFullPath))
			{
				return pathMap[fileFullPath];
			}
			if (File.Exists(fileFullPath))
			{
				pathMap[fileFullPath] = fileFullPath;
				return fileFullPath;
			}
			Char pathSeparator = Path.DirectorySeparatorChar;
			String pathFromPackage = file.getPackageName().ToString().Replace('/', pathSeparator);
			String fileName = file.getName();
			foreach (Folder folder in PluginMain.settingObject.SourcePaths)
			{
				StringBuilder localPathBuilder = new StringBuilder(260/*Windows max path length*/);
				localPathBuilder.Append(folder.Path);
				localPathBuilder.Append(pathSeparator);
				localPathBuilder.Append(pathFromPackage);
				localPathBuilder.Append(pathSeparator);
				localPathBuilder.Append(fileName);
				String localPath = localPathBuilder.ToString();
				if (File.Exists(localPath))
				{
					pathMap[fileFullPath] = localPath;
					return localPath;
				}
			}
			Project project = PluginBase.CurrentProject as Project;
			if (project != null)
			{
				foreach (string cp in project.Classpaths)
				{
					StringBuilder localPathBuilder = new StringBuilder(260/*Windows max path length*/);
					localPathBuilder.Append(project.Directory);
					localPathBuilder.Append(pathSeparator);
					localPathBuilder.Append(cp);
					localPathBuilder.Append(pathSeparator);
					localPathBuilder.Append(pathFromPackage);
					localPathBuilder.Append(pathSeparator);
					localPathBuilder.Append(fileName);
					String localPath = localPathBuilder.ToString();
					if (File.Exists(localPath))
					{
						pathMap[fileFullPath] = localPath;
						return localPath;
					}
				}
			}
			pathMap[fileFullPath] = null;
			return null;
		}

		public static void Clear()
		{
			pathMap.Clear();
		}

	}
}
