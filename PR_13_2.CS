using System;
using System.IO;

class FilesAndFolders
{
	private DirectoryInfo Dir;
	private int maxFiles = 0;
	private string hasMostFiles = "";
	private string SystemFolder = Environment.GetEnvironmentVariable("SystemRoot");

	public FilesAndFolders(string root)
	{
		Dir = new DirectoryInfo(root);
	}

	public void OpenDirectory()
	{
		DirectoryInfo[] Directories = null;
		FileInfo [] Files = null;

		try
		{
			Directories = Dir.GetDirectories();
			Files = Dir.GetFiles();
		}
		catch(Exception) 
		{
			Console.WriteLine("Nemam pristup za: " + Dir.FullName);
			return;
		}
			
		if(String.Compare(Dir.FullName, 0, SystemFolder, 0, SystemFolder.Length, true) != 0  &&  Files.Length > MaxFiles)
		{
			MaxFiles = Files.Length;
			HasMostFiles = Dir.FullName;
		}

		foreach(DirectoryInfo NextDir in Directories)
		{
			Dir = NextDir;
			OpenDirectory();
		}
	}

	public int MaxFiles
	{
		get
		{
			return maxFiles;
		}

		set
		{
			maxFiles = value;
		}
	}

	public string HasMostFiles
	{
		get
		{
			return hasMostFiles;
		}		

set
		{
			hasMostFiles = value;
		}
	}
}

class Test
{
	public static void Main()
	{
		FilesAndFolders ff = new FilesAndFolders("c:\\");
		ff.OpenDirectory();

		Console.WriteLine();
		Console.WriteLine("{0} datoteka u mapi {1}", ff.MaxFiles,
ff.HasMostFiles);

	}
}
