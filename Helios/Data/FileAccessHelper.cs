namespace Helios.Data
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
#if ANDROID
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
#else
            return Path.Combine(FileSystem.Current.AppDataDirectory, filename);
#endif
        }
    }
}
