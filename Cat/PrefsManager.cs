using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Cat
{
	public interface IPreferenceData { }
	public class PrefsManager<D> where D : IPreferenceData, new()
	{
		public string DefaultPrefsFilename { get; set; } = "Preferences.ser";
		public string DefaultPrefsFolder { get; set; } = Application.LocalUserAppDataPath;
		public D Data { get; private set; }
		public bool LoadedFromFile { get; protected set; }
		public string FilePath { get; private set; }
		public PrefsManager()
		{
			FilePath = DefaultPrefsFolder + "\\" + DefaultPrefsFilename;
			LoadFromFileOrCreatenew();
		}
		public PrefsManager(string filename)
		{
			if ((filename == null) || (filename == string.Empty))
			{
				throw new InvalidOperationException("Preference file path cannot be null or blank");
			}
			if (filename.Contains("\\")) FilePath = filename;
			else FilePath = DefaultPrefsFolder + "\\" + filename;
			LoadFromFileOrCreatenew();
		}
		private void LoadFromFileOrCreatenew()
		{
			LoadedFromFile = false;
			if (File.Exists(FilePath)) Load();
			if (!LoadedFromFile) Data = new D();
		}
		private void DeterminePrefsFilePath()
		{
			FilePath = string.Empty;
		}
		public void Load()
		{
			if (File.Exists(FilePath))
			{
				BinaryFormatter bf = new BinaryFormatter();
				Stream stream = null;
				try
				{
					stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.None);
					Data = (D)bf.Deserialize(stream);
					stream.Close();
					LoadedFromFile = true;
				}
				catch (Exception exc)
				{
					if ((exc != null) && (stream != null)) stream.Close();
					if (File.Exists(FilePath)) File.Delete(FilePath);
					LoadedFromFile = false;
				}
			}
		}
		public void Save()
		{
			BinaryFormatter bf = new BinaryFormatter();
			if (File.Exists(FilePath)) File.Delete(FilePath);
			using (Stream stream = new FileStream(FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				bf.Serialize(stream, Data);
			}
		}
		public void DeletePrefsFile()
		{
			if (File.Exists(FilePath)) File.Delete(FilePath);
		}
	}
}
