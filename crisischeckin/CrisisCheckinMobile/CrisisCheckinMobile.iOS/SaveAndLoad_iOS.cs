using CrisisCheckinMobile.iOS;
using CrisisCheckinMobile.SaveLoad;
using System;
using System.IO;


//[assembly: Dependency (typeof (SaveAndLoad_iOS))]
namespace CrisisCheckinMobile.iOS
{
	public class SaveAndLoad_iOS : ISaveAndLoad
	{
		public SaveAndLoad_iOS() {}

		public void SaveText(string filename, string text)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
			System.IO.File.WriteAllText(filePath, text);
		}

		public string LoadText(string filename)
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var filePath = Path.Combine(documentsPath, filename);
			return System.IO.File.ReadAllText(filePath);
		}
	}
}