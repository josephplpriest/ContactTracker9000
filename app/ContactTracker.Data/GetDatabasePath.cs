namespace ContactTracker.Data
{
    public class DatabaseHelpers
    {
        public static string GetDatabasePath()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            return Path.Join(path, "ContactTracker.db");
        }
    }
}