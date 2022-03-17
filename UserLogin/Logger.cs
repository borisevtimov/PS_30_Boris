using System.Text;

namespace UserLogin
{
    public static class Logger
    {
        private static List<string> currentSessionActivities = new List<string>();

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";"
                + LoginValidation.currentUserRole + ";"
                + activity;

            currentSessionActivities.Add(activityLine);

            if (File.Exists("test.txt"))
            {
                File.WriteAllText("test.txt", activityLine);
            }
        }

        public static string GetCurrentSessionActivities() 
        {
            StringBuilder result = new StringBuilder();

            foreach (string currentActivity in currentSessionActivities)
            {
                result.AppendLine(currentActivity);
            }

            return result.ToString();
        }
    }
}
